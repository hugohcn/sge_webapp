namespace ModuloVendas
{
    partial class frmModuloVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCodigoProduto = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigoProduto = new DevExpress.XtraEditors.TextEdit();
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidade = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new DevExpress.XtraEditors.TextEdit();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.pnFundo = new System.Windows.Forms.Panel();
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.tBLTIPOPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTipoPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTipoPagamento = new ModuloVendas.sets.dsTipoPagamento();
            this.lblTipoPagamento = new DevExpress.XtraEditors.LabelControl();
            this.btnLimparForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnEfetuarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.tBLTIPOPAGAMENTOTableAdapter = new ModuloVendas.sets.dsTipoPagamentoTableAdapters.TBLTIPOPAGAMENTOTableAdapter();
            this.bUTipoPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            this.pnFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTIPOPAGAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUTipoPagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 1;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newToolStripMenuItem.Text = "&Módulo de Gerenciamento";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "&Sair";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.undoToolStripMenuItem.Text = "&Abrir Caixa";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.redoToolStripMenuItem.Text = "&Fechar Caixa";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(134, 6);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaçãoToolStripMenuItem,
            this.contToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.documentaçãoToolStripMenuItem.Text = "&Documentação";
            // 
            // contToolStripMenuItem
            // 
            this.contToolStripMenuItem.Name = "contToolStripMenuItem";
            this.contToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.contToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.contToolStripMenuItem.Text = "&Contato";
            this.contToolStripMenuItem.Click += new System.EventHandler(this.contToolStripMenuItem_Click);
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCodigoProduto.Appearance.Options.UseFont = true;
            this.lblCodigoProduto.CausesValidation = false;
            this.lblCodigoProduto.Location = new System.Drawing.Point(18, 134);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(110, 16);
            this.lblCodigoProduto.TabIndex = 4;
            this.lblCodigoProduto.Text = "Código do Produto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ModuloVendas.Properties.Resources.topo_winform_vendas_sge_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(134, 133);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCodigoProduto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCodigoProduto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCodigoProduto.Properties.LookAndFeel.SkinName = "iMaginary";
            this.txtCodigoProduto.Properties.ValidateOnEnterKey = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(164, 20);
            this.txtCodigoProduto.TabIndex = 0;
            this.txtCodigoProduto.ToolTip = "Para a consulta do produto é necessário informá-lo.";
            this.txtCodigoProduto.ToolTipTitle = "Campo obrigatório";
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.AllowUserToAddRows = false;
            this.gdvProdutos.AllowUserToResizeColumns = false;
            this.gdvProdutos.AllowUserToResizeRows = false;
            this.gdvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gdvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gdvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Valor,
            this.Quantidade,
            this.Total});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdvProdutos.Location = new System.Drawing.Point(-3, 225);
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdvProdutos.Size = new System.Drawing.Size(784, 150);
            this.gdvProdutos.TabIndex = 6;
            this.gdvProdutos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gdvProdutos_UserDeletingRow);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "StrProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.ToolTipText = "Produto";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "FltValor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.ToolTipText = "Valor do Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "IntQuantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.ToolTipText = "Quantidade Desejada";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblQuantidade.Appearance.Options.UseFont = true;
            this.lblQuantidade.CausesValidation = false;
            this.lblQuantidade.Location = new System.Drawing.Point(18, 162);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(70, 16);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(134, 161);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtQuantidade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.LookAndFeel.SkinName = "iMaginary";
            this.txtQuantidade.Properties.ValidateOnEnterKey = true;
            this.txtQuantidade.Size = new System.Drawing.Size(34, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.ToolTip = "Para a consulta do produto é necessário informá-lo.";
            this.txtQuantidade.ToolTipTitle = "Campo obrigatório";
            this.txtQuantidade.EditValueChanged += new System.EventHandler(this.txtQuantidade_EditValueChanged);
            this.txtQuantidade.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtQuantidade_PreviewKeyDown);
            // 
            // lblValor
            // 
            this.lblValor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblValor.Appearance.Options.UseFont = true;
            this.lblValor.Location = new System.Drawing.Point(646, 401);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 19);
            this.lblValor.TabIndex = 9;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Location = new System.Drawing.Point(597, 401);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(43, 19);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "Valor:";
            // 
            // pnFundo
            // 
            this.pnFundo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnFundo.Controls.Add(this.txtDesconto);
            this.pnFundo.Controls.Add(this.labelControl1);
            this.pnFundo.Controls.Add(this.cmbTipoPagamento);
            this.pnFundo.Controls.Add(this.lblTipoPagamento);
            this.pnFundo.Controls.Add(this.btnLimparForm);
            this.pnFundo.Controls.Add(this.btnEfetuarVenda);
            this.pnFundo.Controls.Add(this.lblValorTotal);
            this.pnFundo.Controls.Add(this.lblValor);
            this.pnFundo.Controls.Add(this.txtQuantidade);
            this.pnFundo.Controls.Add(this.lblQuantidade);
            this.pnFundo.Controls.Add(this.gdvProdutos);
            this.pnFundo.Controls.Add(this.txtCodigoProduto);
            this.pnFundo.Controls.Add(this.pictureBox1);
            this.pnFundo.Controls.Add(this.lblCodigoProduto);
            this.pnFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundo.Location = new System.Drawing.Point(0, 24);
            this.pnFundo.Name = "pnFundo";
            this.pnFundo.Size = new System.Drawing.Size(784, 518);
            this.pnFundo.TabIndex = 3;
            // 
            // txtDesconto
            // 
            this.txtDesconto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtDesconto.Location = new System.Drawing.Point(146, 432);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDesconto.Properties.LookAndFeel.SkinName = "iMaginary";
            this.txtDesconto.Properties.ValidateOnEnterKey = true;
            this.txtDesconto.Size = new System.Drawing.Size(118, 20);
            this.txtDesconto.TabIndex = 16;
            this.txtDesconto.ToolTip = "Valor de desconto na compra.";
            this.txtDesconto.ToolTipTitle = "Campo obrigatório";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.CausesValidation = false;
            this.labelControl1.Location = new System.Drawing.Point(18, 433);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Valor de Desconto:";
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.DataSource = this.tBLTIPOPAGAMENTOBindingSource;
            this.cmbTipoPagamento.DisplayMember = "STRNOME";
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.ItemHeight = 13;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(146, 403);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoPagamento.TabIndex = 14;
            this.cmbTipoPagamento.ValueMember = "ID_TIPOPAGAMENTO";
            // 
            // tBLTIPOPAGAMENTOBindingSource
            // 
            this.tBLTIPOPAGAMENTOBindingSource.DataMember = "TBLTIPOPAGAMENTO";
            this.tBLTIPOPAGAMENTOBindingSource.DataSource = this.dsTipoPagamentoBindingSource;
            // 
            // dsTipoPagamentoBindingSource
            // 
            this.dsTipoPagamentoBindingSource.DataSource = this.dsTipoPagamento;
            this.dsTipoPagamentoBindingSource.Position = 0;
            // 
            // dsTipoPagamento
            // 
            this.dsTipoPagamento.DataSetName = "dsTipoPagamento";
            this.dsTipoPagamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTipoPagamento.Appearance.Options.UseFont = true;
            this.lblTipoPagamento.CausesValidation = false;
            this.lblTipoPagamento.Location = new System.Drawing.Point(18, 404);
            this.lblTipoPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(116, 16);
            this.lblTipoPagamento.TabIndex = 13;
            this.lblTipoPagamento.Text = "Tipo de Pagamento:";
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.Location = new System.Drawing.Point(520, 467);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(120, 25);
            this.btnLimparForm.TabIndex = 12;
            this.btnLimparForm.Text = "Limpar dados";
            this.btnLimparForm.ToolTip = "Limpar os dados existentes na tela de vendas.";
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            // 
            // btnEfetuarVenda
            // 
            this.btnEfetuarVenda.Location = new System.Drawing.Point(661, 467);
            this.btnEfetuarVenda.Name = "btnEfetuarVenda";
            this.btnEfetuarVenda.Size = new System.Drawing.Size(120, 25);
            this.btnEfetuarVenda.TabIndex = 11;
            this.btnEfetuarVenda.Text = "Efetuar venda";
            this.btnEfetuarVenda.ToolTip = "Efetua venda.";
            this.btnEfetuarVenda.Click += new System.EventHandler(this.btnEfetuarVenda_Click);
            // 
            // tBLTIPOPAGAMENTOTableAdapter
            // 
            this.tBLTIPOPAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // bUTipoPagamentoBindingSource
            // 
            this.bUTipoPagamentoBindingSource.AllowNew = false;
            this.bUTipoPagamentoBindingSource.DataSource = typeof(Business.BUTipoPagamento);
            // 
            // frmModuloVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.pnFundo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmModuloVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.G.E - Módulo de Vendas";
            this.Load += new System.EventHandler(this.frmModuloVendas_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            this.pnFundo.ResumeLayout(false);
            this.pnFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTIPOPAGAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUTipoPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl lblCodigoProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtCodigoProduto;
        private System.Windows.Forms.DataGridView gdvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private DevExpress.XtraEditors.LabelControl lblQuantidade;
        private DevExpress.XtraEditors.TextEdit txtQuantidade;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private System.Windows.Forms.Panel pnFundo;
        private DevExpress.XtraEditors.SimpleButton btnEfetuarVenda;
        private DevExpress.XtraEditors.SimpleButton btnLimparForm;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private DevExpress.XtraEditors.LabelControl lblTipoPagamento;
        private System.Windows.Forms.BindingSource bUTipoPagamentoBindingSource;
        private DevExpress.XtraEditors.TextEdit txtDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ModuloVendas.sets.dsTipoPagamento dsTipoPagamento;
        private System.Windows.Forms.BindingSource dsTipoPagamentoBindingSource;
        private System.Windows.Forms.BindingSource tBLTIPOPAGAMENTOBindingSource;
        private ModuloVendas.sets.dsTipoPagamentoTableAdapters.TBLTIPOPAGAMENTOTableAdapter tBLTIPOPAGAMENTOTableAdapter;
    }
}

