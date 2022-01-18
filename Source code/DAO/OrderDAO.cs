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
    class OrderDAO : DAO<Order>
    {
        private static OrderDAO orderDAO = null;
        SqlParameter OrderIdPmt;
        SqlParameter TimeePmt;
        SqlParameter CustomerIdPmt;
        SqlParameter MotorIdPmt;

        private void NewParameter()
        {
            OrderIdPmt = new SqlParameter();
            OrderIdPmt.ParameterName = "@OrderId";
            OrderIdPmt.SqlDbType = SqlDbType.Int;

            TimeePmt = new SqlParameter();
            TimeePmt.ParameterName = "@Timee";
            TimeePmt.SqlDbType = SqlDbType.DateTime;

            CustomerIdPmt = new SqlParameter();
            CustomerIdPmt.ParameterName = "@CustomerId";
            CustomerIdPmt.SqlDbType = SqlDbType.Int;

            MotorIdPmt = new SqlParameter();
            MotorIdPmt.ParameterName = "@MotorId";
            MotorIdPmt.SqlDbType = SqlDbType.Int;
        }

        private OrderDAO()
        {
        }

        public static OrderDAO getInstance()
        {
            if (orderDAO == null)
            {
                orderDAO = new OrderDAO();
            }
            return orderDAO;
        }

        SqlConnection connection;

        public Order get(long id)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = id;

                    string queryString = "SELECT * FROM Orderr AS O LEFT JOIN OrderDetail AS OD ON O.OrderId = OD.OrderId WHERE O.OrderId = @OrderId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
                    SqlDataReader reader = command.ExecuteReader();

                    int MotorId = 0;
                    DateTime Timee = DateTime.Now;
                    Customer customer = null;
                    List<Motorbike> motorbikes = new List<Motorbike>();
                    if (reader.Read())
                    {
                        if (reader["MotorId"] != DBNull.Value)
                        {
                            MotorId = int.Parse(reader["MotorId"].ToString());
                            Motorbike motorbike = MotorbikeDAO.getInstance().get(int.Parse(reader["MotorId"].ToString()));
                            motorbikes.Add(motorbike);
                        }
                        Timee = DateTime.Parse(reader["Timee"].ToString());
                        customer = CustomerDAO.getInstance().get(int.Parse(reader["CustomerId"].ToString()));
                    }
                    else
                        return null;

                    while (reader.Read())
                    {
                        Motorbike motorbike = MotorbikeDAO.getInstance().get(int.Parse(reader["MotorId"].ToString()));
                        motorbikes.Add(motorbike);
                    }
                    return new Order((int)id, Timee, motorbikes, customer);

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


        public List<Order> get(Order order)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    NewParameter();

                    string queryString = "SELECT * FROM Orderr AS O LEFT JOIN OrderDetail AS OD ON  O.OrderId = OD.OrderId ";

                    bool first = true;
                    if (order.ID != 0)
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
                        queryString += " OrderId = @OrderId ";
                        OrderIdPmt.Value = order.ID;
                        command.Parameters.Add(OrderIdPmt);
                    }

                    if (order.Time != default)
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
                        queryString += " Timee = @Timee ";
                        TimeePmt.Value = order.Time;
                        command.Parameters.Add(TimeePmt);
                    }

                    if (order.Customer != null)
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
                        queryString += " O.CustomerId = @CustomerId ";
                        CustomerIdPmt.Value = order.Customer.ID;
                        command.Parameters.Add(CustomerIdPmt);
                    }

                    command.CommandText = queryString;
                    command.Connection = connection;


                    SqlDataReader reader = command.ExecuteReader();

                    List<Order> orders = new List<Order>();

                    int preId = 0;
                    while (reader.Read())
                    {
                        Motorbike motorbike = MotorbikeDAO.getInstance().get(int.Parse(reader["MotorId"].ToString()));

                        if (int.Parse(reader["OrderId"].ToString()) == preId)
                        {
                            Customer customer = CustomerDAO.getInstance().get(int.Parse(reader["CustomerId"].ToString()));

                            orders.Add(new Order(
                                int.Parse(reader["OrderId"].ToString()),
                                Convert.ToDateTime(reader["Timee"].ToString()),
                                new List<Motorbike>(),
                                customer
                            ));
                        }
                        orders[orders.Count - 1].Motorbikes.Add(motorbike);
                    }

                    return orders;
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
        public List<Order> getAll()
        {

            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    string queryString = "SELECT OrderId FROM Orderr";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Order> orders = new List<Order>();
                    while (reader.Read())
                    {
                        int OrderId = int.Parse(reader["OrderId"].ToString());
                        Order order = get(OrderId);
                        orders.Add(order);
                    }

                    return orders;
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

        public bool Insert(Order t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = t.ID;
                    TimeePmt.Value = t.Time;
                    CustomerIdPmt.Value = t.Customer.ID;

                    string queryString = "INSERT INTO Orderr(OrderId, Timee, CustomerId) VALUES (@OrderId, @Timee, @CustomerId)";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
                    command.Parameters.Add(TimeePmt);
                    command.Parameters.Add(CustomerIdPmt);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected < 1)
                        return false;

                    //for (int i = 0; i < t.Motorbikes.Count; i++)
                    //{
                    //    MotorIdPmt.Value = t.Motorbikes[i].ID;

                    //    queryString = "INSERT INTO OrderDetail(OrderId, MotorId) VALUES (@OrderId, @MotorId)";
                    //    command = new SqlCommand(queryString, connection);
                    //    command.Parameters.Add(OrderIdPmt);
                    //    command.Parameters.Add(MotorIdPmt);
                    //    rowsAffected = command.ExecuteNonQuery();
                    //    if (rowsAffected < 1)
                    //        return false;
                    //}
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

        public bool Update(Order t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = t.ID;
                    TimeePmt.Value = t.Time;
                    CustomerIdPmt.Value = t.ID;

                    string queryString = "UPDATE Order SET Timee = @Timee, CustomerId = @CustomerId WHERE OrderId = @OrderId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
                    command.Parameters.Add(TimeePmt);
                    command.Parameters.Add(CustomerIdPmt);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected < 1)
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

        public bool Delete(Order t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = t.ID;

                    string queryString = "DELETE FROM Orderr WHERE OrderId = @OrderId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
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

        public bool DeleteMotor(int orderID, int motorID)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = orderID;
                    MotorIdPmt.Value = motorID;

                    string queryString = "DELETE FROM OrderDetail WHERE OrderId = @OrderId AND MotorId = @MotorId ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
                    command.Parameters.Add(MotorIdPmt);
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

        public bool InsertMotor(int orderID, int motorID)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    OrderIdPmt.Value = orderID;

                    MotorIdPmt.Value = motorID;

                    string queryString = "INSERT INTO OrderDetail(OrderId, MotorId) VALUES (@OrderId, @MotorId)";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(OrderIdPmt);
                    command.Parameters.Add(MotorIdPmt);
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
