namespace PROJETO_MATRIZ
{
    partial class frm1
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtb = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(183, 75);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 0;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(349, 75);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txta.Size = new System.Drawing.Size(100, 131);
            this.txta.TabIndex = 1;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(49, 82);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(42, 13);
            this.lblnum.TabIndex = 3;
            this.lblnum.Text = "número";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(388, 41);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(14, 13);
            this.lbla.TabIndex = 4;
            this.lbla.Text = "A";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(549, 41);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(14, 13);
            this.lblb.TabIndex = 5;
            this.lblb.Text = "B";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(194, 289);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Visible = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(448, 289);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(194, 289);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(510, 75);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb.Size = new System.Drawing.Size(100, 131);
            this.txtb.TabIndex = 2;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(317, 289);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtnum);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnlimpar;
    }
}