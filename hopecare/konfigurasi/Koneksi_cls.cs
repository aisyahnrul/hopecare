using hopecare.Properties;
using MySql.Data.MySqlClient; // tambahkan ini
using SIREMBA.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hopecare.konfigurasi
{
    internal class Koneksi_cls : Konfigurasi_cls
    {
        MySqlConnection _connection; //buat koneksi jaringan lokal ataupun yang lain
        MySqlCommand _command; // untuk insert update delete 
        MySqlDataAdapter _adapter; // untuk data, menampung data hasil query select

        //string _link = "server=192.168.0.2;port=3306;uid=pbo;pwd=wahyu;database=siremba";


        static string[] data = Setting.ambilSeting("setting.txt");

        string _link = data[0] + ";" + data[1] + ";" + data[2] + ";" + data[3] + ";" + data[4];

        // buat constructor
        public Koneksi_cls()
        {
            _connection = new MySqlConnection(_link);
            _command = new MySqlCommand();
            _adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (Exception ex) { }
        }


        void tutupKoneksi()
        {
            _connection.Close();
        }


        public override int eksekusiNonQuery(string query)
        {
            int retVal = -1;
            try
            {
                bukaKoneksi();
                _command.Connection = _connection;
                _command.CommandText = query;
                retVal = _command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }
            return retVal;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable retVal = new DataTable();
            try
            {
                bukaKoneksi();
                _command.Connection = _connection;
                _command.CommandText = query;
                // retVal = _command.ExecuteNonQuery();
                _adapter.SelectCommand = _command;
                _adapter.Fill(retVal);
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }
            return retVal;
        }
    }
}
