
int cnt=0;
int Number(int a)
{
    if(a==0)
    {
        return cnt;
    }
    else 
    {
        cnt++;
        return Number(a/10);
    }
}
System.Console.WriteLine(Number(1234));
