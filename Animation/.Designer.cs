namespace Animation
{
    partial class FormAnimation
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimerInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInternalV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExternalV = new System.Windows.Forms.TextBox();
            this.radioButtonSpinningLines = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpleLines = new System.Windows.Forms.RadioButton();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(14, 32);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 43);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Location = new System.Drawing.Point(14, 85);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(156, 43);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 402);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTimerInterval);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxInternalV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxExternalV);
            this.groupBox1.Controls.Add(this.radioButtonSpinningLines);
            this.groupBox1.Controls.Add(this.radioButtonSimpleLines);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(503, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(190, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Timer interval:";
            // 
            // textBoxTimerInterval
            // 
            this.textBoxTimerInterval.Location = new System.Drawing.Point(130, 155);
            this.textBoxTimerInterval.Name = "textBoxTimerInterval";
            this.textBoxTimerInterval.Size = new System.Drawing.Size(53, 29);
            this.textBoxTimerInterval.TabIndex = 8;
            this.textBoxTimerInterval.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Internal V:";
            // 
            // textBoxInternalV
            // 
            this.textBoxInternalV.Location = new System.Drawing.Point(104, 300);
            this.textBoxInternalV.Name = "textBoxInternalV";
            this.textBoxInternalV.Size = new System.Drawing.Size(53, 29);
            this.textBoxInternalV.TabIndex = 6;
            this.textBoxInternalV.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "External V:";
            // 
            // textBoxExternalV
            // 
            this.textBoxExternalV.Location = new System.Drawing.Point(104, 262);
            this.textBoxExternalV.Name = "textBoxExternalV";
            this.textBoxExternalV.Size = new System.Drawing.Size(53, 29);
            this.textBoxExternalV.TabIndex = 4;
            this.textBoxExternalV.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButtonSpinningLines
            // 
            this.radioButtonSpinningLines.AutoSize = true;
            this.radioButtonSpinningLines.Location = new System.Drawing.Point(12, 224);
            this.radioButtonSpinningLines.Name = "radioButtonSpinningLines";
            this.radioButtonSpinningLines.Size = new System.Drawing.Size(136, 26);
            this.radioButtonSpinningLines.TabIndex = 3;
            this.radioButtonSpinningLines.Text = "Spinning lines";
            this.radioButtonSpinningLines.UseVisualStyleBackColor = true;
            this.radioButtonSpinningLines.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSimpleLines
            // 
            this.radioButtonSimpleLines.AutoSize = true;
            this.radioButtonSimpleLines.Checked = true;
            this.radioButtonSimpleLines.Location = new System.Drawing.Point(12, 192);
            this.radioButtonSimpleLines.Name = "radioButtonSimpleLines";
            this.radioButtonSimpleLines.Size = new System.Drawing.Size(120, 26);
            this.radioButtonSimpleLines.TabIndex = 2;
            this.radioButtonSimpleLines.TabStop = true;
            this.radioButtonSimpleLines.Text = "Simple lines";
            this.radioButtonSimpleLines.UseVisualStyleBackColor = true;
            this.radioButtonSimpleLines.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(3, 3);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(492, 396);
            this.panelImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(714, 406);
            this.Name = "FormAnimation";
            this.Text = "Animation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonSpinningLines;
        private System.Windows.Forms.RadioButton radioButtonSimpleLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInternalV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExternalV;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimerInterval;
    }
}

