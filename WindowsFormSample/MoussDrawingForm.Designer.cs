namespace WindowsFormSample
{
    partial class MoussDrawingForm
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
            this.SuspendLayout();
            // 
            // MoussDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MoussDrawingForm";
            this.Text = "MoussDrawingForm";
            this.Load += new System.EventHandler(this.MoussDrawingForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MoussDrawingForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoussDrawingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoussDrawingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoussDrawingForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}