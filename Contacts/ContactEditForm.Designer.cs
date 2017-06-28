namespace Contacts
{
    partial class ContactEdit
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_FamilyName = new System.Windows.Forms.Label();
            this.txt_FamilyName = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.cmd_Discard = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline);
            this.txt_Name.Location = new System.Drawing.Point(98, 14);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(122, 13);
            this.txt_Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Name.Location = new System.Drawing.Point(14, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 15);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_FamilyName
            // 
            this.lbl_FamilyName.AutoSize = true;
            this.lbl_FamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbl_FamilyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_FamilyName.Location = new System.Drawing.Point(14, 38);
            this.lbl_FamilyName.Name = "lbl_FamilyName";
            this.lbl_FamilyName.Size = new System.Drawing.Size(80, 15);
            this.lbl_FamilyName.TabIndex = 2;
            this.lbl_FamilyName.Text = "Family Name";
            // 
            // txt_FamilyName
            // 
            this.txt_FamilyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline);
            this.txt_FamilyName.Location = new System.Drawing.Point(100, 40);
            this.txt_FamilyName.Name = "txt_FamilyName";
            this.txt_FamilyName.Size = new System.Drawing.Size(122, 13);
            this.txt_FamilyName.TabIndex = 3;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Phone.Location = new System.Drawing.Point(12, 64);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(43, 15);
            this.lbl_Phone.TabIndex = 4;
            this.lbl_Phone.Text = "Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline);
            this.txt_Phone.Location = new System.Drawing.Point(98, 66);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(122, 13);
            this.txt_Phone.TabIndex = 5;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbl_Age.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Age.Location = new System.Drawing.Point(12, 90);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(28, 15);
            this.lbl_Age.TabIndex = 6;
            this.lbl_Age.Text = "Age";
            // 
            // txt_Age
            // 
            this.txt_Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline);
            this.txt_Age.Location = new System.Drawing.Point(100, 92);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(122, 13);
            this.txt_Age.TabIndex = 7;
            // 
            // cmd_Discard
            // 
            this.cmd_Discard.BackColor = System.Drawing.Color.White;
            this.cmd_Discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Discard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmd_Discard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Discard.Location = new System.Drawing.Point(145, 113);
            this.cmd_Discard.Name = "cmd_Discard";
            this.cmd_Discard.Size = new System.Drawing.Size(75, 23);
            this.cmd_Discard.TabIndex = 8;
            this.cmd_Discard.Text = "Discard";
            this.cmd_Discard.UseVisualStyleBackColor = false;
            this.cmd_Discard.Click += new System.EventHandler(this.cmd_Discard_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.BackColor = System.Drawing.Color.White;
            this.cmd_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmd_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Save.Location = new System.Drawing.Point(12, 113);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(75, 23);
            this.cmd_Save.TabIndex = 9;
            this.cmd_Save.Text = "Save";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // ContactEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(232, 143);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Discard);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_FamilyName);
            this.Controls.Add(this.lbl_FamilyName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ContactEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_FamilyName;
        private System.Windows.Forms.TextBox txt_FamilyName;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Button cmd_Discard;
        private System.Windows.Forms.Button cmd_Save;
    }
}