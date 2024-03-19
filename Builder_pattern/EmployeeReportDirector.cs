namespace Builder_pattern
{
    public class EmployeeReportDirector
    {
        private IEmployeeReportBuilder _builder;

        public EmployeeReportDirector(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            //FluentBuilder style
            _builder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
