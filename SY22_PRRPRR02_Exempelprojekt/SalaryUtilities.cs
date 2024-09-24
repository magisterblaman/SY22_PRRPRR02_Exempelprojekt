using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal static class SalaryUtilities {

		public static decimal CalculateHourlySalary(int age) {
			if(age < 18) {
				return 100;
			}else if(age == 18) {
				return 140;
			}else if(age == 19) {
				return 160;
			} else {
				return 180;
			}
		}

	}
}
