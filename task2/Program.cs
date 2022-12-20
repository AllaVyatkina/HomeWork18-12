   Console.WriteLine ("Введите число");

        string number = Console.ReadLine();
        if(number.Length < 3) 
        {
            Console.WriteLine("Третьей цифры нет");
          return;
        }

        Console.WriteLine(number[2]);