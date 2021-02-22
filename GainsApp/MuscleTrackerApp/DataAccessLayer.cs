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
    *  Function             getExerciseTypes
    *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
    *    Parameters
    *     Returns           SqlDataReader
    ***********/

        public SqlDataReader GetExerciseTypes()
        {
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ExerciseType", sqlConnection);

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

        /*****************.
                *  Function             AddExercise
                *   Description         Method that, if successful, adds an Exercise in the database. 
                *    Parameters         string exerciseTypeName, string exerciseName, int weightAmount, int setsAmount, int repsAmount, string bodyParts, int kcalBurned
                *     Returns           
                ***********/

        public void AddËxercise(string exerciseTypeName, string exerciseName, int weightAmount, int setsAmount, int repsAmount, string bodyParts, int kcalBurned)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Exercise (exerciseTypeName, exerciseName, weightAmount, setsAmount, repsAmount, " +
                    "bodyParts, kcalBurned) VALUES(@exerciseTypeName, @exerciseName, @weightAmount, @setsAmount, @repsAmount, @bodyParts, @kcalBurned) ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@exerciseTypeName", exerciseTypeName);
                    sqlCommand.Parameters.AddWithValue("@exerciseName", exerciseName);
                    sqlCommand.Parameters.AddWithValue("@weightAmount", weightAmount);
                    sqlCommand.Parameters.AddWithValue("@setsAmount", setsAmount);
                    sqlCommand.Parameters.AddWithValue("@repsAmount", repsAmount);
                    sqlCommand.Parameters.AddWithValue("@bodyParts", bodyParts); 
                    sqlCommand.Parameters.AddWithValue("@kcalBurned", kcalBurned);



                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

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

        /*****************.
                *  Function             GetExercise
                *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
                *    Parameters         string exerciseTypeName
                *     Returns           SqlDataReader
             ***********/
        public SqlDataReader GetExercises(string exerciseTypeName)
        {
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT exerciseTypeName, exerciseName, weightAmount, setsAmount, repsAmount, bodyParts, " +
                "kcalBurned FROM Exercise WHERE exerciseTypeName = '" + exerciseTypeName + "'", sqlConnection);

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

        /*****************.
   *  Function             RemoveExercise
   *   Description         Method that, if successful, removes an Exercise from the database.
   *    Parameters         string exerciseName, string exerciseTypeName
   *     Returns           
   ***********/

        public void RemoveOffice(string exerciseName, string exerciseTypeName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Exercise WHERE " +
                    "exerciseTypeName = '" + exerciseTypeName + "' AND exerciseName = '" + 
                    exerciseName + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

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

        /*****************.
             *  Function             editExercise
             *   Description         Method that, if successful, edits an Exercise within the database.
             *    Parameters         string exerciseTypeName, string exerciseName, int weightAmount, int setsAmount, int repsAmount, string bodyParts, int kcalBurned
             *      Returns           
             ***********/

        public void EditExercise(string exerciseTypeName, string exerciseName, int weightAmount, int setsAmount, int repsAmount, string bodyParts, int kcalBurned)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE Exercise SET weightAmount = '" + weightAmount + "', setsAmount = " + setsAmount + "', repsAmount = " 
                    + repsAmount + "', bodyParts = " + bodyParts + "', kcalBurned = " + kcalBurned + " WHERE exerciseName = '" + exerciseName + "' AND exerciseTypeName = '" 
                    + exerciseTypeName + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        //int result = - kan användas senare för error handling
                        sqlCommand.ExecuteNonQuery();

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

    }
}
