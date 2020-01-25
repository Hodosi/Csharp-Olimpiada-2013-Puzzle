using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Puzzle
{
    class CLASAMENT
    {
        CONNECTION conn = new CONNECTION();

        public bool deletUser(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Clasament WHERE IdUser=@id";
            command.Connection = conn.getConnection();

            //@par,@poz,@nm,@pi
            command.Parameters.Add("id", SqlDbType.Int).Value = id;

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

        public bool insertClasament(string nume, string timp, int patrate)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Clasament(Nume,Timp,Patratele) VALUES(@nm,@timp,@pat)";
            command.Connection = conn.getConnection();

            //@nm,@timp,@pat
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;
            command.Parameters.Add("timp", SqlDbType.VarChar).Value = timp;
            command.Parameters.Add("pat", SqlDbType.Int).Value = patrate;

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

        public DataTable getClasament()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Clasament";
            command.Connection = conn.getConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
