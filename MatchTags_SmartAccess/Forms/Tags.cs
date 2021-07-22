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
    public partial class Tags : Form
    {
        DataAccess.SAEntities db = new DataAccess.SAEntities();
        DataAccess.Fraccionamiento fr = new DataAccess.Fraccionamiento();
        public Tags()
        {
            InitializeComponent();
        }
private void Tags_Load(object sender, EventArgs e)
        {
            var lcalles = from c in db.Bitacora
                          select c;
            dgvTags.DataSource = lcalles.ToList();
        }
        

        private void dgvTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;
                switch (e.ColumnIndex)
                {
                    case 0:
                        //iID = (dgvTags.Rows[e.RowIndex].Cells["Folio"].FormattedValue).ToString();
                        //ID = int.Parse(iID);
                        //var updateVisi = db.AccFracc_VisitaNoProgramada.Find(ID);
                        //DateTime salida = DateTime.Now;
                        //updateVisi.FechaSalida = salida;
                        //db.Entry(updateVisi).State = System.Data.Entity.EntityState.Modified;
                        //db.SaveChanges();
                        //MessageBox.Show(updateVisi.NombreVisitante.Trim() + " ha salido de " + updateVisi.DireccionVisita.Trim() + " " + updateVisi.Numero.Trim() + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                }
                //var lcalles = from c in db.AccFracc_VisitaNoProgramada
                //              where c.FechaSalida == null
                //              select new { Folio = c.IdVisitaNoProgramada, c.NombreVisitante, Direccion = c.DireccionVisita + " # " + c.Numero, c.Placas };
                //dgvSalida.DataSource = lcalles.ToList();
                //db = new ACCFRACCEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTags_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.lapiz.Width;
                var h = Properties.Resources.lapiz.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.lapiz, new System.Drawing.Rectangle(x, y, w, h)); e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();

            AggTag v1 = new AggTag();
            v1.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
