using System;
using System.Collections.Generic;

class User
{
    public string Username;
    public string Email;
    public string Password;
    public List<Car> Cars = new List<Car>();

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }
}

class Car
{
    public string Make;
    public string Model;
    public int Year;
    public bool Removed = false;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return Removed ? $"{Year} {Make} {Model} [Maha kantud]" : $"{Year} {Make} {Model}";
    }
}

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        // Algne kasutaja
        users.Add(new User("opilane", "opilane@gmail.com", "Opilane12"));

        while (true)
        {
            Console.WriteLine("\n--- AUTOREGISTRI PROGRAMM ---");
            Console.WriteLine("1. Registreeru");
            Console.WriteLine("2. Logi sisse");
            Console.WriteLine("3. Välju");
            Console.Write("Vali: ");
            string choice = Console.ReadLine();

            if (choice == "1") RegisterUser();
            else if (choice == "2") LoginUser();
            else break;
        }
    }

    static void RegisterUser()
    {
        Console.Write("Kasutajanimi: ");
        string username = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        if (!email.Contains("@"))
        {
            Console.WriteLine("Email peab sisaldama '@'.");
            return;
        }
        Console.Write("Parool: ");
        string password = Console.ReadLine();

        if (users.Exists(u => u.Username == username))
        {
            Console.WriteLine("Kasutajanimi juba olemas.");
            return;
        }

        users.Add(new User(username, email, password));
        Console.WriteLine("Kasutaja registreeritud!");
    }

    static void LoginUser()
    {
        Console.Write("Kasutajanimi: ");
        string username = Console.ReadLine();
        Console.Write("Parool: ");
        string password = Console.ReadLine();

        User user = users.Find(u => u.Username == username && u.Password == password);
        if (user == null)
        {
            Console.WriteLine("Vale kasutajanimi või parool.");
            return;
        }

        Console.WriteLine($"Tere tulemast, {username}!");
        UserMenu(user);
    }

    static void UserMenu(User user)
    {
        while (true)
        {
            Console.WriteLine("\n1. Vaata autosid");
            Console.WriteLine("2. Lisa auto");
            Console.WriteLine("3. Maha kanna auto");
            Console.WriteLine("4. Logi välja");
            Console.Write("Vali: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (user.Cars.Count == 0) Console.WriteLine("Sul ei ole autosid.");
                else
                {
                    for (int i = 0; i < user.Cars.Count; i++)
                        Console.WriteLine($"{i + 1}. {user.Cars[i]}");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Auto mark: "); string make = Console.ReadLine();
                Console.Write("Auto mudel: "); string model = Console.ReadLine();
                Console.Write("Auto aasta: "); int.TryParse(Console.ReadLine(), out int year);
                user.Cars.Add(new Car(make, model, year));
                Console.WriteLine("Auto lisatud!");
            }
            else if (choice == "3")
            {
                if (user.Cars.Count == 0)
                {
                    Console.WriteLine("Sul ei ole autosid.");
                    continue;
                }

                for (int i = 0; i < user.Cars.Count; i++)
                    Console.WriteLine($"{i + 1}. {user.Cars[i]}");

                Console.Write("Vali auto number: ");
                if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= user.Cars.Count)
                {
                    user.Cars[idx - 1].Removed = true;
                    Console.WriteLine("Auto maha kantud!");
                }
                else Console.WriteLine("Vale number.");
            }
            else if (choice == "4") break;
            else Console.WriteLine("Vale valik.");
        }
    }
}