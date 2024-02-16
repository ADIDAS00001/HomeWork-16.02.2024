
//SECTION 1
void PrintStars(int n)
{
    for(int i=1;i<=n;i++)
    {
        System.Console.Write("*");
    }
}
System.Console.Write("PrintStars: ");
int n=Convert.ToInt32(Console.ReadLine());
PrintStars(n);
System.Console.WriteLine();


//SECTION 2
void PrintSquare(int a)
{
    for(int i=1;i<=a;i++)
    {
        System.Console.Write("*");
        for(int j=1;j<=a;j++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("PrintSquare: ");
int a=Convert.ToInt32(Console.ReadLine());
PrintStars(a);
System.Console.WriteLine();



//SECTION 3
void  PrintRectangle(int w,int h)
{
    for(int i=1;i<=h;i++)
    {
        for(int j=1;j<=w;j++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("PrintRectangle: ");
int w=Convert.ToInt32(Console.ReadLine());
System.Console.Write("PrintRectangle: ");
int h=Convert.ToInt32(Console.ReadLine());
PrintRectangle(w,h);
System.Console.WriteLine();
