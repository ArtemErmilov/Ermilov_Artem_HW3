/* ДЗ 3
Задача 3: 
Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/

int prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
    
}

int aInt= prompt("Введите число: ");

int sum = 0;

while (aInt>sum)
{
    sum++;
    Console.WriteLine(sum*sum*sum);
}
