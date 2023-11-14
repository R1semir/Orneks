using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orneks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kadınlarda boy-100+yaş/10*0.8
            // Erkeklerde boy-100+yaş/10*0.9
            double boy, ideal;
            int yaş;
            char cinsiyet;
            boy = Convert.ToDouble(textBox1.Text);
            yaş = Convert.ToInt16(textBox2.Text);
            cinsiyet = Convert.ToChar(comboBox1.Text);

            if (cinsiyet == 'K')
            {
                ideal = (boy - 100 + (yaş / 10)) * 0.8;
                label5.Text = ideal.ToString();
            }
            if (cinsiyet == 'E')
            {
                ideal = (boy - 100 + (yaş / 10)) * 0.9;
                label5.Text = ideal.ToString();
            }
        }
    }
}
