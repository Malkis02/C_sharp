void Print (int[,] arr){
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    for (int i = 0; i < rowSize; i++){
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i,j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Array(int n,int m,int from,int to){
    int[,] array = new int[n,m];
    Random rand = new Random();
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            array[i,j] = rand.Next(from,to);
        }    
    }
        return array;
}

string FindElement(int[,] arr,int f,int s){
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if(f > row || f <= 0 || s > column || s <= 0)
        return $"{f} {s} -> такого числа нет";
    return $"[{f} {s}] = {arr[f-1,s-1]} -> ваше число";
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Enter the line position: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine());

Console.Write(FindElement(arr_1,first,second));