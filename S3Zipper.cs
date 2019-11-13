using System;
using netcore_s3_zipper.Models;

namespace netcore_s3_zipper
{
    public static class S3Zipper
    {
        private static int _memoryLimit = 2000;
        public static void SetMemoryLimit(int memoryLimit) {
            _memoryLimit = memoryLimit;
        }

        internal static void Run(string[] args) {
            
        }

        public static void Run(S3Source source, S3Destination s3Destination) {

        }
        public static void Run(S3Source source, string localDestination) {

        }
    }
}
