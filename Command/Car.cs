using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class Car
    {
        public Car(string carModel, string carBrand, int carCost)
        {
            CarModel=carModel;
            СarBrand = carBrand;
            CarCost=carCost;
        }

        public string CarModel
        {
            get => default;
            set
            {
            }
        }

        public string СarBrand
        {
            get => default;
            set
            {
            }
        }

        public int NumberOfCar
        {
            get => default;
            set
            {
            }
        }

        public int CarCost
        {
            get => default;
            set
            {
            }
        }

        public int CostOfAllCar()
        {
            return CarCost * NumberOfCar;
        }
    }
}