// See https://aka.ms/new-console-template for more information
int[] numbers = new int[11];
int summ = 0;
void Array(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
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
Console.WriteLine($"(Сумма нечётных элементов равна:){summ}");
