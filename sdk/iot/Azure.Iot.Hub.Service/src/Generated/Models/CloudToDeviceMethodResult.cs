// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Represents the Device Method Invocation Results. </summary>
    public partial class CloudToDeviceMethodResult
    {
        /// <summary> Initializes a new instance of CloudToDeviceMethodResult. </summary>
        internal CloudToDeviceMethodResult()
        {
        }

        /// <summary> Initializes a new instance of CloudToDeviceMethodResult. </summary>
        /// <param name="status"> Method invocation result status, provided by the device. </param>
        /// <param name="payload"> The JSON-formatted direct method result payload, up to 128kb in size; provided by the device. </param>
        internal CloudToDeviceMethodResult(int? status, object payload)
        {
            Status = status;
            Payload = payload;
        }

        /// <summary> Method invocation result status, provided by the device. </summary>
        public int? Status { get; }
        /// <summary> The JSON-formatted direct method result payload, up to 128kb in size; provided by the device. </summary>
        public object Payload { get; }
    }
}