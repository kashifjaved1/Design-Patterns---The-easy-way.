using Factory.Product.Interface;
using Factory.Factory.Implementation;

double basePrice = 20;
IcecreamFactory icecreamFactory = new();
List<string> flavours = new()
{
    "Mango",
    "ChocoVanilla",
    "Vanilla",
    "Strawberry",
    "Kulfa"
};

Console.WriteLine("Available options.");
flavours.ForEach(x => Console.Write($"{x}   "));
Console.WriteLine("\n");

var flavourInput = Console.ReadLine();

IIcecream selectedIcecream = icecreamFactory.GetIcecream(flavourInput);

if(selectedIcecream != null)
{
    Console.WriteLine($"Your total is RS. {(int)(basePrice * selectedIcecream.GetPrice())}");
}