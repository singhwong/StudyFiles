using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _14._16_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=Company";
            SqlConnection mycon = new SqlConnection(constr);
            try
            {
                mycon.Open();
                string sql = "select * from Clerk";
                SqlCommand mycom = new SqlCommand(sql, mycon);
                SqlDataReader mydr = mycom.ExecuteReader();
                Console.WriteLine("使用DataReader打印输出");
                for (int i = 0; i < mydr.FieldCount; i++)
                {
                    Console.Write(mydr.GetName(i)+"\t");
                }
                Console.WriteLine();
                while (mydr.Read())
                {
                    for(int i=0;i<mydr.FieldCount;i++)
                        Console.Write(mydr[i].ToString()+"\t");
                    Console.WriteLine();

                }
                                mydr.Close();
                Console.WriteLine("使用DataSet打印输出");
                SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                DataSet myds = new DataSet();
                myda.Fill(myds, "Clerk");
                foreach (DataTable table in myds.Tables)
                {
                    foreach(DataColumn col in table.Columns)
                        Console.Write(col.ColumnName+"\t");
                    Console.WriteLine();
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn col in table.Columns)
                            Console.Write(row[col] + "\t");
                        Console.WriteLine();
                    }
                }
               


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }
            Console.ReadKey();
        }
    }
}
