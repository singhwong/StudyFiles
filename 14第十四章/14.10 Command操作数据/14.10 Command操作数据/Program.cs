using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._10_Command操作数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=csharpzxw";
            SqlConnection myCon = new SqlConnection(constr);
            try
            {
                ////创建Command对象过程
                //myCon.Open();
                //string sql = "select * from mytable001";
                //SqlCommand myCom = new SqlCommand(sql,myCon);
                //myCom.CommandTimeout = 2;
                //Console.WriteLine("创建对象成功");

                ////更改数据,ExecuteNonQuery()
                //myCon.Open();
                //string sql = "insert mytable001(name,gender,age,department)values('雪上行者','男',35,'开发部')";
                //SqlCommand myCom = new SqlCommand(sql,myCon);
                //myCom.ExecuteNonQuery();
                //Console.WriteLine("数据更改完成");

                //ExecuteScalar
                myCon.Open();
                string sql = "select min(age) from mytable001";
                SqlCommand myCom = new SqlCommand(sql,myCon);
                int t = 0;
               t=(int) myCom.ExecuteScalar();
                Console.WriteLine("年龄最小的是"+t+"岁");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                myCon.Close();
            }
            Console.ReadKey();

        }

    }
}
