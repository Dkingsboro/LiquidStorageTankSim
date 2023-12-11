using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidStorageTankSim
{
    internal class StorageTank
    {
        public double Width { get; set; } // Instance variables for LST Class
        public double Length { get; set; }
        public double Height { get; set; }
        public double CurrentGallons;
        const double conversion = 7.48052; // Constant variable for the conversion to gallons

        public StorageTank() // No argument constructor for the StorageTank class
        {
            Width = 5;
            Length = 5;
            Height = 5;
            CurrentGallons = 0;
        }

        public StorageTank(double Length, double Width, double Height) // Triple instance constructor overload for Storage Tank.Defines Length, Width, and Height.
        {
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
        }

        public double Capacity() // Method to calculate the volume of the tank in gallons
        {
            double volume = (Length * Width * Height) * conversion;
            return volume;
        }

        private void SetCurrentGallons(double volume) // This set method, sets the volume AFTER conversion to gallons for the Capacity method.This is ONLY to be used to within the class.
        {
            CurrentGallons = volume;
        }

        public bool Add(double gallons) // Add method in order to take the added gallons defined in the main, and see if it will fit in the storage tank.Returns true or false.
        {
            double estimatedVolume = gallons + CurrentGallons;
            if (estimatedVolume <= Capacity())
            {
                SetCurrentGallons(estimatedVolume);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(double gallons) // Return method inorder to take the removed gallons defined in the main, and will see if removal is possible within the storage tank at the calculated capacity.
        {
            if (gallons <= CurrentGallons)
            {
                SetCurrentGallons(CurrentGallons - gallons);
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetPercentFull() // Simply a method for calculating the filled capacity of the tank in percent.
        {
            return CurrentGallons / Capacity()* 100;
        }

        public override string ToString() // To string method to display the information about the defined storage tank.
        {
            return
                $"_______________________________________________________________\n" +
                $"The tank has a width of {Width} feet\n" +
                $"The tank has a length of {Length} feet\n" +
                $"The tank has a height of {Height} feet\n" +
                $"The tank capacity is {Capacity()} gallons\n" +
                $"This container has current gallons of {CurrentGallons} gallons\n" +
                $"_______________________________________________________________";
         }
    }
}
