Console.WriteLine("Write a number");
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string result = num>num2?$"max={num}":(num==num2?"eqals":$"max={num2}");
Console.WriteLine(result);
