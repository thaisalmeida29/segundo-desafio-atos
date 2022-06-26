using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_vendas
{
    internal class Produto
    {
        public string CodEAN { get; set; }

        public string Nome { get; set; }

        public string Preco { get; set; }

        public string Estoque { get; set; }

        public string Marca { get; set; }

        public bool gravarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produto values (@codProduto, @nomeProduto, @preco, @estoque, @marca);";
            command.Parameters.Add("@codProduto", SqlDbType.VarChar);
            command.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Decimal);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters.Add("@marca", SqlDbType.VarChar);
            command.Parameters[0].Value = this.CodEAN;
            command.Parameters[1].Value = this.Nome;
            command.Parameters[2].Value = this.Preco;
            command.Parameters[3].Value = this.Estoque;
            command.Parameters[4].Value = this.Marca;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
