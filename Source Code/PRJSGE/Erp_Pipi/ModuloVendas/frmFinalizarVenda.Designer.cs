namespace ModuloVendas
{
    partial class frmFinalizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarVenda));
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEfetuarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTroco = new DevExpress.XtraEditors.LabelControl();
            this.lblValorRecebido = new DevExpress.XtraEditors.LabelControl();
            this.txtValorRecebido = new DevExpress.XtraEditors.TextEdit();
            this.lblValorDesconto = new DevExpress.XtraEditors.LabelControl();
            this.lblDesconto = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRecebido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(177, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEfetuarVenda
            // 
            this.btnEfetuarVenda.Location = new System.Drawing.Point(283, 272);
            this.btnEfetuarVenda.Name = "btnEfetuarVenda";
            this.btnEfetuarVenda.Size = new System.Drawing.Size(100, 23);
            this.btnEfetuarVenda.TabIndex = 1;
            this.btnEfetuarVenda.Text = "Efetuar venda";
            this.btnEfetuarVenda.Click += new System.EventHandler(this.btnEfetuarVenda_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 235);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Troco:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Location = new System.Drawing.Point(80, 200);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 19);
            this.lblValorTotal.TabIndex = 4;
            // 
            // lblValorTroco
            // 
            this.lblValorTroco.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTroco.Appearance.Options.UseFont = true;
            this.lblValorTroco.Location = new System.Drawing.Point(80, 235);
            this.lblValorTroco.Name = "lblValorTroco";
            this.lblValorTroco.Size = new System.Drawing.Size(0, 19);
            this.lblValorTroco.TabIndex = 5;
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorRecebido.Appearance.Options.UseFont = true;
            this.lblValorRecebido.Location = new System.Drawing.Point(21, 132);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(118, 18);
            this.lblValorRecebido.TabIndex = 6;
            this.lblValorRecebido.Text = "Valor Recebido:";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(145, 133);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorRecebido.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorRecebido.Properties.ValidateOnEnterKey = true;
            this.txtValorRecebido.Size = new System.Drawing.Size(119, 20);
            this.txtValorRecebido.TabIndex = 0;
            this.txtValorRecebido.EditValueChanged += new System.EventHandler(this.txtValorRecebido_EditValueChanged);
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorDesconto.Appearance.Options.UseFont = true;
            this.lblValorDesconto.Location = new System.Drawing.Point(108, 165);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(0, 19);
            this.lblValorDesconto.TabIndex = 10;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesconto.Appearance.Options.UseFont = true;
            this.lblDesconto.Location = new System.Drawing.Point(21, 165);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(81, 19);
            this.lblDesconto.TabIndex = 9;
            this.lblDesconto.Text = "Desconto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 111);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmFinalizarVenda
            // 
            this.AcceptButton = this.btnEfetuarVenda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(391, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValorDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.lblValorRecebido);
            this.Controls.Add(this.lblValorTroco);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEfetuarVenda);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFinalizarVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venda";
            this.Load += new System.EventHandler(this.frmFinalizarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRecebido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnEfetuarVenda;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl lblValorTroco;
        private DevExpress.XtraEditors.LabelControl lblValorRecebido;
        private DevExpress.XtraEditors.TextEdit txtValorRecebido;
        private DevExpress.XtraEditors.LabelControl lblValorDesconto;
        private DevExpress.XtraEditors.LabelControl lblDesconto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}