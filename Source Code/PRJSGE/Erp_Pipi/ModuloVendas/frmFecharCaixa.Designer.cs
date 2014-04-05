namespace ModuloVendas
{
    partial class frmFecharCaixa
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
            this.labelData = new DevExpress.XtraEditors.LabelControl();
            this.labelValorAtualTransicao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblData = new DevExpress.XtraEditors.LabelControl();
            this.lblValorAtual = new DevExpress.XtraEditors.LabelControl();
            this.btnFecharCaixa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.Location = new System.Drawing.Point(12, 12);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(27, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // labelValorAtualTransicao
            // 
            this.labelValorAtualTransicao.Location = new System.Drawing.Point(12, 47);
            this.labelValorAtualTransicao.Name = "labelValorAtualTransicao";
            this.labelValorAtualTransicao.Size = new System.Drawing.Size(107, 13);
            this.labelValorAtualTransicao.TabIndex = 1;
            this.labelValorAtualTransicao.Text = "Valor atual/transação:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Status:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(45, 12);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 3;
            // 
            // lblValorAtual
            // 
            this.lblValorAtual.Location = new System.Drawing.Point(143, 47);
            this.lblValorAtual.Name = "lblValorAtual";
            this.lblValorAtual.Size = new System.Drawing.Size(0, 13);
            this.lblValorAtual.TabIndex = 4;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Location = new System.Drawing.Point(109, 112);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(100, 23);
            this.btnFecharCaixa.TabIndex = 5;
            this.btnFecharCaixa.Text = "&Fechar caixa";
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 141);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.lblValorAtual);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelValorAtualTransicao);
            this.Controls.Add(this.labelData);
            this.Name = "frmFecharCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fechar Caixa";
            this.Load += new System.EventHandler(this.frmFecharCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelData;
        private DevExpress.XtraEditors.LabelControl labelValorAtualTransicao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblData;
        private DevExpress.XtraEditors.LabelControl lblValorAtual;
        private DevExpress.XtraEditors.SimpleButton btnFecharCaixa;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}