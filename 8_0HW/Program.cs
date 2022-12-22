﻿void Print (int[,] arr){
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

void SortedArray(int[,] arr){
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    for (int i = 0; i < rowSize; i++){
        for (int j = 0; j < columnSize; j++){
            for (int k = 0; k < columnSize - j - 1; k++){
                if(arr[i,k] < arr[i,k+1])
               (arr[i,k],arr[i,k+1])=(arr[i,k+1],arr[i,k]); 
            }
        }
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Array(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
SortedArray(arr_1);
Print(arr_1);