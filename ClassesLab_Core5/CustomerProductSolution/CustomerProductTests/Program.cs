using System;
using CustomerProductClasses;

namespace CustomerProductTests {
	class Program {
		static void Main() {
			TestProductConstructors();
			TestCustomerConstructors();
			TestProductPropertyGetters();
			TestCustomerPropertyGetters();
			TestProductPropertySetters();
			TestCustomerPropertySetters();
			TestProductToString();
			TestCustomerToString();
		}

		static void TestProductConstructors() {
			Product p1 = new Product();
			Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

			Console.WriteLine("[Product - testing both constructors]");

			Console.WriteLine("Default constructor -");
			Console.WriteLine("Expecting: default values");
			Console.WriteLine($"Got: {p1}");

			Console.WriteLine("Overloaded constructor -");
			Console.WriteLine("Expecting: [1], [T100], [This is a test product], [$100.00], [10]");
			Console.WriteLine($"Got: {p2}\n");
		}

		static void TestCustomerConstructors() {
			Customer c1 = new Customer();
			Customer c2 = new Customer("double07@gmail.com", "James", 7, "Bond", "44-911-007");

			Console.WriteLine("[Customer - testing both constructors]");

			Console.WriteLine("Default constructor -");
			Console.WriteLine("Expecting: default values");
			Console.WriteLine($"Got: {c1}");

			Console.WriteLine("Overloaded constructor -");
			Console.WriteLine("Expecting: [double07@gmail.com], [James], [7], [Bond], [44-911-007]");
			Console.WriteLine($"Got: {c2}\n");
		}

		static void TestProductPropertyGetters() {
			Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

			Console.WriteLine("[Product - testing getters]");

			Console.WriteLine("Id -");
			Console.WriteLine("Expecting: [1]");
			Console.WriteLine($"Got: [{p1.Id}]");

			Console.WriteLine("Code -");
			Console.WriteLine("Expecting: [T100]");
			Console.WriteLine($"Got: [{p1.Code}]");

			Console.WriteLine("Description -");
			Console.WriteLine("Expecting: [This is a test product]");
			Console.WriteLine($"Got: [{p1.Description}]");

			Console.WriteLine("Price -");
			Console.WriteLine("Expecting: [100]");
			Console.WriteLine($"Got: [{p1.UnitPrice}]");

			Console.WriteLine("Quantity -");
			Console.WriteLine("Expecting: [10]");
			Console.WriteLine($"Got: [{p1.QuantityOnHand}]\n");
		}

		static void TestCustomerPropertyGetters() {
			Customer c1 = new Customer("double07@gmail.com", "James", 7, "Bond", "44-911-007");

			Console.WriteLine("[Customer - testing getters]");

			Console.WriteLine("Email -");
			Console.WriteLine("Expecting: [double07@gmail.com]");
			Console.WriteLine($"Got: [{c1.Email}]");

			Console.WriteLine("FirstName -");
			Console.WriteLine("Expecting: [James]");
			Console.WriteLine($"Got: [{c1.FirstName}]");

			Console.WriteLine("Id -");
			Console.WriteLine("Expecting: [7]");
			Console.WriteLine($"Got: [{c1.Id}]");

			Console.WriteLine("LastName -");
			Console.WriteLine("Expecting: [Bond]");
			Console.WriteLine($"Got: [{c1.LastName}]");

			Console.WriteLine("Phone -");
			Console.WriteLine("Expecting: [44-911-007]");
			Console.WriteLine($"Got: [{c1.Phone}]\n");
		}

		static void TestProductPropertySetters() {
			Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

			Console.WriteLine("[Product - testing setters]");

			p1.Id = 2;
			p1.Code = "T000";
			p1.Description = "First product";
			p1.UnitPrice = 200;
			p1.QuantityOnHand = 20;

			Console.WriteLine("Expecting: [2], [T000], [First product], [$200.00], [20]");
			Console.WriteLine($"Got: {p1}\n");
		}

		static void TestCustomerPropertySetters() {
			Customer c1 = new Customer("double07@gmail.com", "James", 7, "Bond", "44-911-007");

			Console.WriteLine("[Customer - testing setters]");

			c1.Email = "someperson@hotmail.com";
			c1.FirstName = "John";
			c1.Id = 100;
			c1.LastName = "Smith";
			c1.Phone = "541-463-3000";

			Console.WriteLine("Expecting: [someperson@hotmail.com], [John], [100], [Smith], [541-463-3000]");
			Console.WriteLine($"Got: {c1}\n");
		}

		static void TestProductToString() {
			Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

			Console.WriteLine("[Product - testing ToString]");

			Console.WriteLine("Expecting: [1], [T100], [This is a test product], [$100.00], [10]");
			Console.WriteLine($"Got: {p1}\n");
		}

		static void TestCustomerToString() {
			Customer c1 = new Customer("double07@gmail.com", "James", 7, "Bond", "44-911-007");

			Console.WriteLine("[Customer - testing ToString]");

			Console.WriteLine("Expecting: [double07@gmail.com], [James], [7], [Bond], [44-911-007]");
			Console.WriteLine($"Got: {c1}\n");
		}
	}
}