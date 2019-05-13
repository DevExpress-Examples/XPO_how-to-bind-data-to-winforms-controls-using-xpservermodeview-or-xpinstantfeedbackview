Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Namespace XpoTutorial
	Public Module DemoDataHelper
		Private firstNames() As String = { "Peter", "Ryan", "Richard", "Tom", "Mark", "Steve", "Jimmy", "Jeffrey", "Andrew", "Dave", "Bert", "Mike", "Ray", "Paul", "Brad", "Carl", "Jerry" }
		Private lastNames() As String = { "Dolan", "Fischer", "Hamlett", "Hamilton", "Lee", "Lewis", "McClain", "Miller", "Murrel", "Parkins", "Roller", "Shipman", "Bailey", "Barnes", "Lucas", "Campbell" }
		Private productNames() As String = { "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread", "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce", "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora", "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton", "Carnarvon Tigers", "Teatime Chocolate Biscuits", "Sir Rodney's Marmalade", "Sir Rodney's Scones", "Gustaf's Knäckebröd", "Tunnbröd", "Guaraná Fantástica", "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen", "Schoggi Schokolade", "Rössle Sauerkraut", "Thüringer Rostbratwurst", "Nord-Ost Matjeshering", "Gorgonzola Telino", "Mascarpone Fabioli", "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill", "Gravad lax", "Côte de Blaye", "Chartreuse verte", "Boston Crab Meat", "Jack's New England Clam Chowder", "Singaporean Hokkien Fried Mee", "Ipoh Coffee", "Gula Malacca", "Rogede sild", "Spegesild", "Zaanse koeken", "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples", "Filo Mix", "Perth Pasties", "Tourtière", "Pâté chinois", "Gnocchi di nonna Alice", "Ravioli Angelo", "Escargots de Bourgogne", "Raclette Courdavault", "Camembert Pierrot", "Sirop d'érable", "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel", "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra", "Laughing Lumberjack Lager", "Scottish Longbreads", "Gudbrandsdalsost", "Outback Lager", "Flotemysost", "Mozzarella di Giovanni", "Röd Kaviar", "Longlife Tofu", "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße" }
		Private Random As New Random(0)

		Public Function IsSeedRequired(ByVal uow As UnitOfWork) As Boolean
			Return uow.Query(Of Order)().Count() = 0
		End Function

		Public Async Function SeedAsync(ByVal uow As UnitOfWork, ByVal progressHandler As IProgress(Of Integer)) As Task
			Dim customers As New List(Of Customer)()
			For i As Integer = 0 To firstNames.Length - 1
				For j As Integer = 0 To lastNames.Length - 1
					customers.Add(New Customer(uow) With {
						.FirstName = firstNames(i),
						.LastName = lastNames(j)
					})
				Next j
			Next i
			Const batchSize As Integer = 100
            Const recordsCount As Integer = 100000
            For i As Integer = 0 To recordsCount - 1 Step batchSize
				For j As Integer = 0 To batchSize - 1
					Dim order As New Order(uow)
					order.ProductName = productNames(Random.Next(productNames.Length))
					order.OrderDate = New Date(Random.Next(2014, 2024), Random.Next(1, 12), Random.Next(1, 28))
					order.Price = 1 + Random.Next(10000) / 100D
					order.Quantity = 1 + Random.Next(100)
					order.Customer = customers(Random.Next(customers.Count))
				Next j
				Await uow.CommitChangesAsync()
				If progressHandler IsNot Nothing Then
					progressHandler.Report(i * 100 \ recordsCount)
				End If
			Next i
		End Function
	End Module
End Namespace