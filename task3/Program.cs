Console.WriteLine("Введите день недели от 1 до 7: ");
 int number = Convert.ToInt32(Console.ReadLine());
    if(number >8 || number <1)
    {
    Console.WriteLine("Введено некоректное значение");
    return;

    }
    if(number >5)
    {
    Console.WriteLine("Выходной"); 
    }
    else
    {
    Console.WriteLine("Будни");
    }