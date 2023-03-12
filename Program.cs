System.Console.Write("Enter your name:");
string name=Console.ReadLine();
string greeting = $"Hello {name}!";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age:");
string ageAsString= Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted! {age}");

System.Console.Write("Enter Kescha is age:");
string ageAsStringKescha=Console.ReadLine();
System.Console.WriteLine("Converting...");
int ageKescha= Convert.ToInt32(ageAsStringKescha);
System.Console.WriteLine($"Keschaning yoshi {ageKescha}");
System.Console.WriteLine($"Kescha {name}dan {age-ageKescha} kichkina!");

