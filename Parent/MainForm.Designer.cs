
namespace Parent
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
            this._ButtonChild = new System.Windows.Forms.Button();
            this._LabelExecuteState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _ButtonChild
            // 
            this._ButtonChild.Location = new System.Drawing.Point(12, 28);
            this._ButtonChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ButtonChild.Name = "_ButtonChild";
            this._ButtonChild.Size = new System.Drawing.Size(75, 29);
            this._ButtonChild.TabIndex = 1;
            this._ButtonChild.Text = "Child";
            this._ButtonChild.UseVisualStyleBackColor = true;
            this._ButtonChild.Click += new System.EventHandler(this._ButtonChild_Click);
            // 
            // _LabelExecuteState
            // 
            this._LabelExecuteState.AutoSize = true;
            this._LabelExecuteState.Location = new System.Drawing.Point(12, 137);
            this._LabelExecuteState.Name = "_LabelExecuteState";
            this._LabelExecuteState.Size = new System.Drawing.Size(66, 15);
            this._LabelExecuteState.TabIndex = 2;
            this._LabelExecuteState.Text = "실행상태 : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this._LabelExecuteState);
            this.Controls.Add(this._ButtonChild);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _ButtonChild;
        private System.Windows.Forms.Label _LabelExecuteState;
    }
}

