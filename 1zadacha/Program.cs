//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("enter number of the day of week from 1-7" );
int Day = int.Parse(Console.ReadLine() ?? "0");
if (Day ==1)
{
   Console.WriteLine("Monday,weekday");  
}
if (Day==2)
{
      Console.WriteLine("tuesday,weekday");
}
if (Day==3)
{
    Console.WriteLine("wednesday,weekdar");
}
if (Day==4)
{
  Console.WriteLine("thursday,weekday");
}
if (Day==5)
{
    Console.WriteLine("Friday,weekday");
}
if (Day==6)
{
    Console.WriteLine("SATURDAY.WEEKEND");
}
if (Day==7)
{
    Console.WriteLine("SUNDAY.WEEKEND");
}
if (Day>7)
{
    Console.WriteLine("wrong,try again (number from 1-to 7)");
}
if (Day<=0)
{
    Console.WriteLine("wrong,try again (number from 1-to 7)");
}