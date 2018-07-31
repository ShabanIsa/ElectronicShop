﻿using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    public class Category
    {
        private readonly string name;
        private readonly List<IProduct> products;

        public Category(string name)
        {
            this.name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
        }

        public void addProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

    }
}