using System;


/*
 * This is an abstract class of employee
 * here we define the general features of employee
 */
namespace MamaLis
{
	abstract class Employee
	{
		protected string _employeeName;
		protected string _employeeID;
		protected string _jobTitle;
		protected double _hoursOfWork;

		Degree employeeDegree;



		//gets and Sets :

		//employee name
		public string GetEmployeeName() { return this._employeeName; }
		public void SetEmployeeName(string name) { this._employeeName = name; }

		//employee ID
		public string GetEmployeeID() { return this._employeeID; }
		public void SetEmployeeID(string id) { this._employeeID = id; }

		//job title
		public string GetJobTitle() { return this._jobTitle; }
		public void SetJobTitle(string jobTitle) { this._jobTitle = jobTitle; }

		//hours of work
		public double GetHoursOfWork() { return this._hoursOfWork; }
		public void SetHoursOfWork()
		{
			int start, end;
			Console.WriteLine("When do you start working today ? please enter an hour (0-24)");
			start = int.Parse(Console.ReadLine());
			Console.WriteLine("When do you end working today ? please enter an hour (0-24)");
			end = int.Parse(Console.ReadLine());

			this._hoursOfWork += (end - start);
		}



		//Constructor
		public Employee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, double extraRisk)
		{ 
			this._employeeName = employeeName;
			this._employeeID = employeeID;
			this._jobTitle = jobTitle;
			this._hoursOfWork = 0; //new employee worked 0 hours yet.
			this.employeeDegree = new Degree(ifExpert, ifMakeDecisions, extraRisk);			  
		} 
		

		//protected float _salary;

		public virtual float GetSalary() 
		{
			return 5;//(this._hoursOfWork * Consts.hourSalaryAvg); 
		} 

		public void PrintEmployee()
        {
			Console.WriteLine("ID: " + this._employeeID);
			Console.WriteLine("Name: " + this._employeeName);
			Console.WriteLine("Job Title :" + this._jobTitle);
			Console.WriteLine("Hours of work: " + this._hoursOfWork.ToString());
			Console.WriteLine("Salary :" + GetSalary());
			//Console.WriteLine("Degrees :");
		}

		    
	}
}