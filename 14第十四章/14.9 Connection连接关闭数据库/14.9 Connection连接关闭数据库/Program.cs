using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._9_Connection连接关闭数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据库的连接分为两种方式
            //SQL Server数据库
            //windows身份验证实验登录并打开数据库
            //string constr = "Server=.;integrated security=SSPI;Initial Catalog=csharpzxw";

            //SQL验证方式登录
            string constr = "Server=.;user=sa;pwd=sa;database=csharpzxw";

            SqlConnection mysqlCon = new SqlConnection(constr);
            //mysqlCon.Open();
            //Console.WriteLine("数据库成功打开");


            ////通过using语句实现数据库的关闭
            //using (mysqlCon)
            //{
            //    mysqlCon.Open();
            //    Console.WriteLine("数据库成功打开");
            //}

            ////通过try..catch...finally..实现数据库的实时关闭
            //try
            //{
            //    mysqlCon.Open();
            //    Console.WriteLine("数据库成功打开");
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    mysqlCon.Close();
            //    Console.WriteLine("数据库成功关闭");
            //}

            //using语句与try catch finally结合使用
            try
            {
                using (mysqlCon)
                {
                    mysqlCon.Open();
                    Console.WriteLine("成功打开");
                }
            }
            catch
            {

            }
            finally
            {
                mysqlCon.Close();
                Console.WriteLine("成功关闭");
            }


            Console.ReadKey();

        }
    }
}
