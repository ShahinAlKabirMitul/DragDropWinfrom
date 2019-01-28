namespace DragDropResurent
{
    partial class buttonUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDi = new System.Windows.Forms.Button();
            this.btnRoateBack = new System.Windows.Forms.Button();
            this.btnRoateFront = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDi
            // 
            this.btnDi.Location = new System.Drawing.Point(60, 4);
            this.btnDi.Name = "btnDi";
            this.btnDi.Size = new System.Drawing.Size(31, 26);
            this.btnDi.TabIndex = 1;
            this.btnDi.Text = "-";
            this.btnDi.UseVisualStyleBackColor = true;
            // 
            // btnRoateBack
            // 
            this.btnRoateBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRoateBack.Location = new System.Drawing.Point(97, 4);
            this.btnRoateBack.Name = "btnRoateBack";
            this.btnRoateBack.Size = new System.Drawing.Size(31, 26);
            this.btnRoateBack.TabIndex = 2;
            this.btnRoateBack.Text = " ⃔ ";
            this.btnRoateBack.UseVisualStyleBackColor = true;
            // 
            // btnRoateFront
            // 
            this.btnRoateFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRoateFront.Location = new System.Drawing.Point(134, 4);
            this.btnRoateFront.Name = "btnRoateFront";
            this.btnRoateFront.Size = new System.Drawing.Size(31, 26);
            this.btnRoateFront.TabIndex = 3;
            this.btnRoateFront.Text = " ⃕";
            this.btnRoateFront.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(171, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(31, 26);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(77, 142);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "label1";
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Location = new System.Drawing.Point(9, 36);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(201, 93);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            // 
            // buttonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRoateFront);
            this.Controls.Add(this.btnRoateBack);
            this.Controls.Add(this.btnDi);
            this.Controls.Add(this.btnAdd);
            this.Name = "buttonUserControl";
            this.Size = new System.Drawing.Size(234, 164);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonUserControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDi;
        private System.Windows.Forms.Button btnRoateBack;
        private System.Windows.Forms.Button btnRoateFront;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.Label lbl;
    }
}
