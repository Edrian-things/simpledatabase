using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Edrian Badoy
namespace FrmLab1
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName;
        private void button1_Click(object sender, EventArgs e)
        {
            SetFileName = textBox1.Text + ".txt";
            this.Close();
        }
    }
}
