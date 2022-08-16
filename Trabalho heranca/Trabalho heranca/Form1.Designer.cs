namespace Trabalho_heranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncadprofessor = new System.Windows.Forms.Button();
            this.btncadaluno = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadprofessor
            // 
            this.btncadprofessor.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadprofessor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadprofessor.Location = new System.Drawing.Point(57, 313);
            this.btncadprofessor.Name = "btncadprofessor";
            this.btncadprofessor.Size = new System.Drawing.Size(191, 64);
            this.btncadprofessor.TabIndex = 1;
            this.btncadprofessor.Tag = "1";
            this.btncadprofessor.Text = "Cadastrar Professor";
            this.btncadprofessor.UseCompatibleTextRendering = true;
            this.btncadprofessor.UseVisualStyleBackColor = true;
            this.btncadprofessor.Click += new System.EventHandler(this.btncadprofessor_Click);
            // 
            // btncadaluno
            // 
            this.btncadaluno.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadaluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadaluno.Location = new System.Drawing.Point(320, 313);
            this.btncadaluno.Name = "btncadaluno";
            this.btncadaluno.Size = new System.Drawing.Size(191, 64);
            this.btncadaluno.TabIndex = 2;
            this.btncadaluno.Tag = "2";
            this.btncadaluno.Text = "Cadastrar Aluno";
            this.btncadaluno.UseCompatibleTextRendering = true;
            this.btncadaluno.UseVisualStyleBackColor = true;
            this.btncadaluno.Click += new System.EventHandler(this.btncadaluno_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsair.Location = new System.Drawing.Point(586, 313);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(191, 64);
            this.btnsair.TabIndex = 3;
            this.btnsair.Tag = "3";
            this.btnsair.Text = "Sair";
            this.btnsair.UseCompatibleTextRendering = true;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncadaluno);
            this.Controls.Add(this.btncadprofessor);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadprofessor;
        private System.Windows.Forms.Button btncadaluno;
        private System.Windows.Forms.Button btnsair;
    }
}

