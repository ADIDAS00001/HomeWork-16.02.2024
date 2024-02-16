


void EvenNumber(int a, int b)
{
    if (a % 2 == 0)
    {
        if (a > b)
        {
            return;
        }
        else
        {
            System.Console.Write($"{a} ");
            EvenNumber(a + 2, b);
        }
    }
    else
    {
        System.Console.Write($"{a + 1} ");
        EvenNumber(a + 3, b);
    }
}
EvenNumber(1, 20);
System.Console.WriteLine();

void OddNumber(int a, int b)
{
    if (a % 2 != 0)
    {
        if (a > b)
        {
            return;
        }
        else
        {
            System.Console.Write($"{a} ");
            OddNumber(a + 2, b);
        }
    }
    else
    {
        System.Console.Write($"{a + 1} ");
        OddNumber(a + 1, b);
    }
}
OddNumber(1, 20);