using Examination_Database.Entities;
using Examination_Database.Repositories;

namespace Examination_Database.Services;

//internal interface IMenuService
//{
//    public void MainMenu();
//    public void CreateMenu();
//    public void ListAllMenu();
//    public CustomerEntity ListSpecificMenu();
//    public void UpdateMenu();
//    public void DeleteMenu();
//}

internal class MenuService

{
    CustomerService _customerService;
    CustomerRepository _customerRepo;


    public void MainMenu()
    {
        var exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Handle customers");
            Console.WriteLine("2. Handle orders");
            Console.WriteLine("3. Handle payments");
            Console.WriteLine("4. Handle products");
            Console.WriteLine("5. Handle stock");
            Console.WriteLine("6. Handle categories");
            Console.WriteLine("7. Handle subcategories");
            Console.WriteLine("8. Handle suppliers");
            Console.WriteLine("0. Close program");
            Console.Write("Choose one of the above alternatives (0-5): ");
            var option = Console.ReadLine();


            switch (option)
            {
                case "1":
                    CustomerMenu();
                    break;

                case "2":
                    OrderMenu();
                    break;

                case "3":
                    PaymentsMenu();
                    break;

                case "4":
                    ProductMenu();
                    break;

                case "5":
                    StockMenu();
                    break;

                case "6":
                    CategoryMenu();
                    break;

                case "7":
                    SubCategoryMenu();
                    break;

                case "8":
                    SupplierMenu();
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    break;
            }

        } while (exit == false);

    
    }


    public void CustomerMenu()
    {
        

        var exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Create new customer");
            Console.WriteLine("2. Show all customers");
            Console.WriteLine("3. Show details for specific customer");
            Console.WriteLine("4. Update a customer");
            Console.WriteLine("5. Delete a customer");
            Console.WriteLine("0. Close program");
            Console.Write("Choose one of the above alternatives (0-5): ");
            var option = Console.ReadLine();
            

            switch (option)
            {
                case "1":
                    CreateMenu();
                    break;

                case "2":
                    ListAllMenu();
                    break;

                case "3":
                    ListSpecificMenu();
                    break;
                
                case "4":
                    UpdateMenu();
                    break;

                case "5":
                    DeleteMenu();
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    break;
            }

        } while (exit == false);

    }

    public void CreateMenu()
    {
        Console.Clear(); //Clears field from main menu
        Console.WriteLine("Add a new customer");
        Console.WriteLine("-----------------------");

        var customer = new CustomerEntity(); //Instance of new customer

        Console.Write("Email: ");
        string email = Console.ReadLine()!.Trim().ToLower();
        var result = _customerRepo.ExistsAsync(x => x.Email == email);

        if (result)
        {
            Console.WriteLine($"A customer with the email adress \"{email}\" already exists.");
            break;
        }

        else
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine()!.Trim().ToLower();
            if (firstName.Length > 0)
                customer.FirstName = char.ToUpper(firstName[0]) + firstName.Substring(1); //Makes first letter big if the name is longes than one letter

            Console.Write("Last name: ");
            string lastName = Console.ReadLine()!.Trim().ToLower();
            if (lastName.Length > 0)
                customer.LastName = char.ToUpper(lastName[0]) + lastName.Substring(1);


            Console.Write("Phone number: ");
            customer.Phonenumber = Console.ReadLine()!.Trim();


            customer.Adress = new AdressEntity();

            Console.Clear();
            Console.WriteLine("Adress");
            Console.WriteLine("-------------");
            Console.Write("Street: ");
            customer.Adress.StreetName = Console.ReadLine()!;
            Console.Write("Street number: ");
            customer.Adress.StreetNumber = Console.ReadLine();
            Console.Write("City: ");
            customer.Adress.City = Console.ReadLine()!;
            Console.Write("Postal code: ");
            customer.Adress.PostalCode = int.Parse(Console.ReadLine()!);

            _customerService.CreateCustomer(customer);

            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("New customer has been added.");
            Console.ReadKey();
        }

       

    }

    public void OrderMenu()
    {
        throw new NotImplementedException();
    }

    public void PaymentsMenu()
    {
        throw new NotImplementedException();
    }

    public CustomerEntity ProductMenu()
    {
        throw new NotImplementedException();
    }

   

    public void StockMenu()
    {
        throw new NotImplementedException();
    }

    public void CategoryMenu()
    {
        throw new NotImplementedException();
    }

    public void SubCategoryMenu()
    {
        throw new NotImplementedException();
    }

    public void SupplierMenu()
    {
        throw new NotImplementedException();
    }
}




