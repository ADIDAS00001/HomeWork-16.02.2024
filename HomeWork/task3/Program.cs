

int Number(int a)
{
    if(a==0)
    {
        return 0;
    }
    else 
    {
        return a+Number(a-1); 
    }
}
System.Console.WriteLine(Number(10));
