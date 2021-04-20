namespace minesweeper
{
    partial class MinesweeperAlain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperAlain));
            this.m_MinutesLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.m_SeparatorLabel = new System.Windows.Forms.Label();
            this.m_SecondsLabel = new System.Windows.Forms.Label();
            this.LevelCombobox = new System.Windows.Forms.ComboBox();
            this.m_Panel = new System.Windows.Forms.Panel();
            this.m_StartBtn = new System.Windows.Forms.Button();
            this.m_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_MinutesLabel
            // 
            this.m_MinutesLabel.AutoSize = true;
            this.m_MinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.m_MinutesLabel.Location = new System.Drawing.Point(9, 5);
            this.m_MinutesLabel.Name = "m_MinutesLabel";
            this.m_MinutesLabel.Size = new System.Drawing.Size(13, 13);
            this.m_MinutesLabel.TabIndex = 0;
            this.m_MinutesLabel.Text = "0";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // m_SeparatorLabel
            // 
            this.m_SeparatorLabel.AutoSize = true;
            this.m_SeparatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.m_SeparatorLabel.Location = new System.Drawing.Point(23, 3);
            this.m_SeparatorLabel.Name = "m_SeparatorLabel";
            this.m_SeparatorLabel.Size = new System.Drawing.Size(10, 13);
            this.m_SeparatorLabel.TabIndex = 1;
            this.m_SeparatorLabel.Text = ":";
            // 
            // m_SecondsLabel
            // 
            this.m_SecondsLabel.AutoSize = true;
            this.m_SecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.m_SecondsLabel.Location = new System.Drawing.Point(35, 5);
            this.m_SecondsLabel.Name = "m_SecondsLabel";
            this.m_SecondsLabel.Size = new System.Drawing.Size(13, 13);
            this.m_SecondsLabel.TabIndex = 2;
            this.m_SecondsLabel.Text = "0";
            // 
            // LevelCombobox
            // 
            this.LevelCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LevelCombobox.FormattingEnabled = true;
            this.LevelCombobox.Location = new System.Drawing.Point(0, 0);
            this.LevelCombobox.Margin = new System.Windows.Forms.Padding(0);
            this.LevelCombobox.Name = "LevelCombobox";
            this.LevelCombobox.Size = new System.Drawing.Size(234, 21);
            this.LevelCombobox.TabIndex = 4;
            // 
            // m_Panel
            // 
            this.m_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Panel.BackColor = System.Drawing.Color.Transparent;
            this.m_Panel.Controls.Add(this.m_SecondsLabel);
            this.m_Panel.Controls.Add(this.m_MinutesLabel);
            this.m_Panel.Controls.Add(this.m_SeparatorLabel);
            this.m_Panel.Location = new System.Drawing.Point(752, 0);
            this.m_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.m_Panel.Name = "m_Panel";
            this.m_Panel.Size = new System.Drawing.Size(55, 18);
            this.m_Panel.TabIndex = 5;
            // 
            // m_StartBtn
            // 
            this.m_StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.m_StartBtn.BackgroundImage = global::minesweeper.Properties.Resources.play_button_icon_png_26;
            this.m_StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.m_StartBtn.Location = new System.Drawing.Point(234, -1);
            this.m_StartBtn.Margin = new System.Windows.Forms.Padding(0);
            this.m_StartBtn.Name = "m_StartBtn";
            this.m_StartBtn.Size = new System.Drawing.Size(41, 22);
            this.m_StartBtn.TabIndex = 3;
            this.m_StartBtn.UseVisualStyleBackColor = false;
            this.m_StartBtn.Click += new System.EventHandler(this.OnStartBtnClick);
            // 
            // MinesweeperAlain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(809, 516);
            this.Controls.Add(this.m_Panel);
            this.Controls.Add(this.LevelCombobox);
            this.Controls.Add(this.m_StartBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MinesweeperAlain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineSweeper";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.m_Panel.ResumeLayout(false);
            this.m_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label m_MinutesLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label m_SeparatorLabel;
        private System.Windows.Forms.Label m_SecondsLabel;
        private System.Windows.Forms.Button m_StartBtn;
        public System.Windows.Forms.ComboBox LevelCombobox;
        private System.Windows.Forms.Panel m_Panel;
    }
}

