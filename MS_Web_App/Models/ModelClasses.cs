using System;
using System.Collections.Generic;
namespace MS_Web_App.Models
{
	public class Employee
	{
		public int EmpNo { get; set; }
		public string EmpName { get; set; }
	}
	
public class EmployeeDatabase : List<Employee>
{
	
	public EmployeeDatabase()
	{
		Add(new Employee(){EmpNo=101,EmpName="MS"});
		Add(new Employee(){EmpNo=102,EmpName="LS"});
		Add(new Employee(){EmpNo=103,EmpName="TS"});
	}	
}

}


