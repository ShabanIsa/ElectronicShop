﻿using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Interfaces;
using TeamWork.Models.Products.Electronics.Common;
using TeamWork.Models.Products.Electronics.Phones;

namespace TeamWork.Core.Factories
{
    public interface IProductFactory
    {
       ISmartphone CreateSmartphone(string productName, decimal price, string brand, string model, Colours colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, string processor, int ram);
       ILandlinePhone CreateLandlinePhone(string productName, decimal price, string brand, string model, Colours colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, int analogueLines, bool wallMounting);
        //ILaptop CreateLaptop
        //IDesctopPC CreateDesctopPC
    
    }
}