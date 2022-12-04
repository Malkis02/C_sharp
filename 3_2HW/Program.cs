int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}

void Cube(int n){
    for (int i = 1; i <= n; i++){
         Console.WriteLine(Math.Pow(i,3));
    }
}


int n = ReadNumber("Введите число ");
Cube(n);