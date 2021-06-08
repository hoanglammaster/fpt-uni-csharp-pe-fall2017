using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Question2_A
{
    public partial class FunnyButton : Form
    {
        const string ID = "HE140505";
        public FunnyButton()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newButtonTextBox.Text))
            {
                Button button = new Button();
                button.Text = newButtonTextBox.Text;
                button.BackColor = colorTextBox.BackColor;
                button.Click += buttonGenerate_Click;
                flowLayoutPanel.Controls.Add(button);
            }
            else
            {
                MessageBox.Show("Label of the button cannot be blank");
            }
            
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("Label:" + button.Text+"\nColor:RGB("+button.BackColor.R+","+button.BackColor.G+","+button.BackColor.B+")");

        }

        private void generateStdID_Click(object sender, EventArgs e)
        {
            studentIDTextBox.Text = ID; 
        }

        private void chooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = colorTextBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorTextBox.BackColor = colorDialog.Color;
            }
        }
    }
}
