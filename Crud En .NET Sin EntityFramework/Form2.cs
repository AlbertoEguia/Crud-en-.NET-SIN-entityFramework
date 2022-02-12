using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_En.NET_Sin_EntityFramework
{
    public partial class Form2 : Form
    {
        private int? idEquipo;

        public Form2(int? idEquipo=null)
        {
            InitializeComponent();
            
            this.idEquipo = idEquipo;
            if(this.idEquipo != null)
                load();
          
        }


        private void load()
        {
            ConexionBD conex = new ConexionBD();
            Datos dat = conex.GetEdit((int)idEquipo);
            txtNombre.Text = dat.NombreEquipo.ToString();
            txtChampions.Text = dat.Champions.ToString();
            txtLigas.Text = dat.Ligas.ToString();
            txtCopasRey.Text = dat.CopasDelRet.ToString();
            txtSupercopas.Text = dat.Supercopas.ToString(); 
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                if (idEquipo == null)
                    conexion.IngresarDatos(txtNombre.Text, int.Parse(txtChampions.Text), int.Parse(txtLigas.Text), int.Parse(txtCopasRey.Text), int.Parse(txtSupercopas.Text));
                else
                    conexion.EditarDatos(txtNombre.Text, int.Parse(txtChampions.Text), int.Parse(txtLigas.Text), int.Parse(txtCopasRey.Text), int.Parse(txtSupercopas.Text), (int)idEquipo); 
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
    }
}
