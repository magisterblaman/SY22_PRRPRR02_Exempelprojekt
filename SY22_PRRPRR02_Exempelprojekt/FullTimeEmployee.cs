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
			return 0;
		}
	}
}
