using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>()
            {
                ["name"] = "张三",
                ["age"] = 18
            };
            dic.TryAdd("height", 180);
            //dynamic[] keyArr = dic.Keys.ToArray();
            //dynamic[] valueArr = dic.Values.ToArray();
            //foreach (dynamic key in keyArr) {
            //    Console.WriteLine(key);
            //}
            //foreach (dynamic value in valueArr) {
            //    Console.WriteLine(value);
            //}
            //dic.Remove("height");
            //Console.WriteLine(dic.ContainsKey("height"));
            //Console.WriteLine(dic.ContainsValue(180));
            //dic.Clear();
            //Console.WriteLine(dic.Count());
            //foreach (var key in dic) {
            //    Console.WriteLine(key);
            //}
            //foreach(var key in dic.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach (dynamic val in dic.Values) {
            //    Console.WriteLine(val);
            //}
            List<int> list = [1,1, 3, 3,3,3 ,4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    for (int j = i + 1; j < list.Count; j++)
            //    {
            //        if (list[i] == list[j]) { 
            //            list.Remove(list[j]);
            //            j--;
            //            i--;
            //        }

            //    }
            //}
            //for (int i = 0; i < list.Count; i++) {
            //    Console.WriteLine(list[i]);
            //}
            //思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list.IndexOf(list[i]) != list.LastIndexOf(list[i]))
            //    {
            //        while (list.IndexOf(list[i]) != list.LastIndexOf(list[i]))
            //        {
            //            list.Remove(list[i]);
            //        }
            //if (list.LastIndexOf(list[i]) != i)
            //{
            //    list.Remove(list[i]);
            //    i--;
            //}
            //    }
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);}
            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            //    List<int> list2 = new List<int>();
            //    Dictionary<int,int> dict = new Dictionary<int,int>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    dict[list[i]] = i;
            //}
            //foreach (dynamic obj in dict.Keys) {
            //    list2.Add(obj);
            //}
            //List<int> list1 = new List<int>();
            //foreach (var i in dict) {
            //    list1.Add(i.Key);
            //}
            //for (int i = 0; i < list1.Count; i++) {
            //    Console.WriteLine(list1[i]);
            //}
            //思路4创建一个新的List，遍历原本的List，原本List中的每一个元素，放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加
            //List<int> list1 = new List<int>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (!list1.Contains(list[i]))
            //    {
            //        list1.Add(list[i]);
            //    }
            //}
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //冒泡排序：
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    for (int j = 0; j < list1.Count - 1 - i; j++)
            //    {
            //        if (list1[j] >= list1[j + 1])
            //        {
            //            int tmp = list1[j];
            //            list1[j] = list1[j + 1];
            //            list1[j + 1] = tmp;
            //        }
            //    }
            //}
            //foreach (int i in list1) {
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //插入
            //for (int i = 1; i < list.Count; i++)          
            //{
            //    int key = list[i];                        
            //    int j = i - 1;                             
            //    while (j >= 0 && list[j] > key)
            //    {
            //        list[j + 1] = list[j];                 
            //        j--;
            //    }
            //    list[j + 1] = key;
            //}
            //foreach (int i in list1)
            //{
            //    Console.Write(i + " ");
            //}
            //二分查找
            //int l = 0, r = list1.Count - 1;
            //int m = (l + r) / 2;
            //int n = 4;
            //while (l < r)
            //{
            //    if (list1[m] > n)
            //    {

            //    }
            //}
            //int max = 0;
            //for(int i = 0;i< list1.Count; i++)
            //{
            //    if (max < list1[i]) max = list1[i];
            //}
            //int[] arr = new int[max+1];
            //for(int i = 0; i < list1.Count; i++)
            //{
            //    arr[list1[i]] = 1;
            //}
            //List<int> list2 = new List<int>();
            //for(int i = 0; i < max+1; i++)
            //{
            //    if (arr[i] == 1)list2.Add(i);
            //}
            //foreach(int i in list2) Console.WriteLine(i);
            //Console.WriteLine(list.Count);
            //for(int j = 0; j < list.Count; j++)
            //   {
            //       Console.WriteLine(list[j]);
            //   }
//            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
//            {
//                new Dictionary<string, dynamic>
//                {
//                    {"name", "机械键盘"},
//                    {"price", 299.99},
//                    {"code", "G001"},
//                    {"stock", 120}
//                },
//                new Dictionary<string, dynamic>
//                {
//                    {"name", "无线鼠标"},
//                    {"price", 89.50},
//                    {"code", "G002"},
//                    {"stock", 356}
//                },
//                new Dictionary<string, dynamic>
//                {
//                    {"name", "27寸显示器"},
//                    {"price", 1299.00},
//                    {"code", "G003"},
//                    {"stock", 48}
//                },
//                new Dictionary<string, dynamic>
//                {
//                    {"name", "电竞耳机"},
//                    {"price", 199.00},
//                    {"code", "G004"},
//                    {"stock", 85}
//                },
//                new Dictionary<string, dynamic>
//                {
//                    {"name", "电脑支架"},
//                    {"price", 69.90},
//                    {"code", "G005"},
//                    {"stock", 210}
//                }
//            };
//            // 按照价格做排序
//            Console.WriteLine("提示输入的 是price还是stock  排序类型 ");
//            string str = Console.ReadLine();
//            Console.WriteLine("提示输入的是 ASC 还是DSC     排序顺序(ASC升序, DSC降序");
//            string str1 = Console.ReadLine();
//            if(str1 == "ASC")
//            {
//                for (int i = 0; i < goodsList.Count; i++)
//                {
//                    for (int j = 0; j < goodsList.Count - 1 - i; j++)
//                    {
//                        if (goodsList[j][str] > goodsList[j + 1][str])
//                        {
//                            Dictionary<string, dynamic> emp = new Dictionary<string, dynamic>();
//                            emp = goodsList[j];
//                            goodsList[j] = goodsList[j + 1];
//                            goodsList[j + 1] = emp;
//                        }
//                    }
//                }
//            }
//            else
//            {
//                for (int i = 0; i < goodsList.Count; i++)
//                {
//                    for (int j = 0; j < goodsList.Count - 1 - i; j++)
//                    {
//                        if (goodsList[j][str] < goodsList[j + 1][str])
//                        {
//                            Dictionary<string, dynamic> emp = new Dictionary<string, dynamic>();
//                            emp = goodsList[j];
//                            goodsList[j] = goodsList[j + 1];
//                            goodsList[j + 1] = emp;
//                        }
//                    }
//                }
//            }
//            //for (int i = 0; i < goodsList.Count; i++)
//            //{
//            //    Console.WriteLine(goodsList[i][str]);
//            //}
//            foreach(dynamic item in goodsList)
//            {
//                Console.WriteLine($"{item["name"]}--{item[str]}");
//            }
//            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
//{
//    new Dictionary<string, dynamic>
//    {
//        {"singerId", 1001},
//        {"singerName", "周杰伦"},
//        {"genre", "流行"}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"singerId", 1002},
//        {"singerName", "林俊杰"},
//        {"genre", "华语流行"}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"singerId", 1003},
//        {"singerName", "邓紫棋"},
//        {"genre", "流行、摇滚"}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"singerId", 1004},
//        {"singerName", "薛之谦"},
//        {"genre", "抒情流行"}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"singerId", 1005},
//        {"singerName", "毛不易"},
//        {"genre", "民谣流行"}
//    }
//};

//                List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
//{
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 10001},
//        {"singerId", 1001},
//        {"songName", "青花瓷"},
//        {"duration", 239}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 10002},
//        {"singerId", 1001},
//        {"songName", "发如雪"},
//        {"duration", 253}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 10003},
//        {"singerId", 1001},
//        {"songName", "东风破"},
//        {"duration", 215}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 1004},
//        {"singerId", 1002},
//        {"songName", "不为谁而作的歌"},
//        {"duration", 296}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 1005},
//        {"singerId", 1002},
//        {"songName", "背对背拥抱"},
//        {"duration", 262}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 1006},
//        {"singerId", 1003},
//        {"songName", "泡沫"},
//        {"duration", 262}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 1007},
//        {"singerId", 1004},
//        {"songName", "认真的雪"},
//        {"duration", 262}
//    },
//    new Dictionary<string, dynamic>
//    {
//        {"songId", 1008},
//        {"singerId", 1005},
//        {"songName", "消愁"},
//        {"duration", 262}
//    }
//};
//            // 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
//            Console.WriteLine("请输入歌手姓名：");
//            string singer = Console.ReadLine(); // 周杰伦
//            int id = 0;
//            for (int i = 0; i < singerList.Count; i++)
//            {
//                if (singerList[i]["singerName"] == singer)
//                {
//                    id = singerList[i]["singerId"]; break;
//                }
//            }
//            string s = "";
//            for (int i = 0; i < songList.Count; i++)
//            {
//                if (id == songList[i]["singerId"]) s = s + songList[i]["songName"] + " ";
//            }
//            Console.WriteLine(s);
//            //2、通过歌曲查找歌手
//                Console.WriteLine("输入歌曲名称：");
//            string song = Console.ReadLine();
//            int singerid = 0;
//            for (int i = 0; i < songList.Count; i++)
//            {
//                if (songList[i]["songName"] == song)
//                {
//                    //Console.WriteLine(song);
//                    singerid = songList[i]["singerId"]; break;
//                }
//            }
//            string singername = "";
//            for (int i = 0; i < singerList.Count; i++)
//            {
//                if (singerid == singerList[i]["singerId"])
//                {
//                    //Console.WriteLine(singerid);
//                    singername = singerList[i]["singerName"];
//                }
//            }
//            if(singername == "")
//            {
//                Console.WriteLine("该曲目还没有收录进数据库亲");
//            }
//            else
//            {
//                Console.WriteLine(singername);
//            }
        }
        }
    }
