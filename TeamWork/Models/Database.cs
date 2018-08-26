﻿using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Models
{
    public class Database : IDatabase
    {
        private readonly List<IProduct> products;

        public List<IProduct> Products
        {
            get
            {
                return this.products;
            }
        }

        public Database()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
            product.ID = products.IndexOf(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

        public string GetList(string typeOfProduct)
        {
            //throw new NotImplementedException("not implemented Database method GetList()");
            StringBuilder sb = new StringBuilder();
            var collection = this.products.Where(x => x.Name.ToLower().Contains(typeOfProduct)).ToList();
            collection.ForEach(x => sb.Append(x.Print()));
            return sb.ToString();
        }

        public IProduct GetProduct(int id)
        {
            return this.products.First(p => p.ID == id);
        }

        public bool Contains(int id)
        {
            if (products.Any(x => x.ID == id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
