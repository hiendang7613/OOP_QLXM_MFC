using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLXM.DAO
{
	class ConnectionFactory
	{
		private static ConnectionFactory connectionFactory = null;

		String connectionString = "Data Source=localhost;Initial Catalog=QLCHXM;Integrated Security=True";

		private ConnectionFactory()
		{

		}

		public SqlConnection getConnection()
		{
			return new SqlConnection(connectionString);
		}

		public static ConnectionFactory getInstance()
		{
			if (connectionFactory == null)
			{
				connectionFactory = new ConnectionFactory();
			}
			return connectionFactory;
		}

	}
}
