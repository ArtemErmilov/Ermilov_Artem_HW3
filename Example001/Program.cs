/* ДЗ 3.
Задача 1: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

int prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    int a_Int = int.Parse(a_String);
    return a_Int;
}


Console.Write("Введите 5-и значное число => ");
string a_String = Console.ReadLine();
int a_Int = int.Parse(a_String);
int a_Int1=a_Int;

a_Int= Math.Abs(a_Int);
a_String= a_Int.ToString();

int number = a_String.Length;

while (number != 5)
{
    a_Int= prompt($"Введённое число {a_Int1}  не 5-ти значное, введите число заново:  ");
}

if (((a_Int%10)*10+((a_Int/10)%10))==(a_Int/1000))
{
    Console.WriteLine($"Число {a_Int1} являиться 5-и значным палиндромом ");
}
else
{
    Console.WriteLine($"Число {a_Int1} НЕ являиться 5-и значным палиндромом ");
}