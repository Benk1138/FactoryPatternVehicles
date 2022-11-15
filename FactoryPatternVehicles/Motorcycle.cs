﻿using System;
namespace FactoryPatternVehicles
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The Motorcycle is driving");
        }
    }
}
