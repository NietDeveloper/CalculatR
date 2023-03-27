using System;
string password="";
do
{
    System.Console.Write("Enter password:");
    password=Console.ReadLine();
}while(password!="niet0099");
System.Console.Write("Type 1st Number:");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Type 2nd Number:");
int secondNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("enter operation(+,-,*,/,%)");
string operation=Console.ReadLine();
string message=
    !(firstNum>=0)
        ?"1st number is not positive"
        :"1st number is not negative";

System.Console.WriteLine(message);

if(firstNum>secondNum)
{
    System.Console.WriteLine("1st number is greater than 2nd number");
}
else if(firstNum==secondNum)
{
    System.Console.WriteLine("1st and 2nd number are equal");
}
else
{
    System.Console.WriteLine("1st namber is smaller than 2nd number");
}

string result = operation switch
{
    "+" => $"{firstNum}+{secondNum}={firstNum+secondNum}",
    "-" => $"{firstNum}-{secondNum}={firstNum-secondNum}",
    "/" => $"{firstNum}/{secondNum}={firstNum/secondNum}",
    "*" => $"{firstNum}*{secondNum}={firstNum*secondNum}",
    "%" => $"{firstNum}%{secondNum}={firstNum%secondNum}",
    _=>"Operation not found!"
};
System.Console.WriteLine(result);

int counter = 0;
while(counter<firstNum)
{
    System.Console.WriteLine(counter);
    counter+=2;
}

for(int i=1; i<=10;i++)
{
    for(int j=1;j<=10;j++)
    {
        System.Console.WriteLine($"{i} X {j} = {i*j}");
    }
    System.Console.WriteLine("\n");
}
