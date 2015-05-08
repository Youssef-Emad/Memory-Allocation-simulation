namespace memory_allocator
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
            this.allocation_box = new System.Windows.Forms.GroupBox();
            this.worst_fit = new System.Windows.Forms.RadioButton();
            this.best_fit = new System.Windows.Forms.RadioButton();
            this.first_fit = new System.Windows.Forms.RadioButton();
            this.holes_box = new System.Windows.Forms.GroupBox();
            this.hole_button = new System.Windows.Forms.Button();
            this.hole_size_input = new System.Windows.Forms.NumericUpDown();
            this.hole_size_label = new System.Windows.Forms.Label();
            this.address_input = new System.Windows.Forms.NumericUpDown();
            this.hole_address_label = new System.Windows.Forms.Label();
            this.holes_number_label = new System.Windows.Forms.Label();
            this.holes_count = new System.Windows.Forms.NumericUpDown();
            this.processes_box = new System.Windows.Forms.GroupBox();
            this.process_button = new System.Windows.Forms.Button();
            this.process_size_input = new System.Windows.Forms.NumericUpDown();
            this.process_size_label = new System.Windows.Forms.Label();
            this.process_id_input = new System.Windows.Forms.NumericUpDown();
            this.processes_count = new System.Windows.Forms.NumericUpDown();
            this.process_id_label = new System.Windows.Forms.Label();
            this.processes_number_label = new System.Windows.Forms.Label();
            this.allocate_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.allocation_box.SuspendLayout();
            this.holes_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hole_size_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holes_count)).BeginInit();
            this.processes_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.process_size_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.process_id_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processes_count)).BeginInit();
            this.SuspendLayout();
            // 
            // allocation_box
            // 
            this.allocation_box.Controls.Add(this.worst_fit);
            this.allocation_box.Controls.Add(this.best_fit);
            this.allocation_box.Controls.Add(this.first_fit);
            this.allocation_box.Location = new System.Drawing.Point(34, 32);
            this.allocation_box.Name = "allocation_box";
            this.allocation_box.Size = new System.Drawing.Size(729, 86);
            this.allocation_box.TabIndex = 0;
            this.allocation_box.TabStop = false;
            this.allocation_box.Text = "Allocation Method";
            // 
            // worst_fit
            // 
            this.worst_fit.AutoSize = true;
            this.worst_fit.Location = new System.Drawing.Point(567, 38);
            this.worst_fit.Name = "worst_fit";
            this.worst_fit.Size = new System.Drawing.Size(85, 21);
            this.worst_fit.TabIndex = 2;
            this.worst_fit.TabStop = true;
            this.worst_fit.Text = "Worst Fit";
            this.worst_fit.UseVisualStyleBackColor = true;
            this.worst_fit.Click += new System.EventHandler(this.worst_fit_Click);
            // 
            // best_fit
            // 
            this.best_fit.AutoSize = true;
            this.best_fit.Location = new System.Drawing.Point(301, 39);
            this.best_fit.Name = "best_fit";
            this.best_fit.Size = new System.Drawing.Size(76, 21);
            this.best_fit.TabIndex = 1;
            this.best_fit.TabStop = true;
            this.best_fit.Text = "Best Fit";
            this.best_fit.UseVisualStyleBackColor = true;
            this.best_fit.Click += new System.EventHandler(this.best_fit_Click);
            // 
            // first_fit
            // 
            this.first_fit.AutoSize = true;
            this.first_fit.Location = new System.Drawing.Point(21, 39);
            this.first_fit.Name = "first_fit";
            this.first_fit.Size = new System.Drawing.Size(75, 21);
            this.first_fit.TabIndex = 0;
            this.first_fit.TabStop = true;
            this.first_fit.Text = "First Fit";
            this.first_fit.UseVisualStyleBackColor = true;
            this.first_fit.Click += new System.EventHandler(this.first_fit_Click);
            // 
            // holes_box
            // 
            this.holes_box.Controls.Add(this.hole_button);
            this.holes_box.Controls.Add(this.hole_size_input);
            this.holes_box.Controls.Add(this.hole_size_label);
            this.holes_box.Controls.Add(this.address_input);
            this.holes_box.Controls.Add(this.hole_address_label);
            this.holes_box.Controls.Add(this.holes_number_label);
            this.holes_box.Controls.Add(this.holes_count);
            this.holes_box.Location = new System.Drawing.Point(34, 138);
            this.holes_box.Name = "holes_box";
            this.holes_box.Size = new System.Drawing.Size(729, 125);
            this.holes_box.TabIndex = 1;
            this.holes_box.TabStop = false;
            this.holes_box.Text = "Holes";
            // 
            // hole_button
            // 
            this.hole_button.Location = new System.Drawing.Point(567, 78);
            this.hole_button.Name = "hole_button";
            this.hole_button.Size = new System.Drawing.Size(137, 35);
            this.hole_button.TabIndex = 6;
            this.hole_button.Text = "Add Hole";
            this.hole_button.UseVisualStyleBackColor = true;
            this.hole_button.Click += new System.EventHandler(this.hole_button_Click);
            // 
            // hole_size_input
            // 
            this.hole_size_input.Location = new System.Drawing.Point(413, 85);
            this.hole_size_input.Name = "hole_size_input";
            this.hole_size_input.Size = new System.Drawing.Size(120, 22);
            this.hole_size_input.TabIndex = 5;
            // 
            // hole_size_label
            // 
            this.hole_size_label.AutoSize = true;
            this.hole_size_label.Location = new System.Drawing.Point(355, 87);
            this.hole_size_label.Name = "hole_size_label";
            this.hole_size_label.Size = new System.Drawing.Size(35, 17);
            this.hole_size_label.TabIndex = 4;
            this.hole_size_label.Text = "Size";
            // 
            // address_input
            // 
            this.address_input.Location = new System.Drawing.Point(167, 85);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(120, 22);
            this.address_input.TabIndex = 3;
            // 
            // hole_address_label
            // 
            this.hole_address_label.AutoSize = true;
            this.hole_address_label.Location = new System.Drawing.Point(21, 83);
            this.hole_address_label.Name = "hole_address_label";
            this.hole_address_label.Size = new System.Drawing.Size(113, 17);
            this.hole_address_label.TabIndex = 2;
            this.hole_address_label.Text = "Statring Address";
            // 
            // holes_number_label
            // 
            this.holes_number_label.AutoSize = true;
            this.holes_number_label.Location = new System.Drawing.Point(21, 30);
            this.holes_number_label.Name = "holes_number_label";
            this.holes_number_label.Size = new System.Drawing.Size(114, 17);
            this.holes_number_label.TabIndex = 1;
            this.holes_number_label.Text = "Number of Holes";
            // 
            // holes_count
            // 
            this.holes_count.Location = new System.Drawing.Point(167, 30);
            this.holes_count.Name = "holes_count";
            this.holes_count.Size = new System.Drawing.Size(120, 22);
            this.holes_count.TabIndex = 0;
            // 
            // processes_box
            // 
            this.processes_box.Controls.Add(this.process_button);
            this.processes_box.Controls.Add(this.process_size_input);
            this.processes_box.Controls.Add(this.process_size_label);
            this.processes_box.Controls.Add(this.process_id_input);
            this.processes_box.Controls.Add(this.processes_count);
            this.processes_box.Controls.Add(this.process_id_label);
            this.processes_box.Controls.Add(this.processes_number_label);
            this.processes_box.Location = new System.Drawing.Point(34, 269);
            this.processes_box.Name = "processes_box";
            this.processes_box.Size = new System.Drawing.Size(729, 119);
            this.processes_box.TabIndex = 2;
            this.processes_box.TabStop = false;
            this.processes_box.Text = "Processes";
            // 
            // process_button
            // 
            this.process_button.Location = new System.Drawing.Point(567, 54);
            this.process_button.Name = "process_button";
            this.process_button.Size = new System.Drawing.Size(137, 36);
            this.process_button.TabIndex = 6;
            this.process_button.Text = "Add Process";
            this.process_button.UseVisualStyleBackColor = true;
            this.process_button.Click += new System.EventHandler(this.process_button_Click);
            // 
            // process_size_input
            // 
            this.process_size_input.Location = new System.Drawing.Point(429, 67);
            this.process_size_input.Name = "process_size_input";
            this.process_size_input.Size = new System.Drawing.Size(120, 22);
            this.process_size_input.TabIndex = 5;
            // 
            // process_size_label
            // 
            this.process_size_label.AutoSize = true;
            this.process_size_label.Location = new System.Drawing.Point(360, 67);
            this.process_size_label.Name = "process_size_label";
            this.process_size_label.Size = new System.Drawing.Size(35, 17);
            this.process_size_label.TabIndex = 4;
            this.process_size_label.Text = "Size";
            // 
            // process_id_input
            // 
            this.process_id_input.Location = new System.Drawing.Point(167, 65);
            this.process_id_input.Name = "process_id_input";
            this.process_id_input.Size = new System.Drawing.Size(120, 22);
            this.process_id_input.TabIndex = 3;
            // 
            // processes_count
            // 
            this.processes_count.Location = new System.Drawing.Point(167, 32);
            this.processes_count.Name = "processes_count";
            this.processes_count.Size = new System.Drawing.Size(120, 22);
            this.processes_count.TabIndex = 2;
            // 
            // process_id_label
            // 
            this.process_id_label.AutoSize = true;
            this.process_id_label.Location = new System.Drawing.Point(21, 70);
            this.process_id_label.Name = "process_id_label";
            this.process_id_label.Size = new System.Drawing.Size(76, 17);
            this.process_id_label.TabIndex = 1;
            this.process_id_label.Text = "Process ID";
            // 
            // processes_number_label
            // 
            this.processes_number_label.AutoSize = true;
            this.processes_number_label.Location = new System.Drawing.Point(21, 34);
            this.processes_number_label.Name = "processes_number_label";
            this.processes_number_label.Size = new System.Drawing.Size(144, 17);
            this.processes_number_label.TabIndex = 0;
            this.processes_number_label.Text = "Number of Processes";
            // 
            // allocate_button
            // 
            this.allocate_button.Location = new System.Drawing.Point(335, 415);
            this.allocate_button.Name = "allocate_button";
            this.allocate_button.Size = new System.Drawing.Size(126, 39);
            this.allocate_button.TabIndex = 3;
            this.allocate_button.Text = "Allocate";
            this.allocate_button.UseVisualStyleBackColor = true;
            this.allocate_button.Click += new System.EventHandler(this.allocate_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(335, 415);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(126, 38);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Visible = false;
            this.reset_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 473);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.allocate_button);
            this.Controls.Add(this.processes_box);
            this.Controls.Add(this.holes_box);
            this.Controls.Add(this.allocation_box);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory Allocation";
            this.allocation_box.ResumeLayout(false);
            this.allocation_box.PerformLayout();
            this.holes_box.ResumeLayout(false);
            this.holes_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hole_size_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.address_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holes_count)).EndInit();
            this.processes_box.ResumeLayout(false);
            this.processes_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.process_size_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.process_id_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processes_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox allocation_box;
        private System.Windows.Forms.RadioButton worst_fit;
        private System.Windows.Forms.RadioButton best_fit;
        private System.Windows.Forms.RadioButton first_fit;
        private System.Windows.Forms.GroupBox holes_box;
        private System.Windows.Forms.Button hole_button;
        private System.Windows.Forms.NumericUpDown hole_size_input;
        private System.Windows.Forms.Label hole_size_label;
        private System.Windows.Forms.NumericUpDown address_input;
        private System.Windows.Forms.Label hole_address_label;
        private System.Windows.Forms.Label holes_number_label;
        private System.Windows.Forms.NumericUpDown holes_count;
        private System.Windows.Forms.GroupBox processes_box;
        private System.Windows.Forms.Button process_button;
        private System.Windows.Forms.NumericUpDown process_size_input;
        private System.Windows.Forms.Label process_size_label;
        private System.Windows.Forms.NumericUpDown process_id_input;
        private System.Windows.Forms.NumericUpDown processes_count;
        private System.Windows.Forms.Label process_id_label;
        private System.Windows.Forms.Label processes_number_label;
        private System.Windows.Forms.Button allocate_button;
        private System.Windows.Forms.Button reset_button;
    }
}

