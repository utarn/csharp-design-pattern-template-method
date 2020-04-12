using System;

namespace pattern_template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var transferTask = new TransferMoneyTask();
            transferTask.Execute();
            var reportTask = new GenerateReportTask();
            reportTask.Execute();
        }
    }
}
