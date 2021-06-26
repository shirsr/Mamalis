using System;


/*
 * This is an abstract class of employee
 * here we define the general features of employee
 */
namespace MamaLis
{
	abstract class Employee
	{
		protected string _employeeName
		{
			get { return this._employeeName; }
			set { this._employeeName = value; }
		}
		protected string _employeeID
		{
			get { return this._employeeID; }
			set { this._employeeID = value; }
		}
		protected string _jobTitle
		{
			get { return this._jobTitle; }
			set { this._jobTitle = value; }
		}
		protected double _hoursOfWork
		{
			get { return this._hoursOfWork; }
			set { this._hoursOfWork = value; }
		}

		Degree employeeDegree;


		public Employee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, float extraRisk)
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

		    
	}
}