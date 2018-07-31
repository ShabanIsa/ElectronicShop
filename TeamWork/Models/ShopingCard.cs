﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    class ShopingCard
    {
        private readonly List<IProduct> productList;

        public ShopingCard()
        {
            this.productList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return new List<IProduct>(this.productList); }
        }

        public void AddProduct(IProduct product)
        {

            this.productList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {

            this.productList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.productList.Contains(product))
            {
                return true;
            }
            else return false;
        }

        public double TotalPrice()
        {
            return 0;
        }

    }
}