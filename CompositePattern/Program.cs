using CompositePattern.Data;
using CompositePattern.ToDo;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main()
        {
            CompositeItem items = new("DevelopSite","All the work for developing my website");

            CompositeItem devClientSide = new("DevelopClient", "All the work for developing the front end");
            CompositeItem devServerSide = new("DevelopServer", "All the work for developing the back end");

            items.Add(devClientSide);
            items.Add(devServerSide);

            devClientSide.Add(SampleItems.DesignGui);
            devClientSide.Add(SampleItems.ProgramGui);
            devClientSide.Add(SampleItems.CallNewYork);
            devClientSide.Add(SampleItems.BuyCoffee);

            CompositeItem initialDevServerSide = new("DevelopServerFirstTry", "All the work for developing the back end");
            CompositeItem retryDevServerSide = new("DevelopServerSecondTry", "All the work for developing the back end again");

            devServerSide.Add(initialDevServerSide);
            devServerSide.Add(retryDevServerSide);

            initialDevServerSide.Add(SampleItems.DesignApi);
            initialDevServerSide.Add(SampleItems.ProgramApi);
            initialDevServerSide.Add(SampleItems.BuyBook);

            retryDevServerSide.Add(SampleItems.ReProgramApi);
            retryDevServerSide.Add(SampleItems.CallNewYorkAgain);
            retryDevServerSide.Add(SampleItems.BuyNewServer);

            items.Add(new PurchaseItem("Champagne", "A bottle of bubbly to celebrate", 35));

            Console.WriteLine(items.ToString());

            Console.WriteLine();

            Console.WriteLine($"Total cost is {items.Cost:C}.");
            Console.WriteLine($"Total duration is {items.Hours} hours.");

            Console.WriteLine();

            ToDoItem   found = items.Find("BuyNewServer");

            Console.WriteLine(found?.ToString() ?? "Not found");
        }
    }
}
