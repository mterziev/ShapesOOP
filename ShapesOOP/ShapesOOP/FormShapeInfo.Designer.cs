namespace ShapesOOP
{
    partial class FormShapeInfo
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
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(26, 31);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(93, 25);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Position=";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(26, 78);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(63, 25);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size=";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(26, 125);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(66, 25);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Area=";
            // 
            // FormShapeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 207);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPosition);
            this.Name = "FormShapeInfo";
            this.Text = "FormShapeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelPosition;
        public System.Windows.Forms.Label labelSize;
        public System.Windows.Forms.Label labelArea;
    }
}