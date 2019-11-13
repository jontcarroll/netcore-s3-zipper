using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace netcore_s3_zipper.Helpers {
    public static class Extensions {
        public static string GetDescription (this Enum e) {
            var attribute =
                e.GetType ()
                .GetTypeInfo ()
                .GetMember (e.ToString ())
                .FirstOrDefault (member => member.MemberType == MemberTypes.Field)
                .GetCustomAttributes (typeof (DescriptionAttribute), false)
                .SingleOrDefault ()
            as DescriptionAttribute;

            return attribute?.Description ?? e.ToString ();
        }
    }
}