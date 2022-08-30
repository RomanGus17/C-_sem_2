
//СЕМИНАР 3

//Задача 22
//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
Console.WriteLine("Vvedi N");
double N = int.Parse(Console.ReadLine());
double res = 1;

while (res <= N)
{
    Console.WriteLine(Math.Pow(res, 2));
    ++res;
}




//---------------------------------------------------------------------------------------------------------------------
//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2д пространстве
// double xa = 3;
// double xb = 2;
// double ya = 6;
// double yb = 1;
// //AB = √(xb - xa)2 + (yb - ya)2
// //double raznicaX = xb - xa;
// //double raznicaY = yb - ya;
// double koren = Math.Sqrt(Math.Pow(xb - xa, 2)+Math.Pow(yb - ya, 2));

// Console.WriteLine(koren);


//---------------------------------------------------------------------------------------------------------------------
//Задача 18
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координатных точек в этой четверти (x, y)

// void VivestiXYotchetverty(int XY) //функция возвращающая текст для четверти и саму четверть 
// {
//     if (XY == 1)
// {
//     Console.WriteLine("x > 0, y > 0 " + "номер четверти = " + XY);
// }
//     if (XY == 2)
// {
//     Console.WriteLine("x < 0, y > 0 " + "номер четверти = " + XY);
// }
//   if (XY == 3)
// {
//     Console.WriteLine("x < 0, y < 0 " + "номер четверти = " + XY);
// }
//   if (XY == 4)
// {
//     Console.WriteLine("x > 0, y < 0 " + "номер четверти = " + XY);
// }
// }

// Console.WriteLine("Введи номер четверти");
// int n = int.Parse(Console.ReadLine());

// if (n == 1)
// {
//     VivestiXYotchetverty(1);
// }
// if (n == 2)
// {
//     VivestiXYotchetverty(2);
// }
// if (n == 3)
// {
//     VivestiXYotchetverty(3);
// }
// if (n == 4)
// {
//     VivestiXYotchetverty(4);
// }



//---------------------------------------------------------------------------------------------------------------------
//Задача 17
//Напишите программу, которая принимает на вход координаты точки (X, Y), причем X не равно 0 и Y не равно 0 и выдает номер четверти плоскости
//в которой находится эта точка

// void VivestiChetvert(int chet) //функция возвращающая текст для четверти и саму четверть 
// {
//     Console.WriteLine("точка принадлежит четверти " + chet);
// }

// Console.WriteLine("Vvedi X");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("Vvedi Y");
// int y = int.Parse(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     VivestiChetvert(1);
// }
// if (x < 0 && y > 0)
// {
//     VivestiChetvert(2);
// }
// if (x < 0 && y < 0)
// {
//     VivestiChetvert(3);
// }
// if (x > 0 && y < 0)
// {
//     VivestiChetvert(4);
// }