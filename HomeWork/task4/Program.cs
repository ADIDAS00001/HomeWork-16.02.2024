

void Number(int a)
{
    if(a==0)
    {
        return ;
    }
    else 
    {
        Number(a/10);
        System.Console.Write(a%10+" ");
    }
}
Number(1234);