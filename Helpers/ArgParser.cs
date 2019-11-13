using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace netcore_s3_zipper.Helpers {
    public static class ArgParser {
        public static List<Argument> GetArguments(string[] args) {
            var retVal = new List<Argument>();


            return retVal;
        } 
    }

    public class Argument {
        public Parameter Parameter { get; set; }
        public string Value { get; set; }
    }

    public enum Parameter {
        [Description("-bucket")]
        Bucket,
        [Description("-keys")]
        Keys,
        [Description("-in_memory")]
        InMemory,
        [Description("-memory_max")]
        Invalid
    }
}