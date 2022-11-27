void dayOfWeek(int num){
    if(num<6){
        Console.WriteLine("Рабочий");
    }else if(num>5&&num<=7){
        Console.WriteLine("Выходной");
    }else{
        Console.WriteLine("Такого дня нет");
    }
}

int num = int.Parse(Console.ReadLine());
dayOfWeek(num);
