using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            Data();
        }
        //Método para agregar filas y columnas al DataGridView
        private void Data()
        {
            DataGridViewTextBoxColumn cl1 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn cl2 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn cl3 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                ReadOnly = true
            };
            dgvEjemplo.Columns.AddRange(cl1, cl2, cl3);
            string nombre = "Juan", estado = "Nuevo León";
            for (int i = 1; i < 30; i++)
            {
                dgvEjemplo.Rows.Add(i.ToString(), nombre, estado);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 2);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DGVDisenio.Formato(dgvEjemplo, 7);
        }
    }
}
