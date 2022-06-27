using System;

namespace ProductInventory
{
    public delegate void transform(int x);
    public class Program
    {
        public static void Main()
        {
            Inventory obj = new Inventory();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Product Quantity");
                Console.WriteLine("4. Display total value of the inventory");
                Console.WriteLine("5. Make product defective");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice : ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product ID: {0}", id);
                        Console.Write("Enter the product price: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.Write("Enter the product quantities: ");
                        int quantities = int.Parse(Console.ReadLine());
                        Console.Write("Is this product defective? y/n: ");
                        bool answer = Convert.ToBoolean(Console.ReadLine());

                        Product p = new Product(id, price, answer);

                        obj.AddProduct(p, quantities);


                        break;
                    case 2:
                        Console.Write("Enter the product ID to remove: ");
                        id = int.Parse(Console.ReadLine());
                        Product selectedProduct = null;
                        foreach (var product in obj.Products)
                        {
                            if (product.Key.GetId() == id)
                            {
                                selectedProduct = product.Key;
                                break;
                            }
                        }
                        if (selectedProduct != null)
                        {
                            obj.RemoveProduct(selectedProduct);
                            Console.WriteLine("\nThe product has been removed.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nA product does not exist.\n");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the product ID to update product quantity: ");
                        id = int.Parse(Console.ReadLine());
                        selectedProduct = null;
                        foreach (var product in obj.Products)
                        {
                            if (product.Key.GetId() == id)
                            {
                                selectedProduct = product.Key;
                                break;
                            }
                        }
                        if (selectedProduct != null)
                        {
                            Console.Write("Enter a new product quantities: ");
                            quantities = int.Parse(Console.ReadLine());
                            obj.UpdateProductQuantity(selectedProduct, quantities);
                            //obj.Products[selectedProduct] = quantities;
                            Console.WriteLine("\nThe product quantity has been updated.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nA product does not exist.\n");
                        }
                        break;
                    case 4:
                        float total = 0;
                        foreach (var product in obj.Products)
                        {
                            total += product.Key.GetPrice() * product.Value;
                        }
                        Console.WriteLine("The total value of the inventory: {0}", total.ToString("N2"));
                        break;
                    case 5:
                        Console.Write("Enter the product ID to make it defected: ");
                        id = int.Parse(Console.ReadLine());
                        selectedProduct = null;
                        foreach (var product in obj.Products)
                        {
                            if (product.Key.GetId() == id)
                            {
                                selectedProduct = product.Key;
                                break;
                            }
                        }
                        if (selectedProduct != null)
                        {
                            Console.Write("Enter a new product quantities: ");
                            quantities = int.Parse(Console.ReadLine());
                            obj.MakeProductDefective(selectedProduct);
                            //obj.Products[selectedProduct] = quantities;
                            Console.WriteLine("\nThe product quantity has been updated.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nA product does not exist.\n");
                        }
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
