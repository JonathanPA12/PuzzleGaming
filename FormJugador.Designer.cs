
namespace Quiz3_JuegoQuince
{
    partial class FormJugador
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
            this.JugadorName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JugadorName
            // 
            this.JugadorName.AutoSize = true;
            this.JugadorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JugadorName.Location = new System.Drawing.Point(133, 84);
            this.JugadorName.Name = "JugadorName";
            this.JugadorName.Size = new System.Drawing.Size(46, 13);
            this.JugadorName.TabIndex = 0;
            this.JugadorName.Text = "Register";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(191, 281);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(54, 23);
            this.about.TabIndex = 4;
            this.about.Text = "acerca";
            this.about.UseVisualStyleBackColor = true;
            // 
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzleGame.Properties.Resources.adc;
            this.ClientSize = new System.Drawing.Size(423, 316);
            this.ControlBox = false;
            this.Controls.Add(this.about);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.JugadorName);
            this.Name = "FormJugador";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormUsuario_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label JugadorName;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button about;
    }
}