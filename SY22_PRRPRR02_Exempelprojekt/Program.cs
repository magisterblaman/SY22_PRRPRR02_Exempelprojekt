using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Exempelprojekt {
	internal class Program {
		static void Main(string[] args) {
			TimeClock tc = new TimeClock();
			List<Employee> bajskorv = new List<Employee>() {
				new FullTimeEmployee("Hannes Blåman", 20, "man", "LBS", new string[] {"han", "honom"}, "det trodde ni allt va", "hannes.blaman@lbs.se", 660000, -50),
				new PartTimeEmployee("Anna Andersson", 30, "Female", "Bachelor of Science",new string[] { "she", "her" }, "0701234567", "anna@example.com",25000m, 1000m, 50),

			new PartTimeEmployee(
				"Erik Svensson", 25, "Male", "Master's in Engineering",
				new string[] { "he", "him" }, "0709876543", "erik@example.com",
				30000m, 1500m, 75),

			new PartTimeEmployee(
				"Sam Johanson", 28, "Non-binary", "Bachelor of Arts",
				new string[] { "they", "them" }, "0705647382", "sam@example.com",
				22000m, 800m, 60)
			};
			SalaryData sd = new SalaryData(bajskorv, tc);
			UserInterface ui = new UserInterface(sd);

			ui.HandleLogin();
		}
	}
}
