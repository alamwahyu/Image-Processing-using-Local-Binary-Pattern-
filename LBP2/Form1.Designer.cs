namespace LBP2
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
            this.initialPicture = new System.Windows.Forms.PictureBox();
            this.convertedPicture = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // initialPicture
            // 
            this.initialPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.initialPicture.Location = new System.Drawing.Point(36, 84);
            this.initialPicture.Name = "initialPicture";
            this.initialPicture.Size = new System.Drawing.Size(297, 264);
            this.initialPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.initialPicture.TabIndex = 0;
            this.initialPicture.TabStop = false;
            // 
            // convertedPicture
            // 
            this.convertedPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.convertedPicture.Location = new System.Drawing.Point(674, 84);
            this.convertedPicture.Name = "convertedPicture";
            this.convertedPicture.Size = new System.Drawing.Size(297, 264);
            this.convertedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.convertedPicture.TabIndex = 1;
            this.convertedPicture.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.openButton.Location = new System.Drawing.Point(119, 371);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 39);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "OPEN";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.convertButton.Location = new System.Drawing.Point(770, 371);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(110, 39);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(450, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(354, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "GRAYSCALE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "BINARY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.convertedPicture);
            this.Controls.Add(this.initialPicture);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox initialPicture;
        private System.Windows.Forms.PictureBox convertedPicture;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

