
namespace Picturbator
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Export_Btn = new System.Windows.Forms.Button();
            this.Reroll_Btn = new System.Windows.Forms.Button();
            this.AddImage_Btn = new System.Windows.Forms.Button();
            this.Amount_Trb = new System.Windows.Forms.TrackBar();
            this.Width_Lbl = new System.Windows.Forms.Label();
            this.Height_Lbl = new System.Windows.Forms.Label();
            this.Amount_Lbl = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MaxSize_Lbl = new System.Windows.Forms.Label();
            this.UnitMaxSize_Trb = new System.Windows.Forms.TrackBar();
            this.MinSize_Lbl = new System.Windows.Forms.Label();
            this.UnitScale_Trb = new System.Windows.Forms.TrackBar();
            this.Width_Txt = new System.Windows.Forms.NumericUpDown();
            this.Height_Txt = new System.Windows.Forms.NumericUpDown();
            this.Rotation_Chk = new System.Windows.Forms.CheckBox();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Trb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitMaxSize_Trb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitScale_Trb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_Txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_Txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Export_Btn
            // 
            this.Export_Btn.Enabled = false;
            this.Export_Btn.Location = new System.Drawing.Point(730, 350);
            this.Export_Btn.Name = "Export_Btn";
            this.Export_Btn.Size = new System.Drawing.Size(61, 23);
            this.Export_Btn.TabIndex = 1;
            this.Export_Btn.Text = "Export";
            this.Export_Btn.UseVisualStyleBackColor = true;
            this.Export_Btn.Click += new System.EventHandler(this.Export_Btn_Click);
            // 
            // Reroll_Btn
            // 
            this.Reroll_Btn.Enabled = false;
            this.Reroll_Btn.Location = new System.Drawing.Point(730, 292);
            this.Reroll_Btn.Name = "Reroll_Btn";
            this.Reroll_Btn.Size = new System.Drawing.Size(60, 23);
            this.Reroll_Btn.TabIndex = 2;
            this.Reroll_Btn.Text = "Reroll";
            this.Reroll_Btn.UseVisualStyleBackColor = true;
            this.Reroll_Btn.Click += new System.EventHandler(this.Reroll_Btn_Click);
            // 
            // AddImage_Btn
            // 
            this.AddImage_Btn.Location = new System.Drawing.Point(716, 22);
            this.AddImage_Btn.Name = "AddImage_Btn";
            this.AddImage_Btn.Size = new System.Drawing.Size(75, 23);
            this.AddImage_Btn.TabIndex = 3;
            this.AddImage_Btn.Text = "Add Image";
            this.AddImage_Btn.UseVisualStyleBackColor = true;
            this.AddImage_Btn.Click += new System.EventHandler(this.AddImage_Btn_Click);
            // 
            // Amount_Trb
            // 
            this.Amount_Trb.Enabled = false;
            this.Amount_Trb.Location = new System.Drawing.Point(687, 207);
            this.Amount_Trb.Maximum = 500;
            this.Amount_Trb.Minimum = 10;
            this.Amount_Trb.Name = "Amount_Trb";
            this.Amount_Trb.Size = new System.Drawing.Size(104, 45);
            this.Amount_Trb.TabIndex = 7;
            this.Amount_Trb.Value = 100;
            this.Amount_Trb.Scroll += new System.EventHandler(this.Amount_Trb_Scroll);
            // 
            // Width_Lbl
            // 
            this.Width_Lbl.AutoSize = true;
            this.Width_Lbl.Location = new System.Drawing.Point(693, 57);
            this.Width_Lbl.Name = "Width_Lbl";
            this.Width_Lbl.Size = new System.Drawing.Size(38, 13);
            this.Width_Lbl.TabIndex = 10;
            this.Width_Lbl.Text = "Width:";
            this.Width_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Height_Lbl
            // 
            this.Height_Lbl.AutoSize = true;
            this.Height_Lbl.Location = new System.Drawing.Point(690, 81);
            this.Height_Lbl.Name = "Height_Lbl";
            this.Height_Lbl.Size = new System.Drawing.Size(41, 13);
            this.Height_Lbl.TabIndex = 11;
            this.Height_Lbl.Text = "Height:";
            this.Height_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Amount_Lbl
            // 
            this.Amount_Lbl.AutoSize = true;
            this.Amount_Lbl.Location = new System.Drawing.Point(716, 239);
            this.Amount_Lbl.Name = "Amount_Lbl";
            this.Amount_Lbl.Size = new System.Drawing.Size(43, 13);
            this.Amount_Lbl.TabIndex = 14;
            this.Amount_Lbl.Text = "Amount";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 22);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(640, 480);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 15;
            this.PictureBox.TabStop = false;
            this.PictureBox.WaitOnLoad = true;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // MaxSize_Lbl
            // 
            this.MaxSize_Lbl.AutoSize = true;
            this.MaxSize_Lbl.Location = new System.Drawing.Point(716, 185);
            this.MaxSize_Lbl.Name = "MaxSize_Lbl";
            this.MaxSize_Lbl.Size = new System.Drawing.Size(47, 13);
            this.MaxSize_Lbl.TabIndex = 13;
            this.MaxSize_Lbl.Text = "MaxSize";
            // 
            // UnitMaxSize_Trb
            // 
            this.UnitMaxSize_Trb.AutoSize = false;
            this.UnitMaxSize_Trb.Enabled = false;
            this.UnitMaxSize_Trb.Location = new System.Drawing.Point(687, 156);
            this.UnitMaxSize_Trb.Maximum = 300;
            this.UnitMaxSize_Trb.Minimum = 100;
            this.UnitMaxSize_Trb.Name = "UnitMaxSize_Trb";
            this.UnitMaxSize_Trb.Size = new System.Drawing.Size(104, 45);
            this.UnitMaxSize_Trb.TabIndex = 6;
            this.UnitMaxSize_Trb.Value = 150;
            this.UnitMaxSize_Trb.Scroll += new System.EventHandler(this.UnitMaxSize_Trb_Scroll);
            // 
            // MinSize_Lbl
            // 
            this.MinSize_Lbl.AutoSize = true;
            this.MinSize_Lbl.Location = new System.Drawing.Point(721, 137);
            this.MinSize_Lbl.Name = "MinSize_Lbl";
            this.MinSize_Lbl.Size = new System.Drawing.Size(47, 13);
            this.MinSize_Lbl.TabIndex = 12;
            this.MinSize_Lbl.Text = "Min Size";
            // 
            // UnitScale_Trb
            // 
            this.UnitScale_Trb.AutoSize = false;
            this.UnitScale_Trb.Enabled = false;
            this.UnitScale_Trb.Location = new System.Drawing.Point(687, 105);
            this.UnitScale_Trb.Maximum = 100;
            this.UnitScale_Trb.Minimum = 1;
            this.UnitScale_Trb.Name = "UnitScale_Trb";
            this.UnitScale_Trb.Size = new System.Drawing.Size(104, 45);
            this.UnitScale_Trb.TabIndex = 5;
            this.UnitScale_Trb.Value = 10;
            this.UnitScale_Trb.Scroll += new System.EventHandler(this.UnitMinSize_Trb_Scroll);
            // 
            // Width_Txt
            // 
            this.Width_Txt.Location = new System.Drawing.Point(737, 55);
            this.Width_Txt.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.Width_Txt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Width_Txt.Name = "Width_Txt";
            this.Width_Txt.Size = new System.Drawing.Size(54, 20);
            this.Width_Txt.TabIndex = 16;
            this.Width_Txt.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.Width_Txt.ValueChanged += new System.EventHandler(this.Width_Txt_ValueChanged);
            // 
            // Height_Txt
            // 
            this.Height_Txt.Location = new System.Drawing.Point(737, 79);
            this.Height_Txt.Maximum = new decimal(new int[] {
            3072,
            0,
            0,
            0});
            this.Height_Txt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Height_Txt.Name = "Height_Txt";
            this.Height_Txt.Size = new System.Drawing.Size(54, 20);
            this.Height_Txt.TabIndex = 17;
            this.Height_Txt.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.Height_Txt.ValueChanged += new System.EventHandler(this.Height_Txt_ValueChanged);
            // 
            // Rotation_Chk
            // 
            this.Rotation_Chk.AutoSize = true;
            this.Rotation_Chk.Location = new System.Drawing.Point(719, 267);
            this.Rotation_Chk.Name = "Rotation_Chk";
            this.Rotation_Chk.Size = new System.Drawing.Size(66, 17);
            this.Rotation_Chk.TabIndex = 20;
            this.Rotation_Chk.Text = "Rotation";
            this.Rotation_Chk.UseVisualStyleBackColor = true;
            this.Rotation_Chk.CheckedChanged += new System.EventHandler(this.Rotation_Chk_CheckedChanged);
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.InitialImage")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(679, 390);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(112, 112);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PictureBox.TabIndex = 21;
            this.Logo_PictureBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(691, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(690, 321);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 22;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 518);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Logo_PictureBox);
            this.Controls.Add(this.Rotation_Chk);
            this.Controls.Add(this.Height_Txt);
            this.Controls.Add(this.Width_Txt);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Amount_Lbl);
            this.Controls.Add(this.MaxSize_Lbl);
            this.Controls.Add(this.MinSize_Lbl);
            this.Controls.Add(this.Height_Lbl);
            this.Controls.Add(this.Width_Lbl);
            this.Controls.Add(this.Amount_Trb);
            this.Controls.Add(this.UnitMaxSize_Trb);
            this.Controls.Add(this.UnitScale_Trb);
            this.Controls.Add(this.AddImage_Btn);
            this.Controls.Add(this.Reroll_Btn);
            this.Controls.Add(this.Export_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Picturbator";
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Trb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitMaxSize_Trb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitScale_Trb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_Txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_Txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Export_Btn;
        private System.Windows.Forms.Button Reroll_Btn;
        private System.Windows.Forms.Button AddImage_Btn;
        private System.Windows.Forms.TrackBar Amount_Trb;
        private System.Windows.Forms.Label Width_Lbl;
        private System.Windows.Forms.Label Height_Lbl;
        private System.Windows.Forms.Label Amount_Lbl;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label MaxSize_Lbl;
        private System.Windows.Forms.TrackBar UnitMaxSize_Trb;
        private System.Windows.Forms.Label MinSize_Lbl;
        private System.Windows.Forms.TrackBar UnitScale_Trb;
        private System.Windows.Forms.NumericUpDown Width_Txt;
        private System.Windows.Forms.NumericUpDown Height_Txt;
        private System.Windows.Forms.CheckBox Rotation_Chk;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

