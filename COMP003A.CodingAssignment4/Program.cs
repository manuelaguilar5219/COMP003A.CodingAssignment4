namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0;

            Console.WriteLine("Welcome to the Inventory Management System!");

            int userChoice1;
            int userChoice2;

            Console.WriteLine("Choose data storage type");
            Console.WriteLine("1. Arrays");
            Console.WriteLine("2. List");
            Console.WriteLine("Enter your choice");
            userChoice1 = int.Parse(Console.ReadLine());

            if (userChoice1 == 1)
            {
                while (true)
                {
                    Console.WriteLine("Inventory Management System Menu:");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                    userChoice2 = int.Parse(Console.ReadLine());

                    switch (userChoice2)
                    {
                        case 1:
                            if (count < productNames.Length)
                            {
                                Console.WriteLine("Enter product name: ");
                                productNames[count] = Console.ReadLine();
                                Console.WriteLine("Enter product quantity: ");
                                productQuantities[count] = int.Parse(Console.ReadLine());
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Inventory is full!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the product name: ");
                            int index = Array.IndexOf(productNames, Console.ReadLine());
                            if (index != -1)
                            {
                                Console.WriteLine("Enter new product quantity: ");
                                productQuantities[index] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Prodcut quantity changed successfully");
                            }
                            else
                            {
                                Console.WriteLine("Product not found");
                            }
                            break;
                        case 3:
                            double quantitySum = 0;
                            Console.WriteLine("Inventory summary:");
                            for (int i = 0; i < count; i++)
                            {
                                    Console.WriteLine($"-{productNames[i]}: {productQuantities[i]} ");
                                    quantitySum += productQuantities[i];
                            }
                            Console.WriteLine($"Total Products: {count}");
                            Console.WriteLine($"Total Quantity: {quantitySum}");
                            double averageQuantities = quantitySum / count;
                            Console.WriteLine($"Average Quantity: {averageQuantities}");
                            break;
                        case 4:
                            return;
                    }
                }
            }
        }
    }
}
