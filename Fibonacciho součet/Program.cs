
Fibsoucet(Convert.ToInt32(Console.ReadLine()), Fib());
List<int> Fib ()
{
    List<int> values = new List<int>();
    values.Add(1);
    values.Add(1);
    int maxfib = 1000000;
    bool cont = true;
    for (int i = 2;cont; i++)
    {
        
        if (maxfib >= values.Last())
        {
            values.Add(values[i - 1] + values[i - 2]);
        }
        else cont = false;
        //Console.WriteLine($"{i+1}|{(values[i - 1] + values[i - 2])}");
    }
    return values;
}

void Fibsoucet (int num, List<int> fib)
{ while (num != 0)
    {
        int closest = 0;
        bool cont = true;

        for (int i = 0; cont; i++)
        {
            if (fib[i] <= num)
            {
                closest = fib[i];
            }
            else cont = false;
        }
        Console.WriteLine(closest );
        num = num - closest;
    }
}