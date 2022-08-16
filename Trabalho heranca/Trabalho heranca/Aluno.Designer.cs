namespace Trabalho_heranca
{
    partial class Aluno
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
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.txtidade2 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btncadprof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(278, 183);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(266, 20);
            this.txtcurso.TabIndex = 3;
            this.txtcurso.TextChanged += new System.EventHandler(this.txttilulacao_TextChanged);
            // 
            // txtidade2
            // 
            this.txtidade2.Location = new System.Drawing.Point(278, 130);
            this.txtidade2.Name = "txtidade2";
            this.txtidade2.Size = new System.Drawing.Size(266, 20);
            this.txtidade2.TabIndex = 2;
            this.txtidade2.TextChanged += new System.EventHandler(this.txtidade_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(278, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(266, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.Location = new System.Drawing.Point(176, 181);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(56, 20);
            this.lblcurso.TabIndex = 14;
            this.lblcurso.Text = "Curso";
            this.lblcurso.Click += new System.EventHandler(this.lbltitulacao_Click);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(176, 128);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(55, 20);
            this.lblidade.TabIndex = 12;
            this.lblidade.Text = "Idade";
            this.lblidade.Click += new System.EventHandler(this.lblidade_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(176, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Nome";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsair.Location = new System.Drawing.Point(569, 314);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(191, 64);
            this.btnsair.TabIndex = 6;
            this.btnsair.Tag = "6";
            this.btnsair.Text = "Sair";
            this.btnsair.UseCompatibleTextRendering = true;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexibir.Location = new System.Drawing.Point(303, 314);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(191, 64);
            this.btnexibir.TabIndex = 5;
            this.btnexibir.Tag = "5";
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseCompatibleTextRendering = true;
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btncadprof
            // 
            this.btncadprof.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadprof.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadprof.Location = new System.Drawing.Point(40, 314);
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Size = new System.Drawing.Size(191, 64);
            this.btncadprof.TabIndex = 4;
            this.btncadprof.Tag = "4";
            this.btncadprof.Text = "Cadastrar";
            this.btncadprof.UseCompatibleTextRendering = true;
            this.btncadprof.UseVisualStyleBackColor = true;
            this.btncadprof.Click += new System.EventHandler(this.btncadprof_Click);
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txtidade2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btncadprof);
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.TextBox txtidade2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btncadprof;
    }
}