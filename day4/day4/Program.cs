namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //while(count < 5)
            //{
            //    Console.WriteLine("我爱你");
            //    count++;
            //}
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine(++count);
            //}
            //将1-10相加
            //int count = 1;
            //int sum = 0;
            //while(count <= 10)
            //{
            //    sum += count;
            //    count++;
            //}
            //Console.WriteLine(sum);
            //将1-10之间的奇数加起来
            //int count = 1;
            //int sum = 0;
            //while(count <= 10)
            //{
            //    if(count %2 != 0)sum+= count;
            //    count++;
            //}
            //Console.WriteLine(sum);
            //输出50以内所有能被3整除且能被5整除的数字
            //int count = 50;
            //while(count > 0)
            //{
            //    if(count %3 == 0&&count % 5 == 0)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count--;
            //}
            //1-5相乘
            //int count = 1;
            //int sum = 1;
            //while(count <= 5)
            //{
            //    sum *= count;
            //    count++;
            //}
            //Console.WriteLine(sum);
            //逢7就过的游戏中，100以内所有喊过的数字
            //int count = 1;
            //while(count <= 100)
            //{
            //    if(count % 7 == 0 || count % 10 == 7 || count / 10 == 7)
            //    {
            //        count++;
            //        continue;
            //    }
            //    Console.WriteLine(count);
            //    count++;
            //}
            //求100~1000之间所有的水仙花数
            //int count = 100;
            //while (count < 1000)
            //{
            //    int a = count / 100;
            //    int b = count / 10 % 10;
            //    int c = count % 10;
            //    if (a * a * a + b * b * b + c * c * c == count)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count++;
            //}

            //int[] arr = new int[100000];
            //List<int> arr = new List<int>() {0};
            //int count1 = 1;
            //while (count1 < 1000)
            //{
            //    int a = count1 / 100;
            //    int b = count1 / 10 % 10;
            //    int c = count1 % 10;
            //    if (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3) == count1)
            //    {
            //        arr.Add(1);
            //    }else
            //    {
            //        arr.Add(0);
            //    }
            //    count1++;
            //}
            //while (count1 < 100000)
            //{
            //    int num = count1 % 1000;
            //    //if(count1 == 11407)Console.WriteLine(num);
            //    if (arr[num] == 1)
            //    {
            //        arr.Add(1);
            //    }
            //    else
            //    {
            //        arr.Add(0);
            //    }
            //        count1++;
            //}
            //int n = int.Parse(Console.ReadLine());
            //if (arr[n] == 1)
            //{
            //    Console.WriteLine($"{n}是水仙花数");
            //}
            //else
            //{
            //    Console.WriteLine($"{n}不是水仙花数");
            //}
            //int count = 1;
            //do while 倒着输出1-5
            //do { 
            //    Console.WriteLine(count);
            //    count++;
            //} while (count <= 5);
            //倒着输出1-10
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //输出1-10之间的偶数
            //for(int i = 2;i<=10;i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //入职薪水10K，每年涨幅5%，50年后工资多少
            //double count = 10;
            //double num = 0;
            //for(int i = 0; i < 50; i++)
            //{
            //    count *= 1.05;
            //    num += count;
            //}
            //Console.WriteLine($"十年后工资为{count},十年赚了{num*12}");
            //遍历List
            //List<string> strList = new()
            //{
            //        "aa",
            //        "bb",
            //        "ccc",
            //        "dd",
            //        "eee"
            //};
            //for(int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(strList[i]);
            //}
            //List<int> intList = new()
            //{
            //    1,2,3,4,5,6,7,8,9,10
            //};
            //int count = 0;
            //for(int i = 0; i < intList.Count; i++)
            //{
            //    count += intList[i];
            //}
            //Console.WriteLine(count);
            //int[] arr = new int[10000000];
            //arr[0] = 1;
            //arr[1] = 1;
            //for (int i = 2; i * i < arr.Length; i++)
            //{
            //    if (arr[i] == 0)
            //    {
            //        for (int j = i * i; j < arr.Length; j += i)
            //        {
            //            arr[j] = 1;
            //        }
            //    }
            //}
            //Console.WriteLine("请输入你想要判断的数（10000000以内）：");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(arr[n] == 0 ? $"{n}是素数" : $"{n}不是素数");
            //五人每人跑五圈
            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"第{i}位选手开始跑步");
            //    for(int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine($"第{i}位选手跑了{j}圈");
            //    }
            //    Console.WriteLine($"第{i}位选手跑完了");
            //}
            //每行五个*
            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //直角星星
            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //九九乘法表
            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1;j<=i;j++)
            //    {
            //        Console.Write($"{j}*{i}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}
            //输出100以内偶数的和
            //int count = 0;
            //for(int i = 2; i <= 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        count += i;
            //    }
            //}
            //Console.WriteLine($"100以内偶数的和为{count}");
            //int count = 0;
            //for(int i = 1000; i <= 2000; i++)
            //{
            //     if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
            //    {
            //        count++;
            //        if (count < 4)
            //        {
            //            Console.Write($"{i} ");
            //        }
            //        else
            //        {
            //            count = 0;
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //Console.WriteLine("输入层数：");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = n; i > 0; i--)
            //{
            //    for(int j = i; j > 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //double sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += 1.0 / (i + 1);
            //    }
            //    else
            //    {
            //        sum -= 1.0 / (i + 1);
            //    }
            //}
            //Console.WriteLine($"前100项的和为{sum:f5}");
            //int count = 0;
            //int sum = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum *= i;
            //    count += sum;
            //}
            //Console.WriteLine($"前10项阶乘的和为{count}");
            //double height = 5;
            //int count = 0;
            //while (height > 0.1)
            //{
            //    height *= 0.3;
            //    count++;
            //}
            //Console.WriteLine($"要{count}次弹起");
            //double count = 0.00001;
            //double sum = 0.00001;
            //for (int i = 1; i < 64; i++)
            //{
            //    sum *= 2;
            //    //Console.WriteLine(sum);
            //    count += sum;
            //}
            ////Console.WriteLine($"棋盘上的总数为{count}");
            //Console.WriteLine($"棋盘上的重量为{count}");
            double n = 50000;
            int count = 0;
            while (n > 5000)
            {
                n *= 0.95;
                Console.WriteLine($"第{++count}次后，n的值为{n}");
            }
            Console.WriteLine($"总共能够扣除{count}次");
            //int count = 1;
            //for(int i = 6; i > 0; i--)
            //{
            //    count = (count + 1) * 2;
            //}
            //Console.WriteLine($"第一天的桃子数为{count}");
            //double count = 0;
            //double sum = 10;
            //for (int i = 0; i < 10; i++)
            //{
            //    count += sum * 0.5;
            //    sum *= 0.5;
            //}
            //Console.WriteLine($"皮球总共经历了{count}米");

            //int[] arr = [1,3,2,4,6,5,7,9,8,10];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    for(int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        if(arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "张三",
            //    ["age"] = 12
            //};
            ////Console.WriteLine(dic.Keys);
            ////Console.WriteLine(dic.Values);
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //
        }
    }
}
