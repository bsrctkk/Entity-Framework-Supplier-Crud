namespace EFÖdev
{
    partial class SupplierSearch
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
            lblCompanyName = new Label();
            lblContactName = new Label();
            lblContactTitle = new Label();
            lblAdress = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(262, 45);
            label1.TabIndex = 0;
            label1.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 131);
            label2.Name = "label2";
            label2.Size = new Size(238, 45);
            label2.TabIndex = 1;
            label2.Text = "Contact Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 211);
            label3.Name = "label3";
            label3.Size = new Size(214, 45);
            label3.TabIndex = 2;
            label3.Text = "Contact Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 283);
            label4.Name = "label4";
            label4.Size = new Size(144, 45);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyName.Location = new Point(343, 51);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(0, 45);
            lblCompanyName.TabIndex = 4;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactName.Location = new Point(343, 131);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(0, 45);
            lblContactName.TabIndex = 5;
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactTitle.Location = new Point(343, 211);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(0, 45);
            lblContactTitle.TabIndex = 6;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdress.Location = new Point(343, 283);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(0, 45);
            lblAdress.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(622, 117);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(375, 39);
            txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(708, 211);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(211, 67);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // SupplierSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 471);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblAdress);
            Controls.Add(lblContactTitle);
            Controls.Add(lblContactName);
            Controls.Add(lblCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplierSearch";
            Text = "SupplierSearch";
            Load += SupplierSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCompanyName;
        private Label lblContactName;
        private Label lblContactTitle;
        private Label lblAdress;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}