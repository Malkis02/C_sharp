void Array(int n){
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100);
        Console.Write($"{array[i]} ");
    }
}

int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}

int n = ReadNumber("Введите размер массива ");
Array(n);