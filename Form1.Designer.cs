namespace SimpleCalculator
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
            txtInsert = new TextBox();
            txtRssult = new TextBox();
            butCe = new Button();
            butC = new Button();
            butDel = new Button();
            butDivision = new Button();
            butSeven = new Button();
            butEight = new Button();
            butNine = new Button();
            butMultip = new Button();
            butFour = new Button();
            butFive = new Button();
            butSix = new Button();
            butMin = new Button();
            butOne = new Button();
            butTwo = new Button();
            butThree = new Button();
            butPlus = new Button();
            butPlMi = new Button();
            butZero = new Button();
            butDot = new Button();
            butEqual = new Button();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // txtInsert
            // 
            txtInsert.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInsert.Location = new Point(106, 163);
            txtInsert.Name = "txtInsert";
            txtInsert.Size = new Size(487, 57);
            txtInsert.TabIndex = 0;
            txtInsert.UseWaitCursor = true;
            txtInsert.TextChanged += txtInsert_TextChanged;
            // 
            // txtRssult
            // 
            txtRssult.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRssult.Location = new Point(106, 239);
            txtRssult.Name = "txtRssult";
            txtRssult.Size = new Size(487, 57);
            txtRssult.TabIndex = 1;
            txtRssult.UseWaitCursor = true;
            txtRssult.TextChanged += txtRssult_TextChanged;
            // 
            // butCe
            // 
            butCe.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butCe.Location = new Point(106, 345);
            butCe.Name = "butCe";
            butCe.Size = new Size(109, 68);
            butCe.TabIndex = 2;
            butCe.Text = "CE";
            butCe.UseVisualStyleBackColor = true;
            butCe.UseWaitCursor = true;
            butCe.Click += butCe_Click;
            // 
            // butC
            // 
            butC.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butC.Location = new Point(231, 345);
            butC.Name = "butC";
            butC.Size = new Size(109, 68);
            butC.TabIndex = 3;
            butC.Text = "C";
            butC.UseVisualStyleBackColor = true;
            butC.UseWaitCursor = true;
            butC.Click += butC_Click;
            // 
            // butDel
            // 
            butDel.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butDel.Location = new Point(357, 345);
            butDel.Name = "butDel";
            butDel.Size = new Size(109, 68);
            butDel.TabIndex = 4;
            butDel.Text = "DEL";
            butDel.UseVisualStyleBackColor = true;
            butDel.UseWaitCursor = true;
            butDel.Click += butDel_Click;
            // 
            // butDivision
            // 
            butDivision.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butDivision.Location = new Point(484, 345);
            butDivision.Name = "butDivision";
            butDivision.Size = new Size(109, 68);
            butDivision.TabIndex = 5;
            butDivision.Text = "/";
            butDivision.UseVisualStyleBackColor = true;
            butDivision.UseWaitCursor = true;
            butDivision.Click += OperatorButton_Click;
            // 
            // butSeven
            // 
            butSeven.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butSeven.Location = new Point(106, 434);
            butSeven.Name = "butSeven";
            butSeven.Size = new Size(109, 68);
            butSeven.TabIndex = 6;
            butSeven.Text = "7";
            butSeven.UseVisualStyleBackColor = true;
            butSeven.UseWaitCursor = true;
            butSeven.Click += NumberButton_Click;
            // 
            // butEight
            // 
            butEight.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butEight.Location = new Point(231, 434);
            butEight.Name = "butEight";
            butEight.Size = new Size(109, 68);
            butEight.TabIndex = 7;
            butEight.Text = "8";
            butEight.UseVisualStyleBackColor = true;
            butEight.UseWaitCursor = true;
            butEight.Click += NumberButton_Click;
            // 
            // butNine
            // 
            butNine.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butNine.Location = new Point(357, 434);
            butNine.Name = "butNine";
            butNine.Size = new Size(109, 68);
            butNine.TabIndex = 8;
            butNine.Text = "9";
            butNine.UseVisualStyleBackColor = true;
            butNine.UseWaitCursor = true;
            butNine.Click += NumberButton_Click;
            // 
            // butMultip
            // 
            butMultip.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butMultip.Location = new Point(484, 434);
            butMultip.Name = "butMultip";
            butMultip.Size = new Size(109, 68);
            butMultip.TabIndex = 9;
            butMultip.Text = "*";
            butMultip.UseVisualStyleBackColor = true;
            butMultip.UseWaitCursor = true;
            butMultip.Click += OperatorButton_Click;
            // 
            // butFour
            // 
            butFour.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butFour.Location = new Point(106, 529);
            butFour.Name = "butFour";
            butFour.Size = new Size(109, 68);
            butFour.TabIndex = 10;
            butFour.Text = "4";
            butFour.UseVisualStyleBackColor = true;
            butFour.UseWaitCursor = true;
            butFour.Click += NumberButton_Click;
            // 
            // butFive
            // 
            butFive.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butFive.Location = new Point(231, 529);
            butFive.Name = "butFive";
            butFive.Size = new Size(109, 68);
            butFive.TabIndex = 11;
            butFive.Text = "5";
            butFive.UseVisualStyleBackColor = true;
            butFive.UseWaitCursor = true;
            butFive.Click += NumberButton_Click;
            // 
            // butSix
            // 
            butSix.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butSix.Location = new Point(357, 529);
            butSix.Name = "butSix";
            butSix.Size = new Size(109, 68);
            butSix.TabIndex = 12;
            butSix.Text = "6";
            butSix.UseVisualStyleBackColor = true;
            butSix.UseWaitCursor = true;
            butSix.Click += NumberButton_Click;
            // 
            // butMin
            // 
            butMin.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butMin.Location = new Point(484, 529);
            butMin.Name = "butMin";
            butMin.Size = new Size(109, 68);
            butMin.TabIndex = 13;
            butMin.Text = "-";
            butMin.UseVisualStyleBackColor = true;
            butMin.UseWaitCursor = true;
            butMin.Click += OperatorButton_Click;
            // 
            // butOne
            // 
            butOne.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butOne.Location = new Point(106, 624);
            butOne.Name = "butOne";
            butOne.Size = new Size(109, 68);
            butOne.TabIndex = 14;
            butOne.Text = "1";
            butOne.UseVisualStyleBackColor = true;
            butOne.UseWaitCursor = true;
            butOne.Click += NumberButton_Click;
            // 
            // butTwo
            // 
            butTwo.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butTwo.Location = new Point(231, 624);
            butTwo.Name = "butTwo";
            butTwo.Size = new Size(109, 68);
            butTwo.TabIndex = 15;
            butTwo.Text = "2";
            butTwo.UseVisualStyleBackColor = true;
            butTwo.UseWaitCursor = true;
            butTwo.Click += NumberButton_Click;
            // 
            // butThree
            // 
            butThree.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butThree.Location = new Point(357, 624);
            butThree.Name = "butThree";
            butThree.Size = new Size(109, 68);
            butThree.TabIndex = 16;
            butThree.Text = "3";
            butThree.UseVisualStyleBackColor = true;
            butThree.UseWaitCursor = true;
            butThree.Click += NumberButton_Click;
            // 
            // butPlus
            // 
            butPlus.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butPlus.Location = new Point(484, 624);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(109, 68);
            butPlus.TabIndex = 17;
            butPlus.Text = "+";
            butPlus.UseVisualStyleBackColor = true;
            butPlus.UseWaitCursor = true;
            butPlus.Click += OperatorButton_Click;
            // 
            // butPlMi
            // 
            butPlMi.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butPlMi.Location = new Point(106, 719);
            butPlMi.Name = "butPlMi";
            butPlMi.Size = new Size(109, 68);
            butPlMi.TabIndex = 18;
            butPlMi.Text = "+/-";
            butPlMi.UseVisualStyleBackColor = true;
            butPlMi.UseWaitCursor = true;
            butPlMi.Click += butPlMi_Click;
            // 
            // butZero
            // 
            butZero.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butZero.Location = new Point(231, 719);
            butZero.Name = "butZero";
            butZero.Size = new Size(109, 68);
            butZero.TabIndex = 19;
            butZero.Text = "0";
            butZero.UseVisualStyleBackColor = true;
            butZero.UseWaitCursor = true;
            butZero.Click += NumberButton_Click;
            // 
            // butDot
            // 
            butDot.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butDot.Location = new Point(357, 719);
            butDot.Name = "butDot";
            butDot.Size = new Size(109, 68);
            butDot.TabIndex = 20;
            butDot.Text = ".";
            butDot.UseVisualStyleBackColor = true;
            butDot.UseWaitCursor = true;
            butDot.Click += Dot_Click;
            // 
            // butEqual
            // 
            butEqual.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            butEqual.Location = new Point(484, 719);
            butEqual.Name = "butEqual";
            butEqual.Size = new Size(109, 68);
            butEqual.TabIndex = 21;
            butEqual.Text = "=";
            butEqual.UseVisualStyleBackColor = true;
            butEqual.UseWaitCursor = true;
            butEqual.Click += butEqual_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("맑은 고딕", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtTitle.ForeColor = SystemColors.MenuHighlight;
            txtTitle.Location = new Point(110, 21);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(483, 86);
            txtTitle.TabIndex = 22;
            txtTitle.Text = "Simple Calculator";
            txtTitle.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 836);
            Controls.Add(txtTitle);
            Controls.Add(butEqual);
            Controls.Add(butDot);
            Controls.Add(butZero);
            Controls.Add(butPlMi);
            Controls.Add(butPlus);
            Controls.Add(butThree);
            Controls.Add(butTwo);
            Controls.Add(butOne);
            Controls.Add(butMin);
            Controls.Add(butSix);
            Controls.Add(butFive);
            Controls.Add(butFour);
            Controls.Add(butMultip);
            Controls.Add(butNine);
            Controls.Add(butEight);
            Controls.Add(butSeven);
            Controls.Add(butDivision);
            Controls.Add(butDel);
            Controls.Add(butC);
            Controls.Add(butCe);
            Controls.Add(txtRssult);
            Controls.Add(txtInsert);
            Name = "Form1";
            Text = "Calculator 1.0";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInsert;
        private TextBox txtRssult;
        private Button butCe;
        private Button butC;
        private Button butDel;
        private Button butDivision;
        private Button butSeven;
        private Button butEight;
        private Button butNine;
        private Button butMultip;
        private Button butFour;
        private Button butFive;
        private Button butSix;
        private Button butMin;
        private Button butOne;
        private Button butTwo;
        private Button butThree;
        private Button butPlus;
        private Button butPlMi;
        private Button butZero;
        private Button butDot;
        private Button butEqual;
        private TextBox txtTitle;
    }
}
