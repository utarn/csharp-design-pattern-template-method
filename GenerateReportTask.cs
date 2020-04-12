using System;

namespace pattern_template_method
{
    public class GenerateReportTask : TemplateMethod
    {
        public GenerateReportTask() : base()
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}