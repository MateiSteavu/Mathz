namespace Main
{
    partial class C
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
            this.History = new System.Windows.Forms.RichTextBox();
            this.Results = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.ExHolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History.Location = new System.Drawing.Point(87, 192);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(708, 286);
            this.History.TabIndex = 7;
            this.History.Text = "History:";
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.White;
            this.Results.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Results.Location = new System.Drawing.Point(309, 130);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(486, 40);
            this.Results.TabIndex = 6;
            this.Results.Text = "Results:";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.White;
            this.solve.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solve.Location = new System.Drawing.Point(87, 130);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(200, 40);
            this.solve.TabIndex = 5;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExHolder
            // 
            this.ExHolder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExHolder.Location = new System.Drawing.Point(87, 75);
            this.ExHolder.Name = "ExHolder";
            this.ExHolder.Size = new System.Drawing.Size(708, 39);
            this.ExHolder.TabIndex = 4;
            this.ExHolder.Text = "Enter your problem here...";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.ExHolder);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "C";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox History;
        private Label Results;
        private Button solve;
        private TextBox ExHolder;
    }
}