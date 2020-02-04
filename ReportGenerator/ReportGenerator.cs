using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    public enum ReportOutputFormatType
    {
        NameFirst,
        SalaryFirst
    }

    abstract class ReportGenerator : ICompileBehavior
    {
        private readonly EmployeeDB _employeeDb;
        private ReportOutputFormatType _currentOutputFormat;
        private ICompileBehavior compileBehavior;

        public ReportGenerator()
        {
        }

        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _currentOutputFormat = ReportOutputFormatType.NameFirst;
            _employeeDb = employeeDb;
        }

        public abstract void CompileReport();

        public abstract void SetOutputFormat(ReportOutputFormatType format);
    }
}