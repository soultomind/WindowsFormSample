namespace WindowsFormSample
{
    partial class WndProcForm
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
            this._CheckBoxPreventFormMove = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _CheckBoxPreventFormMove
            // 
            this._CheckBoxPreventFormMove.AutoSize = true;
            this._CheckBoxPreventFormMove.Location = new System.Drawing.Point(12, 15);
            this._CheckBoxPreventFormMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._CheckBoxPreventFormMove.Name = "_CheckBoxPreventFormMove";
            this._CheckBoxPreventFormMove.Size = new System.Drawing.Size(74, 19);
            this._CheckBoxPreventFormMove.TabIndex = 0;
            this._CheckBoxPreventFormMove.Text = "이동방지";
            this._CheckBoxPreventFormMove.UseVisualStyleBackColor = true;
            // 
            // WndProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this._CheckBoxPreventFormMove);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WndProcForm";
            this.Text = "WndProcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _CheckBoxPreventFormMove;
    }
}