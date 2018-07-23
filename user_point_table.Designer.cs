namespace WindowsFormsApplication1
{
    partial class user_point_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_point_table));
            this.btn_groupB = new System.Windows.Forms.RadioButton();
            this.btn_groupA = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_groupB
            // 
            this.btn_groupB.AutoSize = true;
            this.btn_groupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groupB.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_groupB.Location = new System.Drawing.Point(795, 45);
            this.btn_groupB.Name = "btn_groupB";
            this.btn_groupB.Size = new System.Drawing.Size(121, 29);
            this.btn_groupB.TabIndex = 7;
            this.btn_groupB.TabStop = true;
            this.btn_groupB.Text = "Group B";
            this.btn_groupB.UseVisualStyleBackColor = true;
            this.btn_groupB.CheckedChanged += new System.EventHandler(this.btn_groupB_CheckedChanged_1);
            // 
            // btn_groupA
            // 
            this.btn_groupA.AutoSize = true;
            this.btn_groupA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groupA.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_groupA.Location = new System.Drawing.Point(443, 45);
            this.btn_groupA.Name = "btn_groupA";
            this.btn_groupA.Size = new System.Drawing.Size(118, 29);
            this.btn_groupA.TabIndex = 6;
            this.btn_groupA.TabStop = true;
            this.btn_groupA.Text = "Group A";
            this.btn_groupA.UseVisualStyleBackColor = true;
            this.btn_groupA.CheckedChanged += new System.EventHandler(this.btn_groupA_CheckedChanged);
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(1142, 526);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 431);
            this.dataGridView1.TabIndex = 4;
            // 
            // user_point_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 613);
            this.Controls.Add(this.btn_groupB);
            this.Controls.Add(this.btn_groupA);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "user_point_table";
            this.Text = "Point Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btn_groupB;
        private System.Windows.Forms.RadioButton btn_groupA;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}