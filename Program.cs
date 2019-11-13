using System;
using System.IO;
using Amazon.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace netcore_s3_zipper {
    class Program {
        static void Main (string[] args) {
            try {
                S3Zipper.Run (args);
            } catch (Exception ex) {
                Console.WriteLine($"Unhandled Exception: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}