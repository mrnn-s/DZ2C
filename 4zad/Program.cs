// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int a = (chislo/10000);
int b = ((chislo%10000)/1000);
int c = (((chislo%10000)%1000)/100);
int d = ((((chislo%10000)%1000)%100)/10);
int e = ((((chislo/10000)%1000)%100)%10);
int result=(e*10000+d*1000+c*100+b*10+a);

if (result==chislo)
{
    Console.WriteLine ("POLINOM");
}
else
{
    Console.WriteLine ("NEPOLINOM");
}