// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

using Microsoft.Graph;

using Newtonsoft.Json;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type IdentitySet.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IdentitySet
    {
    
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false, IsRequired = false)]
        public Identity Application { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false, IsRequired = false)]
        public Identity Device { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false, IsRequired = false)]
        public Identity User { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
