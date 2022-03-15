int a = -9;
int b = -3;
Console.WriteLine(a);
Console.WriteLine(b);

int max = b;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);