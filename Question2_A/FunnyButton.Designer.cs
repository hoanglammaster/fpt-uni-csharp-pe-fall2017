
namespace Question2_A
{
    partial class FunnyButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.generateStdIDButton = new System.Windows.Forms.Button();
            this.newButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.newButtonTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.newButtonLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(12, 25);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "StudentID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Enabled = false;
            this.studentIDTextBox.Location = new System.Drawing.Point(76, 22);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(151, 20);
            this.studentIDTextBox.TabIndex = 1;
            this.studentIDTextBox.TabStop = false;
            // 
            // generateStdIDButton
            // 
            this.generateStdIDButton.Location = new System.Drawing.Point(242, 20);
            this.generateStdIDButton.Name = "generateStdIDButton";
            this.generateStdIDButton.Size = new System.Drawing.Size(75, 23);
            this.generateStdIDButton.TabIndex = 2;
            this.generateStdIDButton.Text = "Generate";
            this.generateStdIDButton.UseVisualStyleBackColor = true;
            this.generateStdIDButton.Click += new System.EventHandler(this.generateStdID_Click);
            // 
            // newButtonGroupBox
            // 
            this.newButtonGroupBox.Controls.Add(this.addNewButton);
            this.newButtonGroupBox.Controls.Add(this.chooseColorButton);
            this.newButtonGroupBox.Controls.Add(this.colorTextBox);
            this.newButtonGroupBox.Controls.Add(this.newButtonTextBox);
            this.newButtonGroupBox.Controls.Add(this.colorLabel);
            this.newButtonGroupBox.Controls.Add(this.newButtonLabel);
            this.newButtonGroupBox.Location = new System.Drawing.Point(15, 60);
            this.newButtonGroupBox.Name = "newButtonGroupBox";
            this.newButtonGroupBox.Size = new System.Drawing.Size(300, 130);
            this.newButtonGroupBox.TabIndex = 3;
            this.newButtonGroupBox.TabStop = false;
            this.newButtonGroupBox.Text = "New Button";
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(219, 93);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 23);
            this.addNewButton.TabIndex = 5;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Location = new System.Drawing.Point(116, 49);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(75, 23);
            this.chooseColorButton.TabIndex = 4;
            this.chooseColorButton.Text = "Choose";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.chooseColor_Click);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Enabled = false;
            this.colorTextBox.Location = new System.Drawing.Point(61, 51);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(39, 20);
            this.colorTextBox.TabIndex = 3;
            // 
            // newButtonTextBox
            // 
            this.newButtonTextBox.Location = new System.Drawing.Point(61, 20);
            this.newButtonTextBox.Name = "newButtonTextBox";
            this.newButtonTextBox.Size = new System.Drawing.Size(233, 20);
            this.newButtonTextBox.TabIndex = 2;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(19, 54);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 1;
            this.colorLabel.Text = "Color:";
            // 
            // newButtonLabel
            // 
            this.newButtonLabel.AutoSize = true;
            this.newButtonLabel.Location = new System.Drawing.Point(19, 27);
            this.newButtonLabel.Name = "newButtonLabel";
            this.newButtonLabel.Size = new System.Drawing.Size(36, 13);
            this.newButtonLabel.TabIndex = 0;
            this.newButtonLabel.Text = "Label:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(15, 196);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(300, 242);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // FunnyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.newButtonGroupBox);
            this.Controls.Add(this.generateStdIDButton);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.studentIDLabel);
            this.Name = "FunnyButton";
            this.Text = "Funny Button";
            this.newButtonGroupBox.ResumeLayout(false);
            this.newButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Button generateStdIDButton;
        private System.Windows.Forms.GroupBox newButtonGroupBox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox newButtonTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label newButtonLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}