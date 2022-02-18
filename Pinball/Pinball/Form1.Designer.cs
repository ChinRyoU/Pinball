
namespace Pinball
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBall = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerball = new System.Windows.Forms.Timer(this.components);
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBall)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(0, 180);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(10, 100);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = ((System.Drawing.Image)(resources.GetObject("Player2.Image")));
            this.Player2.Location = new System.Drawing.Point(774, 180);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(10, 100);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            this.Player2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Player2_PreviewKeyDown);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBall
            // 
            this.pictureBall.BackColor = System.Drawing.Color.Transparent;
            this.pictureBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBall.Image")));
            this.pictureBall.Location = new System.Drawing.Point(397, 233);
            this.pictureBall.Name = "pictureBall";
            this.pictureBall.Size = new System.Drawing.Size(20, 20);
            this.pictureBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBall.TabIndex = 2;
            this.pictureBall.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerball
            // 
            this.timerball.Enabled = true;
            this.timerball.Interval = 10;
            this.timerball.Tick += new System.EventHandler(this.timerball_Tick);
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BackColor = System.Drawing.Color.Transparent;
            this.labelScore1.Font = new System.Drawing.Font("Yu Gothic UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore1.ForeColor = System.Drawing.Color.Gray;
            this.labelScore1.Location = new System.Drawing.Point(330, 9);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(0, 74);
            this.labelScore1.TabIndex = 3;
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.BackColor = System.Drawing.Color.Transparent;
            this.labelScore2.Font = new System.Drawing.Font("Yu Gothic UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore2.ForeColor = System.Drawing.Color.Gray;
            this.labelScore2.Location = new System.Drawing.Point(423, 9);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(0, 74);
            this.labelScore2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.pictureBall);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBall;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerball;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
    }
}

