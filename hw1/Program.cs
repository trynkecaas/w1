int val;
val = 586;
if (val > 99 && val <1000)
{ 
  int res;
  res = (val % 100) / 10;
  Console.WriteLine ( res);
}
else 
{
  Console.WriteLine ( "Error");
}

