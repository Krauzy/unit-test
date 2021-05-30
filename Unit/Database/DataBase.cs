using System;
using System.Data;
using System.Data.SqlClient;

namespace Unit.Database
{
    class DataBase
    {
        private string strcon;
        private SqlConnection con;
        private SqlTransaction trans;

        private static DataBase instance;

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        private DataBase()
        {

            this.strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Trbry\Documents\Unit\Unit\Sales.mdf;Integrated Security=True;Connect Timeout=30";
            con = null;
            trans = null;
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                result = true;
            }
            catch (Exception e)
            {
                // MessageBox.Show(null, "Falha de Conexão: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public void Disconnect()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(null, "Erro de Consulta: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExecuteNonQuery(String sql, params Object[] parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                //string n = sql;
                //for (int i = 0; i < parametros.Length; i += 2)
                //    n = n.Replace(parametros[i].ToString(), parametros[i + 1].ToString());
                //TextFile.Write(path, "[" + Program.Global_User + "]:[" + DateTime.Now + "] " + n.ToUpper());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(null, "Erro de Execução: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int GetIdentity()
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null && o != DBNull.Value)
                return Convert.ToInt32(o);
            else
                return 0;
        }

        public int getMax(string coluna, string tabela)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select MAX(" + coluna + ") as maximo from " + tabela, con);
                cmd.Transaction = trans;

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                int i = (int)dr["maximo"];
                dr.Close();
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO:" + e.Message);
                return 0;
            }

        }
    }
}
