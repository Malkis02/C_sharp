int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}

int Pow(int a,int b){
    int result = a;
for(int i = 1;i<b;i++){
    result*=a;
}
return result;
}

int a = ReadNumber("Введите число а ");
int b = ReadNumber("Введите число b ");

Console.WriteLine(Pow(a,b));