using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class FullTimeEmployee : Employee {
		public decimal BaseSalary;
		public decimal OB;
		
		public FullTimeEmployee(string inputName,
			int inputAge,
			string inputGender,
			string inputEducation,
			string[] inputPronouns,
			string inputPhoneNumber,
			string inputEmail,
			decimal inputBaseSalary,
			decimal inputOB) : base(inputName, inputAge, inputGender, 
				inputEducation, inputPronouns, inputPhoneNumber, inputEmail) {

			BaseSalary = inputBaseSalary;
			OB = inputOB;
		}

		public override decimal CalculateSalary(DateTime start, DateTime end) {
			decimal result = 0;

			TimeSpan span = end - start;
			int hoursPerMonth = 8 * 22;
			decimal salaryFraction = (decimal)span.TotalHours / hoursPerMonth;
			result = salaryFraction * BaseSalary;

			if (span.TotalHours > 10) {
				decimal overtimeWorked = (decimal)span.TotalHours - 10;
				result += overtimeWorked * OB;
			}

			return result;
		}

		public override string GetEmployeeInfo() {
			return "Heltidsanställd\nNamn: " + Name + "\nÅlder: " + Age + "\nBaslön: " + BaseSalary + "kr\nOB: " + OB + "kr";
		}
	}
}
