


int Fact(int a)
{
    if(a==1)
    {
        return 1;
    }
    else 
    {
        return a*Fact(a-2);
    }
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Fact(a));