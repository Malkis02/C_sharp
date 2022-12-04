string IsPalindrome(int x){
   return x<99999&&x>10000?(x%10==x/10000&&(x%100/10)==(x/1000%10)?"палиндром":"не палиндром"):"введено не корректное число"; 
}

int num = int.Parse(Console.ReadLine());

Console.WriteLine(IsPalindrome(num));