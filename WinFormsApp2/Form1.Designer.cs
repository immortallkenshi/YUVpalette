namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorHolder = new System.Windows.Forms.PictureBox();
            this.TrackBarAll = new System.Windows.Forms.TrackBar();
            this.TrackBarY = new System.Windows.Forms.TrackBar();
            this.TrackBarU = new System.Windows.Forms.TrackBar();
            this.TrackBarV = new System.Windows.Forms.TrackBar();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarV)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorHolder
            // 
            this.ColorHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorHolder.Location = new System.Drawing.Point(12, 12);
            this.ColorHolder.Name = "ColorHolder";
            this.ColorHolder.Size = new System.Drawing.Size(473, 411);
            this.ColorHolder.TabIndex = 0;
            this.ColorHolder.TabStop = false;
            // 
            // TrackBarAll
            // 
            this.TrackBarAll.Location = new System.Drawing.Point(536, 54);
            this.TrackBarAll.Maximum = 255;
            this.TrackBarAll.Name = "TrackBarAll";
            this.TrackBarAll.Size = new System.Drawing.Size(197, 45);
            this.TrackBarAll.TabIndex = 1;
            this.TrackBarAll.TickFrequency = 10;
            this.TrackBarAll.ValueChanged += new System.EventHandler(this.TrackBarAll_ValueChanged);
            // 
            // TrackBarY
            // 
            this.TrackBarY.Location = new System.Drawing.Point(536, 105);
            this.TrackBarY.Maximum = 255;
            this.TrackBarY.Name = "TrackBarY";
            this.TrackBarY.Size = new System.Drawing.Size(197, 45);
            this.TrackBarY.TabIndex = 2;
            this.TrackBarY.TickFrequency = 10;
            this.TrackBarY.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // TrackBarU
            // 
            this.TrackBarU.Location = new System.Drawing.Point(536, 156);
            this.TrackBarU.Maximum = 255;
            this.TrackBarU.Name = "TrackBarU";
            this.TrackBarU.Size = new System.Drawing.Size(197, 45);
            this.TrackBarU.TabIndex = 3;
            this.TrackBarU.TickFrequency = 10;
            this.TrackBarU.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // TrackBarV
            // 
            this.TrackBarV.Location = new System.Drawing.Point(536, 207);
            this.TrackBarV.Maximum = 255;
            this.TrackBarV.Name = "TrackBarV";
            this.TrackBarV.Size = new System.Drawing.Size(197, 45);
            this.TrackBarV.TabIndex = 4;
            this.TrackBarV.TickFrequency = 10;
            this.TrackBarV.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // textBoxAll
            // 
            this.textBoxAll.Location = new System.Drawing.Point(739, 54);
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(49, 23);
            this.textBoxAll.TabIndex = 5;
            this.textBoxAll.TextChanged += new System.EventHandler(this.textBoxAll_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(739, 105);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(49, 23);
            this.textBoxY.TabIndex = 6;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxAll_TextChanged);
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(739, 156);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(49, 23);
            this.textBoxU.TabIndex = 7;
            this.textBoxU.TextChanged += new System.EventHandler(this.textBoxAll_TextChanged);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(739, 207);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(49, 23);
            this.textBoxV.TabIndex = 8;
            this.textBoxV.TextChanged += new System.EventHandler(this.textBoxAll_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "All ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(495, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "U";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(495, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "V";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxU);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.TrackBarV);
            this.Controls.Add(this.TrackBarU);
            this.Controls.Add(this.TrackBarY);
            this.Controls.Add(this.TrackBarAll);
            this.Controls.Add(this.ColorHolder);
            this.Name = "Form1";
            this.Text = "YUV Palette";
            ((System.ComponentModel.ISupportInitialize)(this.ColorHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ColorHolder;
        private TrackBar TrackBarAll;
        private TrackBar TrackBarY;
        private TrackBar TrackBarU;
        private TrackBar TrackBarV;
        private TextBox textBoxAll;
        private TextBox textBoxY;
        private TextBox textBoxU;
        private TextBox textBoxV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}