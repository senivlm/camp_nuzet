using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    internal class Storage
    {
        private Product[] arrayOfProducts;
        public List<Product> arrayOfProductsList = new List<Product>();
        Registration registration = new Registration();

        public Product this[int index]
        {
            get => arrayOfProducts[index];
            set => arrayOfProducts[index] = value;
        }

        public Storage(params Product[] arr)
        {
            arrayOfProducts = new Product[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrayOfProducts[i] = arr[i];
            }
        }

        public Storage() { }

        
        private void Add(params Product[] arr)
        {
            arrayOfProducts = new Product[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrayOfProducts[i] = arr[i];
            }
        }
        public void InputProducts()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("Enter number of products: ");
            Console.ResetColor();
            int numberOfProducts = int.Parse(Console.ReadLine());
            arrayOfProducts = new Product[numberOfProducts];
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Input data about product №{i + 1}");

                int choice;
                do
                {
                    Console.WriteLine("Is it a meat product (enter '0') or not (enter '1')?");
                    choice = int.Parse(Console.ReadLine());
                } while (choice != 0 && choice != 1);
                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter weight: ");
                double weight = double.Parse(Console.ReadLine());
                if (choice == 0)
                {

                    Console.Write("Enter category of meeat: ");
                    string categoryOfMeat = Console.ReadLine();
                    CategoryOfMeat cOfMeat;
                    if (Enum.TryParse(typeof(CategoryOfMeat), categoryOfMeat, out object obj))
                    {
                        cOfMeat = (CategoryOfMeat)obj;
                    }
                    else
                    {
                        throw new Exception();
                    }

                    Console.Write("Enter type of meeat: ");
                    string typeOfMeat = Console.ReadLine();
                    SpeciesOfMeat tOfMeat;
                    if (Enum.TryParse(typeof(SpeciesOfMeat), typeOfMeat, out object obj1))
                    {
                        tOfMeat = (SpeciesOfMeat)obj1;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    arrayOfProducts[i] = new Meat(productName, price, weight, cOfMeat, tOfMeat);
                }
                else
                {
                    arrayOfProducts[i] = new Product(productName, price, weight);
                }

            }
        }

        public void AutoInitialization()
        {
            arrayOfProducts = new Product[6];
            arrayOfProducts[0] = new Product("pineapple", 10, 1);
            arrayOfProducts[1] = new Meat("beef", 300, 2, CategoryOfMeat.HightSort1, SpeciesOfMeat.mutton);
            arrayOfProducts[2] = new Product("carrot", 10, 5);
            arrayOfProducts[3] = new Product("orange juice", 15, 0.5);
            arrayOfProducts[4] = new Meat("meat", 100, 1, CategoryOfMeat.Sort2, SpeciesOfMeat.chicken);
            arrayOfProducts[5] = new DairyProduct("milk",12, 0.9 , DateTime.Now);
        }

        public void PrintAllInfoAboutProducts()
        {
            foreach (var item in arrayOfProducts)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintAllMeatProducts()
        {
            foreach (var item in arrayOfProducts)
            {
                if (item.GetType() == typeof(Meat))
                {
                    Console.WriteLine(item._name);
                }
            }
        }

        public void ChangePrice(int percent)
        {
            for (int i = 0; i < arrayOfProducts.Length; i++)
            {
                arrayOfProducts[i].ChangePrice(percent);
            }
        }

        private string ReadFilePath()
        {
            ReaderFile reader = new ReaderFile();

            string result = "";
            int value = 0;
            do
            {
                Console.WriteLine("enter name(path) of file: ");
                reader.Path = Console.ReadLine();
                result = reader.ReadFromFile();
                value++;
            }
            while (value < 4 && result == "File is not found...");
            {
                return result;
            }

        }
        private void ParseFromFile(List<string> list)
        {
            string name = list[0];
            if (char.IsLower(name[0]))
            {
                name = char.ToUpper(name[0]) + name.Substring(1);
            }


           
            try
            {
                if (name != null /*&& double.TryParse(list[1], out double price) && double.TryParse(list[2], out double weight)*/)
                {
                    double price = Convert.ToDouble(list[1]);
                    double weight = Convert.ToDouble(list[2]);
                    Product product;
                    if (DateTime.TryParse(list[3], out DateTime d))
                    {
                        product = new DairyProduct(name, price, weight, d);
                        
                    }
                    else if (Enum.TryParse(typeof(SpeciesOfMeat), list[5], out object obj1) && Enum.TryParse(typeof(CategoryOfMeat), list[4], out object obj2))
                    {
                        product = new Meat(name, price, weight, (CategoryOfMeat)obj2, (SpeciesOfMeat)obj1);
                        
                    }
                    else 
                    {
                        product = new Product(name, price, weight);
                        

                    }

                    arrayOfProductsList.Add(product);

            }



            }
            catch (Exception ex)
            {
                //if (ex.Message != null)
                    registration.AddToJournal(ex.Message);
            }
        
            
        }
        public void Show()
        {
            foreach (Product product in arrayOfProductsList)
            {
                Console.WriteLine(product);
            }
        }
        public void InputFromFile()
        {
            string fileName = ReadFilePath();

            var firstSplit = fileName.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> split;
            for (int i = 0; i < firstSplit.Length; i++)
            {
                split = new List<string>();
                var secondSplit = firstSplit[i].Split(',',StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 5; j++)
                {
                    if(j<secondSplit.Length)
                    {
                        split.Add(secondSplit[j].Trim());
                    }
                    
                }
                ParseFromFile(split);
            }
        }
        
        public void ShowRegistration()
        {
            Console.WriteLine(registration); 
        }



    
    
}
}
