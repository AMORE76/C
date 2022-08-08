Console.Write("Input username. My name is ");
string username = Console.ReadLine();

/* Console.Write("Hello, ");
Console.Write(username!); */

if(username.ToLower() == "mike")
{
   Console.Write("Hurray, it is ");
} 
else
{
   Console.Write("Hello, ");
}

Console.Write(username);
Console.Write("!");