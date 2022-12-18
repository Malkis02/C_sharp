int[] Array(int n){
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100);
    }
        return array;
}

int[] Print (int[] arr){
    for (int i = 0; i <arr.Length; i++){
        Console.Write($"{arr[i]} ");
    Console.WriteLine();    
    }
    return arr;
}

int ReadNumber(string message){
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null? 0 : int.Parse(s);
    return a;
}

int MaxAndMin(int[] arr){
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++){
        for (int j = 0; j < arr.Length; j++){
            if(arr[j]<min){
                min=arr[j];
            }
        }
    if(arr[i]>max){
        max = arr[i];
    }
    }
    Console.WriteLine($"max={max},min={min}");
    return max-min;
}

int n = ReadNumber("Введите размер массива ");
Console.WriteLine(MaxAndMin(Print(Array(n))));