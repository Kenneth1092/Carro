namespace Carro
{
    partial class compra
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DirTxt = new System.Windows.Forms.TextBox();
            this.Dir2Txt = new System.Windows.Forms.TextBox();
            this.PaisTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.compraBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ApeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(80, 19);
            this.NameTxt.MaxLength = 15;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // DirTxt
            // 
            this.DirTxt.Location = new System.Drawing.Point(80, 73);
            this.DirTxt.MaxLength = 25;
            this.DirTxt.Name = "DirTxt";
            this.DirTxt.Size = new System.Drawing.Size(100, 20);
            this.DirTxt.TabIndex = 1;
            this.DirTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirTxt_KeyPress);
            // 
            // Dir2Txt
            // 
            this.Dir2Txt.Location = new System.Drawing.Point(80, 99);
            this.Dir2Txt.MaxLength = 25;
            this.Dir2Txt.Name = "Dir2Txt";
            this.Dir2Txt.Size = new System.Drawing.Size(100, 20);
            this.Dir2Txt.TabIndex = 2;
            // 
            // PaisTxt
            // 
            this.PaisTxt.Location = new System.Drawing.Point(80, 125);
            this.PaisTxt.MaxLength = 15;
            this.PaisTxt.Name = "PaisTxt";
            this.PaisTxt.Size = new System.Drawing.Size(100, 20);
            this.PaisTxt.TabIndex = 3;
            this.PaisTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaisTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirreción 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "País";
            // 
            // compraBtn
            // 
            this.compraBtn.Location = new System.Drawing.Point(13, 161);
            this.compraBtn.Name = "compraBtn";
            this.compraBtn.Size = new System.Drawing.Size(94, 23);
            this.compraBtn.TabIndex = 8;
            this.compraBtn.Text = "Finalizar compra";
            this.compraBtn.UseVisualStyleBackColor = true;
            this.compraBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellidos";
            // 
            // ApeTxt
            // 
            this.ApeTxt.Location = new System.Drawing.Point(80, 47);
            this.ApeTxt.MaxLength = 30;
            this.ApeTxt.Name = "ApeTxt";
            this.ApeTxt.Size = new System.Drawing.Size(100, 20);
            this.ApeTxt.TabIndex = 9;
            this.ApeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApeTxt_KeyPress);
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 200);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApeTxt);
            this.Controls.Add(this.compraBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaisTxt);
            this.Controls.Add(this.Dir2Txt);
            this.Controls.Add(this.DirTxt);
            this.Controls.Add(this.NameTxt);
            this.Name = "compra";
            this.Text = "compra";
            this.Load += new System.EventHandler(this.compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox DirTxt;
        private System.Windows.Forms.TextBox Dir2Txt;
        private System.Windows.Forms.TextBox PaisTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button compraBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ApeTxt;
    }
}