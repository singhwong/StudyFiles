using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _14._13_数据集DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Dataset对象
            DataSet myds = new DataSet("csharp51zxw");
            DataTable mydt = new DataTable("mytable001");
            myds.Tables.Add(mydt);
            DataColumn mydcol1 = new DataColumn("id",Type.GetType("System.Int32"));
            DataColumn mydcol2 = new DataColumn("name", Type.GetType("System.String"));
            DataColumn mydcol3 = new DataColumn("department", Type.GetType("System.String"));
            mydt.Columns.Add(mydcol1);
            mydt.Columns.Add(mydcol2);
            mydt.Columns.Add(mydcol3);
            string[,] mystr = { { "张三", "开发部" }, { "李四", "销售部" }, { "王五", "技术支持部" }, { "赵六", "人事部" }, { "刘七", "项目部" } };
            for (int i = 0; i < mystr.Length / 2; i++)
            {
                DataRow myrow = mydt.NewRow();
                myrow[0] = i+1;
                myrow["name"] = mystr[i, 0];
                myrow[2] = mystr[i, 1];
                mydt.Rows.Add(myrow);
            }
            myds.AcceptChanges();
            Console.WriteLine("更改前的数据");
            outValues(myds);

            DataTable mydt002 = mydt.Clone();
            DataRow mydr = mydt002.NewRow();
            mydt002.Rows.Add(new object[] { 6,"王二小","技术部"});
            mydt002.Rows.Add(new object[] { 7, "张小虎", "开发部" });
            myds.Merge(mydt002);//将mydt002及其架构合并到myds中
            Console.WriteLine("\n"+"合并后的数据集");
            outValues(myds);
            DataSet myds001 = myds.Copy();
            DataSet myds002 = myds.Clone();
            Console.WriteLine("COPY结果");
            outValues(myds001);
            Console.WriteLine("Clone结果");
            outValues(myds002);

       




            Console.ReadKey();
                        





        }
        public static void outValues(DataSet ds)//实现遍历dataset
        {
            foreach (DataTable outtable in ds.Tables)
            {
                Console.WriteLine("表名称:" + outtable.TableName);
                foreach (DataRow outdr in outtable.Rows)
                {
                    foreach(DataColumn outdcol in outtable.Columns)
                        Console.Write(outdr[outdcol]+"\t");
                    Console.WriteLine();

                }
            }
        }
    }
}
