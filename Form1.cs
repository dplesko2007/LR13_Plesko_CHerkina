using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR13_Plesko_CHerkina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            labelMessage.Text = "Начало работы";
        }

        private void buttonHello_Click_1(object sender, EventArgs e)
        {
            labelMessage.Text = "Привет";
        }

        private void buttonGoodbye_Click_1(object sender, EventArgs e)
        {
            labelMessage.Text = "До свидания";
        }
    }
}