
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
            this.complete_name_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.RichTextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.age_box = new System.Windows.Forms.RichTextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.RichTextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.contact_box = new System.Windows.Forms.RichTextBox();
            this.user_info = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.user_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // complete_name_label
            // 
            this.complete_name_label.AutoSize = true;
            this.complete_name_label.Location = new System.Drawing.Point(40, 23);
            this.complete_name_label.Name = "complete_name_label";
            this.complete_name_label.Size = new System.Drawing.Size(85, 13);
            this.complete_name_label.TabIndex = 0;
            this.complete_name_label.Text = "Complete Name:";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(153, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(312, 33);
            this.name_box.TabIndex = 1;
            this.name_box.Text = "";
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(40, 96);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(29, 13);
            this.age_label.TabIndex = 0;
            this.age_label.Text = "Age:";
            // 
            // age_box
            // 
            this.age_box.Location = new System.Drawing.Point(153, 93);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(312, 33);
            this.age_box.TabIndex = 1;
            this.age_box.Text = "";
            this.age_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(40, 173);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(95, 13);
            this.address_label.TabIndex = 0;
            this.address_label.Text = "Complete Address:";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(153, 170);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(312, 33);
            this.address_box.TabIndex = 1;
            this.address_box.Text = "";
            this.address_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(40, 252);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(87, 13);
            this.contact_label.TabIndex = 0;
            this.contact_label.Text = "Contact Number:";
            // 
            // contact_box
            // 
            this.contact_box.Location = new System.Drawing.Point(153, 249);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(312, 33);
            this.contact_box.TabIndex = 1;
            this.contact_box.Text = "";
            this.contact_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // user_info
            // 
            this.user_info.Controls.Add(this.save_btn);
            this.user_info.Controls.Add(this.contact_box);
            this.user_info.Controls.Add(this.contact_label);
            this.user_info.Controls.Add(this.address_box);
            this.user_info.Controls.Add(this.address_label);
            this.user_info.Controls.Add(this.age_box);
            this.user_info.Controls.Add(this.age_label);
            this.user_info.Controls.Add(this.name_box);
            this.user_info.Controls.Add(this.complete_name_label);
            this.user_info.Location = new System.Drawing.Point(44, 60);
            this.user_info.Name = "user_info";
            this.user_info.Size = new System.Drawing.Size(511, 352);
            this.user_info.TabIndex = 2;
            this.user_info.Paint += new System.Windows.Forms.PaintEventHandler(this.user_info_Paint);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(368, 297);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 43);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 424);
            this.Controls.Add(this.user_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.user_info.ResumeLayout(false);
            this.user_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label complete_name_label;
        private System.Windows.Forms.RichTextBox name_box;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.RichTextBox age_box;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.RichTextBox address_box;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.RichTextBox contact_box;
        private System.Windows.Forms.Panel user_info;
        private System.Windows.Forms.Button save_btn;
    }
}

