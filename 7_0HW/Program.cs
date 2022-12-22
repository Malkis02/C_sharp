void Print (double[,] arr){
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    for (int i = 0; i < rowSize; i++){
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i,j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] Array(int n,int m,int from,int to){
    double[,] array = new double[n,m];
    Random rand = new Random();
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            array[i,j] = Math.Round(rand.NextDouble() * (from+to) - from,2);
        }    
    }
        return array;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);