
namespace Contact_Tracing_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button3 = new System.Windows.Forms.Button();
            this.user1_label = new System.Windows.Forms.Label();
            this.user2_label = new System.Windows.Forms.Label();
            this.user3_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(214, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Created By: Ruel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // user1_label
            // 
            this.user1_label.AutoSize = true;
            this.user1_label.Location = new System.Drawing.Point(9, 49);
            this.user1_label.Name = "user1_label";
            this.user1_label.Size = new System.Drawing.Size(0, 13);
            this.user1_label.TabIndex = 4;
            // 
            // user2_label
            // 
            this.user2_label.AutoSize = true;
            this.user2_label.Location = new System.Drawing.Point(211, 49);
            this.user2_label.Name = "user2_label";
            this.user2_label.Size = new System.Drawing.Size(0, 13);
            this.user2_label.TabIndex = 4;
            // 
            // user3_label
            // 
            this.user3_label.AutoSize = true;
            this.user3_label.Location = new System.Drawing.Point(414, 49);
            this.user3_label.Name = "user3_label";
            this.user3_label.Size = new System.Drawing.Size(0, 13);
            this.user3_label.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 424);
            this.Controls.Add(this.user3_label);
            this.Controls.Add(this.user2_label);
            this.Controls.Add(this.user1_label);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label user1_label;
        private System.Windows.Forms.Label user2_label;
        private System.Windows.Forms.Label user3_label;
    }
}