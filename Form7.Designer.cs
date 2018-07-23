namespace WindowsFormsApplication1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.btn_viewfixture = new System.Windows.Forms.Button();
            this.btn_updatefixture = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_teamdetails = new System.Windows.Forms.Button();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewfixture
            // 
            this.btn_viewfixture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewfixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewfixture.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewfixture.Image = global::WindowsFormsApplication1.Properties.Resources.arrow31;
            this.btn_viewfixture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewfixture.Location = new System.Drawing.Point(91, 87);
            this.btn_viewfixture.Name = "btn_viewfixture";
            this.btn_viewfixture.Size = new System.Drawing.Size(321, 60);
            this.btn_viewfixture.TabIndex = 0;
            this.btn_viewfixture.Text = "View Current Fixture";
            this.btn_viewfixture.UseVisualStyleBackColor = true;
            this.btn_viewfixture.Click += new System.EventHandler(this.btn_viewfixture_Click);
            // 
            // btn_updatefixture
            // 
            this.btn_updatefixture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updatefixture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatefixture.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatefixture.Image = global::WindowsFormsApplication1.Properties.Resources.arrow31;
            this.btn_updatefixture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatefixture.Location = new System.Drawing.Point(91, 179);
            this.btn_updatefixture.Name = "btn_updatefixture";
            this.btn_updatefixture.Size = new System.Drawing.Size(321, 61);
            this.btn_updatefixture.TabIndex = 1;
            this.btn_updatefixture.Text = "Update Fixture";
            this.btn_updatefixture.UseVisualStyleBackColor = true;
            this.btn_updatefixture.Click += new System.EventHandler(this.btn_updatefixture_Click);
            // 
            // btn_point
            // 
            this.btn_point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_point.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Image = global::WindowsFormsApplication1.Properties.Resources.arrow31;
            this.btn_point.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_point.Location = new System.Drawing.Point(91, 287);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(321, 59);
            this.btn_point.TabIndex = 2;
            this.btn_point.Text = "View Point Table";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_teamdetails
            // 
            this.btn_teamdetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teamdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teamdetails.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teamdetails.Image = ((System.Drawing.Image)(resources.GetObject("btn_teamdetails.Image")));
            this.btn_teamdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teamdetails.Location = new System.Drawing.Point(91, 384);
            this.btn_teamdetails.Name = "btn_teamdetails";
            this.btn_teamdetails.Size = new System.Drawing.Size(321, 65);
            this.btn_teamdetails.TabIndex = 3;
            this.btn_teamdetails.Text = "Team Details";
            this.btn_teamdetails.UseVisualStyleBackColor = true;
            this.btn_teamdetails.Click += new System.EventHandler(this.btn_teamdetails_Click);
            // 
            // btn_changepass
            // 
            this.btn_changepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepass.Image = ((System.Drawing.Image)(resources.GetObject("btn_changepass.Image")));
            this.btn_changepass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changepass.Location = new System.Drawing.Point(91, 483);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(321, 59);
            this.btn_changepass.TabIndex = 4;
            this.btn_changepass.Text = "Change Password";
            this.btn_changepass.UseVisualStyleBackColor = true;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Forte", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Image = global::WindowsFormsApplication1.Properties.Resources.logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(1117, 463);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 44);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(1055, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 107);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1112, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_changepass);
            this.Controls.Add(this.btn_teamdetails);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_updatefixture);
            this.Controls.Add(this.btn_viewfixture);
            this.Name = "Form7";
            this.Text = "Admin Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewfixture;
        private System.Windows.Forms.Button btn_updatefixture;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_teamdetails;
        private System.Windows.Forms.Button btn_changepass;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}