using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTags_SmartAccess.DataAccess.DTO
{
    public class FraccionamientoDTO
    {
        public int IdFraccionamiento { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string ServerSql { get; set; }
        public string PuertoSql { get; set; }
        public string UserSql { get; set; }
        public string PswSql { get; set; }       
    }
}
