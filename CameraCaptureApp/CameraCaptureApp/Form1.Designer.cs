namespace CameraCaptureApp
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
            comboBoxWebCam = new ComboBox();
            btn_Start = new Button();
            btn_Capture = new Button();
            btn_Save = new Button();
            btn_Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebCam
            // 
            comboBoxWebCam.FormattingEnabled = true;
            comboBoxWebCam.Location = new Point(611, 12);
            comboBoxWebCam.Name = "comboBoxWebCam";
            comboBoxWebCam.Size = new Size(177, 23);
            comboBoxWebCam.TabIndex = 0;
            comboBoxWebCam.SelectedIndexChanged += comboBoxWebCam_SelectedIndexChanged;
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.Lime;
            btn_Start.Font = new Font("Humnst777 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Start.Location = new Point(611, 56);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(177, 57);
            btn_Start.TabIndex = 2;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Capture
            // 
            btn_Capture.BackColor = Color.Yellow;
            btn_Capture.Font = new Font("Humnst777 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Capture.Location = new Point(611, 139);
            btn_Capture.Name = "btn_Capture";
            btn_Capture.Size = new Size(177, 57);
            btn_Capture.TabIndex = 3;
            btn_Capture.Text = "Capture";
            btn_Capture.UseVisualStyleBackColor = false;
            btn_Capture.Click += btn_Capture_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Fuchsia;
            btn_Save.Font = new Font("Humnst777 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Location = new Point(611, 217);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(177, 57);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Red;
            btn_Exit.Font = new Font("Humnst777 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Exit.Location = new Point(611, 293);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(177, 57);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(582, 426);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(294, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 420);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Save);
            Controls.Add(btn_Capture);
            Controls.Add(btn_Start);
            Controls.Add(comboBoxWebCam);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebCam;
        private Button btn_Start;
        private Button btn_Capture;
        private Button btn_Save;
        private Button btn_Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}