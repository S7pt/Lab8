namespace RealLab8
{
    partial class Form6
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
            this.SortByDuration = new System.Windows.Forms.Button();
            this.SortByWeight = new System.Windows.Forms.Button();
            this.SortByInitials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortByDuration
            // 
            this.SortByDuration.Location = new System.Drawing.Point(131, 110);
            this.SortByDuration.Name = "SortByDuration";
            this.SortByDuration.Size = new System.Drawing.Size(198, 90);
            this.SortByDuration.TabIndex = 0;
            this.SortByDuration.Text = "Sort by duration";
            this.SortByDuration.UseVisualStyleBackColor = true;
            this.SortByDuration.Click += new System.EventHandler(this.SortByDuration_Click);
            // 
            // SortByWeight
            // 
            this.SortByWeight.Location = new System.Drawing.Point(522, 110);
            this.SortByWeight.Name = "SortByWeight";
            this.SortByWeight.Size = new System.Drawing.Size(199, 90);
            this.SortByWeight.TabIndex = 1;
            this.SortByWeight.Text = "Sort by Weight";
            this.SortByWeight.UseVisualStyleBackColor = true;
            this.SortByWeight.Click += new System.EventHandler(this.SortByWeight_Click);
            // 
            // SortByInitials
            // 
            this.SortByInitials.Location = new System.Drawing.Point(329, 242);
            this.SortByInitials.Name = "SortByInitials";
            this.SortByInitials.Size = new System.Drawing.Size(198, 90);
            this.SortByInitials.TabIndex = 2;
            this.SortByInitials.Text = "Sort by initials";
            this.SortByInitials.UseVisualStyleBackColor = true;
            this.SortByInitials.Click += new System.EventHandler(this.SortByInitials_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortByInitials);
            this.Controls.Add(this.SortByWeight);
            this.Controls.Add(this.SortByDuration);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortByDuration;
        private System.Windows.Forms.Button SortByWeight;
        private System.Windows.Forms.Button SortByInitials;
    }
}