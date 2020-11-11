namespace projeto_facul
{
    partial class FormCadastroProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProf));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(191, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 40);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "CANCEL";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(70, 176);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '*';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(237, 37);
            this.gunaTextBox1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = "CADASTRAR-SE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(67, 231);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 17);
            this.gunaLabel2.TabIndex = 36;
            this.gunaLabel2.Text = "Senha";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(67, 156);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "Usuário";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(70, 251);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '*';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(237, 37);
            this.gunaTextBox2.TabIndex = 34;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(12, 93);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(365, 10);
            this.gunaLinePanel2.TabIndex = 33;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(48, 90);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(293, 10);
            this.gunaLinePanel1.TabIndex = 32;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel4.Location = new System.Drawing.Point(140, 106);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(119, 30);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "CADASTRO";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(134, 1);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(135, 127);
            this.bunifuTileButton1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(395, 449);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.bunifuTileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroProf";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}