namespace DiceMachine
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDice = new System.Windows.Forms.NumericUpDown();
            this.nudSides = new System.Windows.Forms.NumericUpDown();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "# of Sides";
            // 
            // nudDice
            // 
            this.nudDice.Location = new System.Drawing.Point(12, 25);
            this.nudDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDice.Name = "nudDice";
            this.nudDice.Size = new System.Drawing.Size(51, 20);
            this.nudDice.TabIndex = 3;
            this.nudDice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSides
            // 
            this.nudSides.Location = new System.Drawing.Point(90, 25);
            this.nudSides.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSides.Name = "nudSides";
            this.nudSides.Size = new System.Drawing.Size(52, 20);
            this.nudSides.TabIndex = 4;
            this.nudSides.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSides.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(12, 51);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(60, 23);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(82, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(12, 80);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(130, 186);
            this.lbResults.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(154, 278);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.nudSides);
            this.Controls.Add(this.nudDice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dice Machine";
            ((System.ComponentModel.ISupportInitialize)(this.nudDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDice;
        private System.Windows.Forms.NumericUpDown nudSides;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbResults;
    }
}

