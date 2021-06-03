
namespace Contact_Tracing_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.complete_name_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.RichTextBox();
            this.age_box = new System.Windows.Forms.RichTextBox();
            this.address_box = new System.Windows.Forms.RichTextBox();
            this.contact_box = new System.Windows.Forms.RichTextBox();
            this.user_info = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.age_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.user_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // complete_name_label
            // 
            this.complete_name_label.AutoSize = true;
            this.complete_name_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_name_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.complete_name_label.Location = new System.Drawing.Point(14, 20);
            this.complete_name_label.Name = "complete_name_label";
            this.complete_name_label.Size = new System.Drawing.Size(167, 25);
            this.complete_name_label.TabIndex = 0;
            this.complete_name_label.Text = "Complete Name:";
            // 
            // name_box
            // 
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(196, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(312, 33);
            this.name_box.TabIndex = 1;
            this.name_box.TabStop = false;
            this.name_box.Text = "";
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // age_box
            // 
            this.age_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_box.Location = new System.Drawing.Point(196, 93);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(312, 33);
            this.age_box.TabIndex = 1;
            this.age_box.TabStop = false;
            this.age_box.Text = "";
            this.age_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // address_box
            // 
            this.address_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_box.Location = new System.Drawing.Point(196, 170);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(312, 33);
            this.address_box.TabIndex = 1;
            this.address_box.TabStop = false;
            this.address_box.Text = "";
            this.address_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // contact_box
            // 
            this.contact_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.contact_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_box.Location = new System.Drawing.Point(196, 249);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(312, 33);
            this.contact_box.TabIndex = 1;
            this.contact_box.TabStop = false;
            this.contact_box.Text = "";
            this.contact_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // user_info
            // 
            this.user_info.BackColor = System.Drawing.Color.Transparent;
            this.user_info.Controls.Add(this.save_btn);
            this.user_info.Controls.Add(this.contact_box);
            this.user_info.Controls.Add(this.address_box);
            this.user_info.Controls.Add(this.age_box);
            this.user_info.Controls.Add(this.name_box);
            this.user_info.Controls.Add(this.contact_label);
            this.user_info.Controls.Add(this.address_label);
            this.user_info.Controls.Add(this.age_label);
            this.user_info.Controls.Add(this.complete_name_label);
            this.user_info.Location = new System.Drawing.Point(50, 28);
            this.user_info.Name = "user_info";
            this.user_info.Size = new System.Drawing.Size(511, 352);
            this.user_info.TabIndex = 2;
            this.user_info.Paint += new System.Windows.Forms.PaintEventHandler(this.user_info_Paint);
            // 
            // save_btn
            // 
            this.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.save_btn.FlatAppearance.BorderSize = 2;
            this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(368, 297);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 43);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.age_label.Location = new System.Drawing.Point(14, 93);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(53, 25);
            this.age_label.TabIndex = 0;
            this.age_label.Text = "Age:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.address_label.Location = new System.Drawing.Point(14, 170);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(90, 25);
            this.address_label.TabIndex = 0;
            this.address_label.Text = "Address:";
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contact_label.Location = new System.Drawing.Point(14, 249);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(170, 25);
            this.contact_label.TabIndex = 0;
            this.contact_label.Text = "Contact Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 424);
            this.Controls.Add(this.user_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.user_info.ResumeLayout(false);
            this.user_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label complete_name_label;
        private System.Windows.Forms.RichTextBox name_box;
        private System.Windows.Forms.RichTextBox age_box;
        private System.Windows.Forms.RichTextBox address_box;
        private System.Windows.Forms.RichTextBox contact_box;
        private System.Windows.Forms.Panel user_info;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label age_label;
    }
}

