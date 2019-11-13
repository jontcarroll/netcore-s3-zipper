using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;

namespace netcore_s3_zipper {
    internal class S3Client {
        private readonly AmazonS3Client _client;
        public S3Client (string accessKey, string secretKey, RegionEndpoint region) {
            _client = new AmazonS3Client (
                new BasicAWSCredentials (accessKey, secretKey), RegionEndpoint.USEast1
            );
        }
        public async Task<GetObjectMetadataResponse> GetObjectMetadataAsync (string bucket, string key) {
            try {
                var response = await _client.GetObjectMetadataAsync (new GetObjectMetadataRequest {
                    BucketName = bucket,
                        Key = key
                });

                return response;

            } catch (AmazonS3Exception e) {
                throw e;
            } catch (Exception e) {
                throw e;
            }
        }

        public async Task<MemoryStream> GetObjectMemoryStreamAsync (string bucket, string key) {
            try {
                var request = new GetObjectRequest {
                    BucketName = bucket,
                    Key = key
                };

                using (GetObjectResponse response = await _client.GetObjectAsync (request))
                using (Stream responseStream = response.ResponseStream) {
                    MemoryStream memResponseStream = new MemoryStream ();
                    responseStream.CopyTo (memResponseStream);
                    memResponseStream.Position = 0;
                    return memResponseStream;
                }
            } catch (AmazonS3Exception e) {
                throw e;
            } catch (Exception e) {
                throw e;
            }
        }

        public async Task DownloadObjectAsync (string bucket, string key, string destinationPath) {
            try {
                var request = new GetObjectRequest {
                    BucketName = bucket,
                    Key = key
                };

                using (var response = await _client.GetObjectAsync (request)) {
                    await response.WriteResponseStreamToFileAsync (destinationPath, false, default (CancellationToken));
                }
            } catch (AmazonS3Exception e) {
                throw e;
            } catch (Exception e) {
                throw e;
            }
        }

    }
}