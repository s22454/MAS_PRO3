using System;
using System.Collections.Generic;

namespace PRO3
{
    public class Employee
    {
        private Dictionary<DateTime, int> _schedule;
        protected bool _isMedicalStuff;

        public Employee()
        {
            _schedule = new Dictionary<DateTime, int>();
            _isMedicalStuff = false;
        }

        public bool AssignToJob(DateTime dateTime, int room)
        {
            if (_schedule.ContainsKey(dateTime))
            {
                Console.WriteLine("This employee isn't available at that time!");
                return false;
            }
            
            _schedule.Add(dateTime, room);
            Console.WriteLine("Employee was successfully assigned to the job");
            return true;
        }
        
        public bool AssignToOperation(DateTime dateTime, int room)
        {
            if (!_isMedicalStuff)
            {
                Console.WriteLine("This employee isn't part of medical stuff!");
                return false;
            }

            if (_schedule.ContainsKey(dateTime))
            {
                Console.WriteLine("This employee isn't available at that time!");
                return false;
            }

            _schedule.Add(dateTime, room);
            Console.WriteLine("Employee was successfully assigned to operation");
            return true;
        }
    }
}