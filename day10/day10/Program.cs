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
            //Library library1 = new Library();
            //library1.book("./books.txt");
            //library1.queryName();
            void gitIn()
            {
                Console.WriteLine("请输入用户名和密码：");
                string userName = Console.ReadLine();
                string password = Console.ReadLine();
                File.AppendAllText("./user.txt", $"userName= {userName} password= {password}\n");
                File.AppendAllText("./user.txt", "===\n");
            }
        gitIn();
    }
    }
}
