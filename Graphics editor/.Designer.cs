namespace GraphicsEditor
{
    partial class FormEditorImage
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
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNameImage = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxScalingX = new System.Windows.Forms.TextBox();
            this.textBoxScalingY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonScaling = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLegibility = new System.Windows.Forms.RadioButton();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.radioButtonSharpn = new System.Windows.Forms.RadioButton();
            this.radioButtonBlur = new System.Windows.Forms.RadioButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.buttonСonvolutionFilter = new System.Windows.Forms.Button();
            this.textBoxWindow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMedianFilter = new System.Windows.Forms.Button();
            this.buttonMonochromeFilter = new System.Windows.Forms.Button();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(38, 42);
            this.buttonChooseImage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(167, 41);
            this.buttonChooseImage.TabIndex = 0;
            this.buttonChooseImage.Text = "Choose image";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(5, 5);
            this.panelImage.Margin = new System.Windows.Forms.Padding(5);
            this.panelImage.Name = "panelImage";
            this.panelImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelImage.Size = new System.Drawing.Size(386, 422);
            this.panelImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 220);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNameImage
            // 
            this.labelNameImage.AutoSize = true;
            this.labelNameImage.Location = new System.Drawing.Point(34, 15);
            this.labelNameImage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNameImage.Name = "labelNameImage";
            this.labelNameImage.Size = new System.Drawing.Size(81, 22);
            this.labelNameImage.TabIndex = 2;
            this.labelNameImage.Text = "No image";
            // 
            // openFile
            // 
            this.openFile.Filter = "Image jpg (*.jpg)|*.jpg|Image bmp (*.bmp)|*.bmp|All files(*.*)|*.*";
            this.openFile.InitialDirectory = "D:\\Documents\\3 курс\\5 семестр\\Компьютерная графика\\Сomputer graphics\\Сomputer gra" +
    "phics\\Properties\\Images";
            this.openFile.Title = "Choose image";
            // 
            // textBoxScalingX
            // 
            this.textBoxScalingX.Location = new System.Drawing.Point(45, 22);
            this.textBoxScalingX.Name = "textBoxScalingX";
            this.textBoxScalingX.Size = new System.Drawing.Size(50, 29);
            this.textBoxScalingX.TabIndex = 3;
            this.textBoxScalingX.TextChanged += new System.EventHandler(this.textBoxScalingX_TextChanged);
            // 
            // textBoxScalingY
            // 
            this.textBoxScalingY.Location = new System.Drawing.Point(138, 22);
            this.textBoxScalingY.Name = "textBoxScalingY";
            this.textBoxScalingY.Size = new System.Drawing.Size(50, 29);
            this.textBoxScalingY.TabIndex = 4;
            this.textBoxScalingY.TextChanged += new System.EventHandler(this.textBoxScalingY_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "y:";
            // 
            // buttonScaling
            // 
            this.buttonScaling.Location = new System.Drawing.Point(21, 59);
            this.buttonScaling.Margin = new System.Windows.Forms.Padding(5);
            this.buttonScaling.Name = "buttonScaling";
            this.buttonScaling.Size = new System.Drawing.Size(167, 41);
            this.buttonScaling.TabIndex = 7;
            this.buttonScaling.Text = "Scaling";
            this.buttonScaling.UseVisualStyleBackColor = true;
            this.buttonScaling.Click += new System.EventHandler(this.buttonScaling_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.panelImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 432);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.buttonChooseImage);
            this.groupBox1.Controls.Add(this.labelNameImage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(399, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 331);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRotate);
            this.tabPage1.Controls.Add(this.textBoxAngle);
            this.tabPage1.Controls.Add(this.textBoxScalingY);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxScalingX);
            this.tabPage1.Controls.Add(this.buttonScaling);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(209, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scaling/Rotate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(21, 145);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(167, 41);
            this.buttonRotate.TabIndex = 10;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(104, 108);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(50, 29);
            this.textBoxAngle.TabIndex = 8;
            this.textBoxAngle.TextChanged += new System.EventHandler(this.textBoxAngle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonMedianFilter);
            this.tabPage2.Controls.Add(this.buttonСonvolutionFilter);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.textBoxWindow);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonMonochromeFilter);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(226, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonLegibility);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.radioButtonSharpn);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.radioButtonBlur);
            this.groupBox2.Controls.Add(this.textBox01);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox02);
            this.groupBox2.Controls.Add(this.textBox00);
            this.groupBox2.Location = new System.Drawing.Point(3, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 125);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonLegibility
            // 
            this.radioButtonLegibility.AutoSize = true;
            this.radioButtonLegibility.Location = new System.Drawing.Point(117, 55);
            this.radioButtonLegibility.Name = "radioButtonLegibility";
            this.radioButtonLegibility.Size = new System.Drawing.Size(100, 26);
            this.radioButtonLegibility.TabIndex = 11;
            this.radioButtonLegibility.TabStop = true;
            this.radioButtonLegibility.Text = "Legibility";
            this.radioButtonLegibility.UseVisualStyleBackColor = true;
            this.radioButtonLegibility.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(76, 89);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(29, 29);
            this.textBox22.TabIndex = 8;
            this.textBox22.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // radioButtonSharpn
            // 
            this.radioButtonSharpn.AutoSize = true;
            this.radioButtonSharpn.Location = new System.Drawing.Point(117, 90);
            this.radioButtonSharpn.Name = "radioButtonSharpn";
            this.radioButtonSharpn.Size = new System.Drawing.Size(91, 26);
            this.radioButtonSharpn.TabIndex = 10;
            this.radioButtonSharpn.TabStop = true;
            this.radioButtonSharpn.Text = "Sharpen";
            this.radioButtonSharpn.UseVisualStyleBackColor = true;
            this.radioButtonSharpn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonBlur
            // 
            this.radioButtonBlur.AutoSize = true;
            this.radioButtonBlur.Location = new System.Drawing.Point(117, 22);
            this.radioButtonBlur.Name = "radioButtonBlur";
            this.radioButtonBlur.Size = new System.Drawing.Size(61, 26);
            this.radioButtonBlur.TabIndex = 9;
            this.radioButtonBlur.TabStop = true;
            this.radioButtonBlur.Text = "Blur";
            this.radioButtonBlur.UseVisualStyleBackColor = true;
            this.radioButtonBlur.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(41, 54);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(29, 29);
            this.textBox11.TabIndex = 4;
            this.textBox11.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(41, 19);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(29, 29);
            this.textBox01.TabIndex = 1;
            this.textBox01.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(76, 54);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(29, 29);
            this.textBox12.TabIndex = 5;
            this.textBox12.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(41, 89);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(29, 29);
            this.textBox21.TabIndex = 7;
            this.textBox21.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(6, 89);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(29, 29);
            this.textBox20.TabIndex = 6;
            this.textBox20.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 54);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(29, 29);
            this.textBox10.TabIndex = 3;
            this.textBox10.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(76, 19);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(29, 29);
            this.textBox02.TabIndex = 2;
            this.textBox02.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // textBox00
            // 
            this.textBox00.Location = new System.Drawing.Point(6, 19);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(29, 29);
            this.textBox00.TabIndex = 0;
            this.textBox00.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // buttonСonvolutionFilter
            // 
            this.buttonСonvolutionFilter.Location = new System.Drawing.Point(34, 248);
            this.buttonСonvolutionFilter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonСonvolutionFilter.Name = "buttonСonvolutionFilter";
            this.buttonСonvolutionFilter.Size = new System.Drawing.Size(167, 41);
            this.buttonСonvolutionFilter.TabIndex = 3;
            this.buttonСonvolutionFilter.Text = "Сonvolution Filter";
            this.buttonСonvolutionFilter.UseVisualStyleBackColor = true;
            this.buttonСonvolutionFilter.Click += new System.EventHandler(this.buttonСonvolutionFilter_Click);
            // 
            // textBoxWindow
            // 
            this.textBoxWindow.Location = new System.Drawing.Point(135, 48);
            this.textBoxWindow.Name = "textBoxWindow";
            this.textBoxWindow.Size = new System.Drawing.Size(50, 29);
            this.textBoxWindow.TabIndex = 10;
            this.textBoxWindow.TextChanged += new System.EventHandler(this.textBoxWindow_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Window:";
            // 
            // buttonMedianFilter
            // 
            this.buttonMedianFilter.Location = new System.Drawing.Point(34, 78);
            this.buttonMedianFilter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMedianFilter.Name = "buttonMedianFilter";
            this.buttonMedianFilter.Size = new System.Drawing.Size(167, 41);
            this.buttonMedianFilter.TabIndex = 2;
            this.buttonMedianFilter.Text = "Median Filter";
            this.buttonMedianFilter.UseVisualStyleBackColor = true;
            this.buttonMedianFilter.Click += new System.EventHandler(this.buttonMedianFilter_Click);
            // 
            // buttonMonochromeFilter
            // 
            this.buttonMonochromeFilter.Location = new System.Drawing.Point(34, 5);
            this.buttonMonochromeFilter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMonochromeFilter.Name = "buttonMonochromeFilter";
            this.buttonMonochromeFilter.Size = new System.Drawing.Size(167, 41);
            this.buttonMonochromeFilter.TabIndex = 1;
            this.buttonMonochromeFilter.Text = "Monochrome Filter";
            this.buttonMonochromeFilter.UseVisualStyleBackColor = true;
            this.buttonMonochromeFilter.Click += new System.EventHandler(this.buttonMonochromeFilter_Click);
            // 
            // FormEditorImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(600, 471);
            this.Name = "FormEditorImage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label labelNameImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox textBoxScalingX;
        private System.Windows.Forms.TextBox textBoxScalingY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonScaling;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonMonochromeFilter;
        private System.Windows.Forms.Button buttonСonvolutionFilter;
        private System.Windows.Forms.Button buttonMedianFilter;
        private System.Windows.Forms.TextBox textBoxWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonLegibility;
        private System.Windows.Forms.RadioButton radioButtonSharpn;
        private System.Windows.Forms.RadioButton radioButtonBlur;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox00;
    }
}

