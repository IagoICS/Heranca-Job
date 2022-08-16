namespace Trabalho_heranca
{
    partial class Professor
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btncadprof = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lbltitulacao = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txttilulacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsair.Location = new System.Drawing.Point(581, 321);
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
            this.btnexibir.Location = new System.Drawing.Point(315, 321);
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
            this.btncadprof.Location = new System.Drawing.Point(52, 321);
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Size = new System.Drawing.Size(191, 64);
            this.btncadprof.TabIndex = 4;
            this.btncadprof.Tag = "4";
            this.btncadprof.Text = "Cadastrar";
            this.btncadprof.UseCompatibleTextRendering = true;
            this.btncadprof.UseVisualStyleBackColor = true;
            this.btncadprof.Click += new System.EventHandler(this.btncadprof_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(188, 80);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Nome";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(188, 135);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(55, 20);
            this.lblidade.TabIndex = 5;
            this.lblidade.Text = "Idade";
            this.lblidade.Click += new System.EventHandler(this.lblidade_Click);
            // 
            // lbltitulacao
            // 
            this.lbltitulacao.AutoSize = true;
            this.lbltitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulacao.Location = new System.Drawing.Point(188, 190);
            this.lbltitulacao.Name = "lbltitulacao";
            this.lbltitulacao.Size = new System.Drawing.Size(82, 20);
            this.lbltitulacao.TabIndex = 6;
            this.lbltitulacao.Text = "Titulação";
            this.lbltitulacao.Click += new System.EventHandler(this.lbltitulacao_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(290, 82);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(266, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(290, 137);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(266, 20);
            this.txtidade.TabIndex = 2;
            this.txtidade.TextChanged += new System.EventHandler(this.txtidade_TextChanged);
            // 
            // txttilulacao
            // 
            this.txttilulacao.Location = new System.Drawing.Point(290, 190);
            this.txttilulacao.Name = "txttilulacao";
            this.txttilulacao.Size = new System.Drawing.Size(266, 20);
            this.txttilulacao.TabIndex = 3;
            this.txttilulacao.TextChanged += new System.EventHandler(this.txttilulacao_TextChanged);
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttilulacao);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbltitulacao);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btncadprof);
            this.Name = "Professor";
            this.Text = "Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btncadprof;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lbltitulacao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txttilulacao;
    }
}