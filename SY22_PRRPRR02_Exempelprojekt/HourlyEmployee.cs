using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class HourlyEmployee : Employee {
		public decimal HourlySalary;
		public decimal OB;
		
		public HourlyEmployee(string inputName,
			int inputAge,
			string inputGender,
			string inputEducation,
			string[] inputPronouns,
			string inputPhoneNumber,
			string inputEmail,
			decimal inputHourlySalary,
			decimal inputOB) : base(inputName, inputAge, inputGender, 
				inputEducation, inputPronouns, inputPhoneNumber, inputEmail) {

			HourlySalary = inputHourlySalary;
			OB = inputOB;
		}

		public override decimal CalculateSalary(DateTime start, DateTime end) {
			decimal result = 0;

			TimeSpan span = end - start;

			result = (decimal)span.TotalHours * HourlySalary;

			if (end.DayOfWeek == DayOfWeek.Sunday) {
				result += OB * (decimal)span.TotalHours;
			}

			return result;
		}

		public override string GetEmployeeInfo() {
			return "Timanställd\nNamn: " + Name + "\nÅlder: " + Age + "\nTimlön: " + HourlySalary + "kr\nOB: " + OB + "kr";
		}
	}
}
