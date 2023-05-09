namespace EFÖdev.Forms
{
    partial class SupplierAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            txtAdress = new TextBox();
            btnAdd = new Button();
            dataGridSupplierAdd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplierAdd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 67);
            label1.Name = "label1";
            label1.Size = new Size(256, 45);
            label1.TabIndex = 0;
            label1.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 135);
            label2.Name = "label2";
            label2.Size = new Size(231, 45);
            label2.TabIndex = 1;
            label2.Text = "Contact Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 203);
            label3.Name = "label3";
            label3.Size = new Size(207, 45);
            label3.TabIndex = 2;
            label3.Text = "Contact Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 269);
            label4.Name = "label4";
            label4.Size = new Size(123, 45);
            label4.TabIndex = 3;
            label4.Text = "Adress:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(315, 79);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(267, 39);
            txtCompanyName.TabIndex = 4;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(315, 142);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(267, 39);
            txtContactName.TabIndex = 5;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(315, 209);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(267, 39);
            txtContactTitle.TabIndex = 6;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(315, 276);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(267, 39);
            txtAdress.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(369, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 66);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridSupplierAdd
            // 
            dataGridSupplierAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupplierAdd.Location = new Point(659, 50);
            dataGridSupplierAdd.Name = "dataGridSupplierAdd";
            dataGridSupplierAdd.RowHeadersWidth = 82;
            dataGridSupplierAdd.RowTemplate.Height = 41;
            dataGridSupplierAdd.Size = new Size(911, 410);
            dataGridSupplierAdd.TabIndex = 9;
            // 
            // SupplierAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1655, 501);
            Controls.Add(dataGridSupplierAdd);
            Controls.Add(btnAdd);
            Controls.Add(txtAdress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplierAdd";
            Text = "SupplierAdd";
            Load += SupplierAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSupplierAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtAdress;
        private Button btnAdd;
        private DataGridView dataGridSupplierAdd;
    }
}