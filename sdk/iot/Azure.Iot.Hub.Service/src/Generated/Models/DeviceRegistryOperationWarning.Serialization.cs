// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class DeviceRegistryOperationWarning
    {
        internal static DeviceRegistryOperationWarning DeserializeDeviceRegistryOperationWarning(JsonElement element)
        {
            string deviceId = default;
            string warningCode = default;
            string warningStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningStatus = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceRegistryOperationWarning(deviceId, warningCode, warningStatus);
        }
    }
}