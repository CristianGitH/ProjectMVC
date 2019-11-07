using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Parcial
    {
        public int Id_Position { get; set; }
        public int Id_Team { get; set; }
        public string Name_Team { get; set; }
        public int Points { get; set; }
        public int MatchesPlay { get; set; }
        public int GoalsFavor { get; set; }
        public int GoalsAgains { get; set; }
    }
}
