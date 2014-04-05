namespace ModuloVendas
{
    partial class frmAbrirCaixa
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
            this.lblDataAtual = new DevExpress.XtraEditors.LabelControl();
            this.labelData = new DevExpress.XtraEditors.LabelControl();
            this.labelUltimoValorTransicao = new DevExpress.XtraEditors.LabelControl();
            this.btnAbrirCaixa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtValorAbertura = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorAbertura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDataAtual.Appearance.Options.UseFont = true;
            this.lblDataAtual.Location = new System.Drawing.Point(42, 21);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(70, 14);
            this.lblDataAtual.TabIndex = 0;
            this.lblDataAtual.Text = "labelControl1";
            // 
            // labelData
            // 
            this.labelData.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelData.Appearance.Options.UseFont = true;
            this.labelData.Location = new System.Drawing.Point(9, 21);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(29, 14);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data:";
            // 
            // labelUltimoValorTransicao
            // 
            this.labelUltimoValorTransicao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelUltimoValorTransicao.Appearance.Options.UseFont = true;
            this.labelUltimoValorTransicao.Location = new System.Drawing.Point(9, 54);
            this.labelUltimoValorTransicao.Name = "labelUltimoValorTransicao";
            this.labelUltimoValorTransicao.Size = new System.Drawing.Size(147, 14);
            this.labelUltimoValorTransicao.TabIndex = 2;
            this.labelUltimoValorTransicao.Text = "Valor de abertura do caixa:";
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.AllowFocus = false;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(154, 141);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirCaixa.TabIndex = 1;
            this.btnAbrirCaixa.Text = "&Abrir caixa";
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowFocus = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(260, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValorAbertura
            // 
            this.txtValorAbertura.Location = new System.Drawing.Point(162, 52);
            this.txtValorAbertura.Name = "txtValorAbertura";
            this.txtValorAbertura.Size = new System.Drawing.Size(116, 20);
            this.txtValorAbertura.TabIndex = 0;
            // 
            // frmAbrirCaixa
            // 
            this.AcceptButton = this.btnAbrirCaixa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(370, 176);
            this.Controls.Add(this.txtValorAbertura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.labelUltimoValorTransicao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.lblDataAtual);
            this.Name = "frmAbrirCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Abrir Caixa";
            this.Load += new System.EventHandler(this.frmAbrirCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorAbertura.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDataAtual;
        private DevExpress.XtraEditors.LabelControl labelData;
        private DevExpress.XtraEditors.LabelControl labelUltimoValorTransicao;
        private DevExpress.XtraEditors.SimpleButton btnAbrirCaixa;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtValorAbertura;
    }
}