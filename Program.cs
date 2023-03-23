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
int ageDifference = age - ageKescha;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");
System.Console.WriteLine($"You are older than KESCHA: {age>ageDifference}");
System.Console.WriteLine($"You are younger than KESCHA:{age<ageDifference}");
System.Console.WriteLine($"You are older than or equal KESCHA:{age>=ageDifference}");
System.Console.WriteLine($"You are younger than or equal KESCHA:{age<=ageDifference}");
System.Console.WriteLine($"Are you equal to KESCHA:{age==ageDifference}");
System.Console.WriteLine($"Are you not equal KESCHA:{age!=ageDifference}");


