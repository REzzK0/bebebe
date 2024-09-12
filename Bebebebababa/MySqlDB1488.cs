using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bebebebababa
{
    public class MySqlDB1488
    {
        MySqlConnection mySqlConnection;
        public MySqlDB1488()
        {
            MySqlConnectionStringBuilder stringBuilder = new();
            stringBuilder.UserID = "student";
            stringBuilder.Password = "student";
            stringBuilder.Database = "SALUKI_1135uuuuuuu";
            stringBuilder.Server = "192.168.200.13";
            stringBuilder.CharacterSet = "utf8mb4";
            mySqlConnection = new MySqlConnection(stringBuilder.ToString());
            OpenConnection();
        }

        private bool OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
