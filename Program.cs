// 64 Задание
// string PringNumbers(int start, int end)
// {
//     if (start > end) {return "";}
//     if (start == end) {return start.ToString();}
//     return start.ToString() + ", " + PringNumbers(start + 1, end);
// }

// int m;
// int.TryParse(Console.ReadLine(), out m);
// int n;
// int.TryParse(Console.ReadLine(), out n);
// Console.WriteLine(PringNumbers(m, n));

// 66 задание
// int SumNumbers(int start, int end)
// {
//     if (start > end) {return 0;}
//     if (start == end) {return start;}
//     return start + SumNumbers(start + 1, end);
// }

// int m;
// int.TryParse(Console.ReadLine(), out m);
// int n;
// int.TryParse(Console.ReadLine(), out n);
// Console.WriteLine(SumNumbers(m, n));

// 68 задание
// int AkermanNumbers(int m, int n)
// {
//     if (m == 0) {return n + 1;}
//     if (n == 0) {return AkermanNumbers(m - 1, 1);}
//     return AkermanNumbers(m - 1, AkermanNumbers(m, n - 1));
// }

// int m;
// int.TryParse(Console.ReadLine(), out m);
// int n;
// int.TryParse(Console.ReadLine(), out n);
// Console.WriteLine(AkermanNumbers(m, n));