using System;

namespace netcore_s3_zipper.Config {
    public class S3Credentials {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Region { get; set; }
    }
}