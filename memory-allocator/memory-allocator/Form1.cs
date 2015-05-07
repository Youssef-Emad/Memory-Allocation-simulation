using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace memory_allocator
{
    public partial class Form1 : Form
    {
        int holes = 0;
        int processes = 0;

        List<hole> holes_list = new List<hole>();
        List<process> processes_list = new List<process>();
        List<drawing_block> draw_list = new List<drawing_block>();

        decimal total_size = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void first_fit_Click(object sender, EventArgs e)
        {

        }

        private void best_fit_Click(object sender, EventArgs e)
        {

        }

        private void worst_fit_Click(object sender, EventArgs e)
        {

        }

        private void hole_button_Click(object sender, EventArgs e)
        {
            if (holes < holes_count.Value)
            {
                if (holes_list.Exists(hole => hole.get_address() == address_input.Value))
                {
                    MessageBox.Show("Starting address already exists");
                }
                else
                {
                    hole h = new hole("Memory", hole_size_input.Value, address_input.Value);
                    holes_list.Add(h);
                    total_size += hole_size_input.Value;
                    holes++;
                    address_input.Value = 0;
                    hole_size_input.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Unable to add hole , Please increment the number of holes");
            }

        }

        private void process_button_Click(object sender, EventArgs e)
        {

        }

        private void allocate_button_Click(object sender, EventArgs e)
        {

        }
    }
}
