namespace okay
{
    partial class VariablesPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariablesPractice));
            this.Hockey = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hockey
            // 
            this.Hockey.Location = new System.Drawing.Point(12, 12);
            this.Hockey.Name = "Hockey";
            this.Hockey.Size = new System.Drawing.Size(140, 88);
            this.Hockey.TabIndex = 0;
            this.Hockey.Text = "Hockey";
            this.Hockey.UseVisualStyleBackColor = true;
            this.Hockey.Click += new System.EventHandler(this.Hockey_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(12, 126);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(140, 84);
            this.Area.TabIndex = 1;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Carpet
            // 
            this.Carpet.Location = new System.Drawing.Point(13, 238);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(141, 88);
            this.Carpet.TabIndex = 2;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(13, 350);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(140, 88);
            this.Bill.TabIndex = 3;
            this.Bill.Text = "Bill";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.SystemColors.Info;
            this.outputLabel.Location = new System.Drawing.Point(175, 22);
            this.outputLabel.MaximumSize = new System.Drawing.Size(1000000, 10000000);
            this.outputLabel.MinimumSize = new System.Drawing.Size(590, 405);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(590, 405);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "(Unkown)";
            // 
            // VariablesPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 451);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Hockey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VariablesPractice";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hockey;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Label outputLabel;
    }
}

