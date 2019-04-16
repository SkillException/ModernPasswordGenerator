namespace ModernPasswordGenerator
{
    partial class ModernPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernPasswordGenerator));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.btnAutoCopy = new System.Windows.Forms.Button();
            this.lblAutoCopy = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOwnersRights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.btnClose.Location = new System.Drawing.Point(295, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(12, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(277, 31);
            this.txtPassword.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Password Generator";
            // 
            // txtWords
            // 
            this.txtWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.txtWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWords.Location = new System.Drawing.Point(12, 56);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(52, 31);
            this.txtWords.TabIndex = 3;
            this.txtWords.Text = "2";
            this.txtWords.TextChanged += new System.EventHandler(this.txtWords_TextChanged);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.lblWords.Location = new System.Drawing.Point(70, 58);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(74, 25);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "Words";
            this.lblWords.Click += new System.EventHandler(this.lblWords_Click);
            // 
            // btnAutoCopy
            // 
            this.btnAutoCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnAutoCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.btnAutoCopy.Location = new System.Drawing.Point(12, 93);
            this.btnAutoCopy.Name = "btnAutoCopy";
            this.btnAutoCopy.Size = new System.Drawing.Size(183, 33);
            this.btnAutoCopy.TabIndex = 5;
            this.btnAutoCopy.Text = "Copy on Generate";
            this.btnAutoCopy.UseVisualStyleBackColor = false;
            this.btnAutoCopy.Click += new System.EventHandler(this.btnAutoCopy_Click);
            // 
            // lblAutoCopy
            // 
            this.lblAutoCopy.AutoSize = true;
            this.lblAutoCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.lblAutoCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.lblAutoCopy.Location = new System.Drawing.Point(290, 93);
            this.lblAutoCopy.Name = "lblAutoCopy";
            this.lblAutoCopy.Size = new System.Drawing.Size(109, 29);
            this.lblAutoCopy.TabIndex = 4;
            this.lblAutoCopy.Text = "Disabled";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.btnCopy.Location = new System.Drawing.Point(295, 147);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(93, 33);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.btnImport.Location = new System.Drawing.Point(12, 186);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(156, 33);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.btnGenerate.Location = new System.Drawing.Point(174, 186);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 33);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 231);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Loading...";
            // 
            // lblOwnersRights
            // 
            this.lblOwnersRights.AutoSize = true;
            this.lblOwnersRights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.lblOwnersRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnersRights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(176)))), ((int)(((byte)(44)))));
            this.lblOwnersRights.Location = new System.Drawing.Point(261, 231);
            this.lblOwnersRights.Name = "lblOwnersRights";
            this.lblOwnersRights.Size = new System.Drawing.Size(127, 20);
            this.lblOwnersRights.TabIndex = 4;
            this.lblOwnersRights.Text = "by SkillException";
            this.lblOwnersRights.Click += new System.EventHandler(this.lblOwnersRights_Click);
            // 
            // ModernPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAutoCopy);
            this.Controls.Add(this.lblAutoCopy);
            this.Controls.Add(this.lblOwnersRights);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModernPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModernPasswordGenerator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModernPasswordGenerator_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EM_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EM_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnAutoCopy;
        private System.Windows.Forms.Label lblAutoCopy;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOwnersRights;
    }
}

