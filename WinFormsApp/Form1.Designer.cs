
namespace WinFormsApp
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
            this.radius = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.CalcC = new System.Windows.Forms.Button();
            this.CalcR = new System.Windows.Forms.Button();
            this.CalcT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.areaC = new System.Windows.Forms.Label();
            this.perimeterC = new System.Windows.Forms.Label();
            this.areaR = new System.Windows.Forms.Label();
            this.perimeterR = new System.Windows.Forms.Label();
            this.areaT = new System.Windows.Forms.Label();
            this.perimeterT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(80, 36);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 22);
            this.radius.TabIndex = 0;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(359, 38);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 22);
            this.height.TabIndex = 1;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(359, 89);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 22);
            this.width.TabIndex = 2;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(634, 36);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 3;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(634, 89);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 4;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(634, 134);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 22);
            this.c.TabIndex = 5;
            // 
            // CalcC
            // 
            this.CalcC.Location = new System.Drawing.Point(80, 328);
            this.CalcC.Name = "CalcC";
            this.CalcC.Size = new System.Drawing.Size(111, 71);
            this.CalcC.TabIndex = 7;
            this.CalcC.Text = "Calculate For Circle";
            this.CalcC.UseVisualStyleBackColor = true;
            this.CalcC.Click += new System.EventHandler(this.CalcC_Click);
            // 
            // CalcR
            // 
            this.CalcR.Location = new System.Drawing.Point(359, 328);
            this.CalcR.Name = "CalcR";
            this.CalcR.Size = new System.Drawing.Size(109, 71);
            this.CalcR.TabIndex = 8;
            this.CalcR.Text = "Calculate For Rectangle";
            this.CalcR.UseVisualStyleBackColor = true;
            this.CalcR.Click += new System.EventHandler(this.CalcR_Click);
            // 
            // CalcT
            // 
            this.CalcT.Location = new System.Drawing.Point(607, 328);
            this.CalcT.Name = "CalcT";
            this.CalcT.Size = new System.Drawing.Size(107, 71);
            this.CalcT.TabIndex = 9;
            this.CalcT.Text = "Calculate For Triangle";
            this.CalcT.UseVisualStyleBackColor = true;
            this.CalcT.Click += new System.EventHandler(this.CalcT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Side A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Size B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Size C:";
            // 
            // areaC
            // 
            this.areaC.AutoSize = true;
            this.areaC.Location = new System.Drawing.Point(77, 251);
            this.areaC.Name = "areaC";
            this.areaC.Size = new System.Drawing.Size(0, 17);
            this.areaC.TabIndex = 17;
            // 
            // perimeterC
            // 
            this.perimeterC.AutoSize = true;
            this.perimeterC.Location = new System.Drawing.Point(77, 283);
            this.perimeterC.Name = "perimeterC";
            this.perimeterC.Size = new System.Drawing.Size(0, 17);
            this.perimeterC.TabIndex = 18;
            // 
            // areaR
            // 
            this.areaR.AutoSize = true;
            this.areaR.Location = new System.Drawing.Point(356, 251);
            this.areaR.Name = "areaR";
            this.areaR.Size = new System.Drawing.Size(0, 17);
            this.areaR.TabIndex = 19;
            // 
            // perimeterR
            // 
            this.perimeterR.AutoSize = true;
            this.perimeterR.Location = new System.Drawing.Point(356, 283);
            this.perimeterR.Name = "perimeterR";
            this.perimeterR.Size = new System.Drawing.Size(0, 17);
            this.perimeterR.TabIndex = 20;
            // 
            // areaT
            // 
            this.areaT.AutoSize = true;
            this.areaT.Location = new System.Drawing.Point(611, 251);
            this.areaT.Name = "areaT";
            this.areaT.Size = new System.Drawing.Size(0, 17);
            this.areaT.TabIndex = 21;
            // 
            // perimeterT
            // 
            this.perimeterT.AutoSize = true;
            this.perimeterT.Location = new System.Drawing.Point(611, 283);
            this.perimeterT.Name = "perimeterT";
            this.perimeterT.Size = new System.Drawing.Size(0, 17);
            this.perimeterT.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.perimeterT);
            this.Controls.Add(this.areaT);
            this.Controls.Add(this.perimeterR);
            this.Controls.Add(this.areaR);
            this.Controls.Add(this.perimeterC);
            this.Controls.Add(this.areaC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcT);
            this.Controls.Add(this.CalcR);
            this.Controls.Add(this.CalcC);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.radius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Button CalcC;
        private System.Windows.Forms.Button CalcR;
        private System.Windows.Forms.Button CalcT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label areaC;
        private System.Windows.Forms.Label perimeterC;
        private System.Windows.Forms.Label areaR;
        private System.Windows.Forms.Label perimeterR;
        private System.Windows.Forms.Label areaT;
        private System.Windows.Forms.Label perimeterT;
    }
}

