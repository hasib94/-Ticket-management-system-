namespace WindowsFormsApplication1
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btn_fixture = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_team = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_live = new System.Windows.Forms.Button();
            this.btn_view_booking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fixture
            // 
            this.btn_fixture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fixture.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fixture.Image = ((System.Drawing.Image)(resources.GetObject("btn_fixture.Image")));
            this.btn_fixture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fixture.Location = new System.Drawing.Point(866, 90);
            this.btn_fixture.Name = "btn_fixture";
            this.btn_fixture.Size = new System.Drawing.Size(251, 56);
            this.btn_fixture.TabIndex = 0;
            this.btn_fixture.Text = "View Fixture";
            this.btn_fixture.UseVisualStyleBackColor = true;
            this.btn_fixture.Click += new System.EventHandler(this.btn_fixture_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_booking.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_booking.Image")));
            this.btn_booking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_booking.Location = new System.Drawing.Point(866, 184);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(251, 58);
            this.btn_booking.TabIndex = 1;
            this.btn_booking.Text = "Ticket Booking";
            this.btn_booking.UseVisualStyleBackColor = true;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Image = global::WindowsFormsApplication1.Properties.Resources.logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(221, 495);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(117, 48);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_team
            // 
            this.btn_team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_team.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_team.Image = ((System.Drawing.Image)(resources.GetObject("btn_team.Image")));
            this.btn_team.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_team.Location = new System.Drawing.Point(866, 277);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(251, 60);
            this.btn_team.TabIndex = 4;
            this.btn_team.Text = "View Team Details";
            this.btn_team.UseVisualStyleBackColor = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // btn_point
            // 
            this.btn_point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_point.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Image = ((System.Drawing.Image)(resources.GetObject("btn_point.Image")));
            this.btn_point.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_point.Location = new System.Drawing.Point(866, 374);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(251, 59);
            this.btn_point.TabIndex = 5;
            this.btn_point.Text = "View Point Table";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_info
            // 
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_info.Location = new System.Drawing.Point(866, 472);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(251, 59);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "View Profile";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_live
            // 
            this.btn_live.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_live.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_live.Font = new System.Drawing.Font("Niagara Engraved", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_live.Image = global::WindowsFormsApplication1.Properties.Resources.Live_score;
            this.btn_live.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_live.Location = new System.Drawing.Point(221, 277);
            this.btn_live.Name = "btn_live";
            this.btn_live.Size = new System.Drawing.Size(132, 50);
            this.btn_live.TabIndex = 8;
            this.btn_live.Text = "Live Score";
            this.btn_live.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_live.UseVisualStyleBackColor = true;
            this.btn_live.Click += new System.EventHandler(this.btn_live_Click);
            // 
            // btn_view_booking
            // 
            this.btn_view_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_booking.Font = new System.Drawing.Font("Niagara Engraved", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_booking.Location = new System.Drawing.Point(221, 333);
            this.btn_view_booking.Name = "btn_view_booking";
            this.btn_view_booking.Size = new System.Drawing.Size(132, 79);
            this.btn_view_booking.TabIndex = 9;
            this.btn_view_booking.Text = "View Booking";
            this.btn_view_booking.UseVisualStyleBackColor = true;
            this.btn_view_booking.Click += new System.EventHandler(this.btn_view_booking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(225, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Label 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(144, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 107);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_view_booking);
            this.Controls.Add(this.btn_live);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.btn_fixture);
            this.DoubleBuffered = true;
            this.Name = "Form8";
            this.Text = "User Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fixture;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_team;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_live;
        private System.Windows.Forms.Button btn_view_booking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}