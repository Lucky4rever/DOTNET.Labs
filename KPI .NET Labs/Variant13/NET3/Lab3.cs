﻿using DOTNET_Labs.Variant13.NET3.Materials;
using System;

namespace DOTNET_Labs.Variant13.NET3
{
    class Lab3
    {
        private static Lab3 _instance;

        private Lab3() { }

        public static Lab3 GetInstance()
        {
            return _instance ?? (_instance = new Lab3());
        }

        public void Var13_Lab3()
        {
            Console.WriteLine("Variant 13\nLab 3\n");

            MaterialFabric fabric = new MaterialFabric();

            Material brick1 = fabric.CreateBrick(BrickType.Ceramic, 100);
            Material brick2 = fabric.CreateBrick(BrickType.Clinker, 100);
            Material brick3 = fabric.CreateBrick(BrickType.Silicate, 100);
            Material concrete = fabric.CreateConcrete(1);
            Material slabs = fabric.CreateReinforcedConcreteSlabs(10, 10, 3);


            Supplier supplier1 = new Supplier("Grand Supplier");

            supplier1.AddItemToList(new SupplierListItem(brick1, 45, 100));
            supplier1.AddItemToList(new SupplierListItem(brick2, 40, 140));
            supplier1.AddItemToList(new SupplierListItem(brick3, 80, 90));


            Supplier supplier2 = new Supplier("Буд-матеріали");

            supplier2.AddItemToList(new SupplierListItem(brick2, 30, 110));
            supplier2.AddItemToList(new SupplierListItem(concrete, 1, 5));
            supplier2.AddItemToList(new SupplierListItem(slabs, 10, 500));


            SuppliersList suppliersList = new SuppliersList();

            suppliersList.AddSupplier(supplier1);
            suppliersList.AddSupplier(supplier2);

            var bestItems = suppliersList.FindBestItems(brick2, 200);

            Console.WriteLine(bestItems.Item1);

            foreach (SupplierListItem item in bestItems.Item2)
            {
                Console.WriteLine(item);

                Supplier bestSupplier = suppliersList.FindSupplier(item.Material, item.MaxCount, item.PriceForSet);

                Console.WriteLine(bestSupplier);
            }

            Console.WriteLine();
        }
    }
}
