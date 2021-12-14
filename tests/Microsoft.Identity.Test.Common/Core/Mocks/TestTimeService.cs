﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Identity.Client.Utils;

namespace Microsoft.Identity.Test.Common.Core.Mocks
{
    public class TestTimeService : ITimeService
    {
        public TestTimeService()
        {
            UtcNow = DateTime.UtcNow;
        }

        public TestTimeService(DateTime utcNow)
        {
            UtcNow = utcNow;
        }

        public DateTime UtcNow { get; set; }

        public DateTime GetUtcNow()
        {
            return UtcNow;
        }

        public void MoveToFuture(TimeSpan span)
        {
            UtcNow = UtcNow + span;
        }

        public void MoveToPast(TimeSpan span)
        {
            UtcNow = UtcNow - span;
        }
    }
}
