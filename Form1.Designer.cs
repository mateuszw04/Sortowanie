namespace Sortowanie
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
            GenerujButton = new Button();
            label1 = new Label();
            label2 = new Label();
            s1 = new Button();
            s2 = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // GenerujButton
            // 
            GenerujButton.Location = new Point(238, 12);
            GenerujButton.Name = "GenerujButton";
            GenerujButton.Size = new Size(274, 46);
            GenerujButton.TabIndex = 0;
            GenerujButton.Text = "Generuj";
            GenerujButton.UseVisualStyleBackColor = true;
            GenerujButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 105);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 150);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // s1
            // 
            s1.Location = new Point(620, 97);
            s1.Name = "s1";
            s1.Size = new Size(75, 23);
            s1.TabIndex = 3;
            s1.Text = "S1";
            s1.UseVisualStyleBackColor = true;
            s1.Click += button1_Click_1;
            // 
            // s2
            // 
            s2.Location = new Point(620, 146);
            s2.Name = "s2";
            s2.Size = new Size(75, 23);
            s2.TabIndex = 4;
            s2.Text = "S2";
            s2.UseVisualStyleBackColor = true;
            s2.Click += s2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 193);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(620, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "S3 (QuickSort)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(s2);
            Controls.Add(s1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GenerujButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerujButton;
        private Label label1;
        private Label label2;
        private Button s1;
        private Button s2;
        private Label label3;
        private Button button1;
    }
}
