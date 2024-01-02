using MySql.Data.MySqlClient;
using P12_1_714220039;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_1_714220039.controller
{
    internal class CekLogin
    { 
        Koneksi connect = new Koneksi();

        public bool cek_login(string username, string password)
        {
            try
            {
                connect.OpenConnection();
                MySqlDataReader reader = connect.reader("SELECT * FROM t_user WHERE username='" + username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    connect.CloseConnection();
                    return true;
                }
                else
                {
                    connect.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
