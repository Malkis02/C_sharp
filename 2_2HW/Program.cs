void PrintThirdNum(int num){
    if(num<100){
        Console.WriteLine("Третьей цифры нет");
    }else{
    while (num>1000)
    {
        num/=10;
    }
    }
    Console.WriteLine(num%10);
}

int num = int.Parse(Console.ReadLine());
PrintThirdNum(num);