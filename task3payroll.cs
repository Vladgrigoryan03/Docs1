using System;

class Employee{

    public string _EmployeeName;
    public string _EmployeePosition;
    public double _EmployeeSalaryHour;
    public double _EmployeeHoursWorked;

    public Employee(string EmployeeName, string EmployeePosition, double EmployeeSalaryHour, double EmployeeHoursWorked){
        this._EmployeeName = EmployeeName;
        this._EmployeePosition = EmployeePosition;
        this._EmployeeSalaryHour = EmployeeSalaryHour;
        this._EmployeeHoursWorked = EmployeeHoursWorked;
    }

    public double CalculateSalary(){
        if(this._EmployeeHoursWorked <= 40){
        return this._EmployeeSalaryHour * this._EmployeeHoursWorked;
        }
        else {
            return (this._EmployeeSalaryHour * 40) + (this._EmployeeSalaryHour* 1.5 * (this._EmployeeHoursWorked - 40));
        }
    }
}

    class Program{
        static void Main(string[] args){
            Employee[] employee = new Employee[3];
            employee[0] = new Employee("Vlad", "Boss", 20000, 40);
            employee[1] = new Employee("Gag", "Director", 15000, 60);
            employee[2] = new Employee("Tik", "Manager", 10000, 100);
            for(int i = 0; i < employee.Length; ++i){
                Console.WriteLine($"Name: {employee[i]._EmployeeName}\nPosition: {employee[i]._EmployeePosition}\nSalary: {employee[i].CalculateSalary()}");
            }
        }
    }
