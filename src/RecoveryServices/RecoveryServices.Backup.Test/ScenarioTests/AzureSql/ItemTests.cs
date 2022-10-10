﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Test.ScenarioTests
{
    public partial class ItemTests : RecoveryServicesBackupTestRunner
    {
        private readonly string _AzureSqlcommonModule = $"ScenarioTests/Common.ps1";
        private readonly string _AzureSqltestModule = $"ScenarioTests/{PsBackupProviderTypes.AzureSql}/ItemTests.ps1";

        public ItemTests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact(Skip = "This workload is not supported anymore")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureSql)]
        public void TestAzureSqlGetItems()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureSqlcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureSqltestModule.AsAbsoluteLocation()}",
                "Test-AzureSqlGetItems"
            );
        }

        [Fact(Skip = "This workload is not supported anymore")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureSql)]
        public void TestAzureSqlDisableProtection()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureSqlcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureSqltestModule.AsAbsoluteLocation()}",
                "Test-AzureSqlDisableProtection"
            );
        }

        [Fact(Skip = "This workload is not supported anymore")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureSql)]
        public void TestAzureSqlGetRPs()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureSqlcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureSqltestModule.AsAbsoluteLocation()}",
                "Test-AzureSqlGetRPs"
            );
        }
    }
}