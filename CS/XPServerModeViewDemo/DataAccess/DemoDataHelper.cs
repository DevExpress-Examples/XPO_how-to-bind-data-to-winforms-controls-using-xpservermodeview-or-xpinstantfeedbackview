﻿using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XpoTutorial {
    public static class DemoDataHelper {
        private static string[] firstNames = new string[] {
            "Peter", "Ryan", "Richard", "Tom", "Mark", "Steve",
            "Jimmy", "Jeffrey", "Andrew", "Dave", "Bert", "Mike",
            "Ray", "Paul", "Brad", "Carl", "Jerry" };
        private static string[] lastNames = new string[] {
            "Dolan", "Fischer", "Hamlett", "Hamilton", "Lee",
            "Lewis", "McClain", "Miller", "Murrel", "Parkins",
            "Roller", "Shipman", "Bailey", "Barnes", "Lucas", "Campbell" };
        private static string[] productNames = new string[] {
            "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning",
            "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread",
            "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce",
            "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora",
            "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton",
            "Carnarvon Tigers", "Teatime Chocolate Biscuits",
            "Sir Rodney's Marmalade", "Sir Rodney's Scones",
            "Gustaf's Knäckebröd", "Tunnbröd", "Guaraná Fantástica",
            "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen",
            "Schoggi Schokolade", "Rössle Sauerkraut", "Thüringer Rostbratwurst",
            "Nord-Ost Matjeshering", "Gorgonzola Telino", "Mascarpone Fabioli",
            "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill",
            "Gravad lax", "Côte de Blaye", "Chartreuse verte",
            "Boston Crab Meat", "Jack's New England Clam Chowder",
            "Singaporean Hokkien Fried Mee", "Ipoh Coffee",
            "Gula Malacca", "Rogede sild", "Spegesild", "Zaanse koeken",
            "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples",
            "Filo Mix", "Perth Pasties", "Tourtière", "Pâté chinois",
            "Gnocchi di nonna Alice", "Ravioli Angelo", "Escargots de Bourgogne",
            "Raclette Courdavault", "Camembert Pierrot", "Sirop d'érable",
            "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel",
            "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra",
            "Laughing Lumberjack Lager", "Scottish Longbreads",
            "Gudbrandsdalsost", "Outback Lager", "Flotemysost",
            "Mozzarella di Giovanni", "Röd Kaviar", "Longlife Tofu",
            "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße" };
        private static Random Random = new Random(0);

        public static bool IsSeedRequired(UnitOfWork uow) {
            return uow.Query<Order>().Count() == 0;
        }

        public static async Task SeedAsync(UnitOfWork uow, IProgress<int> progressHandler) {
            List<Customer> customers = new List<Customer>();
            for(int i = 0; i < firstNames.Length; i++) {
                for(int j = 0; j < lastNames.Length; j++) {
                    customers.Add(new Customer(uow) {
                        FirstName = firstNames[i],
                        LastName = lastNames[j]
                    });
                }
            }
            const int batchSize = 100;
            const int recordsCount = 100000;
            for(int i = 0; i < recordsCount; i += batchSize) {
                for(int j = 0; j < batchSize; j++) {
                    Order order = new Order(uow);
                    order.ProductName = productNames[Random.Next(productNames.Length)];
                    order.OrderDate = new DateTime(Random.Next(2014, 2024), Random.Next(1, 12), Random.Next(1, 28));
                    order.Price = 1 + Random.Next(10000) / 100m;
                    order.Quantity = 1 + Random.Next(100);
                    order.Customer = customers[Random.Next(customers.Count)];
                }
                await uow.CommitChangesAsync();
                if(progressHandler != null) {
                    progressHandler.Report(i * 100 / recordsCount);
                }
            }
        }
    }
}