using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPDP
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        class StringOps
        {
            public string Reemplazar(string s)
            {
                return s.Replace(' ', '-');
            }

            public string Remover(string s)
            {
                string temp = "";
                int i;
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                    {
                        temp += s[i];
                    }
                }
                return temp;
            }
            public string Invertir(string s)
            {
                string temp = "";
                int i, j;
                for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                {
                    temp += s[i];
                }
                return temp;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringOps so = new StringOps();
            StrMod strOp = so.Reemplazar;
            string str;

            str = strOp(cadena.Text);
            string mensaje = "La cadena resultante es:\t\t \n\n" + "\t" + str;
            MessageBoxButtons boton = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "Reemplazar espacios", boton);
        }

        delegate string StrMod(string str);

        private void button1_Click(object sender, EventArgs e)
        {
            StringOps so = new StringOps();
            StrMod strOp = so.Remover;
            string str;

            str = strOp(cadena.Text);
            string mensaje = "La cadena resultante es:\t\t \n\n" + "\t" + str;
            MessageBoxButtons boton = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "Remover espacios", boton);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StringOps so = new StringOps();
            StrMod strOp = so.Invertir;
            string str;

            str = strOp(cadena.Text);
            string mensaje = "La cadena resultante es:\t\t \n\n" + "\t" + str;
            MessageBoxButtons boton = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "Invertir Cadena", boton);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnReemplazar.Enabled = false;
            btnInvertir.Enabled = false;
        }

        private void controlbotones()
        {
            if(cadena.Text.Trim() != string.Empty)
            {
                btnEliminar.Enabled=true;
                btnReemplazar.Enabled=true;
                btnInvertir.Enabled=true;
                errorProvider1.SetError(cadena, "");
            }
            else
            {
                if(cadena.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(cadena, "Debe introducir una cadena.");
                }
                btnEliminar.Enabled = false;
                btnReemplazar.Enabled = false;
                btnInvertir .Enabled = false;
                cadena.Focus();
            }
        }

        private void cadena_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }

    }
}
