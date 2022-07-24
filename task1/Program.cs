 /*
 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
 является ли оно палиндромом.
 */

 Console.WriteLine("введите  число");
            string x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            string x2 = new String(arr);
 
            if (x == x2) Console.WriteLine("Палиндром");
            else Console.WriteLine("Не палиндром");