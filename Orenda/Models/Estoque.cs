using System.Data.SqlClient;

namespace Orenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estoque")]
    public partial class Estoque
    {
        [Key]
        public int cod_est { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "date")]
        public DateTime mpVal { get; set; }

        private readonly static string _conn =
            @"Data Source=DESKTOP-3NC3AOG;Initial Catalog=Orenda;Integrated Security=SSPI;Persist Security Info=False;";
        private static SqlConnection myConnection = new SqlConnection(_conn);
        //public bool Cadastrar()
        //{
            //var sql = " insert into Clientes (cliNome, cliCPF, endereco, cidade, estado, ativo) values(" +
            //          $" '{this.Nome}' ,{this.CPF}, '{this.Endereco}', '{this.Cidade}', '{this.Estado}', '{this.Situacao}')";
            //try
            //{
            //    using (var minhaConnection = new SqlConnection(_conn))
            //    {
            //        {
            //            minhaConnection.Open();
            //            using (var cmd = new SqlCommand(sql, minhaConnection))
            //            {
            //                using (var dr = cmd.ExecuteReader())
            //                {
            //                    return true;
            //                }
            //            }
            //        }
            //    }

            //}
            //catch (Exception)
            //{
            //    myConnection.Close();
            //    return (false);
            //}
        //}
    }
}
