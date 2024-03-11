namespace ATM_application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            pinTextBox = new TextBox();
            amountTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            amountErrorProvider = new ErrorProvider(components);
            pinErrorProvider = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)amountErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pinErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(329, 297);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pinTextBox
            // 
            pinTextBox.Location = new Point(345, 211);
            pinTextBox.Name = "pinTextBox";
            pinTextBox.PasswordChar = '*';
            pinTextBox.Size = new Size(150, 31);
            pinTextBox.TabIndex = 1;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(345, 141);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(150, 31);
            amountTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 144);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter Amount:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 211);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "Enter PIN:";
            label2.Click += label2_Click;
            // 
            // amountErrorProvider
            // 
            amountErrorProvider.ContainerControl = this;
            // 
            // pinErrorProvider
            // 
            pinErrorProvider.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(amountTextBox);
            Controls.Add(pinTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amountErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pinErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox pinTextBox;
        private TextBox amountTextBox;
        private Label label1;
        private Label label2;
        private ErrorProvider amountErrorProvider;
        private ErrorProvider pinErrorProvider;
        private ErrorProvider errorProvider3;
    }
}