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
                else if (hole_size_input.Value == 0)
                {
                    MessageBox.Show("Hole size can't be equal zero");
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
                int x = this.Width - 120;
                int y = 10;
                int chart_length = this.Height - 60;
                int rec_length = 0;
                int chart_width = 65;

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
                            decimal difference = holes_list[j].get_size() - processes_list[i].get_size();
                            if (difference < capacity && difference >= 0)
                            {
                                capacity = difference;
                                index = j;
                            }
                        }
                        else if (worst_fit.Checked == true)
                        {
                            decimal difference = holes_list[j].get_size() - processes_list[i].get_size();
                            if (difference > capacity)
                            {
                                capacity = difference;
                                index = j;
                            }
                        }
                    }

                    if (best_fit.Checked == true || worst_fit.Checked == true)
                    {
                        drawing_block b = new drawing_block(processes_list[i].get_id(), holes_list[index].get_address(), processes_list[i].get_size());
                        draw_list.Add(b);
                        holes_list[index].update(holes_list[index].get_address() + processes_list[i].get_size(), holes_list[index].get_size() - processes_list[i].get_size());

                        if (best_fit.Checked)
                        {
                            capacity = 1000;
                        }
                        else
                        {
                            capacity = 0;
                        }
                    }
                }

                for (int i = 0; i < holes_list.Count(); i++)
                {
                    if (holes_list[i].get_size() > 0)
                    {
                        drawing_block b = new drawing_block("Memory", holes_list[i].get_address(), holes_list[i].get_size());
                        draw_list.Add(b);
                    }
                }

                draw_list = draw_list.OrderBy(drawing_block => drawing_block.get_address()).ToList();

                for (int i = 0; i < draw_list.Count - 1; i++)
                {
                    decimal next_address = draw_list[i + 1].get_address();
                    decimal address_size = draw_list[i].get_address() + draw_list[i].get_size();

                    if (next_address > address_size && draw_list[i].get_id() != "")
                    {
                        drawing_block b = new drawing_block("", address_size, next_address - address_size);
                        total_size += next_address - address_size;
                        draw_list.Add(b);
                    }
                }

                draw_list = draw_list.OrderBy(drawing_block => drawing_block.get_address()).ToList();

                foreach (drawing_block b in draw_list)
                {
                    Color color;

                    if (b.get_id() == "")
                    {
                        color = System.Drawing.Color.Black;
                    }
                    else if (b.get_id() == "Memory")
                    {
                        color = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        color = System.Drawing.Color.Yellow;
                    }
                    System.Drawing.Graphics formGraphics = this.CreateGraphics();

                    System.Drawing.Font waiting_font = new System.Drawing.Font("Arial", 13);
                    System.Drawing.Font turn_font = new System.Drawing.Font("Arial", 13);
                    System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 8);
                    System.Drawing.Font time_font = new System.Drawing.Font("Arial", 8);
                    System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black);

                    System.Drawing.SolidBrush rec_brush = new System.Drawing.SolidBrush(color);
                    System.Drawing.SolidBrush font_brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                    rec_length = (chart_length / (int)total_size) * ((int)b.get_size());

                    Rectangle temp = new Rectangle(x, y, chart_width, rec_length);
                    formGraphics.DrawRectangle(pen, temp);
                    formGraphics.FillRectangle(rec_brush, temp);

                    formGraphics.DrawString(b.get_id(), drawFont, font_brush, x + 20, y + (rec_length - 1) / 2);
                    formGraphics.DrawString((b.get_size() + b.get_address()).ToString(), time_font, font_brush, x + chart_width, y + rec_length - 4);

                    drawFont.Dispose();
                    turn_font.Dispose();
                    waiting_font.Dispose();
                    font_brush.Dispose();
                    rec_brush.Dispose();
                    formGraphics.Dispose();

                    y += rec_length;
                }
            }
        }
    }
}
