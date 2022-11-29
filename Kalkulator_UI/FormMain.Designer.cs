namespace Kalkulator_UI
{
    partial class FormMain
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
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonMinPlus = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtruct = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.labelCoders = new System.Windows.Forms.Label();
            this.panelMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainPanel.Controls.Add(this.buttonClear);
            this.panelMainPanel.Controls.Add(this.buttonBackspace);
            this.panelMainPanel.Controls.Add(this.labelStatus);
            this.panelMainPanel.Controls.Add(this.buttonEqual);
            this.panelMainPanel.Controls.Add(this.buttonDot);
            this.panelMainPanel.Controls.Add(this.buttonMinPlus);
            this.panelMainPanel.Controls.Add(this.buttonDevide);
            this.panelMainPanel.Controls.Add(this.buttonMultiply);
            this.panelMainPanel.Controls.Add(this.buttonSubtruct);
            this.panelMainPanel.Controls.Add(this.buttonAdd);
            this.panelMainPanel.Controls.Add(this.buttonZero);
            this.panelMainPanel.Controls.Add(this.buttonNine);
            this.panelMainPanel.Controls.Add(this.buttonEight);
            this.panelMainPanel.Controls.Add(this.buttonSeven);
            this.panelMainPanel.Controls.Add(this.buttonSix);
            this.panelMainPanel.Controls.Add(this.buttonFive);
            this.panelMainPanel.Controls.Add(this.buttonFour);
            this.panelMainPanel.Controls.Add(this.buttonThree);
            this.panelMainPanel.Controls.Add(this.buttonTwo);
            this.panelMainPanel.Controls.Add(this.buttonOne);
            this.panelMainPanel.Controls.Add(this.textBoxDisplay);
            this.panelMainPanel.Location = new System.Drawing.Point(20, 46);
            this.panelMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(313, 445);
            this.panelMainPanel.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(240, 378);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 49);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(20, 378);
            this.buttonBackspace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(53, 49);
            this.buttonBackspace.TabIndex = 19;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(19, 74);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(109, 16);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Ovdje idu poruke";
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(93, 378);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(127, 49);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "IZRAČUNAJ";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(167, 310);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(53, 49);
            this.buttonDot.TabIndex = 16;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonMinPlus
            // 
            this.buttonMinPlus.Location = new System.Drawing.Point(20, 310);
            this.buttonMinPlus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinPlus.Name = "buttonMinPlus";
            this.buttonMinPlus.Size = new System.Drawing.Size(53, 49);
            this.buttonMinPlus.TabIndex = 15;
            this.buttonMinPlus.Text = "+/-";
            this.buttonMinPlus.UseVisualStyleBackColor = true;
            this.buttonMinPlus.Click += new System.EventHandler(this.buttonMinPlus_Click);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(240, 310);
            this.buttonDevide.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(53, 49);
            this.buttonDevide.TabIndex = 14;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(241, 242);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(52, 49);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonSubtruct
            // 
            this.buttonSubtruct.Location = new System.Drawing.Point(240, 175);
            this.buttonSubtruct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubtruct.Name = "buttonSubtruct";
            this.buttonSubtruct.Size = new System.Drawing.Size(53, 49);
            this.buttonSubtruct.TabIndex = 12;
            this.buttonSubtruct.Text = "-";
            this.buttonSubtruct.UseVisualStyleBackColor = true;
            this.buttonSubtruct.Click += new System.EventHandler(this.buttonSubtruct_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(240, 107);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 49);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(93, 310);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(53, 49);
            this.buttonZero.TabIndex = 10;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(167, 242);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(52, 49);
            this.buttonNine.TabIndex = 9;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(93, 242);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(52, 49);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(20, 242);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(53, 49);
            this.buttonSeven.TabIndex = 7;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(167, 175);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(53, 49);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(93, 175);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(53, 49);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(20, 175);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(53, 49);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(167, 107);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(53, 49);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(93, 107);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(53, 49);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(20, 107);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(53, 49);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(20, 18);
            this.textBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDisplay.MaxLength = 9;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(272, 46);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // labelCoders
            // 
            this.labelCoders.AutoSize = true;
            this.labelCoders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoders.Location = new System.Drawing.Point(16, 11);
            this.labelCoders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoders.Name = "labelCoders";
            this.labelCoders.Size = new System.Drawing.Size(301, 25);
            this.labelCoders.TabIndex = 1;
            this.labelCoders.Text = "Kalkulator - Kodovali Vesna i Ajla";
            this.labelCoders.Click += new System.EventHandler(this.labelCoders_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 514);
            this.Controls.Add(this.labelCoders);
            this.Controls.Add(this.panelMainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator 0.1";
            this.panelMainPanel.ResumeLayout(false);
            this.panelMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.Label labelCoders;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonMinPlus;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtruct;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
    }
}

