// Task10

Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((number1/10)%10);

// Task13

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
int i = 1; 
int ThirdNumber;
if (Third(number2)<=2)
{
    Console.WriteLine("Число не имеет 3ей цифры");
}
else
{
    ThirdNumber = number2/(Convert.ToInt32(Math.Pow(10, (i-3)))) - number2/(Convert.ToInt32(Math.Pow(10, (i-2))))*10;
    Console.WriteLine("третья цифра - " + ThirdNumber);
}


int Third(int number2)
{
    while (number2/10 != 0)
    {
        number2 = number2/10;
        i++; // Счетчик разрядов
    }
    
    return i;
}

// Task15

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number3<=7)
{
    switch (number3)
    {
        case 1:
            Console.WriteLine("No");
            break;
        case 2:
            Console.WriteLine("No");
            break;
        case 3:
            Console.WriteLine("No");
            break;
        case 4:
            Console.WriteLine("No");
            break;
        case 5:
            Console.WriteLine("Fifty fifty");
            break;
        case 6:
            Console.WriteLine("yes");
            break;
        case 7:
            Console.WriteLine("yes");
            break;
        
    }
}
else
{
    Console.WriteLine("Некорректное число");
}