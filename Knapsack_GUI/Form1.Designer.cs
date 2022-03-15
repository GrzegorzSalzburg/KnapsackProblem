namespace Knapsack_GUI
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
            this.components = new System.ComponentModel.Container();
            this.tB_items = new System.Windows.Forms.TextBox();
            this.tB_seed = new System.Windows.Forms.TextBox();
            this.tB_capacity = new System.Windows.Forms.TextBox();
            this.B_run = new System.Windows.Forms.Button();
            this.tB_instance = new System.Windows.Forms.TextBox();
            this.tB_result = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_items
            // 
            this.tB_items.Location = new System.Drawing.Point(155, 15);
            this.tB_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_items.Name = "tB_items";
            this.tB_items.Size = new System.Drawing.Size(132, 22);
            this.tB_items.TabIndex = 0;
            this.tB_items.TextChanged += new System.EventHandler(this.tB_items_TextChanged);
            // 
            // tB_seed
            // 
            this.tB_seed.Location = new System.Drawing.Point(155, 47);
            this.tB_seed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_seed.Name = "tB_seed";
            this.tB_seed.Size = new System.Drawing.Size(132, 22);
            this.tB_seed.TabIndex = 1;
            this.tB_seed.TextChanged += new System.EventHandler(this.tB_items_TextChanged);
            // 
            // tB_capacity
            // 
            this.tB_capacity.Location = new System.Drawing.Point(155, 79);
            this.tB_capacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_capacity.Name = "tB_capacity";
            this.tB_capacity.Size = new System.Drawing.Size(132, 22);
            this.tB_capacity.TabIndex = 2;
            this.tB_capacity.TextChanged += new System.EventHandler(this.tB_items_TextChanged);
            // 
            // B_run
            // 
            this.B_run.Location = new System.Drawing.Point(36, 139);
            this.B_run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_run.Name = "B_run";
            this.B_run.Size = new System.Drawing.Size(100, 28);
            this.B_run.TabIndex = 3;
            this.B_run.Text = "Run";
            this.B_run.UseVisualStyleBackColor = true;
            this.B_run.Click += new System.EventHandler(this.B_run_Click);
            // 
            // tB_instance
            // 
            this.tB_instance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_instance.Location = new System.Drawing.Point(379, 33);
            this.tB_instance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_instance.Multiline = true;
            this.tB_instance.Name = "tB_instance";
            this.tB_instance.ReadOnly = true;
            this.tB_instance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_instance.Size = new System.Drawing.Size(317, 381);
            this.tB_instance.TabIndex = 4;
            // 
            // tB_result
            // 
            this.tB_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_result.Location = new System.Drawing.Point(36, 187);
            this.tB_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_result.Multiline = true;
            this.tB_result.Name = "tB_result";
            this.tB_result.ReadOnly = true;
            this.tB_result.Size = new System.Drawing.Size(311, 227);
            this.tB_result.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "instance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add seed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_result);
            this.Controls.Add(this.tB_instance);
            this.Controls.Add(this.B_run);
            this.Controls.Add(this.tB_capacity);
            this.Controls.Add(this.tB_seed);
            this.Controls.Add(this.tB_items);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_items;
        private System.Windows.Forms.TextBox tB_seed;
        private System.Windows.Forms.TextBox tB_capacity;
        private System.Windows.Forms.Button B_run;
        private System.Windows.Forms.TextBox tB_instance;
        private System.Windows.Forms.TextBox tB_result;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

