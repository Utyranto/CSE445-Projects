namespace RileyThanBrowser
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.CalcDisplay = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.resultDisplay = new System.Windows.Forms.Label();
            this.EncryptTitle = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 22);
            this.textBox1.TabIndex = 0;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(409, 26);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 57);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(95, 56);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 23);
            this.ForwardButton.TabIndex = 3;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(833, 26);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(914, 26);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 87);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(976, 250);
            this.webBrowser1.TabIndex = 6;
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.AutoSize = true;
            this.CalcDisplay.Location = new System.Drawing.Point(154, 341);
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(67, 16);
            this.CalcDisplay.TabIndex = 7;
            this.CalcDisplay.Text = "Calculator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(36, 388);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(117, 387);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.Location = new System.Drawing.Point(200, 387);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(75, 23);
            this.TimesButton.TabIndex = 12;
            this.TimesButton.Text = "*";
            this.TimesButton.UseVisualStyleBackColor = true;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(282, 387);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 13;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(143, 413);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(78, 16);
            this.resultDisplay.TabIndex = 14;
            this.resultDisplay.Text = "Result Here";
            // 
            // EncryptTitle
            // 
            this.EncryptTitle.AutoSize = true;
            this.EncryptTitle.Location = new System.Drawing.Point(597, 340);
            this.EncryptTitle.Name = "EncryptTitle";
            this.EncryptTitle.Size = new System.Drawing.Size(137, 16);
            this.EncryptTitle.TabIndex = 15;
            this.EncryptTitle.Text = "Enter String to Encrypt";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(600, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(389, 22);
            this.textBox4.TabIndex = 16;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(600, 387);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 17;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // EncryptDisplay
            // 
            this.EncryptDisplay.AutoSize = true;
            this.EncryptDisplay.Location = new System.Drawing.Point(597, 413);
            this.EncryptDisplay.Name = "EncryptDisplay";
            this.EncryptDisplay.Size = new System.Drawing.Size(138, 16);
            this.EncryptDisplay.TabIndex = 18;
            this.EncryptDisplay.Text = "Encrypted String Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 563);
            this.Controls.Add(this.EncryptDisplay);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.EncryptTitle);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.TimesButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CalcDisplay);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label CalcDisplay;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label EncryptTitle;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label EncryptDisplay;
    }
}

