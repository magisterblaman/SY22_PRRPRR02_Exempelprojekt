using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class UserInterface {
		private SalaryData _salaryData;

		public UserInterface(SalaryData inputSalaryData) {
			_salaryData = inputSalaryData;
		}

		public void HandleLogin() {
			Console.WriteLine("Välkommen! Vänligen logga in.");
            Console.Write("Användarnamn: ");
			string username = Console.ReadLine();
			Console.Write("Lösenord: ");
			string password = Console.ReadLine();

			if (username == "bossen" && password == "boss") {
				PrintBossMenu();
			} else if (username == "HABL" && password == "jagälskarsy22<3") {
				PrintEmployeeMenu(_salaryData.Employees[0]);
			} else {
				Console.WriteLine("Ogiltigt användarnamn och/eller lösenord");
			}
		}

		private void PrintBossMenu() {
			Console.WriteLine("Vänligen välj en anställd: ");
			for (int i = 0; i < _salaryData.Employees.Count; i++) {
				Console.WriteLine((i + 1) + ". " + _salaryData.Employees[i].Name);
			}
			int employeeIndex = int.Parse(Console.ReadLine()) - 1;

			PrintEmployeeInfo(_salaryData.Employees[employeeIndex]);
		}

		private void PrintEmployeeInfo(Employee employee) {
			string info = employee.GetEmployeeInfo();
			Console.WriteLine(info);
		}

		private void PrintEmployeeMenu(Employee employee) {
			Console.WriteLine("Välkommen " + employee.Name + ". Vänligen välj ett alternativ.");
			Console.WriteLine("1. Se din info");
			Console.WriteLine("2. Registrera ett arbetspass");
			int userChoice = int.Parse(Console.ReadLine());

			if (userChoice == 1) {
				PrintEmployeeInfo(employee);
			} else if (userChoice == 2) {
				Console.Write("Vilken tid började du jobba? ");
				string startTimeString = Console.ReadLine();
				Console.Write("Vilken tid slutade du jobba? ");
				string endTimeString = Console.ReadLine();

				DateTime startTime = DateTime.ParseExact(startTimeString, "H:mm", CultureInfo.InvariantCulture);
				DateTime endTime = DateTime.ParseExact(endTimeString, "H:mm", CultureInfo.InvariantCulture);

				WorkedShift shift = new WorkedShift(startTime, endTime, employee);
				_salaryData.TimeClock.WorkedShifts.Add(shift);
				Console.WriteLine("Arbetat pass registrerat");
				_salaryData.TimeClock.PrintAllWorkedShifts();
			}
		}

		private void PrintMenu() {
			
		}
	}
}
