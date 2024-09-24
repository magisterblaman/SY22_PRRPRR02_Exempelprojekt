using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class WorkedShift {
		public DateTime Start;
		public DateTime End;
		public Employee Employee;

		public WorkedShift(DateTime inputStart, DateTime inputEnd, Employee inputEmployee) {
			Start = inputStart;
			End = inputEnd;
			Employee = inputEmployee;
		}
	}
}
