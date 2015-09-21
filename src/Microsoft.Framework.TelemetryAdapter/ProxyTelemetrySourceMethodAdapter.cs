﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;

namespace Microsoft.Framework.TelemetryAdapter
{
    public class ProxyTelemetrySourceMethodAdapter : ITelemetrySourceMethodAdapter
    {
        public Func<object, object, bool> Adapt(MethodInfo method, Type inputType)
        {
            return Internal.ProxyMethodEmitter.CreateProxyMethod(method, inputType);
        }
    }
}
