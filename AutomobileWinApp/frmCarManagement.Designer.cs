namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            btnNew = new Button();
            btnLoad = new Button();
            lbManufactor = new Label();
            txtName = new TextBox();
            lbName = new Label();
            txtID = new TextBox();
            lbID = new Label();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            txtPrice = new TextBox();
            txtManufactor = new TextBox();
            txtReleaseYear = new TextBox();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(428, 93);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(62, 23);
            btnNew.TabIndex = 25;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(349, 93);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(62, 23);
            btnLoad.TabIndex = 24;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbManufactor
            // 
            lbManufactor.AutoSize = true;
            lbManufactor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbManufactor.Location = new Point(33, 90);
            lbManufactor.Name = "lbManufactor";
            lbManufactor.Size = new Size(75, 17);
            lbManufactor.TabIndex = 18;
            lbManufactor.Text = "Manufactor";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(121, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 25);
            txtName.TabIndex = 17;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(33, 55);
            lbName.Name = "lbName";
            lbName.Size = new Size(67, 17);
            lbName.TabIndex = 16;
            lbName.Text = "Car Name";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(121, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 25);
            txtID.TabIndex = 15;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(33, 19);
            lbID.Name = "lbID";
            lbID.Size = new Size(44, 17);
            lbID.TabIndex = 14;
            lbID.Text = "Car ID";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleaseYear.Location = new Point(340, 54);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(82, 17);
            lbReleaseYear.TabIndex = 20;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(340, 19);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 17);
            lbPrice.TabIndex = 19;
            lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(428, 16);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(139, 25);
            txtPrice.TabIndex = 27;
            // 
            // txtManufactor
            // 
            txtManufactor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtManufactor.Location = new Point(121, 87);
            txtManufactor.Name = "txtManufactor";
            txtManufactor.Size = new Size(139, 25);
            txtManufactor.TabIndex = 26;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtReleaseYear.Location = new Point(428, 47);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(139, 25);
            txtReleaseYear.TabIndex = 28;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 93);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 23);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(33, 145);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.Size = new Size(534, 234);
            dgvCarList.TabIndex = 30;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(440, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 31;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufactor);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufactor);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnLoad;
        private Label lbManufactor;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtID;
        private Label lbID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private TextBox txtPrice;
        private TextBox txtManufactor;
        private TextBox txtReleaseYear;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}