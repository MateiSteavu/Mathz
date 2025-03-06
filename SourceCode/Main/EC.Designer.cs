namespace Main
{
    partial class EC
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
            this.echolder = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // echolder
            // 
            this.echolder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.echolder.Location = new System.Drawing.Point(75, 65);
            this.echolder.Name = "echolder";
            this.echolder.Size = new System.Drawing.Size(708, 39);
            this.echolder.TabIndex = 0;
            this.echolder.Text = "Enter your ecuation here...";
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.White;
            this.solve.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solve.Location = new System.Drawing.Point(75, 120);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(200, 40);
            this.solve.TabIndex = 1;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.White;
            this.Results.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Results.Location = new System.Drawing.Point(297, 120);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(486, 40);
            this.Results.TabIndex = 2;
            this.Results.Text = "Results:";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History.Location = new System.Drawing.Point(75, 182);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(708, 286);
            this.History.TabIndex = 3;
            this.History.Text = "History:";
            // 
            // EC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.echolder);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EC";
            this.Text = "Ecuation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox echolder;
        private Button solve;
        private Label Results;
        private RichTextBox History;
    }
}