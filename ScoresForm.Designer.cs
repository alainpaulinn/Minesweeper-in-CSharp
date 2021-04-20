namespace minesweeper
{
    partial class ScoresForm
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
            this.highscoresListView = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time_Used = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // highscoresListView
            // 
            this.highscoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Time_Used,
            this.Level});
            this.highscoresListView.GridLines = true;
            this.highscoresListView.HideSelection = false;
            this.highscoresListView.Location = new System.Drawing.Point(-1, -1);
            this.highscoresListView.Name = "highscoresListView";
            this.highscoresListView.Size = new System.Drawing.Size(800, 418);
            this.highscoresListView.TabIndex = 0;
            this.highscoresListView.UseCompatibleStateImageBehavior = false;
            this.highscoresListView.View = System.Windows.Forms.View.Details;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 272;
            // 
            // Time_Used
            // 
            this.Time_Used.Text = "Time Used";
            this.Time_Used.Width = 207;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 314;
            // 
            // ScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highscoresListView);
            this.Name = "ScoresForm";
            this.Text = "ScoresForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView highscoresListView;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Time_Used;
        private System.Windows.Forms.ColumnHeader Level;
    }
}