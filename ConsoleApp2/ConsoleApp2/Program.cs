using System;
using System.Collections.Generic;

namespace LitwareLib
{
    public class Employees
    {
        private int _EmpNo;
        private string _EmpName;
        private double _Salary;
        private double _HRA;
        private double _TA;
        private double _DA;
        private double _PF;
        private double _TDS;
        private double _NetSalary;
        private double _GrossSalary;

        public Employees(int EmpNo, string EmpName, double Salary)
        {
            this._EmpNo = EmpNo;
            this._EmpName = EmpName;
            this._Salary = Salary;
            /*
             *double HRA, double TA, double DA, double PF, double TDS,
            double NetSalary, double GrossSalary)
            this._HRA = HRA;
            this._TA = TA;
            this._DA = DA;
            this._PF = PF;
            this._TDS = TDS;
            this._NetSalary = NetSalary;
            this._GrossSalary = GrossSalary;
            */
        }

        //public properites get and set
        public int EmpNo
        {
            get
            {
                return this._EmpNo;
            }
            set
            {
                this._EmpNo = value;
            }
        }
        public string EmpName
        {
            get
            {
                return this._EmpName;
            }
            set
            {
                this._EmpName = value;
            }
        }
        public double Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this._Salary = value;
            }
        }

        public void Calculate()
        {
            if (Salary < 5000)
            {
                _HRA = 0.1 * Salary;
                _TA = 0.05 * Salary;
                _DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                _HRA = 0.15 * Salary;
                _TA = 0.1 * Salary;
                _DA = 0.2 * Salary;
            }
            else if (Salary < 15000)
            {
                _HRA = 0.2 * Salary;
                _TA = 0.15 * Salary;
                _DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                _HRA = 0.25 * Salary;
                _TA = 0.2 * Salary;
                _DA = 0.3 * Salary;
            }
            else
            {
                _HRA = 0.3 * Salary;
                _TA = 0.25 * Salary;
                _DA = 0.35 * Salary;
            }

            _GrossSalary = Salary + _HRA + _TA + _DA;

            _PF = 0.1 * _GrossSalary;
            _TDS = 0.18 * _GrossSalary;
            _NetSalary = _GrossSalary - (_PF + _TDS);

            Console.WriteLine("Employee Details - EmpNo: {0} \nEmpName: {1} \nSalary: {2}", _EmpNo, _EmpName, _Salary);
            Console.WriteLine("GrossSalary : {0}", _GrossSalary);
            Console.WriteLine("PF : {0}", _PF);
            Console.WriteLine("TDS : {0}", _TDS);
            Console.WriteLine("NetSalary : {0}", _NetSalary);
        }
        public static void Main()
        {
            Employees emp = new Employees(101, "Harish", 8000);
            emp.Calculate();
        }
    }

}