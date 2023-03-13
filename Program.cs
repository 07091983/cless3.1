//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите число X первой точки: ");  //Первая точка
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Y первой точки: ");  
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Z первой точки: ");  
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число X второй точки: ");  //Вторая точка
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Y второй точки: ");  
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число Z второй точки: ");  
double z2 = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));



Console.WriteLine($"Расстояние между точками : {distance:F3}");


