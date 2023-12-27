//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// class Program
// {
//      static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int M = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         PrintNaturalNumbers(M, N);
//     }

//     static void PrintNaturalNumbers(int start, int end)
//     {
//         if (start <= end)
//         {
//             Console.WriteLine(start);
//             PrintNaturalNumbers(start + 1, end);
//         }
//     }    

// }


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// class Program
// {
//     static void Main()
//    {
//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         int result = AckermannFunction(n, m);
//         Console.WriteLine($"Значение функции Аккермана для ({n}, {m}) равно: {result}");
//     }

//     static int AckermannFunction(int n, int m)
//     {
//         if (n == 0)
//             return m + 1;
//         else if (n > 0 && m == 0)
//             return AckermannFunction(n - 1, 1);
//         else if (n > 0 && m > 0)
//             return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
//         else
//             throw new ArgumentException("Некорректные значения n и m.");
//     }
// }

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// class Program
// {
//     static void Main()
//     {
//         int[] arr = new int[] { 1, 5, 3, 4, 5, 12, 7, };
//         PrintArrayReversed(arr, 0);
//     }

//     static void PrintArrayReversed(int[] arr, int index)
//     {
//         if (index == arr.Length)
//         {
//             return;
//         }

//         Console.Write(arr[arr.Length - 1 - index] + " ");
//         PrintArrayReversed(arr, index + 1);
//     }
// }
