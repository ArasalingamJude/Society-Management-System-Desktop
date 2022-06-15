namespace Society_Management_System
{
    partial class AddSociety
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSociety = new System.Windows.Forms.Button();
            this.btnAllocateHouse = new System.Windows.Forms.Button();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSocietyName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtSocietyName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Housing Society";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddSociety
            // 
            this.btnAddSociety.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSociety.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddSociety.Location = new System.Drawing.Point(49, 109);
            this.btnAddSociety.Name = "btnAddSociety";
            this.btnAddSociety.Size = new System.Drawing.Size(144, 34);
            this.btnAddSociety.TabIndex = 1;
            this.btnAddSociety.Text = "AddSociety";
            this.btnAddSociety.UseVisualStyleBackColor = false;
            // 
            // btnAllocateHouse
            // 
            this.btnAllocateHouse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllocateHouse.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAllocateHouse.Location = new System.Drawing.Point(49, 170);
            this.btnAllocateHouse.Name = "btnAllocateHouse";
            this.btnAllocateHouse.Size = new System.Drawing.Size(144, 34);
            this.btnAllocateHouse.TabIndex = 2;
            this.btnAllocateHouse.Text = "Allocate House";
            this.btnAllocateHouse.UseVisualStyleBackColor = false;
            this.btnAllocateHouse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnComplain.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnComplain.Location = new System.Drawing.Point(49, 231);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(144, 34);
            this.btnComplain.TabIndex = 3;
            this.btnComplain.Text = "Complain";
            this.btnComplain.UseVisualStyleBackColor = false;
            this.btnComplain.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(49, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSocietyName
            // 
            this.lblSocietyName.AutoSize = true;
            this.lblSocietyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSocietyName.Location = new System.Drawing.Point(275, 109);
            this.lblSocietyName.Name = "lblSocietyName";
            this.lblSocietyName.Size = new System.Drawing.Size(105, 20);
            this.lblSocietyName.TabIndex = 5;
            this.lblSocietyName.Text = "Society Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(275, 212);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHouseNo.Location = new System.Drawing.Point(275, 161);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(78, 20);
            this.lblHouseNo.TabIndex = 7;
            this.lblHouseNo.Text = "House No";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(275, 264);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 20);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // txtSocietyName
            // 
            this.txtSocietyName.Location = new System.Drawing.Point(435, 106);
            this.txtSocietyName.Name = "txtSocietyName";
            this.txtSocietyName.Size = new System.Drawing.Size(229, 23);
            this.txtSocietyName.TabIndex = 9;
            this.txtSocietyName.TextChanged += new System.EventHandler(this.txtSocietyName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(435, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 23);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(435, 265);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(229, 23);
            this.txtCity.TabIndex = 11;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(435, 161);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(229, 23);
            this.txtHouseNo.TabIndex = 12;
            this.txtHouseNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(449, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSociety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSocietyName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSocietyName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnComplain);
            this.Controls.Add(this.btnAllocateHouse);
            this.Controls.Add(this.btnAddSociety);
            this.Controls.Add(this.label1);
            this.Name = "AddSociety";
            this.Text = "AddSociety";
            this.Load += new System.EventHandler(this.AddSociety_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAddSociety;
        private Button btnAllocateHouse;
        private Button btnComplain;
        private Button btnLogout;
        private Label lblSocietyName;
        private Label lblAddress;
        private Label lblHouseNo;
        private Label lblCity;
        private TextBox txtSocietyName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtHouseNo;
        private Button btnAdd;
    }
}