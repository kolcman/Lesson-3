﻿System.Console.WriteLine("Введите 3-х значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

// TASK1
// if ((number >= 100) && (number < 1000)) 
// {
//     int figure1 = number / 100;
//     int figure2 = number % 100 / 10;
//     int figure3 = number % 10;
//     System.Console.WriteLine($"{figure1}{figure3}");
//     int sum = Convert.ToInt32(figure3) + 1;
//     System.Console.WriteLine(sum);

// }
// else
// {
//     System.Console.WriteLine("Вы ввели не 3-х значное число!");
// }

// TASK2



if (number >= 100 && number < 1000)
{
    int figure1 = number / 100;
    int figure2 = number % 100 / 10;
    int figure3 = number % 10;
    int result = 1;
    if (figure2 == 1)
    {
        System.Console.WriteLine("1");
    }
    else
    {
        while(figure3 > 0)
        {
            result *= figure2;
            figure3--;

        }
        System.Console.WriteLine(result);
        // System.Console.WriteLine(Math.Pow(figure2, figure3)); - Method Math
    }
}
else
{
    System.Console.WriteLine("Вы ввели не 3-х значное число!");
}