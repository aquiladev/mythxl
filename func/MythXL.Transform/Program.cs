﻿using CommandLine;
using MythXL.Transform.Commands;

namespace MythXL.Transform
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<
                AzureTableEntryMoveOptions,
                MigrateContractV1Options,
                MigrateAnalysisV1Options,
                AnalysisVersionsFixOptions,
                ResetContractOptions>(args)
                .MapResult(
                    (AzureTableEntryMoveOptions opts) => AzureTableEntryMove.RunAddAndReturnExitCode(opts),
                    (MigrateContractV1Options opts) => MigrateContractV1.RunAddAndReturnExitCode(opts),
                    (MigrateAnalysisV1Options opts) => MigrateAnalysisV1.RunAddAndReturnExitCode(opts),
                    (AnalysisVersionsFixOptions opts) => AnalysisVersionsFix.RunAddAndReturnExitCode(opts),
                    (ResetContractOptions opts) => ResetContract.RunAddAndReturnExitCode(opts),
                    errs => 1);
        }
    }
}
