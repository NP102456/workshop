namespace workshop
{
    partial class FrmCustomerByCountry
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
            dvgResult = new DataGridView();
            cboCountry = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgResult).BeginInit();
            SuspendLayout();
            // 
            // dvgResult
            // 
            dvgResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgResult.Location = new Point(11, 45);
            dvgResult.Name = "dvgResult";
            dvgResult.RowHeadersWidth = 51;
            dvgResult.Size = new Size(776, 392);
            dvgResult.TabIndex = 0;
            dvgResult.Visible = false;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(405, 12);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(185, 28);
            cboCountry.TabIndex = 1;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 15);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "เลือกประเทศที่ตั้งของลูกค้า";
            // 
            // FrmCustomerByCountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(cboCountry);
            Controls.Add(dvgResult);
            Name = "FrmCustomerByCountry";
            Text = "FrmCustomerByCountry";
            WindowState = FormWindowState.Maximized;
            Load += FrmCustomerByCountry_Load;
            ((System.ComponentModel.ISupportInitialize)dvgResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgResult;
        private ComboBox cboCountry;
        private Label label1;
    }
}