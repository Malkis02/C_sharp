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

int[,] MatrixProduct(int[,] arr,int[,] arr2){
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int[,] matrix = new int[rowSize,columnSize];

    if(rowSize != arr2.GetLength(0) || columnSize != arr2.GetLength(1)){
        return matrix;
    }

    for (int i = 0; i < rowSize; i++){
        for (int j = 0; j < columnSize; j++){
            matrix[i,j] = arr[i,j] * arr2[i,j];
        }
    }
    return matrix;
}

Console.Write("Enter the number of rows 1: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column = int.Parse(Console.ReadLine());

int[,] arr = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Console.Write("Enter the number of rows 2: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column1 = int.Parse(Console.ReadLine());

int[,] arr1 = Array(row1, column1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));                    
Print(arr);
Print(arr1);
Print(MatrixProduct(arr,arr1));