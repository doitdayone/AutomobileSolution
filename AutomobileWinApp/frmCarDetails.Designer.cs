namespace AutomobileWinApp
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbID = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            lbName = new Label();
            lbManufactor = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            cboManufactor = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(30, 29);
            lbID.Name = "lbID";
            lbID.Size = new Size(44, 17);
            lbID.TabIndex = 0;
            lbID.Text = "Car ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(118, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 25);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(118, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 25);
            txtName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(30, 65);
            lbName.Name = "lbName";
            lbName.Size = new Size(67, 17);
            lbName.TabIndex = 2;
            lbName.Text = "Car Name";
            // 
            // lbManufactor
            // 
            lbManufactor.AutoSize = true;
            lbManufactor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbManufactor.Location = new Point(30, 100);
            lbManufactor.Name = "lbManufactor";
            lbManufactor.Size = new Size(75, 17);
            lbManufactor.TabIndex = 4;
            lbManufactor.Text = "Manufactor";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(30, 135);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 17);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleaseYear.Location = new Point(30, 170);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(82, 17);
            lbReleaseYear.TabIndex = 8;
            lbReleaseYear.Text = "Release Year";
            // 
            // cboManufactor
            // 
            cboManufactor.FormattingEnabled = true;
            cboManufactor.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "HuynDai", "Kia", "Suzuki", "Toyota" });
            cboManufactor.Location = new Point(118, 97);
            cboManufactor.Name = "cboManufactor";
            cboManufactor.Size = new Size(189, 25);
            cboManufactor.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 132);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(189, 25);
            txtPrice.TabIndex = 10;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(118, 167);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(189, 25);
            txtReleaseYear.TabIndex = 11;
            txtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(118, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(232, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 266);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufactor);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufactor);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox txtID;
        private TextBox txtName;
        private Label lbName;
        private Label lbManufactor;
        private Label lbPrice;
        private Label lbReleaseYear;
        private ComboBox cboManufactor;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}