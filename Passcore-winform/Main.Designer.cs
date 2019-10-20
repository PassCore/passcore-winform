namespace Passcore_winform
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pKey_0 = new System.Windows.Forms.TextBox();
            this.pKey_1 = new System.Windows.Forms.TextBox();
            this.pKey_2 = new System.Windows.Forms.TextBox();
            this.pKey_0_Lable = new System.Windows.Forms.Label();
            this.pKey_1_Lable = new System.Windows.Forms.Label();
            this.pKey_2_Lable = new System.Windows.Forms.Label();
            this.isHard = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pKey_0
            // 
            this.pKey_0.Location = new System.Drawing.Point(12, 24);
            this.pKey_0.Name = "pKey_0";
            this.pKey_0.Size = new System.Drawing.Size(287, 21);
            this.pKey_0.TabIndex = 0;
            // 
            // pKey_1
            // 
            this.pKey_1.Location = new System.Drawing.Point(12, 63);
            this.pKey_1.Name = "pKey_1";
            this.pKey_1.Size = new System.Drawing.Size(287, 21);
            this.pKey_1.TabIndex = 1;
            // 
            // pKey_2
            // 
            this.pKey_2.Location = new System.Drawing.Point(12, 102);
            this.pKey_2.Name = "pKey_2";
            this.pKey_2.Size = new System.Drawing.Size(287, 21);
            this.pKey_2.TabIndex = 2;
            // 
            // pKey_0_Lable
            // 
            this.pKey_0_Lable.AutoSize = true;
            this.pKey_0_Lable.Location = new System.Drawing.Point(10, 9);
            this.pKey_0_Lable.Name = "pKey_0_Lable";
            this.pKey_0_Lable.Size = new System.Drawing.Size(95, 12);
            this.pKey_0_Lable.TabIndex = 3;
            this.pKey_0_Lable.Text = "Standard Str #1";
            // 
            // pKey_1_Lable
            // 
            this.pKey_1_Lable.AutoSize = true;
            this.pKey_1_Lable.Location = new System.Drawing.Point(10, 48);
            this.pKey_1_Lable.Name = "pKey_1_Lable";
            this.pKey_1_Lable.Size = new System.Drawing.Size(95, 12);
            this.pKey_1_Lable.TabIndex = 4;
            this.pKey_1_Lable.Text = "Standard Str #2";
            // 
            // pKey_2_Lable
            // 
            this.pKey_2_Lable.AutoSize = true;
            this.pKey_2_Lable.Location = new System.Drawing.Point(12, 87);
            this.pKey_2_Lable.Name = "pKey_2_Lable";
            this.pKey_2_Lable.Size = new System.Drawing.Size(137, 12);
            this.pKey_2_Lable.TabIndex = 5;
            this.pKey_2_Lable.Text = "Enhance Str (Optional)";
            // 
            // isHard
            // 
            this.isHard.AutoSize = true;
            this.isHard.Location = new System.Drawing.Point(12, 205);
            this.isHard.Name = "isHard";
            this.isHard.Size = new System.Drawing.Size(132, 16);
            this.isHard.TabIndex = 6;
            this.isHard.Text = "Include characters";
            this.isHard.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 140);
            this.trackBar.Maximum = 4;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(287, 45);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "32";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "64";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "128";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "256";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 227);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(287, 48);
            this.Generate.TabIndex = 13;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "v1.0.0b Aquarius(Build #20)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(319, 319);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isHard);
            this.Controls.Add(this.pKey_2_Lable);
            this.Controls.Add(this.pKey_1_Lable);
            this.Controls.Add(this.pKey_0_Lable);
            this.Controls.Add(this.pKey_2);
            this.Controls.Add(this.pKey_1);
            this.Controls.Add(this.pKey_0);
            this.Controls.Add(this.trackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PassCore";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pKey_0;
        private System.Windows.Forms.TextBox pKey_1;
        private System.Windows.Forms.TextBox pKey_2;
        private System.Windows.Forms.Label pKey_0_Lable;
        private System.Windows.Forms.Label pKey_1_Lable;
        private System.Windows.Forms.Label pKey_2_Lable;
        private System.Windows.Forms.CheckBox isHard;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label6;
    }
}

