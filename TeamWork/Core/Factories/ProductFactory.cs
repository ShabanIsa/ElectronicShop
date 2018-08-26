﻿using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;

namespace ElectronicsShop.Core.Factories
{
    public class ProductFactory : IProductFactory
    {
        

        //smartphone command
        //create smartphone gosho 900 Asus ZenPhone Black LiIon 16 3 3 3 Atom 4

        //lanlinePhone command
        //create landlinephone gosho 9 VIVACOM Home White LiIon 16 3 3 3 10

        //laptop command
        //create laptop MyLaptop Lenovo ThinkPad 14 4500 i5 8 500 4 1200


        public ProductFactory()
        {

        }
            //private int count;

        public ILandlinePhone CreateLandlinePhone(int Id, decimal price, string brand, string model, string colour, string battery, int displaySize, PhoneSize size, int analogueLines)
        {
            return new LandlinePhone(Id, price, brand, model, this.GetColour(colour).ToString(), this.getBatteryType(battery).ToString(), displaySize, size, analogueLines);
            //count++;
        }

        public ISmartphone CreateSmartphone( string brand, string model, string colour, string battery, int displaySize,
            PhoneSize size, string processor, int ram, decimal price)
        {

            return new Smartphone( brand, model, this.GetColour(colour).ToString(), this.getBatteryType(battery).ToString(), displaySize, size, processor, ram, price);
            //count++;
        }

        public IDesktopComputer CreateDesktopComputer(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            return new DesktopPC(brand, model, processor, ram, hdd, videoCard, price);
            //count++;
        }

        public ILaptop CreateLaptop(string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price)
        {
            return new Laptop(brand, model, displaySize, batteryCapacity, procesor, ram, hdd, videoCard, price);
            // count++;
        }
        private Colour GetColour(string colour)
        {
            switch (colour)
            {
                case "Black":
                    return Colour.Black;
                case "White":
                    return Colour.White;
                case "Red":
                    return Colour.Red;
                case "Grey":
                    return Colour.Grey;
                case "Blue":
                    return Colour.Blue;
                case "Gold":
                    return Colour.Gold;
                default: throw new ArgumentException("Colour not set correctly!");
            }
        }

        private BatteryType getBatteryType(string battery)
        {
            switch (battery)
            { 
                case "LiIon":
                    return BatteryType.LiIon;
                case "White":
                    return BatteryType.NiMH;
                case "Red":
                    return BatteryType.NiCd;
                default: throw new ArgumentException("Colour not set correctly!");
            }
        }
    }

}
