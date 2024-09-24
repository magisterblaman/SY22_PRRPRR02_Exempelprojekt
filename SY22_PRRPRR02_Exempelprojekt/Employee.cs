using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class Employee {
		public string Name;
		public int Age;
		public string Gender;
		public string Education;
		public string[] Pronouns;
		public string PhoneNumber;
		public string Email;

		protected Employee(string inputName, 
			int inputAge, 
			string inputGender,
			string inputEducation,
			string[] inputPronouns,
			string inputPhoneNumber,
			string inputEmail) {

			Age = inputAge;
			Gender = inputGender;
			Education = inputEducation;
			Pronouns = inputPronouns;
			PhoneNumber = inputPhoneNumber;
			Email = inputEmail;

		}

		public virtual decimal CalculateSalary(DateTime start, DateTime end) {
			return 0;
		}
	}
}
