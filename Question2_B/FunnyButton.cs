using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Question2_B
{
    public partial class FunnyButton : Form
    {
        const string ID = "HE140505";
        bool isLock = false;
        public FunnyButton()
        {
            InitializeComponent();
        }

        private void generateStdIDButton_Click(object sender, EventArgs e)
        {
            studentIDTextBox.Text = ID;
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
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

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newButtonTextBox.Text) && !string.IsNullOrEmpty(positionXTextBox.Text) && !string.IsNullOrEmpty(positionYTextBox.Text))
            {
                Button button = new Button();
                button.Text = newButtonTextBox.Text;
                button.BackColor = colorTextBox.BackColor;
                button.Location = new Point(Int32.Parse(positionXTextBox.Text), Int32.Parse(positionYTextBox.Text));
                groupButtonPanel.Controls.Add(button);

            }
            else
            {
                if (string.IsNullOrEmpty(newButtonTextBox.Text))
                {
                    MessageBox.Show("Label of the button cannot be blank");
                }
                else
                {
                    MessageBox.Show("Position cannot be blank");
                }
            }
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            isLock = true;

        }

        private void groupButtonPanel_Click(object sender, EventArgs e)
        {
            if (isLock)
            {
                Point point = groupButtonPanel.PointToClient(Cursor.Position);
                positionXTextBox.Text = point.X.ToString();
                positionYTextBox.Text = point.Y.ToString();
                isLock = false;
            }
        }
    }
}
