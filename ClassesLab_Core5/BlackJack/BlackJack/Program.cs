using System;
using CardClasses;

namespace BlackJack {
	class Program {
		static void Main() {
			TestCardConstructors();
			TestCardPropertyGetters();
			TestCardPropertySetters();
			TestCardPropertySettersWithExceptions();
			TestCardGroup();
			TestCardColor();
			TestCardValue();
			TestCardMatching();
			TestCardToString();
		}

		static void TestCardConstructors() {
			Card c1 = new();
			Card c2 = new(1, 2);

			Console.WriteLine("[Testing both constructors]");

			Console.WriteLine("Default constructor -");
			Console.WriteLine("Expecting: default values (Suit: [0] Value: [0])");
			Console.WriteLine($"Got: {c1}");

			Console.WriteLine("Overloaded constructor -");
			Console.WriteLine("Expecting: Suit: [1] Value: [2]");
			Console.WriteLine($"Got: {c2}\n\n");
		}

		static void TestCardPropertyGetters() {
			Card c = new(1, 2);

			Console.WriteLine("[Testing getters]");

			Console.WriteLine($"Suit -");
			Console.WriteLine($"Expecting: [1]");
			Console.WriteLine($"Got: [{c.Suit}]");

			Console.WriteLine($"Value -");
			Console.WriteLine($"Expecting: [2]");
			Console.WriteLine($"Got: [{c.Value}]\n\n");
		}

		static void TestCardPropertySetters() {
			Card c = new(1, 2);

			Console.WriteLine("[Testing setters]");

			c.Suit = 4;
			c.Value = 5;

			Console.WriteLine("Expecting: Suit: [4] Value: [5]");
			Console.WriteLine($"Got: {c}\n\n");
		}

		static void TestCardPropertySettersWithExceptions() {
			Card c = new(1, 2);

			Console.WriteLine("[Testing invalid setter values]");

			try {
				c.Suit = -1;
			}
			catch {
				Console.WriteLine("(Suit = -1) Threw an exception when [Suit] is negative -");
				Console.WriteLine($"Expecting: [1]");
				Console.WriteLine($"Got: [{c.Suit}]");
			}

			try {
				c.Suit = 5;
			}
			catch {
				Console.WriteLine("(Suit = 5) Threw an exception when [Suit] is more than 4 -");
				Console.WriteLine($"Expecting: [1]");
				Console.WriteLine($"Got: [{c.Suit}]");
			}

			try {
				c.Value = -1;
			}
			catch {
				Console.WriteLine("(Value = -1) Threw an exception when [Value] is negative -");
				Console.WriteLine($"Expecting: [2]");
				Console.WriteLine($"Got: [{c.Value}]");
			}

			try {
				c.Value = 14;
			}
			catch {
				Console.WriteLine("(Value = 14) Threw an exception when [Value] is more than 13 -");
				Console.WriteLine($"Expecting: [2]");
				Console.WriteLine($"Got: [{c.Value}]");
			}

			try {
				c = new(-1, 14);
			}
			catch {
				Console.WriteLine("5 Constructor should also throw an exception when values are out of range -");
				Console.WriteLine($"[c] is now [{c}]");
			}

			Console.WriteLine("\n");
		}

		static void TestCardGroup() {
			Card c = new(1, 2);

			Console.WriteLine("[Test Card Group]");

			// Clubs
			Console.WriteLine($"Card is a [Club]: {c.IsClub(c.Suit)}");
			// Diamonds
			Console.WriteLine($"Card is a [Diamond]: {c.IsDiamond(c.Suit)}");
			// Hearts
			Console.WriteLine($"Card is a [Heart]: {c.IsHeart(c.Suit)}");
			// Spades
			Console.WriteLine($"Card is a [Spade]: {c.IsSpade(c.Suit)}\n\n");
		}

		static void TestCardColor() {
			Card c = new(1, 2);

			Console.WriteLine("[Test Card Color]");

			// Blacks
			Console.WriteLine($"Card is a [Black]: {c.IsBlack(c.Suit)}");
			// Reds
			Console.WriteLine($"Card is a [Red]: {c.IsRed(c.Suit)}\n\n");
		}

		static void TestCardValue() {
			Card c = new(1, 2);

			Console.WriteLine("[Test Card Value]");

			// Aces
			Console.WriteLine($"Card is an [Ace]: {c.IsAce(c.Value)}");
			// Face cards
			Console.WriteLine($"Card is a [FaceCard]: {c.IsFaceCard(c.Value)}\n\n");
		}

		static void TestCardMatching() {
			Card c1 = new(1, 2);
			Card c2 = new(3, 4);

			Console.WriteLine("[Test Card Matching]");

			// Matching suits
			Console.WriteLine($"Both cards have matching [suits]: {c1.HasMatchingSuit(c2)}");
			// Matching values
			Console.WriteLine($"Both have matching [values]: {c1.HasMatchingValue(c2)}\n\n");
		}

		static void TestCardToString() {
			Card c = new(1, 2);

			Console.WriteLine("[Testing ToString]");

			Console.WriteLine("Expecting: Suit: [1] Value: [2]");
			Console.WriteLine($"Got: {c}\n\n");
		}
	}
}