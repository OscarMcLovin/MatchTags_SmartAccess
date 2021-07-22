using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchTags_SmartAccess.DataAccess.DAO;
using MatchTags_SmartAccess.DataAccess.DTO;

namespace MatchTags_SmartAccess.Forms
{
    public partial class Fraccionamientos : Form
    {
        DataAccess.SAEntities db = new DataAccess.SAEntities();
        DataAccess.Fraccionamiento fr = new DataAccess.Fraccionamiento();
        public Fraccionamientos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fraccionamientos_Load(object sender, EventArgs e)
        {
            var lcalles = from c in db.Fraccionamiento
                          select new { c.Nombre };
            cmboxFraccionamientos.DataSource = lcalles.ToList();
            cmboxFraccionamientos.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fraccionamiento = ( from c in db.Fraccionamiento //tablafraccionamiento
                    where c.Nombre == cmboxFraccionamientos.Text
                          select new FraccionamientoDTO { IdFraccionamiento = c.IdFraccionamiento, IP = c.IP, 
                          Nombre = c.Nombre, PswSql = c.PswSql, PuertoSql = c.PuertoSql, ServerSql = c.ServerSql, UserSql = c.UserSql} ).FirstOrDefault();

             var listtags = TagsDAO.ObtenerTagsByFracc(fraccionamiento);


            //foreach (var i in l)
            //{
            //    string ip = i.ip;
            //    string pass = i.pswsql;
            //    string user = i.usersql;
            //    string server = i.serversql;
            //    messagebox.show(" la conexión con bd  contiene la ip " + ip + " y el password " + pass + " el usuario es " + user +
            //       " el servidor es " + server);
            //}
        }
    }
}
