﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Desafio_vendas
{
    /// <summary>
    /// classe genérica para conectar e realizar operações em uma base de dados
    /// </summary>
    internal class Banco
    {
        string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=db_Venda;TrustServerCertificate=True;Integrated Security=True";
        /* private string stringConexao = "Data Source=localhost; Initial Catalog=ATOSUFN; User ID=usuario; password='senha';language=Portuguese";*/
        /*private string stringConexao = "ConfigurationManager.ConnectionStrings['ATOSUFN'].ConnectionString";*/
        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}

