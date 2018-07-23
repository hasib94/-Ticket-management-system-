namespace WindowsFormsApplication1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_groupA = new System.Windows.Forms.RadioButton();
            this.btn_groupB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_teamid = new System.Windows.Forms.TextBox();
            this.txt_teamname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_played = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_won = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_points = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Teal;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(130, 554);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 40);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_groupA
            // 
            this.btn_groupA.AutoSize = true;
            this.btn_groupA.BackColor = System.Drawing.Color.Teal;
            this.btn_groupA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groupA.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupA.Location = new System.Drawing.Point(766, 28);
            this.btn_groupA.Name = "btn_groupA";
            this.btn_groupA.Size = new System.Drawing.Size(118, 29);
            this.btn_groupA.TabIndex = 2;
            this.btn_groupA.TabStop = true;
            this.btn_groupA.Text = "Group A";
            this.btn_groupA.UseVisualStyleBackColor = false;
            this.btn_groupA.CheckedChanged += new System.EventHandler(this.btn_groupA_CheckedChanged);
            // 
            // btn_groupB
            // 
            this.btn_groupB.AutoSize = true;
            this.btn_groupB.BackColor = System.Drawing.Color.Teal;
            this.btn_groupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_groupB.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupB.Location = new System.Drawing.Point(763, 63);
            this.btn_groupB.Name = "btn_groupB";
            this.btn_groupB.Size = new System.Drawing.Size(121, 29);
            this.btn_groupB.TabIndex = 3;
            this.btn_groupB.TabStop = true;
            this.btn_groupB.Text = "Group B";
            this.btn_groupB.UseVisualStyleBackColor = false;
            this.btn_groupB.CheckedChanged += new System.EventHandler(this.btn_groupB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_teamid
            // 
            this.txt_teamid.Location = new System.Drawing.Point(216, 125);
            this.txt_teamid.Name = "txt_teamid";
            this.txt_teamid.Size = new System.Drawing.Size(100, 20);
            this.txt_teamid.TabIndex = 5;
            // 
            // txt_teamname
            // 
            this.txt_teamname.Location = new System.Drawing.Point(216, 199);
            this.txt_teamname.Name = "txt_teamname";
            this.txt_teamname.Size = new System.Drawing.Size(100, 20);
            this.txt_teamname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_played
            // 
            this.txt_played.Location = new System.Drawing.Point(216, 267);
            this.txt_played.Name = "txt_played";
            this.txt_played.Size = new System.Drawing.Size(100, 20);
            this.txt_played.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Played";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_won
            // 
            this.txt_won.Location = new System.Drawing.Point(216, 338);
            this.txt_won.Name = "txt_won";
            this.txt_won.Size = new System.Drawing.Size(100, 20);
            this.txt_won.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Won";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_lost
            // 
            this.txt_lost.Location = new System.Drawing.Point(216, 411);
            this.txt_lost.Name = "txt_lost";
            this.txt_lost.Size = new System.Drawing.Size(100, 20);
            this.txt_lost.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Moccasin;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_points
            // 
            this.txt_points.Location = new System.Drawing.Point(216, 476);
            this.txt_points.Name = "txt_points";
            this.txt_points.Size = new System.Drawing.Size(100, 20);
            this.txt_points.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Moccasin;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Points";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Algerian", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Image = global::WindowsFormsApplication1.Properties.Resources.Poinbt_table;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(338, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 75);
            this.label7.TabIndex = 16;
            this.label7.Text = "POINT TABLE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 622);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_points);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_lost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_won);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_played);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teamname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_teamid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_groupB);
            this.Controls.Add(this.btn_groupA);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Point Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RadioButton btn_groupA;
        private System.Windows.Forms.RadioButton btn_groupB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_teamid;
        private System.Windows.Forms.TextBox txt_teamname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_played;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_won;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_points;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}