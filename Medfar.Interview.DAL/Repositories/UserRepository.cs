using Medfar.Interview.Types;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Medfar.Interview.DAL.Repositories
{
    public class UserRepository
    {
        private static string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MEDFAR_DEV_INTERVIEW;Integrated Security=True";
        private static SqlConnection _dbConnection;

        public UserRepository()
        {
        }

        public List<User> GetAll()
        {
            _dbConnection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM Users", _dbConnection);

            _dbConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<User> messages = new List<User>();
            while (reader.Read())
            {
                User message = new User
                {
                    Id = (Guid)reader["id"],
                    Last_name = (string)reader["last_name"],
                    First_name = (string)reader["first_name"],
                    Email = (string)reader["email"],
                    Date_created = (DateTime)reader["date_created"]
                };

                messages.Add(message);
            }
            return messages;
        }

        public List<User> GetById(Guid id)
        {
            _dbConnection = new SqlConnection(_connectionString);

            string sqlQuery = @"SELECT * FROM" +
                              " Users " +
                              "WHERE id = '" + id +"'";
            SqlCommand command = new SqlCommand(sqlQuery, _dbConnection);

            _dbConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<User> messages = new List<User>();
            while (reader.Read())
            {
                User message = new User
                {
                    Id = (Guid)reader["id"],
                    Last_name = (string)reader["last_name"],
                    First_name = (string)reader["first_name"],
                    Email = (string)reader["email"],
                    Date_created = (DateTime)reader["date_created"]
                };

                messages.Add(message);
            }
            return messages;
        }

        public int Insert(User u)
        {
            _dbConnection = new SqlConnection(_connectionString);

            string sqlQuery = @"INSERT INTO" +
                              " Users " +
                              "values ('" + u.Id + "', '" + u.Last_name + "', '" + u.First_name + "', '" + u.Email + "', '" + u.Date_created + "')";

            using (SqlCommand command = new SqlCommand(sqlQuery, _dbConnection))
            {
                _dbConnection.Open();

                int nbresult = command.ExecuteNonQuery();

                return nbresult;
            }
        }

        public int Update(User u)
        {
            _dbConnection = new SqlConnection(_connectionString);

            string sqlQuery = @"UPDATE   " +
                              " Users" +
                              " SET last_name='" + u.Last_name + "', first_name='" + u.First_name + "', email='" + u.Email + "', date_created='" + u.Date_created + "' " +
                              "WHERE id= '" + u.Id + "'";

            SqlCommand command = new SqlCommand(sqlQuery, _dbConnection);
            _dbConnection.Open();

            int nbresult = command.ExecuteNonQuery();

            return nbresult;
        }

        public int Delete(User u)
        {
            _dbConnection = new SqlConnection(_connectionString);

            string sqlQuery = @"DELETE FROM  " +
                                 " Users " +
                                 " WHERE id= '" + u.Id + "'";

            SqlCommand command = new SqlCommand(sqlQuery, _dbConnection);

            _dbConnection.Open();

            int nbresult = command.ExecuteNonQuery();

            return nbresult;
        }

    }
}