using DOTNET_Lab3_V13.Services;
using DOTNET_Lab3_V13.Source;
using DOTNET_Lab3_V13.Source.Interfaces;
using DOTNET_Lab3_V13.Source.Resources;
using System;
using System.Collections.Generic;

namespace DOTNET_Lab3_V13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Variant 13\nLab 3\n");

            Var13_Lab3();

            Console.ReadKey();
        }

        static void Var13_Lab3()
        {
            IMaterialFabric fabric = new MaterialFabric();

            IMaterial brick1 = fabric.CreateBrick(BrickType.Ceramic, 100);
            IMaterial brick2 = fabric.CreateBrick(BrickType.Clinker, 100);
            IMaterial brick3 = fabric.CreateBrick(BrickType.Silicate, 100);
            IMaterial concrete = fabric.CreateConcrete(1);
            IMaterial slabs = fabric.CreateReinforcedConcreteSlabs(10, 10, 3);


            ISupplier supplier1 = new Supplier("Grand Supplier");

            supplier1.AddItemToList(new SupplierListItem(brick1, 45, 100));
            supplier1.AddItemToList(new SupplierListItem(brick2, 40, 140));
            supplier1.AddItemToList(new SupplierListItem(brick3, 80, 90));


            ISupplier supplier2 = new Supplier("Буд-матеріали");

            supplier2.AddItemToList(new SupplierListItem(brick2, 30, 110));
            supplier2.AddItemToList(new SupplierListItem(concrete, 1, 5));
            supplier2.AddItemToList(new SupplierListItem(slabs, 10, 500));

            List<ISupplier> suppliers = new List<ISupplier>() { supplier1, supplier2 };

            //================================================================

            SuppliersListService suppliersListService = new SuppliersListService();

            //List<ISupplierListItem> bestItems = suppliersListService.FindBestItems(suppliers, brick2, 30);
            //List<ISupplierListItem> bestItems = suppliersListService.FindBestItems(suppliers, brick2, 70);
            List<ISupplierListItem> bestItems = suppliersListService.FindBestItems(suppliers, brick2, 71);

            foreach (SupplierListItem item in bestItems)
            {
                Console.WriteLine(item);

                ISupplier bestSupplier = suppliersListService.FindSupplier(suppliers, item);

                Console.WriteLine(bestSupplier);
            }

            Console.WriteLine();
        }
    }
}
