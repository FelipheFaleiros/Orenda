using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Orenda.Models
{
    public class Produtos
    {
        public string Nome { get; set; }
        public decimal CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Situacao { get; set;}

        private readonly static string _conn =
            @"Data Source=DESKTOP-3NC3AOG;Initial Catalog=Orenda;Integrated Security=SSPI;Persist Security Info=False;";
        private static SqlConnection myConnection = new SqlConnection(_conn);
        public bool Cadastrar()
        {
            var sql = " insert into Clientes (cliNome, cliCPF, endereco, cidade, estado, ativo) values(" + 
                      $" '{this.Nome}' ,{this.CPF}, '{this.Endereco}', '{this.Cidade}', '{this.Estado}', '{this.Situacao}')" ;
            try
            {
                using (var minhaConnection = new SqlConnection(_conn))
                {
                    {
                        minhaConnection.Open();
                        using (var cmd = new SqlCommand(sql, minhaConnection) )
                        {
                            using (var dr=cmd.ExecuteReader())
                            {
                                return true;
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                myConnection.Close();
                return (false);
            }
        }
    }
}