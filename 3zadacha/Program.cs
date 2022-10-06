//Задать номер четверти, показать диапазоны для возможных координат
Console.Write("enter nomer chetverti:");
int chetvert = int.Parse(Console.ReadLine() ?? "0");
if (chetvert <= 4)
    switch (chetvert)
    {
        case 1:
            Console.WriteLine("0<X<(+)Бесконечность, 0<Y<(+)Бесконечность");
            break;
        case 2:
            Console.WriteLine("-Бесконечность<X<0, 0<Y<(+)Бесконечность");
            break;
        case 3:
            Console.WriteLine("-Бесконечность<X<0, -Бесконечность<Y<0");
            break;
        case 4:
            Console.WriteLine("0<X<(+)Бесконечность, -Бесконечность<Y<0");
            break;
    }
else
{
    Console.WriteLine("wrong try adain");
}