// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class StringWrapper
    {
        /// <summary>
        /// Initializes a new instance of the StringWrapper class.
        /// </summary>
        public StringWrapper() { }

        /// <summary>
        /// Initializes a new instance of the StringWrapper class.
        /// </summary>
        public StringWrapper(string field = default(string), string empty = default(string), string nullProperty = default(string))
        {
            Field = field;
            Empty = empty;
            NullProperty = nullProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "empty")]
        public string Empty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "null")]
        public string NullProperty { get; set; }

    }
}
