void Numbers(int m,int n,int sum){
     sum = sum+=m;
    
    if(m > n) return;
    Console.Write($"{sum} ");
    Numbers(m + 1, n,sum);
}

int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}
int m = ReadNumber("Введите число ");
int n = ReadNumber("Введите число ");
Numbers(m,n,0);
