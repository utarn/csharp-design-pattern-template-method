using System;

namespace pattern_template_method
{
    public class TransferMoneyTask : TemplateMethod
    {
        public TransferMoneyTask() : base()
        {

        }
        public TransferMoneyTask(AuditTrail auditTrail)
        : base(auditTrail)
        {

        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}