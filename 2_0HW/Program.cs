int secondNumber(int num){
    return num%100/10;
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(secondNumber(num));