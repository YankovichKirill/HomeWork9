int m = InputNumber("Enter m: ");
int n = InputNumber("Enter n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Sum of elements = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}