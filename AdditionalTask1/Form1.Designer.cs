namespace Movie_Hotflix
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
            flowLayoutPanelMovies = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            movieNameTextBox = new TextBox();
            searchButton = new Button();
            popularFilmsButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.Location = new Point(33, 67);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(895, 606);
            flowLayoutPanelMovies.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(370, 689);
            button1.Name = "button1";
            button1.Size = new Size(86, 36);
            button1.TabIndex = 1;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPrevPage_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(531, 689);
            button2.Name = "button2";
            button2.Size = new Size(80, 36);
            button2.TabIndex = 2;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNextPage_Click;
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.BackColor = Color.Black;
            movieNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            movieNameTextBox.ForeColor = Color.White;
            movieNameTextBox.Location = new Point(327, 15);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.Size = new Size(335, 35);
            movieNameTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(723, 14);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(139, 38);
            searchButton.TabIndex = 4;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // popularFilmsButton
            // 
            popularFilmsButton.FlatStyle = FlatStyle.Flat;
            popularFilmsButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            popularFilmsButton.ForeColor = Color.White;
            popularFilmsButton.Location = new Point(33, 14);
            popularFilmsButton.Name = "popularFilmsButton";
            popularFilmsButton.Size = new Size(200, 38);
            popularFilmsButton.TabIndex = 0;
            popularFilmsButton.Text = "Популярные фильмы";
            popularFilmsButton.UseVisualStyleBackColor = true;
            popularFilmsButton.Click += popularFilmsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(967, 737);
            Controls.Add(popularFilmsButton);
            Controls.Add(searchButton);
            Controls.Add(movieNameTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelMovies);
            Name = "Form1";
            Text = "Movie Hotflix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMovies;
        private Button button1;
        private Button button2;
        private TextBox movieNameTextBox;
        private Button searchButton;
        private Button popularFilmsButton;
    }
}
