/* Задача №64. 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int InputNumber(String messageToUser)
{
    Console.Write(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse (answer, out int number);
    return number;
}

void OutPutNumber (int number)
{
    if (number==0) return;
    
     Console.Write($"{number} ");
     OutPutNumber(number-1);
    
}

int n = InputNumber ("Введите число: ");
Console.WriteLine();
OutPutNumber(n);
Console.WriteLine();
