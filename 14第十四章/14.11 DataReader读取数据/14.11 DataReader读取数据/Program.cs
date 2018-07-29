using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._11_DataReader读取数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=csharpzxw";
            SqlConnection mycon = new SqlConnection(constr);
            try
            {
                mycon.Open();
                string sql = "select * from mytable001 where gender='男'";
                SqlCommand mycom = new SqlCommand(sql,mycon);
                //声明datareader
                SqlDataReader mydr;
                mydr = mycom.ExecuteReader();
                if (mydr.HasRows)
                {
                    Console.WriteLine("mytable001中存在数据");
                }
                else
                {
                    Console.WriteLine("mytable001不存在任何数据");
                }
                //Console.WriteLine(mydr.FieldCount);
                //Console.WriteLine(mydr.IsClosed);
                //Console.WriteLine(mydr.GetDataTypeName(1));
                //string mystr = "age";
                //Console.WriteLine(mydr.GetOrdinal(mystr));
                //if(mydr.Read())
                //Console.WriteLine(mydr.GetValue(1));

                //object[] myobj = new object[mydr.FieldCount];

                //while(mydr.Read())
                //{ mydr.GetValues(myobj);
                //    foreach (object outobj in myobj) Console.Write(outobj + "\t");
                //    Console.WriteLine();

                //}

                while (mydr.Read())
                {
                    Console.Write(mydr[0].ToString()+",");
                    Console.Write(mydr[1].ToString()+",");
                    Console.Write(mydr["gender"].ToString()+",");
                    Console.Write(mydr["department"].ToString());

                    Console.WriteLine();
                }

                mydr.Close();
                //Console.WriteLine(mydr.IsClosed);
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
