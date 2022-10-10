// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support
{

    /// <summary>Provisioning state of the Service</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningStateTypeConverter))]
    public partial struct ProvisioningState :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Creating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Creating'", "Creating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Creating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Updating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Updating'", "Updating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Updating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Starting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Starting'", "Starting", global::System.Management.Automation.CompletionResultType.ParameterValue, "Starting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Stopping".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Stopping'", "Stopping", global::System.Management.Automation.CompletionResultType.ParameterValue, "Stopping");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Deleting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Deleting'", "Deleting", global::System.Management.Automation.CompletionResultType.ParameterValue, "Deleting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Deleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Deleted'", "Deleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "Deleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Succeeded".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Succeeded'", "Succeeded", global::System.Management.Automation.CompletionResultType.ParameterValue, "Succeeded");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Failed'", "Failed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Moving".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Moving'", "Moving", global::System.Management.Automation.CompletionResultType.ParameterValue, "Moving");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Moved".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Moved'", "Moved", global::System.Management.Automation.CompletionResultType.ParameterValue, "Moved");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MoveFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MoveFailed'", "MoveFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "MoveFailed");
            }
        }
    }
}