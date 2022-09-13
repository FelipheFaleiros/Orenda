using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Orenda.Models
{
    public class Usuarios
    {
        //private readonly static string _conn = @"Data Source=.\DESKTOP-3NC3AOG;AttachDbFilenameC:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\new.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        private readonly static string _conn = @"Data Source=DESKTOP-3NC3AOG;Initial Catalog=new;Integrated Security=SSPI;Persist Security Info=False;";

        public int Id { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        static void Main(string[] args)
        {
            SqlConnection minhaConnection =
                new SqlConnection(@"Data Source=DESKTOP-3NC3AOG;Initial Catalog=new;Integrated Security=SSPI;Persist Security Info=False;");
            
            minhaConnection.Open();
        }

        public bool Login()
        {


            var sql = "Select Id, Nome, Senha From Users Where Email = '" + this.Email + "' ";

            try
            {

                using (var minhConnection = new SqlConnection(_conn))
                {
                    minhConnection.Open();
                    using (var cmd = new SqlCommand(sql, minhConnection))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows) //se encontrou alguma linha
                            {
                                if (dr.Read())//vai ler
                                {
                                    if (this.Senha == dr["Senha"].ToString())
                                    {
                                        this.Id = Convert.ToInt32(dr["Id"]);
                                        this.Usuario = dr["Nome"].ToString();
                                        return true;
                                    }
                                }
                            }
                            return false;
                        }

                    }
                }
            }

            catch (Exception)
            {
                //Console.WriteLine(e);
                //return false;
                //throw new InvalidOperationException("Os dados não podem sem lidos", e);
                return false;
            }
        }
    }
}