using System.IO;

namespace Contacts
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                File.Move("../../contacts.csv.temp", "../../contacts.csv");
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmd_Back = new System.Windows.Forms.Button();
            this.cmd_Forward = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Insert = new System.Windows.Forms.Button();
            this.cmd_Remove = new System.Windows.Forms.Button();
            this.lb_Show = new System.Windows.Forms.ListBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.cmd_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Back
            // 
            this.cmd_Back.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmd_Back, "cmd_Back");
            this.cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Back.Name = "cmd_Back";
            this.cmd_Back.UseVisualStyleBackColor = false;
            this.cmd_Back.Click += new System.EventHandler(this.cmd_Back_Click);
            // 
            // cmd_Forward
            // 
            this.cmd_Forward.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmd_Forward, "cmd_Forward");
            this.cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Forward.Name = "cmd_Forward";
            this.cmd_Forward.UseVisualStyleBackColor = false;
            this.cmd_Forward.Click += new System.EventHandler(this.cmd_Forward_Click);
            // 
            // cmd_Add
            // 
            resources.ApplyResources(this.cmd_Add, "cmd_Add");
            this.cmd_Add.BackColor = System.Drawing.Color.White;
            this.cmd_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmd_Update, "cmd_Update");
            this.cmd_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Insert
            // 
            this.cmd_Insert.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmd_Insert, "cmd_Insert");
            this.cmd_Insert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Insert.Name = "cmd_Insert";
            this.cmd_Insert.UseVisualStyleBackColor = false;
            this.cmd_Insert.Click += new System.EventHandler(this.cmd_Insert_Click);
            // 
            // cmd_Remove
            // 
            this.cmd_Remove.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cmd_Remove, "cmd_Remove");
            this.cmd_Remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_Remove.Name = "cmd_Remove";
            this.cmd_Remove.UseVisualStyleBackColor = false;
            this.cmd_Remove.Click += new System.EventHandler(this.cmd_Remove_Click);
            // 
            // lb_Show
            // 
            this.lb_Show.BackColor = System.Drawing.Color.White;
            this.lb_Show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lb_Show, "lb_Show");
            this.lb_Show.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Show.FormattingEnabled = true;
            this.lb_Show.MultiColumn = true;
            this.lb_Show.Name = "lb_Show";
            // 
            // lbl_Count
            // 
            resources.ApplyResources(this.lbl_Count, "lbl_Count");
            this.lbl_Count.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Count.Name = "lbl_Count";
            // 
            // cmd_search
            // 
            resources.ApplyResources(this.cmd_search, "cmd_search");
            this.cmd_search.BackColor = System.Drawing.Color.White;
            this.cmd_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_search.Name = "cmd_search";
            this.cmd_search.UseVisualStyleBackColor = false;
            this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmd_search);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lb_Show);
            this.Controls.Add(this.cmd_Remove);
            this.Controls.Add(this.cmd_Insert);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.cmd_Forward);
            this.Controls.Add(this.cmd_Back);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Back;
        private System.Windows.Forms.Button cmd_Forward;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Insert;
        private System.Windows.Forms.Button cmd_Remove;
        private System.Windows.Forms.ListBox lb_Show;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button cmd_search;
    }
}

