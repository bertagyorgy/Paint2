namespace this_is_pain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.btn_clear1 = new System.Windows.Forms.Button();
            this.btn_save1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_selection = new System.Windows.Forms.Button();
            this.pictureBoxElore = new System.Windows.Forms.Button();
            this.pictureBoxVissza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbar1 = new System.Windows.Forms.TrackBar();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.btn_clear1);
            this.panel1.Controls.Add(this.btn_save1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 1041);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Location = new System.Drawing.Point(12, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 542);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::this_is_pain.Properties.Resources.circle;
            this.btn_ellipse.Location = new System.Drawing.Point(12, 310);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(68, 67);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::this_is_pain.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(12, 456);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(68, 67);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::this_is_pain.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(12, 18);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(68, 67);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::this_is_pain.Properties.Resources.bucket;
            this.btn_fill.Location = new System.Drawing.Point(12, 91);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(68, 67);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::this_is_pain.Properties.Resources.rectangle;
            this.btn_rect.Location = new System.Drawing.Point(12, 383);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(68, 67);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::this_is_pain.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pencil.Location = new System.Drawing.Point(12, 164);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(68, 67);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::this_is_pain.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(12, 237);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(68, 67);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_color.Location = new System.Drawing.Point(24, 102);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(68, 26);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // btn_clear1
            // 
            this.btn_clear1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear1.ForeColor = System.Drawing.Color.White;
            this.btn_clear1.Image = global::this_is_pain.Properties.Resources.bin__1_;
            this.btn_clear1.Location = new System.Drawing.Point(3, 17);
            this.btn_clear1.Name = "btn_clear1";
            this.btn_clear1.Size = new System.Drawing.Size(61, 66);
            this.btn_clear1.TabIndex = 8;
            this.btn_clear1.Text = "Clear";
            this.btn_clear1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear1.UseVisualStyleBackColor = false;
            this.btn_clear1.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save1
            // 
            this.btn_save1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_save1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save1.ForeColor = System.Drawing.Color.White;
            this.btn_save1.Image = global::this_is_pain.Properties.Resources.diskette;
            this.btn_save1.Location = new System.Drawing.Point(68, 17);
            this.btn_save1.Name = "btn_save1";
            this.btn_save1.Size = new System.Drawing.Size(55, 66);
            this.btn_save1.TabIndex = 9;
            this.btn_save1.Text = "Save\r\n";
            this.btn_save1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save1.UseVisualStyleBackColor = false;
            this.btn_save1.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btn_paste);
            this.panel2.Controls.Add(this.btn_copy);
            this.panel2.Controls.Add(this.btn_selection);
            this.panel2.Controls.Add(this.pictureBoxElore);
            this.panel2.Controls.Add(this.pictureBoxVissza);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackbar1);
            this.panel2.Controls.Add(this.color_picker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(132, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1772, 99);
            this.panel2.TabIndex = 1;
            // 
            // btn_paste
            // 
            this.btn_paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paste.ForeColor = System.Drawing.Color.White;
            this.btn_paste.Image = global::this_is_pain.Properties.Resources.paste;
            this.btn_paste.Location = new System.Drawing.Point(832, 17);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(61, 66);
            this.btn_paste.TabIndex = 16;
            this.btn_paste.Text = "Paste";
            this.btn_paste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.ForeColor = System.Drawing.Color.White;
            this.btn_copy.Image = global::this_is_pain.Properties.Resources.files_copy_interface_symbol;
            this.btn_copy.Location = new System.Drawing.Point(765, 17);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(61, 66);
            this.btn_copy.TabIndex = 15;
            this.btn_copy.Text = "Copy";
            this.btn_copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_selection
            // 
            this.btn_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selection.ForeColor = System.Drawing.Color.White;
            this.btn_selection.Image = global::this_is_pain.Properties.Resources.shape__1_;
            this.btn_selection.Location = new System.Drawing.Point(698, 17);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(61, 66);
            this.btn_selection.TabIndex = 14;
            this.btn_selection.Text = "Selection";
            this.btn_selection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // pictureBoxElore
            // 
            this.pictureBoxElore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxElore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxElore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.pictureBoxElore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxElore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxElore.ForeColor = System.Drawing.Color.White;
            this.pictureBoxElore.Image = global::this_is_pain.Properties.Resources.redo_arrow_symbol;
            this.pictureBoxElore.Location = new System.Drawing.Point(631, 17);
            this.pictureBoxElore.Name = "pictureBoxElore";
            this.pictureBoxElore.Size = new System.Drawing.Size(61, 66);
            this.pictureBoxElore.TabIndex = 13;
            this.pictureBoxElore.Text = "Redo";
            this.pictureBoxElore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxElore.UseVisualStyleBackColor = false;
            this.pictureBoxElore.Click += new System.EventHandler(this.pictureBoxElore_Click);
            // 
            // pictureBoxVissza
            // 
            this.pictureBoxVissza.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVissza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.pictureBoxVissza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxVissza.ForeColor = System.Drawing.Color.White;
            this.pictureBoxVissza.Image = global::this_is_pain.Properties.Resources.undo_circular_arrow;
            this.pictureBoxVissza.Location = new System.Drawing.Point(564, 17);
            this.pictureBoxVissza.Name = "pictureBoxVissza";
            this.pictureBoxVissza.Size = new System.Drawing.Size(61, 66);
            this.pictureBoxVissza.TabIndex = 12;
            this.pictureBoxVissza.Text = "Undo";
            this.pictureBoxVissza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxVissza.UseVisualStyleBackColor = false;
            this.pictureBoxVissza.Click += new System.EventHandler(this.pictureBoxVissza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(448, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Line width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackbar1
            // 
            this.trackbar1.Location = new System.Drawing.Point(424, 33);
            this.trackbar1.Minimum = 1;
            this.trackbar1.Name = "trackbar1";
            this.trackbar1.Size = new System.Drawing.Size(104, 45);
            this.trackbar1.TabIndex = 3;
            this.trackbar1.Value = 1;
            this.trackbar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::this_is_pain.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(15, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(384, 90);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(132, 99);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1772, 942);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintApp program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_clear1;
        private System.Windows.Forms.TrackBar trackbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pictureBoxElore;
        private System.Windows.Forms.Button pictureBoxVissza;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_paste;
    }
}

