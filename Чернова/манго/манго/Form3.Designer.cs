namespace манго
{
    partial class Form3
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
            this.Авторизация = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Регистрация = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Авторизация
            // 
            this.Авторизация.AutoSize = true;
            this.Авторизация.Location = new System.Drawing.Point(180, 80);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(73, 13);
            this.Авторизация.TabIndex = 0;
            this.Авторизация.Text = "Авторизация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пароль";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(143, 171);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 20);
            this.textBox7.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Логин";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(143, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 20);
            this.textBox6.TabIndex = 15;
            // 
            // Регистрация
            // 
            this.Регистрация.Location = new System.Drawing.Point(154, 231);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(121, 30);
            this.Регистрация.TabIndex = 19;
            this.Регистрация.Text = "Войти";
            this.Регистрация.UseVisualStyleBackColor = true;
            this.Регистрация.Click += new System.EventHandler(this.Регистрация_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Авторизация);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Авторизация;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Регистрация;
        private System.Windows.Forms.Button button1;
    }
}