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



}
