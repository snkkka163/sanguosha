using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace 三国杀
{
    //数据库连接类
    class DB
    {
       static string DBType = ConfigurationManager.AppSettings["DBType"];
       static string database = ConfigurationManager.AppSettings["database"];
       static string username = ConfigurationManager.AppSettings["username"];
       static string password = ConfigurationManager.AppSettings["password"];

        static string connStr = null;
        private SqlConnection conn;

        public SqlConnection Conn
        {
            get {
                if (conn == null) {
                    // 初始化链接
                    switch (DBType) { 
                        case "sql_server":
                            connStr = "Data Source=.;initial Catalog=" + database + ";User=" + username + ";pwd=" + password + ";";
                            break;
                        // 还需要其他数据库链接的话自己写，作者的.NET只连接过SQL Server数据库
                    }
                    conn = new SqlConnection(connStr);
                }    
                return conn;
            }
            set { conn = value; }
        }
        //打开数据库
        public void dbOpen() {
            if(Conn.State==ConnectionState.Closed){
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Broken) {
                Conn.Close();
                Conn.Open();
            }
        }
        public void dbClose() {
            if (Conn.State == ConnectionState.Broken || Conn.State == ConnectionState.Open) {
                Conn.Close();
            }
        }

       //数据库快捷查询
        public string Select(string sql) {
            SqlCommand comm = new SqlCommand(sql, Conn);
            return comm.ExecuteScalar().ToString();
        }
    }
}
