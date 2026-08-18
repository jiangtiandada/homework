using System.ComponentModel;

namespace day10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Action wrireLog = () => {
            //    string str = Console.ReadLine();
            //    var time = DateTime.Now;
            //    File.AppendAllText(@"./content.log",$"{str+time}\n");
            //};
            ////wrireLog();
            //Func<string, int> isFile0rDic = path => {
            //    if (File.Exists(path)) return 1;
            //    if(Directory.Exists(path)) return 2;
            //    return 0;
            //};
            //Func<string, List<string>> fileAndDic = path =>
            //{
            //    if (isFile0rDic(path) != 2) throw new Exception("路径异常错误");
            //    string[] files = Directory.GetFiles(path);
            //    List<string> list = new List<string>();
            //    list.AddRange(files);
            //    string[] dics = Directory.GetDirectories(path);
            //    list.AddRange(dics);
            //    return list;
            //};
            //List<string> list = fileAndDic("./");
            //foreach (string file in list) Console.WriteLine(file);
            //void gitIn()
            //{
            //    Console.WriteLine("请输入用户名和密码：");
            //    string userName = Console.ReadLine();
            //    string password = Console.ReadLine();
            //    File.AppendAllText("./user.txt", $"userName= {userName} password= {password}\n");
            //    File.AppendAllText("./user.txt", "===\n");
            //}
            //gitIn();
            //Book library1 = new Book("./books.txt");
            ////library1.queryName();
            //Random r = new Random();
            //Dictionary<string, dynamic> book1 = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "西游记",
            //    ["author"] = "施耐庵",
            //    ["isBorrow"] = false, // false表示还在书库中，true表示外借
            //    ["id"] = r.NextDouble(),
            //    ["mark"] = "西游、魔幻",
            //    ["price"] = 56.09 // 价格
            //};
            //Dictionary<string, dynamic> book2 = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "三国演义",
            //    ["author"] = "罗贯中",
            //    ["isBorrow"] = true, // false表示还在书库中，true表示外借
            //    ["id"] = r.NextDouble(),
            //    ["mark"] = "言情、武侠",
            //    ["price"] = 56.09 // 价格
            //};
            ////library1.add(book1);
            ////library1.add(book2);
            //book1["isBorrow"] = true;
            ////library1.upDate(book1);
            //library1.delete("西游记");
            Book library = new Book("./book.json");
            string name = "";
            string author = "";
            bool isBorrow = false;
            string mark = "";
            double price = 0.0; 
            string num = "";
             
            while (num!="0") {
                Console.WriteLine("=====欢迎来到图书管理=====");
                Console.WriteLine("1: 新增书籍");
                Console.WriteLine("2: 编辑书籍");
                Console.WriteLine("3: 删除书籍");
                Console.WriteLine("4: 查找单个书籍");
                Console.WriteLine("5: 查找全部书籍");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入书籍名称：");
                        name = Console.ReadLine();
                        Console.WriteLine("请输入作者：");
                        author  = Console.ReadLine();
                        Console.WriteLine("请输入类型：");
                        mark = Console.ReadLine();
                        Console.WriteLine("请输入价格：");
                        price = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> bookDic = new ()
                        {
                            ["name"] = name,
                            ["author"] = author,
                            ["isBorrow"] = false, // false表示还在书库中，true表示外借
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price // 价格
                        };
                        library.add(bookDic);
                        break;
                    case "2":
                        Console.WriteLine("你要修改的书籍");
                        name = Console.ReadLine();
                        Console.WriteLine("请依次输入你要修改的内容（author isBorrow mark price）");
                        string str = Console.ReadLine();
                        string[] strArr = str.Split();
                        Console.WriteLine("请按照你输入的顺序输入修改的内容(中间用空格隔开)");
                        string str1 = Console.ReadLine();
                        string[] strArr1 = str1.Split();
                        library.upDate(name, strArr, strArr1);
                        break;
                    case "3":
                        Console.WriteLine("你要删除的书籍");
                        name = Console.ReadLine();
                        library.delete(name);
                        break;
                    case "4":
                        Console.WriteLine("请输入你要查询的书籍名称：");
                        name = Console.ReadLine();
                        library.SearchBook(name);
                        break;
                    case "5":
                        library.SearchBook();
                        break;
                    case "0":
                        Console.WriteLine("--退出--");
                        break;
                    default:
                        num = "6";
                        Console.WriteLine("输入有误");
                        break;
                }
            }
        }
    }
}
