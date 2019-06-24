using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitVSTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("第一次異動並推送");
            MessageBox.Show("下載GitHub上的專案，第二次異動並推送");
            MessageBox.Show("模擬合作夥伴同時進行修改");
        }
    }
}
