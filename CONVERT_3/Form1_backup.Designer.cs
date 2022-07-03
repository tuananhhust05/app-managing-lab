
namespace CONVERT_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_export = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_holder = new System.Windows.Forms.Button();
            this.btn_tool = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.txt_holder = new System.Windows.Forms.TextBox();
            this.txt_tool = new System.Windows.Forms.TextBox();
            this.txt_setup = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_toolxlsx = new System.Windows.Forms.Button();
            this.txt_toolxlsx = new System.Windows.Forms.TextBox();
            this.btn_export2 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Red;
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(351, 309);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 28);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "EXPORT";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControl1.Location = new System.Drawing.Point(16, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_export);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(821, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INPUT 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_holder);
            this.groupBox1.Controls.Add(this.btn_tool);
            this.groupBox1.Controls.Add(this.btn_setup);
            this.groupBox1.Controls.Add(this.txt_holder);
            this.groupBox1.Controls.Add(this.txt_tool);
            this.groupBox1.Controls.Add(this.txt_setup);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(784, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(65, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Holder.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tool.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Setup.xlsx";
            // 
            // btn_holder
            // 
            this.btn_holder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_holder.BackColor = System.Drawing.Color.Gold;
            this.btn_holder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_holder.Location = new System.Drawing.Point(645, 130);
            this.btn_holder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_holder.Name = "btn_holder";
            this.btn_holder.Size = new System.Drawing.Size(100, 28);
            this.btn_holder.TabIndex = 6;
            this.btn_holder.Text = "Open";
            this.btn_holder.UseVisualStyleBackColor = false;
            this.btn_holder.Click += new System.EventHandler(this.btn_holder_Click_1);
            // 
            // btn_tool
            // 
            this.btn_tool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tool.BackColor = System.Drawing.Color.Gold;
            this.btn_tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tool.Location = new System.Drawing.Point(645, 218);
            this.btn_tool.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tool.Name = "btn_tool";
            this.btn_tool.Size = new System.Drawing.Size(100, 28);
            this.btn_tool.TabIndex = 5;
            this.btn_tool.Text = "Open";
            this.btn_tool.UseVisualStyleBackColor = false;
            this.btn_tool.Click += new System.EventHandler(this.btn_tool_Click_1);
            // 
            // btn_setup
            // 
            this.btn_setup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setup.BackColor = System.Drawing.Color.Gold;
            this.btn_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_setup.Location = new System.Drawing.Point(645, 48);
            this.btn_setup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(100, 28);
            this.btn_setup.TabIndex = 3;
            this.btn_setup.Text = "Open";
            this.btn_setup.UseVisualStyleBackColor = false;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // txt_holder
            // 
            this.txt_holder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_holder.Enabled = false;
            this.txt_holder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_holder.ForeColor = System.Drawing.Color.Black;
            this.txt_holder.Location = new System.Drawing.Point(69, 134);
            this.txt_holder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_holder.Name = "txt_holder";
            this.txt_holder.Size = new System.Drawing.Size(567, 23);
            this.txt_holder.TabIndex = 2;
            // 
            // txt_tool
            // 
            this.txt_tool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tool.Enabled = false;
            this.txt_tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tool.ForeColor = System.Drawing.Color.Black;
            this.txt_tool.Location = new System.Drawing.Point(69, 222);
            this.txt_tool.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tool.Name = "txt_tool";
            this.txt_tool.Size = new System.Drawing.Size(567, 23);
            this.txt_tool.TabIndex = 1;
            // 
            // txt_setup
            // 
            this.txt_setup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_setup.Enabled = false;
            this.txt_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_setup.ForeColor = System.Drawing.Color.Black;
            this.txt_setup.Location = new System.Drawing.Point(69, 50);
            this.txt_setup.Margin = new System.Windows.Forms.Padding(4);
            this.txt_setup.Name = "txt_setup";
            this.txt_setup.Size = new System.Drawing.Size(567, 23);
            this.txt_setup.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btn_export2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(821, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INPUT2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_toolxlsx);
            this.groupBox2.Controls.Add(this.txt_toolxlsx);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(803, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(35, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tool.xlsx";
            // 
            // btn_toolxlsx
            // 
            this.btn_toolxlsx.BackColor = System.Drawing.Color.Gold;
            this.btn_toolxlsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_toolxlsx.ForeColor = System.Drawing.Color.Black;
            this.btn_toolxlsx.Location = new System.Drawing.Point(609, 87);
            this.btn_toolxlsx.Margin = new System.Windows.Forms.Padding(4);
            this.btn_toolxlsx.Name = "btn_toolxlsx";
            this.btn_toolxlsx.Size = new System.Drawing.Size(100, 28);
            this.btn_toolxlsx.TabIndex = 5;
            this.btn_toolxlsx.Text = "Open";
            this.btn_toolxlsx.UseVisualStyleBackColor = false;
            this.btn_toolxlsx.Click += new System.EventHandler(this.btn_toolxlsx_Click);
            // 
            // txt_toolxlsx
            // 
            this.txt_toolxlsx.Enabled = false;
            this.txt_toolxlsx.Location = new System.Drawing.Point(35, 90);
            this.txt_toolxlsx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_toolxlsx.Name = "txt_toolxlsx";
            this.txt_toolxlsx.Size = new System.Drawing.Size(565, 23);
            this.txt_toolxlsx.TabIndex = 4;
            this.txt_toolxlsx.TextChanged += new System.EventHandler(this.txt_toolxlsx_TextChanged);
            // 
            // btn_export2
            // 
            this.btn_export2.BackColor = System.Drawing.Color.Red;
            this.btn_export2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_export2.ForeColor = System.Drawing.Color.White;
            this.btn_export2.Location = new System.Drawing.Point(321, 199);
            this.btn_export2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export2.Name = "btn_export2";
            this.btn_export2.Size = new System.Drawing.Size(100, 28);
            this.btn_export2.TabIndex = 2;
            this.btn_export2.Text = "EXPORT";
            this.btn_export2.UseVisualStyleBackColor = false;
            this.btn_export2.Click += new System.EventHandler(this.btn_export2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 393);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Simulation Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_holder;
        private System.Windows.Forms.Button btn_tool;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.TextBox txt_holder;
        private System.Windows.Forms.TextBox txt_tool;
        private System.Windows.Forms.TextBox txt_setup;
        private System.Windows.Forms.Button btn_export2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_toolxlsx;
        private System.Windows.Forms.TextBox txt_toolxlsx;
    }
}

