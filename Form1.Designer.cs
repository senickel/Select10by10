namespace Select10by10
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button6;
            System.Windows.Forms.Button button7;
            System.Windows.Forms.Button button8;
            System.Windows.Forms.Button button9;
            System.Windows.Forms.Button button10;
            System.Windows.Forms.Button button11;
            this.NextSave = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.NumericUpDown();
            this.GoTo = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.TrackBar();
            this.upload = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(25, 24);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(34, 34);
            button1.TabIndex = 0;
            button1.Text = "100";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(0, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(0, 0);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(0, 0);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(0, 0);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(75, 23);
            button6.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(0, 0);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(75, 23);
            button7.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(0, 0);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(75, 23);
            button8.TabIndex = 0;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(0, 0);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(75, 23);
            button9.TabIndex = 0;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(0, 0);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(75, 23);
            button10.TabIndex = 0;
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(0, 0);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(75, 23);
            button11.TabIndex = 0;
            // 
            // NextSave
            // 
            this.NextSave.Enabled = false;
            this.NextSave.Location = new System.Drawing.Point(114, 498);
            this.NextSave.Name = "NextSave";
            this.NextSave.Size = new System.Drawing.Size(87, 35);
            this.NextSave.TabIndex = 1;
            this.NextSave.Text = "Next and Save";
            this.NextSave.UseVisualStyleBackColor = true;
            this.NextSave.Click += new System.EventHandler(this.next_Click);
            // 
            // Counter
            // 
            this.Counter.Enabled = false;
            this.Counter.Location = new System.Drawing.Point(207, 507);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(87, 20);
            this.Counter.TabIndex = 3;
            this.Counter.Click += new System.EventHandler(this.count_click);
            // 
            // GoTo
            // 
            this.GoTo.Enabled = false;
            this.GoTo.Location = new System.Drawing.Point(300, 498);
            this.GoTo.Name = "GoTo";
            this.GoTo.Size = new System.Drawing.Size(87, 35);
            this.GoTo.TabIndex = 4;
            this.GoTo.Text = "Go To";
            this.GoTo.UseVisualStyleBackColor = true;
            this.GoTo.Click += new System.EventHandler(this.GoTo_click);
            // 
            // Progress
            // 
            this.Progress.Enabled = false;
            this.Progress.Location = new System.Drawing.Point(114, 539);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(273, 45);
            this.Progress.TabIndex = 5;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(65, 24);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(87, 34);
            this.upload.TabIndex = 6;
            this.upload.Text = "Upload File";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 624);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.GoTo);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.NextSave);
            this.Controls.Add(button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextSave;
        private System.Windows.Forms.NumericUpDown Counter;
        private System.Windows.Forms.Button GoTo;
        private System.Windows.Forms.TrackBar Progress;
        private System.Windows.Forms.Button upload;
    }
}

