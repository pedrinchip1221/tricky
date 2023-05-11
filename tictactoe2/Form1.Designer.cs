namespace tictactoe2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.lblvictoriasx = new System.Windows.Forms.Label();
            this.lblvictoriasO = new System.Windows.Forms.Label();
            this.btnmostrarX = new System.Windows.Forms.Button();
            this.btnmostrarO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(428, 229);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 17;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(322, 229);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 16;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(216, 229);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 15;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(428, 123);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 14;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(322, 123);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 13;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(216, 123);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 12;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(428, 17);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 11;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(322, 17);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 10;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(216, 17);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 9;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Location = new System.Drawing.Point(48, 74);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(111, 43);
            this.btnreiniciar.TabIndex = 18;
            this.btnreiniciar.Text = "reiniciar";
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // lblvictoriasx
            // 
            this.lblvictoriasx.AutoSize = true;
            this.lblvictoriasx.Location = new System.Drawing.Point(28, 150);
            this.lblvictoriasx.Name = "lblvictoriasx";
            this.lblvictoriasx.Size = new System.Drawing.Size(60, 13);
            this.lblvictoriasx.TabIndex = 19;
            this.lblvictoriasx.Text = "Victorias X:";
            // 
            // lblvictoriasO
            // 
            this.lblvictoriasO.AutoSize = true;
            this.lblvictoriasO.Location = new System.Drawing.Point(28, 189);
            this.lblvictoriasO.Name = "lblvictoriasO";
            this.lblvictoriasO.Size = new System.Drawing.Size(61, 13);
            this.lblvictoriasO.TabIndex = 20;
            this.lblvictoriasO.Text = "Victorias O:";
            // 
            // btnmostrarX
            // 
            this.btnmostrarX.Enabled = false;
            this.btnmostrarX.Location = new System.Drawing.Point(106, 145);
            this.btnmostrarX.Name = "btnmostrarX";
            this.btnmostrarX.Size = new System.Drawing.Size(75, 23);
            this.btnmostrarX.TabIndex = 21;
            this.btnmostrarX.UseVisualStyleBackColor = true;
            this.btnmostrarX.Click += new System.EventHandler(this.btnmostrarX_Click);
            // 
            // btnmostrarO
            // 
            this.btnmostrarO.Enabled = false;
            this.btnmostrarO.Location = new System.Drawing.Point(106, 184);
            this.btnmostrarO.Name = "btnmostrarO";
            this.btnmostrarO.Size = new System.Drawing.Size(75, 23);
            this.btnmostrarO.TabIndex = 22;
            this.btnmostrarO.UseVisualStyleBackColor = true;
            this.btnmostrarO.Click += new System.EventHandler(this.btnmostrarO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.btnmostrarO);
            this.Controls.Add(this.btnmostrarX);
            this.Controls.Add(this.lblvictoriasO);
            this.Controls.Add(this.lblvictoriasx);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label lblvictoriasx;
        private System.Windows.Forms.Label lblvictoriasO;
        private System.Windows.Forms.Button btnmostrarX;
        private System.Windows.Forms.Button btnmostrarO;
    }
}

