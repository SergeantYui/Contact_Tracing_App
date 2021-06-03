using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user1.txt";
            var str = File.ReadAllText(path);
            user1_label.Text = str;

            string path2 = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user2.txt";
            var str2 = File.ReadAllText(path2);
            user2_label.Text = str2;

            string path3 = @"C:\Users\ruelo\source\repos\Contact_Tracing_App\user\user3.txt";
            var str3 = File.ReadAllText(path3);
            user3_label.Text = str3;
        }

        private void user1_Click(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SergeantYui");
              
        }
    }
}
