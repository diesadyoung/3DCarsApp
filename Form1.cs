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

        private void Form1_Load(object sender, EventArgs e)
        {

            guna2DataGridView1.Rows.Add(7);

            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\1.png");
            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\2.png");

            guna2DataGridView1.Rows[0].Cells[1].Value = "Audi A7 2020";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Audi E-Tron 2020";
            // Add Photos to datagrid
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < guna2DataGridView1.Rows.Count)
            {
                cpt++;
                guna2PictureBox1.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
               

                guna2PictureBox2.Load("..\\Debug\\Pics\\" + cpt.ToString()+cpt.ToString() + ".png");
                guna2PictureBox3.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox4.Image = guna2PictureBox1.Image;
                // Uploading next photo from lib
            }
            else cpt = 1;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                guna2PictureBox1.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;


                guna2PictureBox2.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox3.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox4.Image = guna2PictureBox1.Image;
                // Uploading previusly photo from lib
            }
            else cpt = 1;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = guna2PictureBox2.Image;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = guna2PictureBox3.Image;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = guna2PictureBox4.Image;
        }
    }
}
