﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Identity.Client.AppConfig;
using Microsoft.Identity.Client.AuthScheme;
using Microsoft.Identity.Client.AuthScheme.Bearer;
using Microsoft.Identity.Client.TelemetryCore.Internal.Events;

namespace Microsoft.Identity.Client.ApiConfig.Parameters
{
    internal class AcquireTokenCommonParameters
    {
        public ApiEvent.ApiIds ApiId { get; set; } = ApiEvent.ApiIds.None;
        public Guid CorrelationId { get; set; }
        public Guid UserProvidedCorrelationId { get; set; }
        public bool UseCorrelationIdFromUser { get; set; }
        public IEnumerable<string> Scopes { get; set; }
        public IDictionary<string, string> ExtraQueryParameters { get; set; }
        public string Claims { get; set; }
        public AuthorityInfo AuthorityOverride { get; set; }
        public IAuthenticationScheme AuthenticationScheme { get; set; } = new BearerAuthenticationScheme();
        public IDictionary<string, string> ExtraHttpHeaders { get; set; }
        public PoPAuthenticationConfiguration PopAuthenticationConfiguration { get; set; }

        /// <summary>
        /// If set, the client assertion parameters should be ignored and these parameters should be set.
        /// The input string is the token endpoint and a cancellation token.
        /// The output is a list of name / value strings to be sent to the HTTP request to the token endpoint
        /// </summary>
        public Func<string, CancellationToken, Task<IReadOnlyList<KeyValuePair<string, string>>>> ClientAssertionOverrideDelegate { get; set; }

    }
}
