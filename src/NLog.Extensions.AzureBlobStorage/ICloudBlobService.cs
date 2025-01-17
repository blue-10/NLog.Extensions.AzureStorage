﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NLog.Extensions.AzureStorage
{
    interface ICloudBlobService
    {
        void Connect(string connectionString, string serviceUri, string tenantIdentity, IDictionary<string, string> blobMetadata, IDictionary<string, string> blobTags);
        Task AppendFromByteArrayAsync(string containerName, string blobName, string contentType, byte[] buffer, CancellationToken cancellationToken);
    }
}
