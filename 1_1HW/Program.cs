Console.WriteLine("Write a number");
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int result = (num>num2&&num>num3)?num:(num2>num&&num2>num3?num2:num3);
Console.WriteLine($"Max number {result}");