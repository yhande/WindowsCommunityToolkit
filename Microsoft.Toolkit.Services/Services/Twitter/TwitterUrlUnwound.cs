﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.Toolkit.Services.Twitter
{
    /// <summary>
    /// Twitter Url Unwound object; provides original Url for shortened t.co links.
    /// </summary>
    public class TwitterUrlUnwound
    {
        /// <summary>
        /// Gets or sets fully unwound url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets status of unwind; if anything but 200 is bad data.
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets HTML title for url.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets description of link.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}