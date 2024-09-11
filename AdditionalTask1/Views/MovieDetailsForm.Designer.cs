namespace Movie_Hotflix.Views
{
    partial class MovieDetailsForm
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
            posterPicture = new PictureBox();
            voteAverageLabel = new Label();
            releaseDateLabel = new Label();
            titleLabel = new Label();
            button1 = new Button();
            overviewTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)posterPicture).BeginInit();
            SuspendLayout();
            // 
            // posterPicture
            // 
            posterPicture.Location = new Point(29, 32);
            posterPicture.Name = "posterPicture";
            posterPicture.Size = new Size(202, 287);
            posterPicture.TabIndex = 0;
            posterPicture.TabStop = false;
            // 
            // voteAverageLabel
            // 
            voteAverageLabel.AutoSize = true;
            voteAverageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            voteAverageLabel.ForeColor = Color.White;
            voteAverageLabel.Location = new Point(261, 148);
            voteAverageLabel.Name = "voteAverageLabel";
            voteAverageLabel.Size = new Size(52, 21);
            voteAverageLabel.TabIndex = 1;
            voteAverageLabel.Text = "label1";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            releaseDateLabel.ForeColor = Color.White;
            releaseDateLabel.Location = new Point(261, 104);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(52, 21);
            releaseDateLabel.TabIndex = 2;
            releaseDateLabel.Text = "label1";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(251, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(118, 58);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "label1";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 340);
            button1.Name = "button1";
            button1.Size = new Size(202, 39);
            button1.TabIndex = 6;
            button1.Text = "Похожие фильмы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFindSimilarMovies_Click;
            // 
            // overviewTextBox
            // 
            overviewTextBox.BackColor = Color.Black;
            overviewTextBox.BorderStyle = BorderStyle.None;
            overviewTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            overviewTextBox.ForeColor = Color.White;
            overviewTextBox.Location = new Point(261, 189);
            overviewTextBox.Multiline = true;
            overviewTextBox.Name = "overviewTextBox";
            overviewTextBox.ScrollBars = ScrollBars.Vertical;
            overviewTextBox.Size = new Size(512, 190);
            overviewTextBox.TabIndex = 7;
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(overviewTextBox);
            Controls.Add(button1);
            Controls.Add(titleLabel);
            Controls.Add(releaseDateLabel);
            Controls.Add(voteAverageLabel);
            Controls.Add(posterPicture);
            Name = "MovieDetailsForm";
            Text = "MovieDetailsForm";
            ((System.ComponentModel.ISupportInitialize)posterPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox posterPicture;
        private Label voteAverageLabel;
        private Label releaseDateLabel;
        private Label titleLabel;
        private Button button1;
        private TextBox overviewTextBox;
    }
}