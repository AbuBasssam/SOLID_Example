using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ValidationExample
{
    public class PersonRepositary:IPersonRepositary
    {
        private readonly string _ConnectionString;
        public PersonRepositary (string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public bool CheckExistAsync(string NationalNo)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParameter);
                        connection.Open();
                         command.ExecuteNonQuery();
                        return (int)returnParameter.Value == 1;
                    }



                }


            }
            catch (Exception ex)
            {
                //clsEventLog.SetEventLog(ex.Message, EventLogEntryType.Error);

            }

            return false;

        }
    }
}
