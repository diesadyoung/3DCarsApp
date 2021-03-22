using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cpt = 1;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.Rows.Add(7);

            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("C:\\Users\\Nick Picasso\\source\\repos\\11111\\bin\\Debug\\Pics\\audi-a7.png");
            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("N:\\Downloads\\audi-e-tron.png");
             
            guna2DataGridView1.Rows[0].Cells[1].Value = "Audi A7 2020";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Audi E-Tron 2020";
            // Add Photos
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < guna2DataGridView1.Rows.Count)
            {
                guna2PictureBox1.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;


                guna2PictureBox2.Load("C:\\Users\\Nick Picasso\\source\\repos\\11111\\bin\\Debug\\Pics\\" + cpt.ToString()+cpt.ToString() + ".png");
                guna2PictureBox3.Load("C:\\Users\\Nick Picasso\\source\\repos\\11111\\bin\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox3.Image = guna2PictureBox1.Image;
                cpt++;
            }
            else cpt = 1;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                guna2PictureBox1.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;


                guna2PictureBox2.Load("C:\\Users\\Nick Picasso\\source\\repos\\11111\\bin\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox3.Load("C:\\Users\\Nick Picasso\\source\\repos\\11111\\bin\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox3.Image = guna2PictureBox1.Image;
                cpt--;
            }
            else cpt = 1;
        }
    }
}
