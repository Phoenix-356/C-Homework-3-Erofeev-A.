/* Напишите программу, которая принимает на вход координаты двух т
очек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double x1, x2, x3, y1, y2, y3, distance;
double distance1;
    Console.WriteLine("Введите x1");
        x1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите x2");
        x2 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите x3");
        x3 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите y1");
        y1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите y2");
        y2 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите y3");
        y3 = Convert.ToDouble(Console.ReadLine()); 
    distance = Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2) + Math.Pow(y3 - x3, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();
                