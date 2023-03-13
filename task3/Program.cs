/* Задача №68. 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

int InputNumber(String messageToUser)
{
    Console.Write(messageToUser);
    String answer = Console.ReadLine();
    int.TryParse(answer, out int number);
    return number;
}

int Akkerman (int m, int n) 
{
    if (m == 0) 
    return n+1;
    if (n==0) 
    return Akkerman(m-1,1);
    if (m>0 && n>0)
    return  Akkerman(m-1,Akkerman(m,n-1));
    return Akkerman(m,n);
}

(int, int) CheckingNumbers(int m, int n) // Метод для проверки чисел (больше или меньше 0).
{
    if (m < 0)
    {
        m = Math.Abs(m);
        Console.WriteLine ($"Число №1 было исправленно на положительное: -> ({m})"+
        " т.к функция Аккермана принимает только положительные числа!");
    }
    if (n < 0 )
    {
        n = Math.Abs(n);
        Console.WriteLine ($"Число №2 было исправленно на положительное: -> ({n})"+
        " т.к функция Аккермана принимает только положительные числа!");
    }
   
    return (m, n);
}

int m = InputNumber("Введите положительное число №1: ");
int n = InputNumber("Введите положительное число №2: ");
Console.WriteLine();
(m,n)=CheckingNumbers(m, n);
int rez = Akkerman(m, n);
Console.WriteLine();
Console.WriteLine($"Результат вычисления функции Аккермана: {rez}");
