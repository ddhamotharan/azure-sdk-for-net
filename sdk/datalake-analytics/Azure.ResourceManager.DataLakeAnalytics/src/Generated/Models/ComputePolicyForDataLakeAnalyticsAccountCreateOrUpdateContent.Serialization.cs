// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType.ToString());
            if (Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (Optional.IsDefined(MinPriorityPerJob))
            {
                writer.WritePropertyName("minPriorityPerJob"u8);
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
