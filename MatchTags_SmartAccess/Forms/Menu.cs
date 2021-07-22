using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchTags_SmartAccess.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            Fraccionamientos fr = new Fraccionamientos();
            fr.Show();
        }

        private void AccesoVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Tags v1 = new Tags();
            v1.Show();
        }
    }
}
