using System;
using System.Collections.Generic;

namespace PRO3.Properties
{
    public class Doctor : Employee
    {
        private Dictionary<Specialization, DateTime> _specializations;
        private int _numberOfSurgeries;
        private float _cancerDetectionRate;
        
        private string _name;

        public Doctor()
        {
            _specializations = new Dictionary<Specialization, DateTime>();
            _isMedicalStuff = true;
        }

        public void AddSpecialization(Specialization specialization, DateTime acquisitionDate)
        {
            if (_specializations.ContainsKey(specialization))
            {
                _specializations[specialization] = acquisitionDate;
                Console.WriteLine("Specialization data was updated");
            }
            
            _specializations.Add(specialization, acquisitionDate);
        }

        public bool PerformHeartSurgery()
        {
            if (_specializations.ContainsKey(Specialization.Cardiologist))
            {
                Console.WriteLine("Dr. " + _name + " is performing heart surgery");
                return true;
            }

            return false;
        }
        
        public bool DiagnoseCancer()
        {
            if (_specializations.ContainsKey(Specialization.Oncologist))
            {
                Console.WriteLine("Dr. " + _name + " is diagnosing cancer");
                return true;
            }

            return false;
        }

        public int GetNumberOfSurgeries()
        {
            if (_specializations.ContainsKey(Specialization.Cardiologist))
            {
                return _numberOfSurgeries;
            }

            Console.WriteLine("This doctor isn't a cardiologist!");
            return 0;
        }

        public void SetNumberOfSurgeries(int x)
        {
            if (_specializations.ContainsKey(Specialization.Cardiologist))
            {
                _numberOfSurgeries = x;
            }

            Console.WriteLine("This doctor isn't a cardiologist!");
        }

        public float GetCancerDetectionRate()
        {
            if (_specializations.ContainsKey(Specialization.Oncologist))
            {
                return _cancerDetectionRate;
            }

            Console.WriteLine("This doctor isn't a oncologist!");
            return 0;
        }
        
        public void SetCancerDetectionRate(int x)
        {
            if (_specializations.ContainsKey(Specialization.Oncologist))
            {
                _cancerDetectionRate = x;
            }

            Console.WriteLine("This doctor isn't a oncologist!");
        }
    }
}