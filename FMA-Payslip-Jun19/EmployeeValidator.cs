using System;

namespace FMA_Payslip_Jun19
{
    public class EmployeeValidator
    {
        public bool EmployeeIsValid(Employee employee)
        {
            return SalaryIsValid(employee.Salary) && SuperRateIsValid(employee.SuperRate) && DateRangeIsValid(employee.PayPeriodStartDate, employee.PayPeriodEndDate);
        }

        private static bool SalaryIsValid(decimal salary)
        {
            return salary > 0;
        }

        private static bool SuperRateIsValid(decimal superRate)
        {
            return superRate >= 0 && superRate <= 50;
        }

        private static bool DateRangeIsValid(string startDate, string endDate)
        {
            if (DateTime.TryParse(startDate, out var startDateTime) && DateTime.TryParse(endDate, out var endDateTime))
            {
                var startDateIsFirstDayInMonth = startDateTime.Day == 1;
                var endDateIsLastDayInMonth = endDateTime.Day == DateTime.DaysInMonth(DateTime.Now.Year, endDateTime.Month);
                var startDateAndEndDateInSameMonth = startDateTime.Month == endDateTime.Month;
                return startDateIsFirstDayInMonth && endDateIsLastDayInMonth && startDateAndEndDateInSameMonth;
            }

            return false;
        }
    }
}