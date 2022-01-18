using QLXM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM.DAO
{
    class ManufacturerDAO : DAO<Manufacturer>
    {
        private static ManufacturerDAO manufacturerDAO = null;
        SqlParameter ManuIdPmt;
        SqlParameter ManuNamePmt;

        void NewParameter()
        {
            ManuIdPmt = new SqlParameter();
            ManuIdPmt.ParameterName = "@ManuId";
            ManuIdPmt.SqlDbType = SqlDbType.Int;

            ManuNamePmt = new SqlParameter();
            ManuNamePmt.ParameterName = "@ManuName";
            ManuNamePmt.SqlDbType = SqlDbType.VarChar;
        }
        private ManufacturerDAO()
        {
        }

        public static ManufacturerDAO getInstance()
        {
            if (manufacturerDAO == null)
            {
                manufacturerDAO = new ManufacturerDAO();
            }
            return manufacturerDAO;
        }

        SqlConnection connection;


        public Manufacturer get(long id)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();
                    ManuIdPmt.Value = id;

                    string queryString = "SELECT * FROM Manufacturer WHERE ManuId = @ManuId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(ManuIdPmt);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Manufacturer(int.Parse(reader["MotorId"].ToString()), reader["MotorName"].ToString());
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Manufacturer> get(Manufacturer manufacturer)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    NewParameter();

                    string queryString = "SELECT * FROM Manufacturer";
                    bool first = true;

                    if (manufacturer.Id != 0)
                    {
                        if (first)
                        {
                            first = false;
                            queryString += " WHERE ";
                        }
                        else
                        {
                            queryString += " AND ";
                        }
                        queryString += " ManuId = @ManuId ";
                        ManuIdPmt.Value = manufacturer.Id;
                        command.Parameters.Add(ManuIdPmt);
                    }

                    if (manufacturer.Name != "")
                    {
                        if (first)
                        {
                            first = false;
                            queryString += " WHERE ";
                        }
                        else
                        {
                            queryString += " AND ";
                        }
                        queryString += " ManuName = @ManuName ";
                        ManuNamePmt.Value = manufacturer.Name;
                        command.Parameters.Add(ManuNamePmt);
                    }

                    command.CommandText = queryString;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();

                    List<Manufacturer> manufacturers = new List<Manufacturer>();
                    while (reader.Read())
                    {
                        manufacturers.Add(new Manufacturer(int.Parse(reader["ManuId"].ToString()),
                            reader["ManuName"].ToString()
                            ));
                    }

                    return manufacturers;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Manufacturer> getAll()
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    string queryString = "SELECT * FROM Manufacturer";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Manufacturer> manufacturers = new List<Manufacturer>();
                    while (reader.Read())
                    {
                        Manufacturer manufacturer = new Manufacturer(
                            int.Parse(reader["ManuId"].ToString()),
                            reader["ManuName"].ToString()
                            );

                        manufacturers.Add(manufacturer);
                    }

                    return manufacturers;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool Insert(Manufacturer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    ManuIdPmt.Value = t.Id;
                    ManuNamePmt.Value = t.Name;

                    string queryString = "INSERT INTO Manufacturer(ManuId ,	ManuName) VALUES (@ManuId, @ManuName)";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(ManuIdPmt);
                    command.Parameters.Add(ManuNamePmt);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected < 1)
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;

        }

        public bool Update(Manufacturer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    ManuIdPmt.Value = t.Id;
                    ManuNamePmt.Value = t.Name;

                    string queryString = "UPDATE Manufacturer SET ManuName = @ManuName WHERE ManuId = @ManuId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(ManuIdPmt);
                    command.Parameters.Add(ManuNamePmt);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected < 1)
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }

        public bool Delete(Manufacturer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    ManuIdPmt.Value = t.Id;

                    string queryString = "DELETE FROM Manufacturer WHERE ManuId = @ManuId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(ManuIdPmt);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected < 1)
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }
    }
}
