System.Console.WriteLine("Введите 3-х значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 100) && (number < 1000)) 
{
    int figure1 = number / 100;
    int figure2 = number % 100 / 10;
    int figure3 = number % 10;
    System.Console.WriteLine(figure1 + "" + figure3);
}
else
{
    System.Console.WriteLine("Вы ввели не 3-х значное число!");
}
