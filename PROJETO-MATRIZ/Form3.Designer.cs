namespace PROJETO_MATRIZ
{
    partial class frm3
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
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(93, 71);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 0;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(384, 87);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.ReadOnly = true;
            this.txta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txta.Size = new System.Drawing.Size(100, 173);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(525, 87);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.ReadOnly = true;
            this.txtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb.Size = new System.Drawing.Size(100, 173);
            this.txtb.TabIndex = 2;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(564, 284);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "b";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(410, 284);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 4;
            this.lbla.Text = "a";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(32, 74);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(44, 13);
            this.lblnum.TabIndex = 5;
            this.lblnum.Text = "Número";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(133, 338);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 6;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(133, 338);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Visible = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(289, 338);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(460, 338);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtnum);
            this.Name = "frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}