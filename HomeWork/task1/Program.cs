


void Number(int a)
{
    if(a==1)
    {
        System.Console.Write(1+" ");
    }
    else 
    {
        Number(a-1);
        System.Console.Write(a+" ");
    }
}
int a=Convert.ToInt32(Console.ReadLine());
Number(a);