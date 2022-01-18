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
    class MotorbikeDAO : DAO<Motorbike>
    {
        private static MotorbikeDAO motorbikeDAO = null;
        SqlParameter MotorIdPmt;
        SqlParameter MotorNamePmt;
        SqlParameter ManuIdPmt;
        SqlParameter CostPmt;

        private void NewParameter()
        {
            MotorIdPmt = new SqlParameter();
            MotorIdPmt.ParameterName = "@MotorId";
            MotorIdPmt.SqlDbType = SqlDbType.Int;

            MotorNamePmt = new SqlParameter();
            MotorNamePmt.ParameterName = "@MotorName";
            MotorNamePmt.SqlDbType = SqlDbType.VarChar;

            ManuIdPmt = new SqlParameter();
            ManuIdPmt.ParameterName = "@ManuId";
            ManuIdPmt.SqlDbType = SqlDbType.Int;

            CostPmt = new SqlParameter();
            CostPmt.ParameterName = "@Cost";
            CostPmt.SqlDbType = SqlDbType.Int;
        }

        private MotorbikeDAO()
        {
        }

        public static MotorbikeDAO getInstance()
        {
            if (motorbikeDAO == null)
            {
                motorbikeDAO = new MotorbikeDAO();
            }
            return motorbikeDAO;
        }

        SqlConnection connection;


        public Motorbike get(long id)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    MotorIdPmt.Value = id;

                    string queryString = "SELECT * FROM Motorbike AS MT, Manufacturer AS MN WHERE MotorId = @MotorId AND MT.ManuId = MN.ManuId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(MotorIdPmt);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Manufacturer manufacturer = new Manufacturer(int.Parse(reader["ManuId"].ToString()), reader["ManuName"].ToString());

                        return new Motorbike(
                            int.Parse(reader["MotorId"].ToString()),
                            reader["MotorName"].ToString(),
                            manufacturer,
                            int.Parse(reader["Cost"].ToString())
                        );

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


        public List<Motorbike> get(Motorbike motorbike)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    NewParameter();

                    string queryString = "SELECT * FROM Motorbike AS MT, Manufacturer AS MN WHERE MT.ManuId = MN.ManuId";

                    if (motorbike.ID != 0)
                    {
                        queryString += " AND ";
                        queryString += " MotorId = @MotorId ";
                        MotorIdPmt.Value = motorbike.ID;
                        command.Parameters.Add(MotorIdPmt);
                    }

                    if (motorbike.Name != "")
                    {
                        queryString += " AND ";
                        queryString += " MotorName = @MotorName ";
                        MotorNamePmt.Value = motorbike.Name;
                        command.Parameters.Add(MotorNamePmt);
                    }

                    if (motorbike.Manufacturer.Name != "")
                    {
                        queryString += " AND ";
                        queryString += " MT.ManuName = @ManuId ";
                        ManuIdPmt.Value = motorbike.Manufacturer.Name;
                        command.Parameters.Add(ManuIdPmt);
                    }
                    command.CommandText = queryString;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();

                    List<Motorbike> motorbikes = new List<Motorbike>();
                    while (reader.Read())
                    {
                        Manufacturer manufacturer = new Manufacturer(int.Parse(reader["ManuId"].ToString()), reader["ManuName"].ToString());

                        motorbikes.Add(new Motorbike(
                            int.Parse(reader["MotorId"].ToString()),
                            reader["MotorName"].ToString(),
                            manufacturer,
                            int.Parse(reader["Cost"].ToString())
                        ));

                    }

                    return motorbikes;
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

        public List<Motorbike> getAll()
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    string queryString = "SELECT * FROM Motorbike AS MT, Manufacturer AS MN WHERE MT.ManuId = MN.ManuId";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Motorbike> motorbikes = new List<Motorbike>();
                    while (reader.Read())
                    {
                        Manufacturer manufacturer = new Manufacturer(int.Parse(reader["ManuId"].ToString()), reader["ManuName"].ToString());

                        motorbikes.Add(new Motorbike(
                            int.Parse(reader["MotorId"].ToString()),
                            reader["MotorName"].ToString(),
                            manufacturer,
                            int.Parse(reader["Cost"].ToString())
                        ));

                    }

                    return motorbikes;
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

        public bool Insert(Motorbike t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    MotorIdPmt.Value = t.ID;
                    MotorNamePmt.Value = t.Name;
                    ManuIdPmt.Value = t.Manufacturer.Id;
                    CostPmt.Value = t.Cost;

                    string queryString = "INSERT INTO Motorbike(MotorId, MotorName, ManuId,Cost) VALUES (@MotorId, @MotorName, @ManuId,@Cost)";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(MotorIdPmt);
                    command.Parameters.Add(MotorNamePmt);
                    command.Parameters.Add(ManuIdPmt);
                    command.Parameters.Add(CostPmt);
                    int count = command.ExecuteNonQuery();
                    if (count < 1)
                    {
                        return false;
                    }
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

        public bool Update(Motorbike t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    MotorIdPmt.Value = t.ID;
                    MotorNamePmt.Value = t.Name;
                    ManuIdPmt.Value = t.Manufacturer.Id;
                    CostPmt.Value = t.Cost;

                    string queryString = "UPDATE Motorbike SET MotorName = @MotorName, ManuId = @ManuId, Cost = @Cost WHERE MotorId = @MotorId ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(MotorIdPmt);
                    command.Parameters.Add(MotorNamePmt);
                    command.Parameters.Add(ManuIdPmt);
                    command.Parameters.Add(CostPmt);
                    int count = command.ExecuteNonQuery();
                    if (count < 1)
                    {
                        return false;
                    }
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

        public bool Delete(Motorbike t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    MotorIdPmt.Value = t.ID;

                    string queryString = "DELETE FROM Motorbike WHERE MotorId = @MotorId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(MotorIdPmt);
                    int count = command.ExecuteNonQuery();
                    if (count < 1)
                    {
                        return false;
                    }
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
