using System;


/*
 * This is an abstract class of employee
 * here we define the general features of employee
 */
abstract class Employee
{
	protected string _employeeName;
	protected string _employeeID;
	protected string _jobTitle;
	//Degree 
	protected float _hoursOfWork;
	protected float _salary;


	public virtual float GetSalary() { return this._salary; } //abstract method
}
