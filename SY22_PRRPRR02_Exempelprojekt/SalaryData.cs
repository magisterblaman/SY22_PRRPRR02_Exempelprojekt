using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class SalaryData {
		public List<Employee> Employees;
		public TimeClock TimeClock;

		public SalaryData(List<Employee> inputEmployees, TimeClock inputTimeClock) {
			Employees = inputEmployees;
			TimeClock = inputTimeClock;
		}
	}
}
