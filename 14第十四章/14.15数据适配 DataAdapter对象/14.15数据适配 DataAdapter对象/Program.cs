using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _14._15数据适配_DataAdapter对象
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sqlwxg;database=winform";
            SqlConnection mycon = new SqlConnection(constr);
            try
            {
                //mycon.Open();
                //string sql = "select * from mytable001";
                //SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                //DataSet myds = new DataSet();
                //myda.Fill(myds, "mytable001");

                //Console.WriteLine("填充成功");
                //OutValues(myds);

                //Console.ReadKey();

                //更改数据源文件
                mycon.Open();
                DataSet myds = new DataSet();
                //myds.Reset();
                
                SqlDataAdapter myda = new SqlDataAdapter("select * from wxgtable", mycon);

                
                myda.Fill(myds, "wxgtable");//acceptchange处于true状态
                Console.WriteLine("原dataset对象内容");
                
                string updatesql = "update wxgtable set gender='女' where name='杜小月'";
                myda.UpdateCommand = new SqlCommand(updatesql, mycon);
                //myda.Fill(myds, "wxgtable");
                DataRow row = myds.Tables[0].Rows[3];
                row["gender"] = "女";
                myda.Update(myds, "wxgtable");
                myda.Fill(myds, "wxgtable");
                Console.WriteLine("更改后dataset对象内容");

                OutValues(myds);






            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }
            Console.ReadKey();
        }   
         public static void OutValues(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("表名:" + dt.TableName);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col]+"\t");
                    }
                    Console.WriteLine();

                }
            }
        }
       
    }
}
