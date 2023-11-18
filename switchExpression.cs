// switch expression 
using System;

namespace ProgramNamespace

internal class Programm{
  static void Main() {
	  int cardNumber = 12;
	  string cardName = cardNumber switch{
									13 => "King",
									12 => "Queen",
									11 => "Joker",
									_ => "Other Cards"
								 };
	  Console.WriteLine($"cardName : {cardName}");
   }
}
