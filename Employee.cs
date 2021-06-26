using System;


/*
 * This is an abstract class of employee
 * here we define the general features of employee
 */
abstract class Employee
{
	protected string _employeeName
	{ get { return this._employeeName; }
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
	protected float _hoursOfWork
	{
		get { return this._hoursOfWork; }
		set { this._hoursOfWork = value; }
	}
	
	//protected float _salary;

	public virtual float GetSalary() { return 179999; } //abstract method


}
