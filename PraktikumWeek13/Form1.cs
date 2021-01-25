using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13
{
    public partial class FormPengaturanNama : Form
    {
        public FormPengaturanNama()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelEmpty.Text == "[EMPTY]" && textBoxPesan.Text != "SHOWN")
            {
                labelEmpty.Text = textBoxPesan.Text;
            }
            if (labelEmpty.Text != "[EMPTY]" )
            {
                if (textBoxPesan.Text == "DELETE")
                {
                    labelEmpty.Text = "[EMPTY]";
                    labelEmpty.ForeColor = Color.Black;
                }
                else if (textBoxPesan.Text == "SHOWN")
                {
                    labelEmpty.Visible = true;
                }
                else if (textBoxPesan.Text == "HIDE")
                {
                    labelEmpty.Visible = false;
                }
                else if (textBoxPesan.Text == "BLUE")
                {
                    labelEmpty.ForeColor = Color.Blue;
                }
                else if (textBoxPesan.Text == "RED")
                {
                    labelEmpty.ForeColor = Color.Red;
                }
                else if (textBoxPesan.Text == "GREEN")
                {
                    labelEmpty.ForeColor = Color.Green;
                }

            }
        }
    }
}
