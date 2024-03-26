string num = "28";
byte n = byte.Parse(num);
nint n1 = (int)n;
int n2 = (int)n1;
long n3 = (long)n2;
double n4 = (double)n3;
Console.WriteLine($"{n}, {n1}, {n2}, {n3}, {n4}");
