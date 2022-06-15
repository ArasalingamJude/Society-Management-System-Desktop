namespace Society_Management_System
{
    partial class UserPanel
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
            this.btnMakeComplain = new System.Windows.Forms.Button();
            this.btnRentOrSell = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblComplain = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnComplain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            // 
            // btnMakeComplain
            // 
            this.btnMakeComplain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeComplain.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnMakeComplain.Location = new System.Drawing.Point(30, 121);
            this.btnMakeComplain.Name = "btnMakeComplain";
            this.btnMakeComplain.Size = new System.Drawing.Size(144, 34);
            this.btnMakeComplain.TabIndex = 15;
            this.btnMakeComplain.Text = "Make Complain";
            this.btnMakeComplain.UseVisualStyleBackColor = false;
            this.btnMakeComplain.Click += new System.EventHandler(this.btnMakeComplain_Click);
            // 
            // btnRentOrSell
            // 
            this.btnRentOrSell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRentOrSell.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRentOrSell.Location = new System.Drawing.Point(30, 210);
            this.btnRentOrSell.Name = "btnRentOrSell";
            this.btnRentOrSell.Size = new System.Drawing.Size(144, 34);
            this.btnRentOrSell.TabIndex = 16;
            this.btnRentOrSell.Text = "Rent Or Sell";
            this.btnRentOrSell.UseVisualStyleBackColor = false;
            this.btnRentOrSell.Click += new System.EventHandler(this.btnRentOrSell_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(30, 358);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 34);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberName.Location = new System.Drawing.Point(272, 121);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(114, 20);
            this.lblMemberName.TabIndex = 19;
            this.lblMemberName.Text = "Member Name";
            this.lblMemberName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblComplain
            // 
            this.lblComplain.AutoSize = true;
            this.lblComplain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplain.Location = new System.Drawing.Point(272, 233);
            this.lblComplain.Name = "lblComplain";
            this.lblComplain.Size = new System.Drawing.Size(75, 20);
            this.lblComplain.TabIndex = 20;
            this.lblComplain.Text = "Complain";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(272, 168);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 20);
            this.lblSubject.TabIndex = 21;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(418, 118);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(229, 23);
            this.txtMemberName.TabIndex = 23;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(418, 165);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(229, 23);
            this.txtSubject.TabIndex = 24;
            this.txtSubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 25;
            // 
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComplain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComplain.Location = new System.Drawing.Point(433, 326);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(147, 38);
            this.btnComplain.TabIndex = 31;
            this.btnComplain.Text = "Make Complain";
            this.btnComplain.UseVisualStyleBackColor = false;
            this.btnComplain.Click += new System.EventHandler(this.btnComplain_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComplain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblComplain);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRentOrSell);
            this.Controls.Add(this.btnMakeComplain);
            this.Controls.Add(this.label1);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMakeComplain;
        private Button btnRentOrSell;
        private Button btnLogout;
        private Label lblMemberName;
        private Label lblComplain;
        private Label lblSubject;
        private TextBox txtMemberName;
        private TextBox txtSubject;
        private TextBox textBox1;
        private Button btnComplain;
    }
}