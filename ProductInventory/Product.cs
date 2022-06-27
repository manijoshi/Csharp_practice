using System;
using System.Collections.Generic;

namespace ProductInventory
{
    public delegate void Transformer(int x);
    public class PriceChangedEventArgs : EventArgs
    {
        public float Difference { get; private set; }
        public PriceChangedEventArgs(float difference)
        {
            Difference = difference;
        }
    }

    public class Product
    {
        public event EventHandler ChangeDefectiveness;
        public event EventHandler<PriceChangedEventArgs> ChangePrice;

        int id;
        float price;
        bool isDefective;

        public int GetId()
        {
            return id;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float value)
        {
            PriceChangedEventArgs e = new PriceChangedEventArgs(value - price);
            price = value;
            ChangePrice(this, e);
        }

        public bool GetIsDefective()
        {
            return isDefective;
        }

        public void SetIsDefective(bool value)
        {
            isDefective = value;
            ChangeDefectiveness(this, null);
        }

        public Product(int id, float price, bool isDefective)
        {
            this.id = id;
            this.price = price;
            this.isDefective = isDefective;
        }


    }


}