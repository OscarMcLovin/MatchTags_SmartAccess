using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchTags_SmartAccess
{
    public partial class AggTag : Form
    {
        DataAccess.SAEntities db = new DataAccess.SAEntities();
        DataAccess.Fraccionamiento fr = new DataAccess.Fraccionamiento();
        public AggTag()
        {
            InitializeComponent();
        }

        
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Forms.Tags v1 = new Forms.Tags();
            v1.Show();
        }

        private void btn_ConectarAntena_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conexión con BD " + btn_ConectarAntena.Text + " exitosa.");
        }
    }
}
