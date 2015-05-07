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

        decimal capacity;
        int index = 0;

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
            if (holes == holes_count.Value && holes != 0)
            {
                decimal max_hole_size = 0;
                for (int i = 0; i < holes_list.Count; i++)
                {
                    if (holes_list[i].get_size() > max_hole_size)
                        max_hole_size = holes_list[i].get_size();
                }

                if (processes < processes_count.Value)
                {
                    if (processes_list.Exists(process => process.get_id() == "P" + process_id_input.Value.ToString()))
                    {
                        MessageBox.Show("Process ID already exists");
                    }
                    else if (process_size_input.Value == 0)
                    {
                        MessageBox.Show("Process size can not be equal zero");
                    }
                    else if (process_size_input.Value > max_hole_size)
                    {
                        MessageBox.Show("Process size is too large");
                    }
                    else
                    {
                        process p = new process("P" + process_id_input.Value.ToString(), process_size_input.Value);
                        processes_list.Add(p);
                        process_size_input.Value = 0;
                        process_id_input.Value = 0;
                        processes++;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to add process , Please increment the number of processes");
                }
            }
            else
            {
                MessageBox.Show("Enter the holes first");
            }
        }

        private void allocate_button_Click(object sender, EventArgs e)
        {
            if (holes != holes_count.Value)
            {
                MessageBox.Show("Please finish Entering holes first");
            }
            else if (processes != processes_count.Value)
            {
                MessageBox.Show("Please finish Entering processes first");
            }
            else if (holes_count.Value == 0)
            {
                MessageBox.Show("No holes are available");
            }
            else if (processes_count.Value == 0)
            {
                MessageBox.Show("No processes are available to allocate");
            }
            else
            {
                processes_list = processes_list.OrderBy(process => process.get_id()).ToList();

                for (int i = 0; i < processes_list.Count; i++)
                {
                    for (int j = 0; j < holes_list.Count; j++)
                    {
                        if (first_fit.Checked == true)
                        {
                            if (processes_list[i].get_size() <= holes_list[j].get_size())
                            {
                                drawing_block b = new drawing_block(processes_list[i].get_id(), holes_list[j].get_address(), processes_list[i].get_size());
                                draw_list.Add(b);
                                holes_list[j].update(holes_list[j].get_address() + processes_list[i].get_size(), holes_list[j].get_size() - processes_list[i].get_size());
                                break;
                            }
                        }
                        else if (best_fit.Checked == true)
                        {
                            
                        }
                        else if (worst_fit.Checked == true)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}
