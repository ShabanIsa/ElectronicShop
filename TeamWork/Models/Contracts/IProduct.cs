﻿namespace ElectronicsShop.Models.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        decimal Price { get; }

        int RealID { get; set; }
    }
}