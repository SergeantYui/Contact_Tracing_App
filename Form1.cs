using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        byte counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void user1()
        {
            string filepath = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user1.txt";
            //string[] lines = File.ReadAllLines(filepath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();

            lines.Add("Complete Name: " + name_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Age: " + age_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Complete Address: " + address_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Contact Number: " + contact_box.Text);
            File.WriteAllLines(filepath, lines);
        }
        private void user2()
        {
            string filepath = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user2.txt";
            //string[] lines = File.ReadAllLines(filepath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();

            lines.Add("Complete Name: " + name_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Age: " + age_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Complete Address: " + address_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Contact Number: " + contact_box.Text);
            File.WriteAllLines(filepath, lines);
        }
        private void user3()
        {
            string filepath = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user3.txt";
            //string[] lines = File.ReadAllLines(filepath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();

            lines.Add("Complete Name: " + name_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Age: " + age_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Complete Address: " + address_box.Text);
            File.WriteAllLines(filepath, lines);

            lines.Add("Contact Number: " + contact_box.Text);
            File.WriteAllLines(filepath, lines);
        }


        private void name_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void user_info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                user1();
                save_btn.Enabled = false;
            }
            if (counter == 1)
            {
                user2();
                save_btn.Enabled = false;
            }
            if (counter == 2)
            {
                user3();
                save_btn.Enabled = false;
            }
            string message = "Want to add another contact? ";
            string title = "Contact Tracing App";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                name_box.Clear();
                age_box.Clear();
                address_box.Clear();
                contact_box.Clear();
                save_btn.Enabled = true;
                counter += 1;

            }
            if (result == DialogResult.No && counter <= 2)
            {

                Form users = new Form2();
                this.Hide();
                users.Show();
            }
           
        }
    }
}
