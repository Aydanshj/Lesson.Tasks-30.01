using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_30._01._2023
{
    internal class Vehicle
    {
        protected double _mileage;
        public double Mileage => _mileage;
        public virtual void Drive(double km)
        {
            _mileage += km;
        }
    }
}
