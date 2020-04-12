namespace pattern_template_method
{
    public abstract class TemplateMethod
    {
        private readonly AuditTrail _auditTrail;

        public TemplateMethod()
        {
            _auditTrail = new AuditTrail();
        }
        public TemplateMethod(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
            _auditTrail.Stop();
        }

        protected abstract void DoExecute();
    }
}