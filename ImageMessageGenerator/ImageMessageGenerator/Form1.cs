using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMessageGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in FontFamily.Families)
            {
                fontFamily.Items.Add(family.Name);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"c:\\";
            dialog.Filter = "Image File (png)|*.png|Image File (jpg)|*.jpg|All files|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("User Cancelled");
                return;
            }
            lblImage.Text = dialog.FileName;

        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            lblColor.BackColor = dialog.Color;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            boxImage.ImageLocation = lblImage.Text;

            lblMessage.Text = txtMessage.Text;
            lblMessage.Font = new Font(fontFamily.Text, (int)fontSize.Value);
            lblMessage.ForeColor = lblColor.BackColor;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MESSAGE SEND!");
            return;
        }

        private void fontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontFamily.SelectedIndex == -1)
                return;
            string familyName = fontFamily.Text;
            lblMessage.Font = new Font(familyName, 12);
        }
    }
}
