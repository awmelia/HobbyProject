using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscleTrackerApp
{
    class DataAccessLayer
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Server=localhost;Database=Smart Office 2.0;User Id = user2.0; Password = losen";
        
        public SqlConnection SqlConnection { get => SqlConnection; set => SqlConnection = value; }

        /*****************.
           *  Function             closeConnection()
           *   Description         Method that closes the SqlConnection object of this instance.
           *    Parameters
           *     Returns           
           ***********/
        public void CloseConnection()
        {
            sqlConnection.Close();
        }

        /*****************.
    *  Function             getExercises
    *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
    *    Parameters
    *     Returns           SqlDataReader
    ***********/

        public SqlDataReader GetExercises()
        {
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Exercise", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                return dataReader;
            }
            catch (SqlException e)
            {

                throw e;

            }
            catch (Exception e)
            {
                throw e;
            }


        }


    }
}
