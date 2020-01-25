using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Puzzle
{
    class PICTURES
    {
        CONNECTION conn = new CONNECTION();

        public void deletePic()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Pictures";
            command.Connection = conn.getConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public bool insertPic(int parent, string poz, string name, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Pictures(PicParent,PicPoz,PicName,Pic) VALUES(@par,@poz,@nm,@pi)";
            command.Connection = conn.getConnection();

            //@par,@poz,@nm,@pi
            command.Parameters.Add("par", SqlDbType.Int).Value = parent;
            command.Parameters.Add("poz", SqlDbType.VarChar).Value = poz;
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("pi", SqlDbType.Image).Value = pic.ToArray();

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public DataTable getPic(string poz)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Pic FROM Pictures WHERE PicPoz=@poz";
            command.Connection = conn.getConnection();

            command.Parameters.Add("poz", SqlDbType.VarChar).Value = poz;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
