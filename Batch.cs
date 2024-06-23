using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project6App
{
    public partial class Batch : Form
    {
        public int max = 0;
        public int min = 0;

        public Batch()
        {
            InitializeComponent();
            
        }

        private void Batch_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if ((int)to.Value > max)
            {
                to.Value = (decimal)max;
            }
            if (form.Value.Equals(to.Value) || (int)form.Value > max)
            {
                form.Value = 0;
            }

            if ((int)form.Value > (int)to.Value)
            {
                MessageBox.Show("Invalid settings","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Re_turn();
            this.Hide();

        }

        public int[] Re_turn()
        {

            int[] data = new int[2];
            data[0] = (int)form.Value;
            data[1] = (int)to.Value;
            return data;
        }

        public void Up_data()
        {
            form.Value = min;
            form.Update();
            to.Value = max;
            to.Update();
        }
    }
}
