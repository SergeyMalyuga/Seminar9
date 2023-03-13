/* Задача №66.
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputNumber(String messageToUser)
{
    Console.Write(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int OutPutNumber(int number1, int number2) // Метод для вычисления суммы натуральных чисел.
{
    if (number1 > number2)
        return 0;
    return number1 + OutPutNumber(number1 + 1, number2);
}

(int, int) CheckingForNaturalNumbers(int number1, int number2) // Метод для проверки натуральности чисел.
{
    
    if (number1 <= 0)
    {
        number1 = 1;
    }
    if (number2 <= 0)
    {
        number2 = number1;
        number1 = 1;
        Console.WriteLine($"Так как число №1 > №2 ({number1}>{number2}) они были поменяны местами");
    }
    if (number1 > number2)
    {
        int temp = number2;
        number2 = number1;
        number1 = temp;
    }

    return (number1, number2);
}

int n = InputNumber("Введите натуральное число (начало промежутка чисел) №1: ");
int m = InputNumber("Введите натуральное число число (конец промежутка чисел) №2: ");
(n, m) = CheckingForNaturalNumbers(n, m);
int sum = OutPutNumber(n, m);
Console.WriteLine();
Console.WriteLine($"Сумму натуральных элементов в промежутке от {n} до {m} -> {sum}");
