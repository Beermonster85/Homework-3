// Задача №1
// Напишите программу, которая принимает на вход координаты точки (X и Y), причем x не равен 0 и Y не равен 0 и выдает номер четверти плоскости в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if ((X > 0) && (Y > 0))
// {
//     Console.WriteLine("№1");
// }

// else if ((X < 0) && (Y > 0))
// {
//     Console.WriteLine("№2");
// }

// else if ((X < 0) && (Y < 0))
// {
//     Console.WriteLine("№3");
// }

// else if ((X > 0) && (Y < 0))
// {
//     Console.WriteLine("№4");
// }


// Задача №2
// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (x,y)

// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("X > 0 && Y > 0");
// }
// else if (number == 2)
// {
//     Console.WriteLine("X < 0 && Y > 0");
// }
// else if (number == 3)
// {
//     Console.WriteLine("X < 0 && Y < 0");
// }
// else if (number == 4)
// {
//     Console.WriteLine("X > 0 && Y < 0");
// }
// else
// {
//     Console.WriteLine("такой четверти нет");
// }

// Второй метод решения задачи

// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         {
//             Console.WriteLine("X > 0 && Y > 0");
//             break;
//         }
//     case 2:
//         {
//             Console.WriteLine("X < 0 && Y > 0");
//             break;
//         }
//     case 3:
//         {
//             Console.WriteLine("X < 0 && Y < 0");
//             break;
//         }
//     case 4:
//         {
//             Console.WriteLine("X > 0 && Y < 0");
//             break;
//         }
//     default:
//         {
//             Console.WriteLine("такой четверти нет");
//             break;
//         }
// }


// Задача №3
// Напишите программу, которая принимает на вход координаты двух точек и находит раастояние между ними в 2D пространстве.
// А(3,6) B(2,1)--->5,09

// Console.WriteLine("Введите координату точки #1 по X");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату точки #1 по Y");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки #2 по X");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату точки #2 по Y");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
// Console.WriteLine(d);