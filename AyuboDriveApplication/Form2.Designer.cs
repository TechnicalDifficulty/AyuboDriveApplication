namespace AyuboDriveApplication
{
    partial class rent_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.driver_needed_checkbox = new System.Windows.Forms.CheckBox();
            this.type_of_vehicles_combo_box = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.end_date_picker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Vehicle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Driver needed :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // driver_needed_checkbox
            // 
            this.driver_needed_checkbox.AutoSize = true;
            this.driver_needed_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_needed_checkbox.Location = new System.Drawing.Point(236, 339);
            this.driver_needed_checkbox.Name = "driver_needed_checkbox";
            this.driver_needed_checkbox.Size = new System.Drawing.Size(18, 17);
            this.driver_needed_checkbox.TabIndex = 3;
            this.driver_needed_checkbox.UseVisualStyleBackColor = true;
            this.driver_needed_checkbox.CheckedChanged += new System.EventHandler(this.driver_needed_checkbox_CheckedChanged);
            // 
            // type_of_vehicles_combo_box
            // 
            this.type_of_vehicles_combo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_of_vehicles_combo_box.FormattingEnabled = true;
            this.type_of_vehicles_combo_box.Location = new System.Drawing.Point(236, 263);
            this.type_of_vehicles_combo_box.Name = "type_of_vehicles_combo_box";
            this.type_of_vehicles_combo_box.Size = new System.Drawing.Size(265, 33);
            this.type_of_vehicles_combo_box.TabIndex = 5;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(36, 483);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(173, 71);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(402, 483);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(173, 71);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date :";
            // 
            // start_date_picker
            // 
            this.start_date_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_picker.Location = new System.Drawing.Point(236, 98);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(338, 30);
            this.start_date_picker.TabIndex = 10;
            this.start_date_picker.ValueChanged += new System.EventHandler(this.start_date_picker_ValueChanged);
            // 
            // end_date_picker
            // 
            this.end_date_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_picker.Location = new System.Drawing.Point(236, 176);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(338, 30);
            this.end_date_picker.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.end_date_picker);
            this.groupBox1.Controls.Add(this.start_date_picker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.submit_btn);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.type_of_vehicles_combo_box);
            this.groupBox1.Controls.Add(this.driver_needed_checkbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent";
            // 
            // rent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 608);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rent_form";
            this.Text = "Rent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox driver_needed_checkbox;
        private System.Windows.Forms.ComboBox type_of_vehicles_combo_box;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker start_date_picker;
        private System.Windows.Forms.DateTimePicker end_date_picker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}