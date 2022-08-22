// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Random rmd = new Random();
double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = rmd.Next(-100, 100) + rmd.NextDouble();
    double v = Math.Round(arrayRealNumbers[i], 3);
    Console.WriteLine(v + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным {Math.Round(maxNumber,2)} и минимальным {Math.Round(minNumber,2)} элементами: {Math.Round(decision,2)}");