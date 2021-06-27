namespace Hospital_Management_System
{
    partial class Dash_Board
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor";
            this.label4.Click += new System.EventHandler(this.Doctor);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient";
            this.label5.Click += new System.EventHandler(this.Billing);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wardboy";
            this.label6.Click += new System.EventHandler(this.Wardboy);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(741, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Image = global::Hospital_Management_System.Properties.Resources.pulling_stretcher_doctor_medical_character_concept_fJrofkOd_S;
            this.label9.Location = new System.Drawing.Point(640, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 174);
            this.label9.TabIndex = 8;
            this.label9.Click += new System.EventHandler(this.Wardboy_click);
            // 
            // label11
            // 
            this.label11.Image = global::Hospital_Management_System.Properties.Resources.patient_transport_clipart_6;
            this.label11.Location = new System.Drawing.Point(210, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 174);
            this.label11.TabIndex = 6;
            this.label11.Click += new System.EventHandler(this.Doctor_click);
            // 
            // label7
            // 
            this.label7.Image = global::Hospital_Management_System.Properties.Resources.Doctor_Clipart_Images_28;
            this.label7.Location = new System.Drawing.Point(65, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 174);
            this.label7.TabIndex = 6;
            this.label7.Click += new System.EventHandler(this.Doctor_click);
            // 
            // label2
            // 
            this.label2.Image = global::Hospital_Management_System.Properties.Resources.medical_appointment_doctor_healthcare_40568__1_1;
            this.label2.Location = new System.Drawing.Point(2, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 34);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = global::Hospital_Management_System.Properties.Resources.medical_appointment_doctor_healthcare_405681;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 75);
            this.label1.TabIndex = 0;
            // 
            // Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dash_Board";
            this.Text = "Dash_Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}