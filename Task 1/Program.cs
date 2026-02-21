Console.Write("Enter name: ");
string? name = Console.ReadLine();

Console.Write("Enter age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter height: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Name: {name}  Age: {age}  Height: {height}m");
