using MatchTags_SmartAccess.DataAccess.DAO;
using MatchTags_SmartAccess.DataAccess.DTO;
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
    public partial class Login : Form
    {
        DataAccess.Usuario usu = new DataAccess.Usuario();
        DataAccess.Bitacora bi = new DataAccess.Bitacora();
        DataAccess.ErrorLog el = new DataAccess.ErrorLog();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenLogin()
        {
            try
            {
                Form ex = checkStateForm("Login");
                if (ex == null)
                    VisualizarFormas(new Login());
                else
                {
                    ex.WindowState = FormWindowState.Normal;
                    ex.Activate();
                }
            }
            catch
            {

            }
        }

        private static Form checkStateForm(string formName)
        {
            return Application.OpenForms.OfType<Form>().Where(pre => pre.Name == formName).SingleOrDefault<Form>();
        }

        private void VisualizarFormas(Form form)
        {
            form.Show();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            usu.NombreUsuario = textBoxuSER.Text.Trim();
            usu.Contrasena = textBoxPaSS.Text.Trim();
            using (DataAccess.SAEntities db = new DataAccess.SAEntities())
            {
                var usu = from u in db.Usuario
                          where u.NombreUsuario == textBoxuSER.Text.Trim() && u.Contrasena == textBoxPaSS.Text.Trim()
                          select u;

                if (usu.Count() > 0)
                {
                    try
                    {
                        string Name = "";
                        string Ape = "";
                        foreach (var i in usu)
                        {
                            Name = i.Nombre;
                            Ape = i.Apellido;

                        }
                        bi.DescripcionBitacora = "El usuario " + Name.Trim() + " inició sesión";
                        bi.FechaBitacora = DateTime.Now;
                        db.Bitacora.Add(bi);
                        db.SaveChanges();
                        Forms.Menu me = new Forms.Menu();
                        me.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        el.Error = "" + ex;
                        el.Modulo = "Login";
                        el.Fecha = DateTime.Now;
                        db.ErrorLog.Add(el);
                        db.SaveChanges();
                        MessageBox.Show("No se pudo acceder al sistema " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningun Usuario con el nombre " + textBoxuSER.Text.Trim());
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
