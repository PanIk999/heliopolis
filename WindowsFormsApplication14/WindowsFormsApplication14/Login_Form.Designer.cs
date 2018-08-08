namespace WindowsFormsApplication14
{
    partial class Login_Form
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
            this.textBox1_Username = new System.Windows.Forms.TextBox();
            this.textBox2_Passwort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_Username
            // 
            this.textBox1_Username.Location = new System.Drawing.Point(237, 75);
            this.textBox1_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1_Username.Name = "textBox1_Username";
            this.textBox1_Username.Size = new System.Drawing.Size(148, 26);
            this.textBox1_Username.TabIndex = 0;
            this.textBox1_Username.Text = "BarbaraBush";
            // 
            // textBox2_Passwort
            // 
            this.textBox2_Passwort.Location = new System.Drawing.Point(237, 165);
            this.textBox2_Passwort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2_Passwort.Name = "textBox2_Passwort";
            this.textBox2_Passwort.Size = new System.Drawing.Size(148, 26);
            this.textBox2_Passwort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Einloggen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_Passwort);
            this.Controls.Add(this.textBox1_Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_Username;
        private System.Windows.Forms.TextBox textBox2_Passwort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}