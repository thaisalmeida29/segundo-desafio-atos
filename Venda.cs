using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_vendas
{
    public class Venda
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public List<ItemVenda> ItemVendas { get; set; } = new List<ItemVenda>();

        public decimal ValorTotalVenda => ItemVendas.Sum(i => i.PrecoTotal);


        public bool gravarVenda()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into venda output inserted.idVenda values (@idCliente, @valorTotal);";
            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Decimal);
          
            command.Parameters[0].Value = this.IdCliente;
            command.Parameters[1].Value = this.ValorTotalVenda;

            try
            {
                int idVenda = Convert.ToInt32(command.ExecuteScalar());
                command.Parameters.Clear();

                foreach (ItemVenda itemVenda  in ItemVendas)
                {
                    command.CommandText = "insert into itemVenda values (@idProduto, @idVenda, @quantidade, @valorTotal);";
                    command.Parameters.Add("@idProduto", SqlDbType.Int);
                    command.Parameters.Add("@idVenda", SqlDbType.Int);
                    command.Parameters.Add("@quantidade", SqlDbType.Int);
                    command.Parameters.Add("@valorTotal", SqlDbType.Decimal);

                    command.Parameters[0].Value = itemVenda.IdProduto;
                    command.Parameters[1].Value = idVenda;
                    command.Parameters[2].Value = itemVenda.Quantidade;
                    command.Parameters[3].Value = itemVenda.PrecoTotal;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                tran.Commit();
                return true;
            }
            catch (Exception ex)
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

    public class ItemVenda
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoTotal { get; set; }
    }
}
