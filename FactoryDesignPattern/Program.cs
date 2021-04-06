using System;
using System.Data;
using System.Data.Common;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                static void Main(string[] args)
                {
                    DbProviderFactory provider = null;
                    DbConnection con = null;
                    DbCommand cmd = null;
                    DbDataReader rdr = null;
                    DataTable dt = new DataTable();
                    provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
                    con = provider.CreateConnection();   //Create Connection according to Connection Class  
                    con.ConnectionString = "Data Source=SOURAV-PC\\SQL_INSTANCE;Initial Catalog=test;Integrated Security=True";
                    cmd = provider.CreateCommand();   //Create command according to Provider         
                    try
                    {
                        cmd.CommandText = "select * from name";
                        cmd.CommandType = CommandType.Text;
                        if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                        {
                            con.Open();
                            cmd.Connection = con;
                            using (con)
                            {
                                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                                while (rdr.Read())
                                {
                                    Console.WriteLine(rdr["nametest"].ToString());
                                    Console.WriteLine(rdr["surname"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        //trn.Rollback();  
                        con.Dispose();
                        cmd.Dispose();
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
    

