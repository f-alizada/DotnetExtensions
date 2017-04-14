// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Specification.Tests.TestUtilities.Xunit;
using Microsoft.EntityFrameworkCore.SqlServer.FunctionalTests.Utilities;
using Xunit;

[assembly: TestFramework("Microsoft.EntityFrameworkCore.Specification.Tests.TestUtilities.Xunit.ConditionalTestFramework", "Microsoft.EntityFrameworkCore.Specification.Tests")]

// Skip the entire assembly if not on Windows and no external SQL Server is configured

[assembly: SqlServerConfiguredCondition]
#if NETCOREAPP2_0
[assembly: OsSkipCondition(TestPlatform.Windows, WindowsVersions.Win2008R2, WindowsVersions.Win7, SkipReason = "SqlClient has issue with .netcoreapp2.0 on win7.")]
#endif
