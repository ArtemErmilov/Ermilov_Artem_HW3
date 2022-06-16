/* ДЗ3. 
Задача 2: 
Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
    
}

Console.WriteLine("Введите координаты точки A");

int ax = prompt("X=> ");
int ay = prompt("Y=> ");
int az = prompt("Z=> ");

Console.WriteLine("Введите координаты точки B");

int bx = prompt("X=> ");
int by = prompt("Y=> ");
int bz = prompt("Z=> ");

int dx = bx - ax;
int dy = by - ay;
int dz = bz - az;

double line = Math.Sqrt(dx * dx + dy * dy + dz * dz);

Console.WriteLine($"Длина отрезка между точками A и B равняется {line}");