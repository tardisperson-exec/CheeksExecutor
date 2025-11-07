namespace CheeksExec
{
    partial class Form1
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
            this.AttachBTN = new System.Windows.Forms.Button();
            this.InfYeildBTN = new System.Windows.Forms.Button();
            this.quorumMonaco11 = new QuorumMonaco.QuorumMonaco1();
            this.ExecuteBTN = new System.Windows.Forms.Button();
            this.isattached = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttachBTN
            // 
            this.AttachBTN.Location = new System.Drawing.Point(382, 448);
            this.AttachBTN.Name = "AttachBTN";
            this.AttachBTN.Size = new System.Drawing.Size(145, 47);
            this.AttachBTN.TabIndex = 3;
            this.AttachBTN.Text = "Inject";
            this.AttachBTN.UseVisualStyleBackColor = true;
            this.AttachBTN.Click += new System.EventHandler(this.AttachBTN_Click);
            // 
            // InfYeildBTN
            // 
            this.InfYeildBTN.Location = new System.Drawing.Point(12, 450);
            this.InfYeildBTN.Name = "InfYeildBTN";
            this.InfYeildBTN.Size = new System.Drawing.Size(66, 45);
            this.InfYeildBTN.TabIndex = 5;
            this.InfYeildBTN.Text = "IY";
            this.InfYeildBTN.UseVisualStyleBackColor = true;
            this.InfYeildBTN.Click += new System.EventHandler(this.InfYeildBTN_Click);
            // 
            // quorumMonaco11
            // 
            this.quorumMonaco11.Location = new System.Drawing.Point(13, 13);
            this.quorumMonaco11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quorumMonaco11.Name = "quorumMonaco11";
            this.quorumMonaco11.Size = new System.Drawing.Size(514, 428);
            this.quorumMonaco11.TabIndex = 7;
            // 
            // ExecuteBTN
            // 
            this.ExecuteBTN.Location = new System.Drawing.Point(231, 450);
            this.ExecuteBTN.Name = "ExecuteBTN";
            this.ExecuteBTN.Size = new System.Drawing.Size(145, 45);
            this.ExecuteBTN.TabIndex = 8;
            this.ExecuteBTN.Text = "Execute";
            this.ExecuteBTN.UseVisualStyleBackColor = true;
            this.ExecuteBTN.Click += new System.EventHandler(this.ExecuteBTN_Click);
            // 
            // isattached
            // 
            this.isattached.Location = new System.Drawing.Point(85, 450);
            this.isattached.Name = "isattached";
            this.isattached.Size = new System.Drawing.Size(93, 43);
            this.isattached.TabIndex = 9;
            this.isattached.Text = "Is Attached?";
            this.isattached.UseVisualStyleBackColor = true;
            this.isattached.Click += new System.EventHandler(this.isattached_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 505);
            this.Controls.Add(this.isattached);
            this.Controls.Add(this.ExecuteBTN);
            this.Controls.Add(this.quorumMonaco11);
            this.Controls.Add(this.InfYeildBTN);
            this.Controls.Add(this.AttachBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AttachBTN;
        private System.Windows.Forms.Button InfYeildBTN;
        private QuorumMonaco.QuorumMonaco1 quorumMonaco11;
        private System.Windows.Forms.Button ExecuteBTN;
        private System.Windows.Forms.Button isattached;
    }
}

