
namespace Paint4D
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
            this.canvas = new System.Windows.Forms.Panel();
            this.new_canvas_button = new System.Windows.Forms.Button();
            this.clear_all_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_black = new System.Windows.Forms.Button();
            this.button_brown = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_orange = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.button_blue = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_white = new System.Windows.Forms.Button();
            this.imageBttn = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rectangleBttn = new System.Windows.Forms.Button();
            this.elipseBttn = new System.Windows.Forms.Button();
            this.lineBttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 107);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1270, 561);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // new_canvas_button
            // 
            this.new_canvas_button.Location = new System.Drawing.Point(12, 9);
            this.new_canvas_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_canvas_button.Name = "new_canvas_button";
            this.new_canvas_button.Size = new System.Drawing.Size(123, 33);
            this.new_canvas_button.TabIndex = 1;
            this.new_canvas_button.Text = "New canvas";
            this.new_canvas_button.UseVisualStyleBackColor = true;
            this.new_canvas_button.Click += new System.EventHandler(this.new_canvas_button_Click);
            // 
            // clear_all_button
            // 
            this.clear_all_button.Location = new System.Drawing.Point(140, 9);
            this.clear_all_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_all_button.Name = "clear_all_button";
            this.clear_all_button.Size = new System.Drawing.Size(123, 33);
            this.clear_all_button.TabIndex = 2;
            this.clear_all_button.Text = "Clear all";
            this.clear_all_button.UseVisualStyleBackColor = true;
            this.clear_all_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_black);
            this.groupBox1.Controls.Add(this.button_brown);
            this.groupBox1.Controls.Add(this.button_red);
            this.groupBox1.Controls.Add(this.button_orange);
            this.groupBox1.Controls.Add(this.button_green);
            this.groupBox1.Controls.Add(this.button_blue);
            this.groupBox1.Controls.Add(this.button_yellow);
            this.groupBox1.Controls.Add(this.button_white);
            this.groupBox1.Location = new System.Drawing.Point(268, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(143, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button_black
            // 
            this.button_black.BackColor = System.Drawing.Color.Black;
            this.button_black.Location = new System.Drawing.Point(108, 34);
            this.button_black.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_black.Name = "button_black";
            this.button_black.Size = new System.Drawing.Size(28, 21);
            this.button_black.TabIndex = 7;
            this.button_black.UseVisualStyleBackColor = false;
            this.button_black.Click += new System.EventHandler(this.button_black_Click);
            // 
            // button_brown
            // 
            this.button_brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_brown.Location = new System.Drawing.Point(108, 7);
            this.button_brown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_brown.Name = "button_brown";
            this.button_brown.Size = new System.Drawing.Size(28, 21);
            this.button_brown.TabIndex = 6;
            this.button_brown.UseVisualStyleBackColor = false;
            this.button_brown.Click += new System.EventHandler(this.button_brown_Click);
            // 
            // button_red
            // 
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.Location = new System.Drawing.Point(75, 34);
            this.button_red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(28, 21);
            this.button_red.TabIndex = 5;
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_orange
            // 
            this.button_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_orange.Location = new System.Drawing.Point(75, 7);
            this.button_orange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_orange.Name = "button_orange";
            this.button_orange.Size = new System.Drawing.Size(28, 21);
            this.button_orange.TabIndex = 4;
            this.button_orange.UseVisualStyleBackColor = false;
            this.button_orange.Click += new System.EventHandler(this.button_orange_Click);
            // 
            // button_green
            // 
            this.button_green.BackColor = System.Drawing.Color.Lime;
            this.button_green.Location = new System.Drawing.Point(40, 34);
            this.button_green.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(28, 21);
            this.button_green.TabIndex = 3;
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // button_blue
            // 
            this.button_blue.BackColor = System.Drawing.Color.Blue;
            this.button_blue.Location = new System.Drawing.Point(39, 7);
            this.button_blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_blue.Name = "button_blue";
            this.button_blue.Size = new System.Drawing.Size(28, 21);
            this.button_blue.TabIndex = 2;
            this.button_blue.UseVisualStyleBackColor = false;
            this.button_blue.Click += new System.EventHandler(this.button_blue_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.Location = new System.Drawing.Point(5, 34);
            this.button_yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(28, 21);
            this.button_yellow.TabIndex = 1;
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_white
            // 
            this.button_white.Location = new System.Drawing.Point(5, 7);
            this.button_white.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_white.Name = "button_white";
            this.button_white.Size = new System.Drawing.Size(28, 21);
            this.button_white.TabIndex = 0;
            this.button_white.UseVisualStyleBackColor = true;
            this.button_white.Click += new System.EventHandler(this.button_white_Click);
            // 
            // imageBttn
            // 
            this.imageBttn.Image = global::Paint4D.Properties.Resources.Screenshot_2024_03_23_162131;
            this.imageBttn.Location = new System.Drawing.Point(600, 15);
            this.imageBttn.Margin = new System.Windows.Forms.Padding(4);
            this.imageBttn.Name = "imageBttn";
            this.imageBttn.Size = new System.Drawing.Size(77, 75);
            this.imageBttn.TabIndex = 6;
            this.imageBttn.UseVisualStyleBackColor = true;
            this.imageBttn.Click += new System.EventHandler(this.imageBttn_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Image = global::Paint4D.Properties.Resources.EraserPixelArt;
            this.EraserButton.Location = new System.Drawing.Point(418, 9);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(4);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(83, 81);
            this.EraserButton.TabIndex = 4;
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pen thickness";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(693, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rectangleBttn
            // 
            this.rectangleBttn.Location = new System.Drawing.Point(508, 9);
            this.rectangleBttn.Name = "rectangleBttn";
            this.rectangleBttn.Size = new System.Drawing.Size(85, 27);
            this.rectangleBttn.TabIndex = 10;
            this.rectangleBttn.Text = "Rectangle";
            this.rectangleBttn.UseVisualStyleBackColor = true;
            this.rectangleBttn.Click += new System.EventHandler(this.rectangleBttn_Click);
            // 
            // elipseBttn
            // 
            this.elipseBttn.Location = new System.Drawing.Point(508, 35);
            this.elipseBttn.Name = "elipseBttn";
            this.elipseBttn.Size = new System.Drawing.Size(85, 28);
            this.elipseBttn.TabIndex = 11;
            this.elipseBttn.Text = "Ellipse";
            this.elipseBttn.UseVisualStyleBackColor = true;
            this.elipseBttn.Click += new System.EventHandler(this.elipseBttn_Click);
            // 
            // lineBttn
            // 
            this.lineBttn.Location = new System.Drawing.Point(508, 61);
            this.lineBttn.Name = "lineBttn";
            this.lineBttn.Size = new System.Drawing.Size(85, 29);
            this.lineBttn.TabIndex = 12;
            this.lineBttn.Text = "Line";
            this.lineBttn.UseVisualStyleBackColor = true;
            this.lineBttn.Click += new System.EventHandler(this.lineBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 543);
            this.Controls.Add(this.lineBttn);
            this.Controls.Add(this.elipseBttn);
            this.Controls.Add(this.rectangleBttn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBttn);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear_all_button);
            this.Controls.Add(this.new_canvas_button);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button new_canvas_button;
        private System.Windows.Forms.Button clear_all_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_black;
        private System.Windows.Forms.Button button_brown;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_orange;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_blue;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_white;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button imageBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button rectangleBttn;
        private System.Windows.Forms.Button elipseBttn;
        private System.Windows.Forms.Button lineBttn;
    }
}

