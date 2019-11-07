using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Services
{
    public class Parcial : Interfaces.IParcial
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private SqlDataAdapter dataAdapter = null;

        /// <summary>
        /// Consulta la tabla de posiciones
        /// </summary>
        /// <returns>TABLA DE POSICIONES</returns>
        public List<Models.DB.Parcial> GetParcials()
        {
            try
            {
                var listParcials = new List<Models.DB.Parcial>();

                connection = Data.ConnectionParcial.GetConnection();
                command = new SqlCommand("Pa_TablePositions", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataSet result = new DataSet();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);

                foreach (DataRow item in result.Tables[0].Rows)
                {
                    listParcials.Add(new Models.DB.Parcial
                    {
                        Id_Position = Convert.ToInt32(item["Position"]),
                        Id_Team = Convert.ToInt32(item["Id_Team"]),
                        Name_Team = item["NameTeam"].ToString(),
                        Points = Convert.ToInt32(item["Points"]), 
                        MatchesPlay = Convert.ToInt32(item["MatchesPlay"]),
                        GoalsFavor = Convert.ToInt32(item["GoalsFavor"]),
                        GoalsAgains = Convert.ToInt32(item["GoalsContra"])
                    });
                }

                return listParcials;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
