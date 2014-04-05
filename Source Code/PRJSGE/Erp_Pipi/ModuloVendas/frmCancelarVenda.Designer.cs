namespace ModuloVendas
{
    partial class frmCancelarVenda
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
            this.dsVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendas = new ModuloVendas.sets.dsVendas();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dsVendasBindingSource
            // 
            this.dsVendasBindingSource.DataSource = this.dsVendas;
            this.dsVendasBindingSource.Position = 0;
            // 
            // dsVendas
            // 
            this.dsVendas.DataSetName = "dsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCancelarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Name = "frmCancelarVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cancelar venda";
            ((System.ComponentModel.ISupportInitialize)(this.dsVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dsVendasBindingSource;
        private ModuloVendas.sets.dsVendas dsVendas;
    }
}