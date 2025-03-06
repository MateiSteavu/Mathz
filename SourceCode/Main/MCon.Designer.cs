namespace Main
{
    partial class MCon
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
            this.initp = new System.Windows.Forms.ComboBox();
            this.im = new System.Windows.Forms.ComboBox();
            this.initcoef = new System.Windows.Forms.TextBox();
            this.transform = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.finmeas = new System.Windows.Forms.ComboBox();
            this.finp = new System.Windows.Forms.ComboBox();
            this.History = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // initp
            // 
            this.initp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initp.FormattingEnabled = true;
            this.initp.Items.AddRange(new object[] {
            "terra",
            "giga",
            "mega",
            "kilo",
            "hecto",
            "deca",
            "normal",
            "deci",
            "centi",
            "mili",
            "micro",
            "nano",
            "piko"});
            this.initp.Location = new System.Drawing.Point(98, 110);
            this.initp.Name = "initp";
            this.initp.Size = new System.Drawing.Size(172, 39);
            this.initp.TabIndex = 0;
            this.initp.Text = "Prefix:";
            // 
            // im
            // 
            this.im.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.im.FormattingEnabled = true;
            this.im.Items.AddRange(new object[] {
            "m",
            "g",
            "l",
            "N",
            "J",
            "W"});
            this.im.Location = new System.Drawing.Point(274, 110);
            this.im.Name = "im";
            this.im.Size = new System.Drawing.Size(268, 39);
            this.im.TabIndex = 1;
            this.im.Text = "Unit of measurment:";
            // 
            // initcoef
            // 
            this.initcoef.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initcoef.Location = new System.Drawing.Point(98, 65);
            this.initcoef.Name = "initcoef";
            this.initcoef.Size = new System.Drawing.Size(673, 39);
            this.initcoef.TabIndex = 2;
            this.initcoef.Text = "Enter your value here...";
            // 
            // transform
            // 
            this.transform.BackColor = System.Drawing.Color.White;
            this.transform.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transform.Location = new System.Drawing.Point(548, 110);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(223, 39);
            this.transform.TabIndex = 6;
            this.transform.Text = "Transform";
            this.transform.UseVisualStyleBackColor = false;
            this.transform.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.BackColor = System.Drawing.Color.White;
            this.Results.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Results.Location = new System.Drawing.Point(98, 177);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(673, 39);
            this.Results.TabIndex = 7;
            this.Results.Text = "Solution...";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finmeas
            // 
            this.finmeas.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finmeas.FormattingEnabled = true;
            this.finmeas.Items.AddRange(new object[] {
            "m",
            "g",
            "l",
            "N",
            "J",
            "W"});
            this.finmeas.Location = new System.Drawing.Point(411, 237);
            this.finmeas.Name = "finmeas";
            this.finmeas.Size = new System.Drawing.Size(360, 39);
            this.finmeas.TabIndex = 9;
            this.finmeas.Text = "Unit of measurment:";
            // 
            // finp
            // 
            this.finp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finp.FormattingEnabled = true;
            this.finp.Items.AddRange(new object[] {
            "terra",
            "giga",
            "mega",
            "kilo",
            "hecto",
            "deca",
            "normal",
            "deci",
            "centi",
            "mili",
            "micro",
            "nano",
            "piko"});
            this.finp.Location = new System.Drawing.Point(98, 237);
            this.finp.Name = "finp";
            this.finp.Size = new System.Drawing.Size(307, 39);
            this.finp.TabIndex = 8;
            this.finp.Text = "Prefix:";
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History.Location = new System.Drawing.Point(98, 298);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(673, 201);
            this.History.TabIndex = 10;
            this.History.Text = "History:";
            // 
            // MCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.History);
            this.Controls.Add(this.finmeas);
            this.Controls.Add(this.finp);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.initcoef);
            this.Controls.Add(this.im);
            this.Controls.Add(this.initp);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MCon";
            this.Text = "Measurment Conerter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox initp;
        private ComboBox im;
        private TextBox initcoef;
        private Button transform;
        private Label Results;
        private ComboBox finmeas;
        private ComboBox finp;
        private RichTextBox History;
    }
}