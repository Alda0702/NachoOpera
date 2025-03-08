namespace NachoOpera
{
    partial class operacion
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNum1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.ForeColor = System.Drawing.Color.White;
            this.txtNum1.Location = new System.Drawing.Point(297, 130);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(54, 36);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNum2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.Color.White;
            this.txtNum2.Location = new System.Drawing.Point(426, 130);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(54, 36);
            this.txtNum2.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOperar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.White;
            this.btnOperar.Location = new System.Drawing.Point(319, 200);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(135, 42);
            this.btnOperar.TabIndex = 2;
            this.btnOperar.Text = "OPERAR";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(381, 135);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(17, 25);
            this.lblSigno.TabIndex = 3;
            this.lblSigno.Text = ":";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.BackColor = System.Drawing.Color.Transparent;
            this.lblIngrese.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(202, 85);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(382, 28);
            this.lblIngrese.TabIndex = 5;
            this.lblIngrese.Text = "INGRESE LOS NUMEROS A OPERAR";
            this.lblIngrese.Click += new System.EventHandler(this.lblIngrese_Click);
            // 
            // operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NachoOpera.Properties.Resources.pink_ruler_cute_mathematics_notebook_education_powerpoint_background_e289d0bf50__960_540;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "operacion";
            this.Text = "operacion";
            this.Load += new System.EventHandler(this.operacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnOperar;
        public System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblIngrese;
    }
}