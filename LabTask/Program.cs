/*#region Task1->1
using System.Diagnostics.CodeAnalysis;

int bal = 64;
if (bal<=100 && bal>=91)
{
    Console.WriteLine("Senin balin A-dir");
}
else if (bal <= 91 && bal >= 81)
{
    Console.WriteLine("Senin balin B-dir");

}
else if (bal <= 81 && bal >= 71)
{
    Console.WriteLine("Senin balin C-dir");

}
else if (bal <= 71 && bal >= 61)
{
    Console.WriteLine("Senin balin D-dir");

}
else if (bal <= 61 && bal >= 51)
{
    Console.WriteLine("Senin balin E-dir");

}
else
{
    Console.WriteLine("Siz kesilmisiniz");
}


#endregion
#region Task1->2
int num = 526;
int sum = 0;
int i = 0;
while (num > 0)
{
    i = num % 10;
    sum = sum + i;
    num = num / 10;


}
Console.WriteLine(sum);
#endregion*/
#region Task1->3
int[] numbers = { 12, 54, 83, 1, 87, 61, 24 };
int evennumcount = 0;
int i = 0;
foreach (var evennum in numbers)
{
    if (evennum%2==0)
    {
        i = evennum;
        evennumcount++;
        Console.Write(i+" ");
    }
}
Console.WriteLine("-"+evennumcount);
#endregion
#region Task1->4
 int[] number = { 21, 54, 63, 16, 34 };

 int max = number[0];
 int min = number[0];
 foreach (var num in number)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}
 Console.WriteLine("en kicik eded" + " " + min);
 Console.WriteLine("en boyuk eded" + " " + max);
 Console.WriteLine("en kicik ve en boyuk ededlerin cemi" + " " + (min + max));
#endregion*/
#region Task1->5
int[] nums = { 2, 5, 2, 8, 9, 2, 7, 2 };
int i = nums[0];
int count = 0;
foreach (var same in nums)
{
    if (same == i)
    {
        count++;
        continue;
    }
}
Console.WriteLine(count);
#endregion*/