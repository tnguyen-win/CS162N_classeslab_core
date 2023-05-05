namespace CustomerProductClasses {
	public class Product {
		private int id;
		private string code;
		private string description;
		private decimal unitPrice;
		private int quantity;

		public Product() { }

		public Product(int productId, string productCode, string desc, decimal price, int qty) {
			id = productId;
			code = productCode;
			description = desc;
			unitPrice = price;
			quantity = qty;
		}

		public int Id {
			get => id;
			set => id = value;
		}

		public string Code {
			get => code;
			set => code = value;
		}

		public string Description {
			get => description;
			set => description = value;
		}

		public decimal UnitPrice {
			get => unitPrice;
			set => unitPrice = value;
		}

		public int QuantityOnHand {
			get => quantity;
			set => quantity = value;
		}

		public override string ToString() {
			return $"Id: [{id}] Code: [{code}] Description: [{description}] UnitPrice: [{unitPrice:C}] Quantity: [{quantity}]";
		}
	}
}