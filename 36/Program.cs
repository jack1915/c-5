// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//    Найдите сумму элементов, стоящих на нечётных позициях (индексах).

//    [3, 7, 23, 12] -> 19

//    [-4, -6, 89, 6] -> 0
int[] numbers = new int[11];
int summ = 0;
Random rmd = new Random();
void Array(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = rmd.Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ )
  {
    Console.Write(( i ) + " ");
    Console.WriteLine(array[i] + " ");
    
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
   
    for (int i = 1; i<array.Length; )
  {
    summ = summ + array[i];
    i = i + 2;
  }
  return summ;
}
Array(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"(Сумма чисел нечётных элементов массива равна:){summ}");
