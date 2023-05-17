using System;
using System.Collections.Generic;
using PRO3.Properties;

namespace PRO3
{
    public class HospitalBed : IBed, ISurgeryEquipment
    {
        private Patient _patient;
        private Dictionary<DateTime, int> _schedule;

        public HospitalBed()
        {
            _schedule = new Dictionary<DateTime, int>();
        }
        
        public bool AssignPatient(Patient patient)
        {
            if (_patient is null)
            {
                _patient = patient;
                return true;
            }

            Console.WriteLine("This bed is occupied!");
            return false;
        }

        public bool OrderForOperation(DateTime dateTime, int roomNumber)
        {
            if (_schedule.ContainsKey(dateTime) || !(_patient is null))
            {
                Console.WriteLine("This bed is " + ((_patient is null)? "not available at that time!" : "occupied!"));
                return false;
            }
            
            _schedule.Add(dateTime, roomNumber);
            return true;
        }
    }
}