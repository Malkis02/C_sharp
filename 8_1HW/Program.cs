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

void RowMinSum(int[,] arr){
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int amount = 1000;
    int num;
    int index = 0;
    for (int i = 0; i < rowSize; i++){
        num = 0;
        for (int j = 0; j < columnSize; j++){
            num += arr[i,j];
        }
            Console.Write($"{num, 4}");
        if(amount > num){
            amount = num;
            index = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Строка с минимальной суммой элементов - {index + 1}");
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
RowMinSum(arr_1);