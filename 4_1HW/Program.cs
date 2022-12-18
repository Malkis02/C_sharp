int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}

int Sum(int n){
    int result = 0;
    while(n>0){
        result +=n%10;
        n/=10;
    }
    return result;
}

int n = ReadNumber("Введите число ");
Console.WriteLine(Sum(n));