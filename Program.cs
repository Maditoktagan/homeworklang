
// void Task8()
// {

//     Console.WriteLine("Введите число ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     int counter = 2;
//     while (counter <= num)
//     {
//         Console.Write(counter + " ");
//         counter = counter + 2;
//     }
// }
// Task8();

Console.Write("Введите число от 1 до 7 = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1) Console.WriteLine("Понедельник");
if (a == 2) Console.WriteLine("Вторник");
if (a == 3) Console.WriteLine("Среда");
if (a == 4) Console.WriteLine("Четверг");
if (a == 5) Console.WriteLine("Пятница");
if (a == 6) Console.WriteLine("Суббота");
if (a == 7) Console.WriteLine("Воскресения");
void Task7()
{
 Console.Write("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
 num = Math.Abs(num);

 int counter = -num;
  // до тех пор пока counter <= num
  // 0 1 2 3 4 5 ... num
   while(counter < num)
   {
    Console.Write(counter + " ");
    counter++;
   }
}   
   Task7();
int a = 5;
int b = 7;
int max = a;
if(b>max) max = b;
Console.WriteLine(max);


int Max(int agr1, int agr2, int agr3)
{
    int result = agr1;
    if (agr2 > result) result = agr2;
    if (agr3 > result) result = agr3;
    return result;
}
int a1 = 2;
int b2 = 3;
int c3 = 7,;

int max1 = Max(a1, b2, c3);
int max2 = Max(a1, b2, c3);
int max3 = Max(a1, b2, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);