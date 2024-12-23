namespace workshop
{
    partial class Form2
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
            btnShow = new Button();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(562, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 0;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(216, 12);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(125, 27);
            txtStart.TabIndex = 1;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(413, 12);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 27);
            txtEnd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 16);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "ราคาเริ่มต้น :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 15);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "ถึงราคา :";
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 56);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(776, 382);
            dgvResult.TabIndex = 5;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(btnShow);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Label label1;
        private Label label2;
        private DataGridView dgvResult;
    }
}