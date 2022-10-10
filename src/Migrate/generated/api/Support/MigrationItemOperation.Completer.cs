// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>Argument completer implementation for MigrationItemOperation.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MigrationItemOperationTypeConverter))]
    public partial struct MigrationItemOperation :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisableMigration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DisableMigration'", "DisableMigration", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisableMigration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TestMigrate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'TestMigrate'", "TestMigrate", global::System.Management.Automation.CompletionResultType.ParameterValue, "TestMigrate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TestMigrateCleanup".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'TestMigrateCleanup'", "TestMigrateCleanup", global::System.Management.Automation.CompletionResultType.ParameterValue, "TestMigrateCleanup");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Migrate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Migrate'", "Migrate", global::System.Management.Automation.CompletionResultType.ParameterValue, "Migrate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "StartResync".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'StartResync'", "StartResync", global::System.Management.Automation.CompletionResultType.ParameterValue, "StartResync");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PauseReplication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PauseReplication'", "PauseReplication", global::System.Management.Automation.CompletionResultType.ParameterValue, "PauseReplication");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResumeReplication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ResumeReplication'", "ResumeReplication", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResumeReplication");
            }
        }
    }
}