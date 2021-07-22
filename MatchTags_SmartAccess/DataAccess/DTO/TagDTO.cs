using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTags_SmartAccess.DataAccess.DTO
{
    public class TagDTO
    {
        public int IdTag { get; set; }
        public string RFID { get; set; }
        public string Identity { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
