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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD conex = new ConexionBD();
            if (conex.probarConexion())
            {
                MessageBox.Show("La conexion se ha realizado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recargar();
        }

        public void recargar()
        {
            ConexionBD conex = new ConexionBD();
            dataGridView1.DataSource = conex.Get();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.ShowDialog();
            recargar();
        }


        private int? selectID()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? idEquipo = selectID();
            if(idEquipo != null)
            {
                Form2 formulario2 = new Form2(idEquipo);
                formulario2.ShowDialog();
                recargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int? idEquipo = selectID();
                if (idEquipo != null)
                {
                    ConexionBD conex = new ConexionBD();
                    conex.EliminarDatos((int)idEquipo);
                    recargar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar" + ex.Message);
            }
        }
    }
}
