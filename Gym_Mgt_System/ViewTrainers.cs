using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mgt_System
{
    public partial class ViewTrainers : Form
    {
        Trainer_class tc = new Trainer_class();
        public ViewTrainers()
        {
            InitializeComponent();
        }

        private void ViewTrainers_Load(object sender, EventArgs e)
        {
            READ();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            tc.Read_Data();
            dataGridView1.DataSource = tc.dt;
        }
    }
}
