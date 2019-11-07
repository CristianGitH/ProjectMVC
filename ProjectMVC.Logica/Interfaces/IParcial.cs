using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Interfaces
{
    public interface IParcial
    {
        List<Models.DB.Parcial> GetParcials();
    }
}
