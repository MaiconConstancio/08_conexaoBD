﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_conexaoBD
{
    internal class ConexaoFlexivel
    {
        string host = "localhost";
        string banco = "08_lista_tarefas";
        string usuario = "root";
        string senha = "senac";

        MySqlConnection conexao;

        public ConexaoFlexivel()
        {
            string dadosConexao = $"Server={host}; Database={banco}; Uid = {usuario}; Pwd={senha};";
            conexao = new MySqlConnection(dadosConexao);
            
            
        }
        public void executaQuery( string query)
        {
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader dados = comando.ExecuteReader();

            Console.WriteLine("---------------");
            if (dados.HasRows == false)
            {
                Console.WriteLine("Nenhum resultado encontrado :z ");
            }

            while (dados.Read() == true)
            {
                Console.WriteLine($"Descrição da tarefa {dados[0]} - {dados["descricao"]}");
            }


            conexao.Close();
        }
    
    
    }
}
