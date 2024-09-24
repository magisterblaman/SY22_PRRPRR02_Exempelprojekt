using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class TimeClock {
		public List<WorkedShift> WorkedShifts;

		public TimeClock() {
			WorkedShifts = new List<WorkedShift>();
		}

		public void PrintAllWorkedShifts() {
			for (int i = 0; i < WorkedShifts.Count; i++) {
				WorkedShift shift = WorkedShifts[i];
				Console.WriteLine(shift.Employee.Name + ": " + shift.Start.ToShortTimeString() + '-' + shift.End.ToShortTimeString());
			}
		}
	}
}
