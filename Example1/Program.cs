string SequenceSegmentRec(int M, int N)
{
    if (N== M - 1) return "";
    return SequenceSegmentRec(M, N-1) + "  " + Convert.ToString(N);
}
try
{
    Console.WriteLine("Enter natural numbers");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SequenceSegmentRec(m, n));
}
catch
{
    Console.WriteLine("Enter a natural number");
}