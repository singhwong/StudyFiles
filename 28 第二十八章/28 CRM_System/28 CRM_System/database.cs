using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _28_CRM_System
{
    class database
    {
        SqlConnection con;
        private void open()//开启 连接数据库
        {
            if (con == null)
            {
string constr = "server=.;database=CRM_database;user=sa;pwd=sa";
            con = new SqlConnection(constr);
            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void close()
        {
            if (con != null)
                con.Close();
        }

        private SqlCommand createcommand(string sqlStr)
        {
            open();
            SqlCommand com = new SqlCommand(sqlStr, con);
            return com;
        }

        public void runSql(string sqlStr)
        {
            SqlCommand cmd = createcommand(sqlStr);
            cmd.ExecuteNonQuery();
            close();
        }

        public int runSqlInt(string sqlStr)
        {
            SqlCommand cmd = createcommand(sqlStr);
            int t = (int)cmd.ExecuteScalar();
            close();
            return t;
        }

        public SqlDataReader runSql(string sqlStr, out SqlDataReader dr)
        {
            SqlCommand cmd = createcommand(sqlStr);
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public DataTable ConvertDataReaderToDataTable(SqlDataReader datareader)
        {
            DataTable dt = new DataTable();
            DataTable schemaTable = datareader.GetSchemaTable();
            try {
                foreach (DataRow myRow in schemaTable.Rows)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = System.Type.GetType("System.String");
                    dt.Columns.Add(myDataColumn);
                }
                while (datareader.Read())
                {
                    DataRow mydataRow = dt.NewRow();
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        mydataRow[i] = datareader[i].ToString();
                    }
                    dt.Rows.Add(mydataRow);
                    mydataRow = null;
                }
                schemaTable = null;
                datareader.Close();
                return dt;
            }
            catch(Exception ex) { throw new Exception("转换出错",ex); }
        }
    }
}
