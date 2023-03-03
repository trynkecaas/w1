Console.WriteLine("введите число");
int val =Convert.ToInt32(Console.ReadLine());
int res;
if (val< 99)
 Console.WriteLine ("третьей цифры нет");
 else if (val > 99 && val <1000)
{
  res = (val % 100) % 10 ;
  Console.WriteLine (res);
}
