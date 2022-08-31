
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] mN = new int[m];

void Input(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    mN[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comp(int[] mN)
{
  int count = 0;
  for (int i = 0; i < mN.Length; i++)
  {
    if(mN[i] > 0 ) count += 1; 
  }
  return count;
}

Input(m);

Console.WriteLine($"Введено чисел больше 0: {Comp(mN)} ");