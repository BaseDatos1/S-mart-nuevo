using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart
{
    public partial class InsertarSucursal : Form
    {
        public InsertarSucursal()
        {
            InitializeComponent();

            textBox1.Text = "Ej: 4512";
            textBox1.ForeColor = Color.Gray;
            textBox5.Text = "Ej: 000000000";
            textBox5.ForeColor = Color.Gray;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }


        //Textbox1 --> ID SUCURSAL
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ej: 4512";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ej: 4512")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        //Textbox5 --> CEDULA ADMIN
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ej: 000000000";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Ej: 000000000")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }



    }
}
