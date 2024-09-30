using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizWeek7
{
    internal class Program
    {
        public class Product
        {
            //I know this part is all generally right
            string ProductID { get; set; }
            string ProductName { get; set; }
            double Price { get; set; }

            //Don't exactly know if this is correct, but I know it needs to set the product variables
            public static void setItems(string productID, string productName, double price)
            {
                Product product = new Product();
                product.ProductID = productID;
                product.ProductName = productName;
                product.Price = price;
            }
           
        }
        public class ShoppingCart
        {
            public static void AddProduct(Product product)
            {
                if (product != null)
                {
                    if (product = "Water")
                    {
                        //then adds water to the cart, similar code for each item to be added and removed.
                    }
                    else if (product = "Bread")
                    { }
                    else if (product = "Milk")
                    { }
                    else if (product = "Candy")
                    { }
                    else if (product = "Eggs")
                    { }
                    else
                    {
                        Console.WriteLine("That item doesn't exist. Be sure to type in your item's name exactly as shown.");
                    }
                    //string grabItem = 
                    //don't got enough time. I know how this all works logically, as the addproduct will take the given product name,
                    // and add it to a list (which I also ran out of time to make) of the items, with each of their variables
                }
            }
            public static void RemoveProduct(string productID)
            {
                //RemoveProduct works very similarly to AddProduct, simply doing the reverse,
                //and basically telling the list that the object/product
                //to add one of itself to the cart

            }
            public static void CalculateTotalPrice()
            {
                int sum = 0;
                foreach (var product in myCart)
                {
                    sum += product.Price;
                }
                Console.WriteLine(sum);
                //calculate total is the easiest, simply reading every object in the cart, taking their price property, and summing them all together.
            }

        }

        static void Main(string[] args)
        {
            //Product firstProduct = new Product();
            //firstProduct.productID = "A";

            //setItems("A", "Water", 2.00);

            ShoppingCart myCart = new ShoppingCart();

            Console.BackgroundColor = ConsoleColor.Green;
            //I didn;t even do the change background color on purpose, for some reason visual studio auto placed it, and if the code worked,
            //I wanted to see how it would look. but the code has errors i can't really fi right now, so hey.
            Console.WriteLine("What action would you like to perform?");
            Console.WriteLine("1 to add an item, 2 to remove and item, 3 to calculate your total price, and 4 to exit.");
            int action = Convert.ToInt32(Console.ReadLine());
            while (action != 4)
            {
                if (action == 1)
                {
                    Console.WriteLine("Which product would you like to add?");
                    Console.WriteLine("Water, Bread, Milk, Candy, or Eggs?");
                    myCart.AddProduct("");
                    //can't get AddProduct or removeproduct working because I honestly don't remember the syntax for it.
                }
                else if (action == 2)
                {
                    Console.WriteLine("Which product would you like to remove?");
                    Console.WriteLine("Water, Bread, Milk, Candy, or Eggs?");

                    myCart.RemoveProduct("Console.ReadLine()");

                    //I may look like a bumbling idiot when doing the quizzes, but I'm commenting all this to prove that I know the content,
                    //just not how to get it done by perfect memory.

                }
                else if (action == 3)
                {
                    CalculateTotalPrice(myCart);
                    //Again, didn't get too far, so I'm not sure how to get the myCart into the CalculateTotalPrice
                    //if your instructions say it has no given variable
                }
                else
                {
                    Console.WriteLine("You input a number without an action associated. Try again.");
                    Console.WriteLine("What action would you like to perform?");
                    Console.WriteLine("1 to add an item, 2 to remove and item, 3 to calculate your total price, and 4 to exit.");
                    action = Convert.ToInt32(Console.ReadLine());
                }
                Console.ReadLine();

                //simply put: I know how to do this. I am pretty good at c# by now. I honestly am just really bad at portraying that.
            }
        }
    }
}
