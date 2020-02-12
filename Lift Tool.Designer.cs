namespace LiftTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bodyImage = new System.Windows.Forms.PictureBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.NumericUpDown();
            this.weightSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bodyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyImage
            // 
            this.bodyImage.Image = ((System.Drawing.Image)(resources.GetObject("bodyImage.Image")));
            this.bodyImage.Location = new System.Drawing.Point(12, 12);
            this.bodyImage.Name = "bodyImage";
            this.bodyImage.Size = new System.Drawing.Size(450, 529);
            this.bodyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bodyImage.TabIndex = 0;
            this.bodyImage.TabStop = false;
            this.bodyImage.Click += new System.EventHandler(this.bodyImage_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(469, 12);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(124, 17);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Body Weight (lbs):";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(599, 12);
            this.weightInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(55, 22);
            this.weightInput.TabIndex = 3;
            this.weightInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // weightSave
            // 
            this.weightSave.Location = new System.Drawing.Point(661, 12);
            this.weightSave.Name = "weightSave";
            this.weightSave.Size = new System.Drawing.Size(75, 23);
            this.weightSave.TabIndex = 4;
            this.weightSave.Text = "Save";
            this.weightSave.UseVisualStyleBackColor = true;
            this.weightSave.Click += new System.EventHandler(this.weightSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.weightSave);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.bodyImage);
            this.Name = "Form1";
            this.Text = "Lift Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bodyImage;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.NumericUpDown weightInput;
        private System.Windows.Forms.Button weightSave;
    }
}

