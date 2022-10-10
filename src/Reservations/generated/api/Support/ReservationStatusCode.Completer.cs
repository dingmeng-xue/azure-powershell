// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support
{

    /// <summary>Argument completer implementation for ReservationStatusCode.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationStatusCodeTypeConverter))]
    public partial struct ReservationStatusCode :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'None'", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Pending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Pending'", "Pending", global::System.Management.Automation.CompletionResultType.ParameterValue, "Pending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Processing".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Processing'", "Processing", global::System.Management.Automation.CompletionResultType.ParameterValue, "Processing");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Active".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Active'", "Active", global::System.Management.Automation.CompletionResultType.ParameterValue, "Active");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PurchaseError".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PurchaseError'", "PurchaseError", global::System.Management.Automation.CompletionResultType.ParameterValue, "PurchaseError");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PaymentInstrumentError".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PaymentInstrumentError'", "PaymentInstrumentError", global::System.Management.Automation.CompletionResultType.ParameterValue, "PaymentInstrumentError");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Split".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Split'", "Split", global::System.Management.Automation.CompletionResultType.ParameterValue, "Split");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Merged".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Merged'", "Merged", global::System.Management.Automation.CompletionResultType.ParameterValue, "Merged");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Expired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Expired'", "Expired", global::System.Management.Automation.CompletionResultType.ParameterValue, "Expired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Succeeded".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Succeeded'", "Succeeded", global::System.Management.Automation.CompletionResultType.ParameterValue, "Succeeded");
            }
        }
    }
}