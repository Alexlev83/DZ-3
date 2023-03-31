// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

double ShowDistance (double x1, double y1, double z1,double x2, double y2, double z2)
{
double disx = x2 - x1;
double disy = y2 - y1;
double disz = z2 - z1;

double disxyz = Math.Sqrt(disx * disx + disy * disy + disz * disz);
return disxyz;

}
Console.Write("Ведите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату y2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату z3: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату x2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату y2: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координату z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowDistance(x1, x2, y1, y2, z1, z2));




// Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
 






