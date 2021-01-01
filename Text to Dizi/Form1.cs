using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_to_Dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dizitext = "string[] dizii =";
        string[] parantez = { "{", "};" };
        private void diziOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dizi = richTextBox1.Text.Replace("\n","~");
            richTextBox2.AppendText(dizitext);
            richTextBox2.AppendText(parantez[0]);
            for (int i = 0; i < dizi.Split('~').Length; i++)
            {

                if (dizi.Split('~').Length - 1 != i) //EBS Coding...
                {
                    richTextBox2.AppendText("\"" + dizi.Split('~')[i].ToString() + "\"" + ",");
                }
                else
                {
                    richTextBox2.AppendText("\"" + dizi.Split('~')[i].ToString() + "\"");
                }

            }

            richTextBox2.AppendText(parantez[1]);

        }
    }
}
