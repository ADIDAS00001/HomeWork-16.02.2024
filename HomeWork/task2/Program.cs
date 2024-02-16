

void Number(int a)
{
    if(a==0)
    {
        return ;
    }
    else 
    {
        System.Console.Write(a+" ");
        Number(a-1);
    }
}
int a=Convert.ToInt32(Console.ReadLine());
Number(a);