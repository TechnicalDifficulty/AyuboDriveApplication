namespace AyuboDriveApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_vehicle_btn = new System.Windows.Forms.Button();
            this.hire_btn = new System.Windows.Forms.Button();
            this.rent_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_vehicle_btn);
            this.groupBox1.Controls.Add(this.hire_btn);
            this.groupBox1.Controls.Add(this.rent_btn);
            this.groupBox1.Font = new System.Drawing.Font("Papyrus", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(487, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your options";
            // 
            // add_vehicle_btn
            // 
            this.add_vehicle_btn.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_vehicle_btn.Location = new System.Drawing.Point(36, 331);
            this.add_vehicle_btn.Name = "add_vehicle_btn";
            this.add_vehicle_btn.Size = new System.Drawing.Size(369, 101);
            this.add_vehicle_btn.TabIndex = 2;
            this.add_vehicle_btn.Text = "ADD VEHICLE";
            this.add_vehicle_btn.UseVisualStyleBackColor = true;
            // 
            // hire_btn
            // 
            this.hire_btn.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hire_btn.Location = new System.Drawing.Point(36, 199);
            this.hire_btn.Name = "hire_btn";
            this.hire_btn.Size = new System.Drawing.Size(369, 101);
            this.hire_btn.TabIndex = 1;
            this.hire_btn.Text = "HIRE";
            this.hire_btn.UseVisualStyleBackColor = true;
            // 
            // rent_btn
            // 
            this.rent_btn.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_btn.Location = new System.Drawing.Point(36, 69);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(369, 101);
            this.rent_btn.TabIndex = 0;
            this.rent_btn.Text = "RENT";
            this.rent_btn.UseVisualStyleBackColor = true;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDriveApplication.Properties.Resources.AyuboMain;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(449, 561);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(449, 561);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 561);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Ayubo Drive";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ayubo Drive";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_vehicle_btn;
        private System.Windows.Forms.Button hire_btn;
        private System.Windows.Forms.Button rent_btn;
    }
}

