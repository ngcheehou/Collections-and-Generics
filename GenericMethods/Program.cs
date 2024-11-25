

int x = 1; int y = 2;
string a = "Hello",  b="World";


Console.WriteLine("Before Swap");
Console.WriteLine($"x: {x}, y: {y}");
Console.WriteLine($"a: {a}, b: {b}");

GenericSwap(ref x, ref y);
GenericSwap(ref a, ref b);

Console.WriteLine("After Swap");
Console.WriteLine($"x: {x}, y: {y}");
Console.WriteLine($"a: {a}, b: {b}");

Console.ReadLine();



void SwapInteger(ref int x , ref int y)
{
    int temp = x;
    x = y; 
    y = temp;
}

void SwapString(ref string x,ref string y)
{
    string temp = x;
    x = y;
    y = temp;
}

void GenericSwap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}