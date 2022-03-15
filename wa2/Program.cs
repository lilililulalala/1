int a = 22;
int b = 3;
int c = 9;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);