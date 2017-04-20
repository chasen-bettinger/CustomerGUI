//    Filename: Employee.cs
// Description: A simple employee example class
//      Author: Ed Hassler (CWID)
//        Date: 2/2/2012
//
//     History:
//          9/11/2014 ehassler Converted to VS2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Employee
    {
        // Members
        private int id;
        private string name;
        private DateTime hireDate;
        private double rate;
        private double hours;

        // Constructors
        public Employee()
        {
            id = 1234;
            name = "John Doe";
            hireDate = DateTime.Now;
            rate = 7.25;
            hours = 0;
        }

        public Employee(int newId, string newName, DateTime newDate, double newRate, double newHours)
        {
            id = newId;
            name = newName;
            hireDate = newDate;
            rate = newRate;
            hours = newHours;
        }

        // Note: For the purpose of examples I encapsulate 3 of the members using properties
        //       and the remaining 2 members using traditional getter/setter methods. The
        //       prefered technique for C# is properties. Whatever techniques is used,
        //       it should be used consistently (i.e. all proerties or all get/set methods).

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }  // In set methods of properties "value" is the name of the
        }                        // parameter created for you that contains the argument 
                                 // passed in by the calling code. Its type will always match
                                 // the type specified in the property declaration.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime StartDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                if (value >= 7.25)
                {
                    rate = value;
                }
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        // Work methods
        public double CalcPay()
        {
            return rate * hours;
        }

        public int GetTenure()
        {
            // Get today's date
            DateTime currDate = DateTime.Now;

            // Get the difference in years
            int years = currDate.Year - hireDate.Year;

            // Subtract another year if we're before the
            // start date in the current year
            if (currDate.Month < hireDate.Month || (currDate.Month == hireDate.Month && currDate.Day < hireDate.Day))
                years--;

            return years;
        }
    }
}
