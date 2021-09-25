using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Microsoft.Azure.PowerShell.Authenticators.Credential
{
    internal class IdentityCompatSwitches
    {
        internal const string DisableInteractiveThreadpoolExecutionSwitchName = "Azure.Identity.DisableInteractiveBrowserThreadpoolExecution";
        internal const string DisableInteractiveThreadpoolExecutionEnvVar = "AZURE_IDENTITY_DISABLE_INTERACTIVEBROWSERTHREADPOOLEXECUTION";
        internal const string DisableCP1ExecutionSwitchName = "Azure.Identity.DisableCP1";
        internal const string DisableCP1ExecutionEnvVar = "AZURE_IDENTITY_DISABLE_CP1";

        public static bool DisableInteractiveBrowserThreadpoolExecution
            => AppContextSwitchHelper.GetConfigValue(DisableInteractiveThreadpoolExecutionSwitchName, DisableInteractiveThreadpoolExecutionEnvVar);

        public static bool DisableCP1
            => AppContextSwitchHelper.GetConfigValue(DisableCP1ExecutionSwitchName, DisableCP1ExecutionEnvVar);
    }
}
