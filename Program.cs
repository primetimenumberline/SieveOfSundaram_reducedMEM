long n = 101;
bool[] b = new bool[n/2 + 1];
for (long i = 1; i <= n; i++)
{
    for (long j = 1; (i+j+2*i*j) < n/2 + 1; j++)
    {
        b[i+j+2*i*j] = true;
    }
}
Console.WriteLine("2");
for (long i = 1; i < n/2 + 1; i++)
{
    if (!b[i])
        Console.WriteLine("{0}", 2*i+1);
}