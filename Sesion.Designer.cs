namespace IMPORTADORAPOO
{
    partial class Sesion
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.piccandado = new System.Windows.Forms.PictureBox();
            this.picUsser = new System.Windows.Forms.PictureBox();
            this.btnOjito = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(84, 312);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(188, 55);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "INICIAR SESIÓN";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.WhatsApp_Image_2026_07_22_at_9_33_59_AM;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPassword.Controls.Add(this.piccandado);
            this.txtPassword.Controls.Add(this.picUsser);
            this.txtPassword.Controls.Add(this.btnOjito);
            this.txtPassword.Controls.Add(this.txtContraseña);
            this.txtPassword.Controls.Add(this.txtUsuario);
            this.txtPassword.Controls.Add(this.label2);
            this.txtPassword.Controls.Add(this.label1);
            this.txtPassword.Controls.Add(this.button1);
            this.txtPassword.Controls.Add(this.lblLoginTitle);
            this.txtPassword.Controls.Add(this.btnIngresar);
            this.txtPassword.Location = new System.Drawing.Point(458, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(708, 531);
            this.txtPassword.TabIndex = 10;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(45, 237);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(289, 29);
            this.txtContraseña.TabIndex = 13;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(45, 138);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(323, 29);
            this.txtUsuario.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(406, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "SOPORTE TÉCNICO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(77, 31);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(577, 68);
            this.lblLoginTitle.TabIndex = 8;
            this.lblLoginTitle.Text = "INICIO DE SESIÓN DEL SISTEMA";
            // 
            // piccandado
            // 
            this.piccandado.BackColor = System.Drawing.Color.Transparent;
            this.piccandado.Image = global::IMPORTADORAPOO.Properties.Resources.bloqueado;
            this.piccandado.Location = new System.Drawing.Point(45, 186);
            this.piccandado.Name = "piccandado";
            this.piccandado.Size = new System.Drawing.Size(47, 50);
            this.piccandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccandado.TabIndex = 16;
            this.piccandado.TabStop = false;
            // 
            // picUsser
            // 
            this.picUsser.BackColor = System.Drawing.Color.Transparent;
            this.picUsser.Image = global::IMPORTADORAPOO.Properties.Resources.nueva_cuenta;
            this.picUsser.Location = new System.Drawing.Point(45, 88);
            this.picUsser.Name = "picUsser";
            this.picUsser.Size = new System.Drawing.Size(47, 47);
            this.picUsser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsser.TabIndex = 15;
            this.picUsser.TabStop = false;
            // 
            // btnOjito
            // 
            this.btnOjito.BackColor = System.Drawing.Color.Transparent;
            this.btnOjito.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.ojo;
            this.btnOjito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOjito.Location = new System.Drawing.Point(342, 239);
            this.btnOjito.Name = "btnOjito";
            this.btnOjito.Size = new System.Drawing.Size(26, 25);
            this.btnOjito.TabIndex = 14;
            this.btnOjito.UseVisualStyleBackColor = false;
            this.btnOjito.Click += new System.EventHandler(this.btnOjito_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.Mapa;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(5, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 534);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.Logosuperior;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 137);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::IMPORTADORAPOO.Properties.Resources.Mapa;
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 494);
            this.panel2.TabIndex = 0;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 672);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion";
            this.Load += new System.EventHandler(this.Sesion_Load);
            this.txtPassword.ResumeLayout(false);
            this.txtPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel txtPassword;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnOjito;
        private System.Windows.Forms.PictureBox piccandado;
        private System.Windows.Forms.PictureBox picUsser;
    }
}