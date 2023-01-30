
namespace Child
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this._ButtonParent = new System.Windows.Forms.Button();
            this._LabelExecuteState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _ButtonParent
            // 
            this._ButtonParent.Location = new System.Drawing.Point(12, 28);
            this._ButtonParent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ButtonParent.Name = "_ButtonParent";
            this._ButtonParent.Size = new System.Drawing.Size(75, 29);
            this._ButtonParent.TabIndex = 0;
            this._ButtonParent.Text = "Parent";
            this._ButtonParent.UseVisualStyleBackColor = true;
            this._ButtonParent.Click += new System.EventHandler(this._ButtonParent_Click);
            // 
            // _LabelExecuteState
            // 
            this._LabelExecuteState.AutoSize = true;
            this._LabelExecuteState.Location = new System.Drawing.Point(12, 137);
            this._LabelExecuteState.Name = "_LabelExecuteState";
            this._LabelExecuteState.Size = new System.Drawing.Size(66, 15);
            this._LabelExecuteState.TabIndex = 1;
            this._LabelExecuteState.Text = "실행상태 : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this._LabelExecuteState);
            this.Controls.Add(this._ButtonParent);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _ButtonParent;
        private System.Windows.Forms.Label _LabelExecuteState;
    }
}

