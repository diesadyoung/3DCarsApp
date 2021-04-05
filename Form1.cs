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
            guna2DataGridView1.Rows[2].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\3.png");
            guna2DataGridView1.Rows[3].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\4.png");
            guna2DataGridView1.Rows[4].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\5.png");
            guna2DataGridView1.Rows[5].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\6.png");
            guna2DataGridView1.Rows[6].Cells[0].Value = Image.FromFile("..\\Debug\\Pics\\7.png");


            guna2DataGridView1.Rows[0].Cells[1].Value = "Audi A4";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Audi A5 Coupe";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Audi A5 Sportback";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Audi A6";
            guna2DataGridView1.Rows[4].Cells[1].Value = "Audi A7 Sportback";
            guna2DataGridView1.Rows[5].Cells[1].Value = "Audi Q3 Sportback";
            guna2DataGridView1.Rows[6].Cells[1].Value = "Audi A8";
            // Add Photos to datagrid
            guna2DataGridView1.Rows[0].Cells[2].Value = "Технические характеристики A4 Sedan\nМодель: 35 TFSI front\nМаксимальная мощность, л. с.при об/ мин: 150/4500\nПривод: Передний привод Разгон с 0 до 100 км / ч: 8,9 с\nОбъем топливного бака: 54 л\nРазрешенная полная масса: 2040 кг";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Технические характеристики A5 Coupe\nМодель: 35 TFSI front\nМаксимальная мощность, л. с.при об/мин: 150/4500\nПривод: Передний привод Разгон с 0 до 100 км/ч: 8,9 с\nОбъем топливного бака: 54 л\nРазрешенная полная масса: 1965 кг";
            guna2DataGridView1.Rows[2].Cells[2].Value = "Технические характеристики A5 Sportback\nМодель: 40 TFSI S front\nМаксимальная мощность, л. с. при об/мин: 190/4200-6000\nПривод: Передний привод\nРазгон с 0 до 100 км/ч: 7,5 с\nОбъем топливного бака: 54 л\nРазрешенная полная масса: 2070 кг";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Технические характеристики A6\nМодель: 35 TFSI front\nМаксимальная мощность, л. с. при об/мин: 150/3900-6000\nПривод: Передний привод\nРазгон с 0 до 100 км/ч: 8,9 с\nОбъем топливного бака: 54 л\nРазрешенная полная масса: 1965 кг";
            guna2DataGridView1.Rows[4].Cells[2].Value = "Технические характеристики A7 Sportback\nМодель: 45 TFSI quattro S tronic\nМаксимальная мощность, л. с. при об/мин: 245/5000-6500\nПривод: Передний привод\nРазгон с 0 до100км/ч: 6,2 с\nОбъем топливного бака: 73 л\nРазрешенная полная масса: 2375 кг";
            guna2DataGridView1.Rows[5].Cells[2].Value = "Технические характеристики Q3 Sportback\nМодель: 35 TFSI S tronic\nМаксимальная мощность, л. с. при об/мин: 150/5000-6000\nПривод: Передний привод\nРазгон с 0 до 100 км/ч: 9,2 с\nОбъем топливного бака: 76 л\nРазрешенная полная масса: 2070 кг";
            guna2DataGridView1.Rows[6].Cells[2].Value = "Технические характеристики A8\nМодель: 55 TFSI quattro\nМаксимальная мощность, л. с. при об/мин: 340/5000-6400\nПривод: quattro\nРазгон с 0 до 100 км/ч: 5,6 с\nОбъем топливного бака: 82 л\nРазрешенная полная масса: 2680 кг";

            guna2DataGridView1.Rows[0].Cells[3].Value = "24.999$";
            guna2DataGridView1.Rows[1].Cells[3].Value = "28.999$";
            guna2DataGridView1.Rows[2].Cells[3].Value = "31.499$";
            guna2DataGridView1.Rows[3].Cells[3].Value = "32.999$";
            guna2DataGridView1.Rows[4].Cells[3].Value = "35.999$";
            guna2DataGridView1.Rows[5].Cells[3].Value = "35.999$";
            guna2DataGridView1.Rows[6].Cells[3].Value = "45.999$";

            guna2DataGridView1.Rows[0].Cells[4].Value = "87";
            guna2DataGridView1.Rows[1].Cells[4].Value = "90";
            guna2DataGridView1.Rows[2].Cells[4].Value = "92";
            guna2DataGridView1.Rows[3].Cells[4].Value = "94";
            guna2DataGridView1.Rows[4].Cells[4].Value = "97";
            guna2DataGridView1.Rows[5].Cells[4].Value = "96";
            guna2DataGridView1.Rows[6].Cells[4].Value = "99";

            guna2DataGridView1.Rows[0].Cells[5].Value = "пр. Независимости, 198";
            guna2DataGridView1.Rows[1].Cells[5].Value = "ул. Серова, 1";
            guna2DataGridView1.Rows[2].Cells[5].Value = "пр. Независимости, 198";
            guna2DataGridView1.Rows[3].Cells[5].Value = "пр. Независимости, 198";
            guna2DataGridView1.Rows[4].Cells[5].Value = "ул. Серова, 1";
            guna2DataGridView1.Rows[5].Cells[5].Value = "пр. Независимости, 198";
            guna2DataGridView1.Rows[6].Cells[5].Value = "ул. Серова, 1";
            
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < guna2DataGridView1.Rows.Count)
            {
                cpt++;
                guna2PictureBox1.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                label2_NameCar.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                label1_about.Text = guna2DataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                label3_price.Text = guna2DataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                label1_rate.Text = guna2DataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                label1_geoloc.Text = guna2DataGridView1.Rows[cpt - 1].Cells[5].Value.ToString();
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
                label2_NameCar.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                label1_about.Text = guna2DataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                label3_price.Text = guna2DataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                label1_rate.Text = guna2DataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                label1_geoloc.Text = guna2DataGridView1.Rows[cpt - 1].Cells[5].Value.ToString();
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Load("..\\Debug\\Pics\\" + cpt.ToString() + "n.png");

            guna2PictureBox2.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + "n.png");

            guna2PictureBox3.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "n.png");

            guna2PictureBox4.Load("..\\Debug\\Pics\\" + cpt.ToString() + "n.png");
        }


        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Load("..\\Debug\\Pics\\" + cpt.ToString() + "b.png");

            guna2PictureBox2.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + "b.png");

            guna2PictureBox3.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "b.png");

            guna2PictureBox4.Load("..\\Debug\\Pics\\" + cpt.ToString() + "b.png");
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Load("..\\Debug\\Pics\\" + cpt.ToString() + "r.png");

            guna2PictureBox2.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + "r.png");

            guna2PictureBox3.Load("..\\Debug\\Pics\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "r.png");

            guna2PictureBox4.Load("..\\Debug\\Pics\\" + cpt.ToString() + "r.png");
        }
    }
}
