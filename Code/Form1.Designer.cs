
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OceanLayers = new System.Windows.Forms.TextBox();
            this.ShoreLayers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ForestLayers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MountainLayers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SnowLayers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.MinimumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(500, 500);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SnowLayers);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MountainLayers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ForestLayers);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ShoreLayers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OceanLayers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(554, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Слои";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.MinimumSize = new System.Drawing.Size(40, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Океан";
            // 
            // OceanLayers
            // 
            this.OceanLayers.Location = new System.Drawing.Point(54, 20);
            this.OceanLayers.Name = "OceanLayers";
            this.OceanLayers.Size = new System.Drawing.Size(202, 20);
            this.OceanLayers.TabIndex = 1;
            // 
            // ShoreLayers
            // 
            this.ShoreLayers.Location = new System.Drawing.Point(54, 46);
            this.ShoreLayers.Name = "ShoreLayers";
            this.ShoreLayers.Size = new System.Drawing.Size(202, 20);
            this.ShoreLayers.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.MinimumSize = new System.Drawing.Size(40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Берег";
            // 
            // ForestLayers
            // 
            this.ForestLayers.Location = new System.Drawing.Point(54, 72);
            this.ForestLayers.Name = "ForestLayers";
            this.ForestLayers.Size = new System.Drawing.Size(202, 20);
            this.ForestLayers.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.MinimumSize = new System.Drawing.Size(40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Лес";
            // 
            // MountainLayers
            // 
            this.MountainLayers.Location = new System.Drawing.Point(54, 98);
            this.MountainLayers.Name = "MountainLayers";
            this.MountainLayers.Size = new System.Drawing.Size(202, 20);
            this.MountainLayers.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.MinimumSize = new System.Drawing.Size(40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Горы";
            // 
            // SnowLayers
            // 
            this.SnowLayers.Location = new System.Drawing.Point(54, 124);
            this.SnowLayers.Name = "SnowLayers";
            this.SnowLayers.Size = new System.Drawing.Size(202, 20);
            this.SnowLayers.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 127);
            this.label6.MinimumSize = new System.Drawing.Size(40, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Снег";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SnowLayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MountainLayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ForestLayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShoreLayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OceanLayers;
        private System.Windows.Forms.Label label2;
    }
}

