namespace Contacts
{
    partial class SearchForm
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
            this.lbl_FamilyName = new System.Windows.Forms.Label();
            this.lb_Output = new System.Windows.Forms.ListBox();
            this.cmd_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_FamilyName
            // 
            this.lbl_FamilyName.AutoSize = true;
            this.lbl_FamilyName.Location = new System.Drawing.Point(12, 110);
            this.lbl_FamilyName.Name = "lbl_FamilyName";
            this.lbl_FamilyName.Size = new System.Drawing.Size(80, 15);
            this.lbl_FamilyName.TabIndex = 0;
            this.lbl_FamilyName.Text = "Family Name";
            // 
            // lb_Output
            // 
            this.lb_Output.FormattingEnabled = true;
            this.lb_Output.Location = new System.Drawing.Point(12, 12);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(180, 95);
            this.lb_Output.TabIndex = 3;
            // 
            // cmd_Search
            // 
            this.cmd_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmd_Search.BackColor = System.Drawing.Color.White;
            this.cmd_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmd_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmd_Search.Location = new System.Drawing.Point(129, 124);
            this.cmd_Search.MaximumSize = new System.Drawing.Size(63, 23);
            this.cmd_Search.MinimumSize = new System.Drawing.Size(63, 23);
            this.cmd_Search.Name = "cmd_Search";
            this.cmd_Search.Size = new System.Drawing.Size(63, 23);
            this.cmd_Search.TabIndex = 17;
            this.cmd_Search.Text = "Search";
            this.cmd_Search.UseVisualStyleBackColor = false;
            this.cmd_Search.Click += new System.EventHandler(this.cmd_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline);
            this.txt_Search.Location = new System.Drawing.Point(12, 129);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(111, 13);
            this.txt_Search.TabIndex = 18;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(204, 161);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmd_Search);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.lbl_FamilyName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.MaximumSize = new System.Drawing.Size(220, 199);
            this.MinimumSize = new System.Drawing.Size(220, 199);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FamilyName;
        private System.Windows.Forms.ListBox lb_Output;
        private System.Windows.Forms.Button cmd_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}