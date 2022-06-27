using System;
using System.Collections.Generic;
namespace ProductInventory
{
    public class Inventory
    {
        public float Total { get; set; }
        public Dictionary<Product, int> Products { get; set; }

        public Inventory()
        {
            Total = 0;
            Products = new Dictionary<Product, int>();
        }

        public void AddProduct(Product p, int quantities)
        {
            if (!p.GetIsDefective())
            {

                Products.Add(p, quantities);
                Total += p.GetPrice();
                p.ChangeDefectiveness += new EventHandler(OnChangeDefectiveness);
                p.ChangePrice += new EventHandler<PriceChangedEventArgs>(OnChangePrice);
            }
        }
        public void MakeProductDefective(Product p)
        {
            p.SetIsDefective(true);
        }


        //public void _OnChangeDefectiveness(object sender,bool isde)
        public void RemoveProduct(Product p)
        {
            if (Products.ContainsKey(p))
            {
                Total -= Products[p] * p.GetPrice();
                Products.Remove(p);
            }
        }

        public void UpdateProductQuantity(Product p, int amount)
        {
            if (Products.ContainsKey(p))
            {
                Total += (amount - Products[p]) * p.GetPrice();
                Products[p] = amount;

            }
        }

        private void OnChangeDefectiveness(object sender, EventArgs e)
        {
            Product p = (Product)sender;
            Console.WriteLine("Product is defective");
            RemoveProduct(p);

        }

        private void OnChangePrice(object sender, PriceChangedEventArgs e)
        {
            Product p = (Product)sender;
            Total += Products[p] * e.Difference;
        }
    }
}