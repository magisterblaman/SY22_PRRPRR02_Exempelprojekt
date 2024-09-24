using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class PartTimeEmployee : Employee {
		public decimal BaseSalary;
		public decimal OB;
		public int WorkingPercentage;
		
		public PartTimeEmployee(string inputName,
			int inputAge,
			string inputGender,
			string inputEducation,
			string[] inputPronouns,
			string inputPhoneNumber,
			string inputEmail,
			decimal inputBaseSalary,
			decimal inputOB,
			int inputWorkingPercentage) : base(inputName, inputAge, inputGender, 
				inputEducation, inputPronouns, inputPhoneNumber, inputEmail) {

			BaseSalary = inputBaseSalary;
			OB = inputOB;
			WorkingPercentage = inputWorkingPercentage;
		}

		public override decimal CalculateSalary(DateTime start, DateTime end) {
			return 0;
		}
	}
}
