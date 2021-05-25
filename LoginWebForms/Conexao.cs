using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWebForms
{
    public class Conexao
    {
        #region Parâmetro Conexão
        private static string Server = "localhost";
        private static string Database = "web_session";
        private static string User = "root";
        private static string Password = "654321";

        private static string connectionString = $@"Server={Server};Database={Database};Uid={User};PWd={Password};Sslmode=nome;Charset=utf8";
        private static MySqlConnection Connection = new MySqlConnection(connectionString);
        #endregion

        #region conectar - desconectar
        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        #endregion
    }
}