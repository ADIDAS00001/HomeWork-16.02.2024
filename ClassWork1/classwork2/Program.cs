


int Fib(int a)
{
    if(a==0 || a==1)
    {
        return a;
    }
    else 
    {
        return Fib(a-1)+Fib(a-2);
    }
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Fib(a));