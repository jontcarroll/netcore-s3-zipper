using System;
using System.Collections.Generic;
using netcore_s3_zipper.Config;

namespace netcore_s3_zipper.Models {
    public class S3ZipperJob {

    }

    public class S3Source {
        public S3Credentials Credentials { get; set; }
        public string Bucket { get; set; }
        public List<string> Keys { get; set; }
    }
    public class S3Destination {
        public S3Credentials Credentials { get; set; }
        public string Bucket { get; set; }
    }
}