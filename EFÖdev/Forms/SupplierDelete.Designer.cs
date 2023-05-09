namespace EFÖdev.Forms
{
    partial class SupplierDelete
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
            txtDelete = new TextBox();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDelete
            // 
            txtDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDelete.Location = new Point(43, 51);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(511, 50);
            txtDelete.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(617, 51);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(212, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1178, 528);
            dataGridView1.TabIndex = 2;
            // 
            // SupplierDelete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 719);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(txtDelete);
            Name = "SupplierDelete";
            Text = "SupplierDelete";
            Load += SupplierDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDelete;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}