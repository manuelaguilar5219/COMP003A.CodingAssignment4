// Author: Manuel Aguilar
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialized new array and list
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0;
            List<string> namesOfProducts = new List<string>();
            List<int> quantityOfProducts = new List<int>();

            Console.WriteLine("Welcome to the Inventory Management System!"); // Welcomes the user
            // Initialized variables
            int userChoice1;
            int userChoice2;
            // Prompt the user to select from array or list
            Console.WriteLine("Choose data storage type");
            Console.WriteLine("1. Arrays");
            Console.WriteLine("2. List");
            Console.WriteLine("Enter your choice");
            userChoice1 = int.Parse(Console.ReadLine());

            if (userChoice1 == 1) // If the user selects arrays
            {
                while (true) // While loop
                {
                    // Displays the system menu and prompts the user to select one of the 4 options
                    Console.WriteLine("Inventory Management System Menu:");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                    userChoice2 = int.Parse(Console.ReadLine());

                    switch (userChoice2)
                    {
                        // Prompts the user to enter product details if they selected to add a product
                        case 1:
                            if (count < productNames.Length)
                            {
                                Console.WriteLine("Enter product name: ");
                                productNames[count] = Console.ReadLine();
                                Console.WriteLine("Enter product quantity: ");
                                productQuantities[count] = int.Parse(Console.ReadLine());
                                count++;
                            }
                            // It will display that the inventory is full if the user tries to add more than the ten product limit
                            else
                            {
                                Console.WriteLine("Inventory is full!");
                            }
                            break;
                        // Prompts the user to update product quantity if the user selects option 2
                        case 2:
                            Console.WriteLine("Enter the product name: ");
                            int index = Array.IndexOf(productNames, Console.ReadLine());
                            if (index != -1)
                            {
                                Console.WriteLine("Enter new product quantity: ");
                                productQuantities[index] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Prodcut quantity changed successfully");
                            }
                            // Displays message that the product was not found if the user tries to change a product that they never added
                            else
                            {
                                Console.WriteLine("Product not found");
                            }
                            break;
                        // If the user selects option 3 it will display the inventory summary to the user
                        case 3:
                            // Initialized quantitySum variable
                            int quantitySum = 0;
                            Console.WriteLine("Inventory Summary:");
                            for (int i = 0; i < count; i++) // for loop
                            {
                                Console.WriteLine($"-{productNames[i]}: {productQuantities[i]} "); // Displays product names and quantities
                                quantitySum += productQuantities[i]; // Assigned productQuantities[i] to quantitySum variable
                            }
                            Console.WriteLine($"Total Products: {count}"); // Displays Total products
                            Console.WriteLine($"Total Quantity: {quantitySum}"); // Displays Total quantity
                            double averageQuantities = quantitySum / count; // Sets averageQuantities to equal quantity sum divided by the total amount of products
                            Console.WriteLine($"Average Quantity: {averageQuantities}"); // Displays averageQuantities
                            break;
                        // Exits the loop if the User selects option 4
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        // Prompts the user to select one of the four options if the user inputs somehting else
                        default:
                            Console.WriteLine("Please selcet one of the four options in the menu!");
                            break;
                    }
                }
            }
            else if (userChoice1 == 2) // If the user selects List
            {
                while (true)
                {
                    // Displays the system menu and prompts the user to select one of the 4 options
                    Console.WriteLine("Inventory Management System Menu:");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                    userChoice2 = int.Parse(Console.ReadLine());

                    switch (userChoice2)
                    {
                        // Prompts the user to enter product details if they selected to add a product
                        case 1:
                            Console.WriteLine("Enter product name: ");
                            namesOfProducts.Add(Console.ReadLine());
                            Console.WriteLine("Enter product quantity");
                            quantityOfProducts.Add(int.Parse(Console.ReadLine()));
                            break;
                        // Prompts the user to update product quantity if the user selects option 2
                        case 2:
                            Console.WriteLine("Enter the product name: ");
                            int index = namesOfProducts.IndexOf(Console.ReadLine());
                            if (index != -1)
                            {
                                Console.WriteLine("Enter new product quantity: ");
                                quantityOfProducts[index] = int.Parse(Console.ReadLine());
                            }
                            // Displays message if the product the user tries to change is not found
                            else
                            {
                                Console.WriteLine("Product not found");
                            }
                            break;
                        // If the user selects option 3 it will display the inventory summary to the user
                        case 3:
                            // Initializes variable
                            int totalQuantity = 0;
                            Console.WriteLine("Inventory Summary: ");
                            for (int i = 0; i < namesOfProducts.Count; i++)
                            {
                                Console.WriteLine($"-{namesOfProducts[i]}: {quantityOfProducts[i]}");
                                totalQuantity += quantityOfProducts[i];
                            }
                            Console.WriteLine($"Total Products: {namesOfProducts.Count}"); // Displays Total products
                            Console.WriteLine($"Total Quantity: {totalQuantity}"); // Displays Total Quantity
                            double quantityAverage = totalQuantity / quantityOfProducts.Count; // Sets the average quantity
                            Console.WriteLine($"Avearage Quantity: {quantityAverage}"); // Displays the Average quantity
                            break;
                        // Exits the loop if the User selects option 4
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        // Prompts the user to select one of the four options if the user inputs somehting else
                        default:
                            Console.WriteLine("Please selcet one of the four options in the menu!");
                            break;
                    }
                }
            }
            // Displays message if the user selects something else other than Arrays or List
            else 
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
