using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project6App
{
    public partial class Main_sys: Form
    {
        public Main_sys()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void run_pd()
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar.Value = i;
                precent.Text = i.ToString();
                precent.Update();
                progressBar.Update();
            }
            time.Enabled = true;
            time.Start();
            
            



        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Length < 2 || password.Text.Length < 2)
            {
                MessageBox.Show("Confirm the password is correctS", "Warning");
            }
            else
            {
                Mysql_op mysql_Op = new Mysql_op();
                if (mysql_Op.search_account(username.Text, password.Text))
                {
                    MessageBox.Show("Login successful !", "Warning");
                    Console.WriteLine("it is working");
                    panel.Enabled = false;
                    text1.Visible = true;
                    text3.Visible = true;
                    precent.Visible = true;
                    progressBar.Visible = true;
                    
                    run_pd();
                    
                    //this.Hide();
                    time.Enabled = false;
                    if (progressBar.Value == 99)
                    {
                        time.Stop();
                        time.Dispose();
                        Console.WriteLine("GO");
                        this.Hide();
                        web next = new web();
                        next.Return_data();
                        next.user_name = username.Text;
                        next.user_password = password.Text;
                        next.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password !", "Warning");
                }
                
        
                
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register re = new register();
            re.Show();
        }

        private void precent_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
