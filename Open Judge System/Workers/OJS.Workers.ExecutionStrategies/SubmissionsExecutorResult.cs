﻿namespace OJS.Workers.ExecutionStrategies
{
    using System.Collections.Generic;

    public class SubmissionsExecutorResult
    {
        public bool IsCompiledSuccessfully { get; set; }

        public string CompilerComment { get; set; }

        public List<TestResult> TestResults { get; set; }
    }
}