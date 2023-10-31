//نیما فدوی
//فاکتوریل
int f = 1, num;
Console.WriteLine("enter numbre");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=
    num; i++)
{
    if (num == 0) break;
    f *= i;
}
Console.WriteLine("{0}!={1}", num, f);
Console.ReadKey();
