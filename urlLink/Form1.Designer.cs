namespace urlLink
{
    partial class frm_TelaPrincioal
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
            this.rch_Descricao = new System.Windows.Forms.RichTextBox();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.txt_CNPJ = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Link1 = new System.Windows.Forms.Button();
            this.btn_Link2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rch_Descricao
            // 
            this.rch_Descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rch_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_Descricao.Location = new System.Drawing.Point(12, 199);
            this.rch_Descricao.Name = "rch_Descricao";
            this.rch_Descricao.Size = new System.Drawing.Size(710, 169);
            this.rch_Descricao.TabIndex = 3;
            this.rch_Descricao.Text = "";
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.Location = new System.Drawing.Point(431, 56);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(291, 113);
            this.btn_Pesquisa.TabIndex = 2;
            this.btn_Pesquisa.Text = "PESQUISAR";
            this.btn_Pesquisa.UseVisualStyleBackColor = false;
            this.btn_Pesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNPJ.Location = new System.Drawing.Point(12, 131);
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(341, 42);
            this.txt_CNPJ.TabIndex = 1;
            this.txt_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Black;
            this.lbl_Status.Location = new System.Drawing.Point(12, 40);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Status.Size = new System.Drawing.Size(404, 65);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = ".........................";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Link1
            // 
            this.btn_Link1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Link1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Link1.Location = new System.Drawing.Point(12, 374);
            this.btn_Link1.Name = "btn_Link1";
            this.btn_Link1.Size = new System.Drawing.Size(195, 50);
            this.btn_Link1.TabIndex = 5;
            this.btn_Link1.Text = "Abrir PDF SP";
            this.btn_Link1.UseVisualStyleBackColor = false;
            this.btn_Link1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Link2
            // 
            this.btn_Link2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Link2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Link2.Location = new System.Drawing.Point(305, 374);
            this.btn_Link2.Name = "btn_Link2";
            this.btn_Link2.Size = new System.Drawing.Size(417, 50);
            this.btn_Link2.TabIndex = 6;
            this.btn_Link2.Text = "Abrir PDF OUTROS ESTADOS";
            this.btn_Link2.UseVisualStyleBackColor = false;
            this.btn_Link2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DIGITE ABAIXO O CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status -> Liberado ou Bloqueado no Detran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Infornações da Empresa";
            // 
            // frm_TelaPrincioal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Link2);
            this.Controls.Add(this.btn_Link1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.rch_Descricao);
            this.Name = "frm_TelaPrincioal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA DETRAN SUCATA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rch_Descricao;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.TextBox txt_CNPJ;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Link1;
        private System.Windows.Forms.Button btn_Link2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

