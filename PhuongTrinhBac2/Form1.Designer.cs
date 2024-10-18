namespace PhuongTrinhBac2
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
            lblPhuongTrinh = new Label();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblKetQua = new Label();
            btnSolve = new Button();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPhuongTrinh
            // 
            lblPhuongTrinh.BackColor = SystemColors.MenuHighlight;
            lblPhuongTrinh.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhuongTrinh.ForeColor = Color.White;
            lblPhuongTrinh.Location = new Point(173, 9);
            lblPhuongTrinh.Name = "lblPhuongTrinh";
            lblPhuongTrinh.Size = new Size(521, 123);
            lblPhuongTrinh.TabIndex = 0;
            lblPhuongTrinh.Text = "ax² + bx + c = 0";
            lblPhuongTrinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(54, 182);
            lblA.Name = "lblA";
            lblA.Size = new Size(56, 32);
            lblA.TabIndex = 1;
            lblA.Text = "a = ";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(352, 182);
            lblB.Name = "lblB";
            lblB.Size = new Size(58, 32);
            lblB.TabIndex = 2;
            lblB.Text = "b = ";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(641, 182);
            lblC.Name = "lblC";
            lblC.Size = new Size(55, 32);
            lblC.TabIndex = 3;
            lblC.Text = "c = ";
            // 
            // txtA
            // 
            txtA.Location = new Point(134, 179);
            txtA.Name = "txtA";
            txtA.Size = new Size(134, 38);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(432, 177);
            txtB.Name = "txtB";
            txtB.Size = new Size(134, 38);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(731, 177);
            txtC.Name = "txtC";
            txtC.Size = new Size(134, 38);
            txtC.TabIndex = 2;
            // 
            // lblKetQua
            // 
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(54, 321);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(809, 124);
            lblKetQua.TabIndex = 5;
            // 
            // btnSolve
            // 
            btnSolve.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolve.Location = new Point(731, 9);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(150, 57);
            btnSolve.TabIndex = 4;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(731, 72);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 60);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(54, 235);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(809, 57);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSolve;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(909, 519);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnSolve);
            Controls.Add(lblKetQua);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblPhuongTrinh);
            Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhuongTrinh;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblKetQua;
        private Button btnSolve;
        private Button btnReset;
        private Button btnExit;
    }
}
