// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AVmManagedDiskUpdateDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(RecoveryTargetDiskAccountType))
            {
                writer.WritePropertyName("recoveryTargetDiskAccountType"u8);
                writer.WriteStringValue(RecoveryTargetDiskAccountType);
            }
            if (Optional.IsDefined(RecoveryReplicaDiskAccountType))
            {
                writer.WritePropertyName("recoveryReplicaDiskAccountType"u8);
                writer.WriteStringValue(RecoveryReplicaDiskAccountType);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(FailoverDiskName))
            {
                writer.WritePropertyName("failoverDiskName"u8);
                writer.WriteStringValue(FailoverDiskName);
            }
            if (Optional.IsDefined(TfoDiskName))
            {
                writer.WritePropertyName("tfoDiskName"u8);
                writer.WriteStringValue(TfoDiskName);
            }
            writer.WriteEndObject();
        }
    }
}
