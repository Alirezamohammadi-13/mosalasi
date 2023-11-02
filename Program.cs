Console.WriteLine("Alireza mohammadi");
Console.WriteLine("adad fibonachi");


Console.WriteLine("adad chandom fibonachi ra namayesh daham?");

int a = 0;
int b = 1;
int c = 0;
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
for (int i = 0; i < n - 1; i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}
Console.WriteLine(" adad mored nazar shoma:");
Console.WriteLine(c);
Console.WriteLine("tamam");