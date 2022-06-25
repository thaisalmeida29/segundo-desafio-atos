using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_vendas
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Estado { get; set; }

        public string Cpf { get; set; }

        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into cliente values (@nome, @email, @telefone, @estado, @cpf);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@estado", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters[0].Value = this.Nome;
            command.Parameters[1].Value = this.Email;
            command.Parameters[2].Value = this.Telefone;
            command.Parameters[3].Value = this.Estado;
            command.Parameters[4].Value = this.Cpf;
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