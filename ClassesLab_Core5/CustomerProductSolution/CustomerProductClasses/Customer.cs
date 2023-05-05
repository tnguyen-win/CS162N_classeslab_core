namespace CustomerProductClasses {
	public class Customer {
		private string email;
		private string firstName;
		private int id;
		private string lastName;
		private string phone;

		public Customer() { }

		public Customer(string customerEmail, string customFirstName, int ID, string customerLastName, string customerPhone) {
			email = customerEmail;
			firstName = customFirstName;
			id = ID;
			lastName = customerLastName;
			phone = customerPhone;
		}

		public string Email {
			get => email;
			set => email = value;
		}

		public string FirstName {
			get => firstName;
			set => firstName = value;
		}

		public int Id {
			get => id;
			set => id = value;
		}

		public string LastName {
			get => lastName;
			set => lastName = value;
		}

		public string Phone {
			get => phone;
			set => phone = value;
		}

		public override string ToString() {
			return $"Email: [{email}] FirstName: [{firstName}] Id: [{id}] LastName: [{lastName}] Phone: [{phone}]";
		}
	}
}