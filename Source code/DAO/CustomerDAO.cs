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
    class CustomerDAO : DAO<Customer>
    {
        private static CustomerDAO customerDAO = null;
        SqlParameter CustomerIdPmt;
        SqlParameter FullnamePmt;
        SqlParameter PhonePmt;

        private void NewParameter()
        {
            CustomerIdPmt = new SqlParameter();
            CustomerIdPmt.ParameterName = "@CustomerId";
            CustomerIdPmt.SqlDbType = SqlDbType.Int;

            FullnamePmt = new SqlParameter();
            FullnamePmt.ParameterName = "@Fullname";
            FullnamePmt.SqlDbType = SqlDbType.VarChar;

            PhonePmt = new SqlParameter();
            PhonePmt.ParameterName = "@Phone";
            PhonePmt.SqlDbType = SqlDbType.VarChar;
        }

        private CustomerDAO()
        {
        }

        public static CustomerDAO getInstance()
        {
            if (customerDAO == null)
            {
                customerDAO = new CustomerDAO();
            }
            return customerDAO;
        }

        SqlConnection connection;

        public Customer get(long id)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();
                    CustomerIdPmt.Value = id;

                    string queryString = "SELECT * FROM Customer WHERE CustomerId = @CustomerId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(CustomerIdPmt);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Customer(int.Parse(reader["CustomerId"].ToString()),
                            reader["Fullname"].ToString(),
                            reader["Phone"].ToString()
                            );
                    }
                    else
                        return null;
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


        public List<Customer> get(Customer customer)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    NewParameter();

                    string queryString = "SELECT * FROM Customer";
                    bool first = true;

                    if (customer.ID != 0)
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
                        queryString += " CustomerId = @CustomerId ";
                        CustomerIdPmt.Value = customer.ID;
                        command.Parameters.Add(CustomerIdPmt);
                    }

                    if (customer.Fullname != "")
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
                        queryString += " Fullname = @Fullname ";
                        FullnamePmt.Value = customer.Fullname;
                        command.Parameters.Add(FullnamePmt);
                    }

                    if (customer.Phone != "")
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
                        queryString += " Phone = @Phone ";
                        PhonePmt.Value = customer.Phone;
                        command.Parameters.Add(PhonePmt);
                    }

                    command.CommandText = queryString;
                    command.Connection = connection;


                    SqlDataReader reader = command.ExecuteReader();

                    List<Customer> customers = new List<Customer>();
                    while (reader.Read())
                    {
                        customers.Add( new Customer(int.Parse(reader["CustomerId"].ToString()),
                            reader["Fullname"].ToString(),
                            reader["Phone"].ToString()
                            ));
                    }

                    return customers;
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

        public List<Customer> getAll()
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    string queryString = "SELECT * FROM Customer";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Customer> customers = new List<Customer>();
                    while (reader.Read())
                    {
                        Customer customer = new Customer(int.Parse(reader["CustomerId"].ToString()),
                            reader["Fullname"].ToString(),
                            reader["Phone"].ToString()
                            );

                        customers.Add(customer);
                    }

                    return customers;
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

        public bool Insert(Customer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    CustomerIdPmt.Value = t.ID;
                    FullnamePmt.Value = t.Fullname;
                    PhonePmt.Value = t.Phone;

                    string queryString = "INSERT INTO Customer(CustomerId, Fullname, Phone) VALUES (@CustomerId, @Fullname, @Phone)";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(CustomerIdPmt);
                    command.Parameters.Add(FullnamePmt);
                    command.Parameters.Add(PhonePmt);
                    command.ExecuteNonQuery();
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

        public bool Update(Customer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    CustomerIdPmt.Value = t.ID;
                    FullnamePmt.Value = t.Fullname;
                    PhonePmt.Value = t.Phone;

                    string queryString = "UPDATE Customer SET Fullname = @Fullname, Phone = @Phone WHERE CustomerId = @CustomerId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(CustomerIdPmt);
                    command.Parameters.Add(FullnamePmt);
                    command.Parameters.Add(PhonePmt);
                    command.ExecuteNonQuery();
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

        public bool Delete(Customer t)
        {
            try
            {
                using (connection = ConnectionFactory.getInstance().getConnection())
                {
                    connection.Open();

                    NewParameter();

                    CustomerIdPmt.Value = t.ID;

                    string queryString = "DELETE FROM Customer WHERE CustomerId = @CustomerId";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(CustomerIdPmt);
                    command.ExecuteNonQuery();
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
