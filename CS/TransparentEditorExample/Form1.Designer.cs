namespace TransparentEditorExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.nwindDataSet = new TransparentEditorExample.nwindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new TransparentEditorExample.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.alphaBlendTextEdit9 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit8 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit7 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit6 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit5 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit4 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit3 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit2 = new ZBobb.AlphaBlendTextEdit();
            this.alphaBlendTextEdit1 = new ZBobb.AlphaBlendTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Company Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(204, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Contact Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Contact Title:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(204, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Address:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 67);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "City:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(204, 67);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Region:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Postal Code:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(204, 93);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Country:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 119);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(34, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Phone:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(204, 119);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(22, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Fax:";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.customersBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(13, 142);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(369, 24);
            this.dataNavigator1.TabIndex = 20;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // alphaBlendTextEdit9
            // 
            this.alphaBlendTextEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Phone", true));
            this.alphaBlendTextEdit9.Location = new System.Drawing.Point(98, 116);
            this.alphaBlendTextEdit9.Name = "alphaBlendTextEdit9";
            this.alphaBlendTextEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit9.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit9.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit9.TabIndex = 16;
            // 
            // alphaBlendTextEdit8
            // 
            this.alphaBlendTextEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Country", true));
            this.alphaBlendTextEdit8.Location = new System.Drawing.Point(282, 90);
            this.alphaBlendTextEdit8.Name = "alphaBlendTextEdit8";
            this.alphaBlendTextEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit8.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit8.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit8.TabIndex = 14;
            // 
            // alphaBlendTextEdit7
            // 
            this.alphaBlendTextEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "PostalCode", true));
            this.alphaBlendTextEdit7.Location = new System.Drawing.Point(98, 90);
            this.alphaBlendTextEdit7.Name = "alphaBlendTextEdit7";
            this.alphaBlendTextEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit7.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit7.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit7.TabIndex = 12;
            // 
            // alphaBlendTextEdit6
            // 
            this.alphaBlendTextEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Region", true));
            this.alphaBlendTextEdit6.Location = new System.Drawing.Point(282, 64);
            this.alphaBlendTextEdit6.Name = "alphaBlendTextEdit6";
            this.alphaBlendTextEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit6.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit6.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit6.TabIndex = 10;
            // 
            // alphaBlendTextEdit5
            // 
            this.alphaBlendTextEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "City", true));
            this.alphaBlendTextEdit5.Location = new System.Drawing.Point(98, 64);
            this.alphaBlendTextEdit5.Name = "alphaBlendTextEdit5";
            this.alphaBlendTextEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit5.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit5.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit5.TabIndex = 8;
            // 
            // alphaBlendTextEdit4
            // 
            this.alphaBlendTextEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Address", true));
            this.alphaBlendTextEdit4.Location = new System.Drawing.Point(282, 38);
            this.alphaBlendTextEdit4.Name = "alphaBlendTextEdit4";
            this.alphaBlendTextEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit4.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit4.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit4.TabIndex = 6;
            // 
            // alphaBlendTextEdit3
            // 
            this.alphaBlendTextEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "ContactTitle", true));
            this.alphaBlendTextEdit3.Location = new System.Drawing.Point(98, 38);
            this.alphaBlendTextEdit3.Name = "alphaBlendTextEdit3";
            this.alphaBlendTextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit3.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit3.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit3.TabIndex = 4;
            // 
            // alphaBlendTextEdit2
            // 
            this.alphaBlendTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "ContactName", true));
            this.alphaBlendTextEdit2.Location = new System.Drawing.Point(282, 12);
            this.alphaBlendTextEdit2.Name = "alphaBlendTextEdit2";
            this.alphaBlendTextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit2.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit2.TabIndex = 2;
            // 
            // alphaBlendTextEdit1
            // 
            this.alphaBlendTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "CompanyName", true));
            this.alphaBlendTextEdit1.Location = new System.Drawing.Point(98, 12);
            this.alphaBlendTextEdit1.Name = "alphaBlendTextEdit1";
            this.alphaBlendTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.alphaBlendTextEdit1.Properties.BackAlpha = 0;
            this.alphaBlendTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.alphaBlendTextEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 171);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.alphaBlendTextEdit9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.alphaBlendTextEdit8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.alphaBlendTextEdit7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.alphaBlendTextEdit6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.alphaBlendTextEdit5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.alphaBlendTextEdit4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.alphaBlendTextEdit3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.alphaBlendTextEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.alphaBlendTextEdit1);
            this.LookAndFeel.SkinName = "Xmas 2008 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaBlendTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TransparentEditorExample.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private ZBobb.AlphaBlendTextEdit alphaBlendTextEdit10;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;

    }
}

