void Numbers(int n){
    if(n == 0) return;
    if(n%2==0)
        Console.Write($" {n} ");
    Numbers(n - 1);
}

int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}
int n = ReadNumber("Введите число ");
Numbers(n);