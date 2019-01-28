namespace DragDropResurent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnRec);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = global::DragDropResurent.Properties.Resources.square4Chair;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare.Location = new System.Drawing.Point(12, 306);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(172, 98);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnRec
            // 
            this.btnRec.BackgroundImage = global::DragDropResurent.Properties.Resources.rectangle10Chair;
            this.btnRec.Image = global::DragDropResurent.Properties.Resources.rectangle10Chair;
            this.btnRec.Location = new System.Drawing.Point(3, 127);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(194, 154);
            this.btnRec.TabIndex = 1;
            this.btnRec.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = global::DragDropResurent.Properties.Resources.circle4Chair;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCircle.Location = new System.Drawing.Point(12, 20);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(157, 91);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "b";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(231, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 519);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnCircle;
    }
}

