using System;
using System.Collections.Generic;
using ThreeLayerLib.Persistence;
using ThreeLayerLib.BL;

namespace ThreeLayerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short mainChoose = 0, imChoose;
            string[] mainMenu = { "Item Management", "Add Customer (using stored procedure)", "Create Order (using Transaction)", "Exit" };
            string[] imMenu = { "Get By Item Id", "Get All Items", "Search By Item Name", "Exit" };
            ItemBL ibl = new ItemBL();
            CustomerBL cbl = new CustomerBL();
            OrderBL obl = new OrderBL();
            List<Item> lst;
            do
            {
                mainChoose = Menu(" Order Management System - OMS", mainMenu);
                switch (mainChoose)
                {
                    case 1:
                        do
                        {
                            // if (ibl == null) ibl = new ItemBL();
                            imChoose = Menu("Item Management", imMenu);
                            switch (imChoose)
                            {
                                case 1:
                                    Console.Write("\nInput Item Id: ");
                                    int itemId;
                                    if (Int32.TryParse(Console.ReadLine(), out itemId))
                                    {
                                        Item i = ibl.GetItemById(itemId);
                                        if (i != null)
                                        {
                                            //Console.WriteLine("Item ID: " + i.ItemId);
                                            Console.WriteLine("Item Name: " + i.ItemName);
                                            Console.WriteLine("Item Price: " + i.ItemPrice);
                                            Console.WriteLine("Amount: " + i.Amount);
                                            Console.WriteLine("Item Status: " + i.Status);
                                            Console.WriteLine("Item Description: " + i.Description);
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no item with id " + itemId);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Choose is wrong!");
                                    }
                                    Console.WriteLine("\n    Press Enter key to back menu...");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    lst = ibl.GetAll();
                                    if (lst.Count > 0)
                                    {
                                        ShowItems("All items:", lst);
                                    }
                                    break;
                                case 3:
                                    Console.Write("Input item name to search: ");
                                    string n = Console.ReadLine() ?? "";
                                    lst = ibl.GetByName(n);
                                    Console.WriteLine("\n" + lst.Count);
                                    if (lst.Count > 0)
                                    {
                                        ShowItems($"Item Count By Name: {n}", lst);
                                    }
                                    break;
                            }
                        } while (imChoose != imMenu.Length);
                        break;
                    case 2:
                        Console.WriteLine("-> New Customer");
                        Console.Write("Customer Name: ");
                        string name = Console.ReadLine() ?? "no name";
                        Console.Write("Customer Address: ");
                        string address = Console.ReadLine() ?? "";
                        Customer c = new Customer { CustomerName = name, CustomerAddress = address };
                        c.CustmerId = cbl.AddCustomer(c);
                        if (c.CustmerId > 0)
                        {
                            Console.WriteLine($"Add customer completed with customer id {c.CustmerId}");
                        }
                        break;
                    case 3:
                        Order order = new Order();
                        //new customer
                        //order.OrderCustomer = new Customer { CustmerId = null, CustomerName = "Nguyen Xuan Sinh", CustomerAddress = "Hanoi" };

                        //exists customer
                        order.OrderCustomer = new Customer { CustmerId = 1, CustomerName = "Nguyen Xuan Sinh", CustomerAddress = "Hanoi" };

                        order.ItemsList.Add(ibl.GetItemById(2));
                        order.ItemsList[0].Amount = 1;
                        order.ItemsList.Add(ibl.GetItemById(3));
                        order.ItemsList[1].Amount = 2;
                        Console.WriteLine("Create Order: " + (obl.CreateOrder(order) ? "completed!" : "not complete!"));
                        break;
                }
            } while (mainChoose != mainMenu.Length);
        }

        private static void ShowItems(string title, List<Item> lst)
        {
            Console.WriteLine(title);
            Console.WriteLine(@"+---------+-----------+------------+--------+-------------+------------------+
| item_id | item_name | unit_price | amount | item_status | item_description |
+---------+-----------+------------+--------+-------------+------------------+");
            foreach (Item item in lst)
            {
                Console.WriteLine("| {0, 7:N0} | {1, 9} | {2, 10:N2} | {3, 6:N0} | {4, 11:N0} | {5, 16} |", item.ItemId, item.ItemName, item.ItemPrice, item.Amount, item.Status, item.Description);
            }
            Console.WriteLine(@"+---------+-----------+------------+--------+-------------+------------------+");
        }

        private static short Menu(string title, string[] menuItems)
        {
            string logo = @"==============================================
╔╦╗┬ ┬┬─┐┌─┐┌─┐  ╦  ┌─┐┬ ┬┌─┐┬─┐  ╔╦╗┌─┐┌┬┐┌─┐
 ║ ├─┤├┬┘├┤ ├┤   ║  ├─┤└┬┘├┤ ├┬┘   ║║├┤ ││││ │
 ╩ ┴ ┴┴└─└─┘└─┘  ╩═╝┴ ┴ ┴ └─┘┴└─  ═╩╝└─┘┴ ┴└─┘";
            short choose = 0;
            Console.WriteLine(logo);
            string line = "==============================================";
            Console.WriteLine(line);
            Console.WriteLine(" " + title);
            Console.WriteLine(line);
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(" " + (i + 1) + ". " + menuItems[i]);
            }
            Console.WriteLine(line);
            do
            {
                Console.Write("Your choice: ");
                try
                {
                    choose = Int16.Parse(Console.ReadLine() ?? "0");
                }
                catch
                {
                    Console.WriteLine("Your Choose is wrong!");
                    continue;
                }
            } while (choose <= 0 || choose > menuItems.Length);
            return choose;
        }
    }
}