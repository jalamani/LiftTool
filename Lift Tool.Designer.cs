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
            this.commonliftsLabel = new System.Windows.Forms.Label();
            this.shrugLabel = new System.Windows.Forms.Label();
            this.benchpressLabel = new System.Windows.Forms.Label();
            this.shoulderpressLabel = new System.Windows.Forms.Label();
            this.bicepcurlLabel = new System.Windows.Forms.Label();
            this.deadliftLabel = new System.Windows.Forms.Label();
            this.squatLabel = new System.Windows.Forms.Label();
            this.calfraiseLabel = new System.Windows.Forms.Label();
            this.legraiseLabel = new System.Windows.Forms.Label();
            this.benchpressInput = new System.Windows.Forms.NumericUpDown();
            this.shrugInput = new System.Windows.Forms.NumericUpDown();
            this.bicepcurlInput = new System.Windows.Forms.NumericUpDown();
            this.shoulderpressInput = new System.Windows.Forms.NumericUpDown();
            this.deadliftInput = new System.Windows.Forms.NumericUpDown();
            this.squatInput = new System.Windows.Forms.NumericUpDown();
            this.calfraiseInput = new System.Windows.Forms.NumericUpDown();
            this.legraiseInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bodyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchpressInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrugInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicepcurlInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoulderpressInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadliftInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfraiseInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legraiseInput)).BeginInit();
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
            // commonliftsLabel
            // 
            this.commonliftsLabel.AutoSize = true;
            this.commonliftsLabel.Location = new System.Drawing.Point(469, 61);
            this.commonliftsLabel.Name = "commonliftsLabel";
            this.commonliftsLabel.Size = new System.Drawing.Size(93, 17);
            this.commonliftsLabel.TabIndex = 5;
            this.commonliftsLabel.Text = "Common Lifts";
            // 
            // shrugLabel
            // 
            this.shrugLabel.AutoSize = true;
            this.shrugLabel.Location = new System.Drawing.Point(475, 92);
            this.shrugLabel.Name = "shrugLabel";
            this.shrugLabel.Size = new System.Drawing.Size(46, 17);
            this.shrugLabel.TabIndex = 6;
            this.shrugLabel.Text = "Shrug";
            // 
            // benchpressLabel
            // 
            this.benchpressLabel.AutoSize = true;
            this.benchpressLabel.Location = new System.Drawing.Point(661, 92);
            this.benchpressLabel.Name = "benchpressLabel";
            this.benchpressLabel.Size = new System.Drawing.Size(88, 17);
            this.benchpressLabel.TabIndex = 7;
            this.benchpressLabel.Text = "Bench Press";
            // 
            // shoulderpressLabel
            // 
            this.shoulderpressLabel.AutoSize = true;
            this.shoulderpressLabel.Location = new System.Drawing.Point(475, 156);
            this.shoulderpressLabel.Name = "shoulderpressLabel";
            this.shoulderpressLabel.Size = new System.Drawing.Size(105, 17);
            this.shoulderpressLabel.TabIndex = 8;
            this.shoulderpressLabel.Text = "Shoulder Press";
            // 
            // bicepcurlLabel
            // 
            this.bicepcurlLabel.AutoSize = true;
            this.bicepcurlLabel.Location = new System.Drawing.Point(661, 156);
            this.bicepcurlLabel.Name = "bicepcurlLabel";
            this.bicepcurlLabel.Size = new System.Drawing.Size(72, 17);
            this.bicepcurlLabel.TabIndex = 9;
            this.bicepcurlLabel.Text = "Bicep Curl";
            // 
            // deadliftLabel
            // 
            this.deadliftLabel.AutoSize = true;
            this.deadliftLabel.Location = new System.Drawing.Point(475, 220);
            this.deadliftLabel.Name = "deadliftLabel";
            this.deadliftLabel.Size = new System.Drawing.Size(56, 17);
            this.deadliftLabel.TabIndex = 10;
            this.deadliftLabel.Text = "Deadlift";
            // 
            // squatLabel
            // 
            this.squatLabel.AutoSize = true;
            this.squatLabel.Location = new System.Drawing.Point(661, 220);
            this.squatLabel.Name = "squatLabel";
            this.squatLabel.Size = new System.Drawing.Size(45, 17);
            this.squatLabel.TabIndex = 11;
            this.squatLabel.Text = "Squat";
            // 
            // calfraiseLabel
            // 
            this.calfraiseLabel.AutoSize = true;
            this.calfraiseLabel.Location = new System.Drawing.Point(475, 292);
            this.calfraiseLabel.Name = "calfraiseLabel";
            this.calfraiseLabel.Size = new System.Drawing.Size(72, 17);
            this.calfraiseLabel.TabIndex = 12;
            this.calfraiseLabel.Text = "Calf Raise";
            // 
            // legraiseLabel
            // 
            this.legraiseLabel.AutoSize = true;
            this.legraiseLabel.Location = new System.Drawing.Point(661, 292);
            this.legraiseLabel.Name = "legraiseLabel";
            this.legraiseLabel.Size = new System.Drawing.Size(72, 17);
            this.legraiseLabel.TabIndex = 13;
            this.legraiseLabel.Text = "Leg Raise";
            // 
            // benchpressInput
            // 
            this.benchpressInput.Location = new System.Drawing.Point(755, 87);
            this.benchpressInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.benchpressInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.benchpressInput.Name = "benchpressInput";
            this.benchpressInput.Size = new System.Drawing.Size(55, 22);
            this.benchpressInput.TabIndex = 15;
            this.benchpressInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shrugInput
            // 
            this.shrugInput.Location = new System.Drawing.Point(587, 87);
            this.shrugInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shrugInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shrugInput.Name = "shrugInput";
            this.shrugInput.Size = new System.Drawing.Size(55, 22);
            this.shrugInput.TabIndex = 16;
            this.shrugInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bicepcurlInput
            // 
            this.bicepcurlInput.Location = new System.Drawing.Point(755, 156);
            this.bicepcurlInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bicepcurlInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bicepcurlInput.Name = "bicepcurlInput";
            this.bicepcurlInput.Size = new System.Drawing.Size(55, 22);
            this.bicepcurlInput.TabIndex = 17;
            this.bicepcurlInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shoulderpressInput
            // 
            this.shoulderpressInput.Location = new System.Drawing.Point(587, 156);
            this.shoulderpressInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shoulderpressInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shoulderpressInput.Name = "shoulderpressInput";
            this.shoulderpressInput.Size = new System.Drawing.Size(55, 22);
            this.shoulderpressInput.TabIndex = 18;
            this.shoulderpressInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deadliftInput
            // 
            this.deadliftInput.Location = new System.Drawing.Point(587, 215);
            this.deadliftInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.deadliftInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deadliftInput.Name = "deadliftInput";
            this.deadliftInput.Size = new System.Drawing.Size(55, 22);
            this.deadliftInput.TabIndex = 19;
            this.deadliftInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // squatInput
            // 
            this.squatInput.Location = new System.Drawing.Point(755, 215);
            this.squatInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.squatInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.squatInput.Name = "squatInput";
            this.squatInput.Size = new System.Drawing.Size(55, 22);
            this.squatInput.TabIndex = 20;
            this.squatInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calfraiseInput
            // 
            this.calfraiseInput.Location = new System.Drawing.Point(587, 287);
            this.calfraiseInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.calfraiseInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.calfraiseInput.Name = "calfraiseInput";
            this.calfraiseInput.Size = new System.Drawing.Size(55, 22);
            this.calfraiseInput.TabIndex = 21;
            this.calfraiseInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // legraiseInput
            // 
            this.legraiseInput.Location = new System.Drawing.Point(755, 287);
            this.legraiseInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.legraiseInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.legraiseInput.Name = "legraiseInput";
            this.legraiseInput.Size = new System.Drawing.Size(55, 22);
            this.legraiseInput.TabIndex = 22;
            this.legraiseInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.legraiseInput);
            this.Controls.Add(this.calfraiseInput);
            this.Controls.Add(this.squatInput);
            this.Controls.Add(this.deadliftInput);
            this.Controls.Add(this.shoulderpressInput);
            this.Controls.Add(this.bicepcurlInput);
            this.Controls.Add(this.shrugInput);
            this.Controls.Add(this.benchpressInput);
            this.Controls.Add(this.legraiseLabel);
            this.Controls.Add(this.calfraiseLabel);
            this.Controls.Add(this.squatLabel);
            this.Controls.Add(this.deadliftLabel);
            this.Controls.Add(this.bicepcurlLabel);
            this.Controls.Add(this.shoulderpressLabel);
            this.Controls.Add(this.benchpressLabel);
            this.Controls.Add(this.shrugLabel);
            this.Controls.Add(this.commonliftsLabel);
            this.Controls.Add(this.weightSave);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.bodyImage);
            this.Name = "Form1";
            this.Text = "Lift Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchpressInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrugInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicepcurlInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoulderpressInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadliftInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfraiseInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legraiseInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bodyImage;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.NumericUpDown weightInput;
        private System.Windows.Forms.Button weightSave;
        private System.Windows.Forms.Label commonliftsLabel;
        private System.Windows.Forms.Label shrugLabel;
        private System.Windows.Forms.Label benchpressLabel;
        private System.Windows.Forms.Label shoulderpressLabel;
        private System.Windows.Forms.Label bicepcurlLabel;
        private System.Windows.Forms.Label deadliftLabel;
        private System.Windows.Forms.Label squatLabel;
        private System.Windows.Forms.Label calfraiseLabel;
        private System.Windows.Forms.Label legraiseLabel;
        private System.Windows.Forms.NumericUpDown benchpressInput;
        private System.Windows.Forms.NumericUpDown shrugInput;
        private System.Windows.Forms.NumericUpDown bicepcurlInput;
        private System.Windows.Forms.NumericUpDown shoulderpressInput;
        private System.Windows.Forms.NumericUpDown deadliftInput;
        private System.Windows.Forms.NumericUpDown squatInput;
        private System.Windows.Forms.NumericUpDown calfraiseInput;
        private System.Windows.Forms.NumericUpDown legraiseInput;
    }
}

