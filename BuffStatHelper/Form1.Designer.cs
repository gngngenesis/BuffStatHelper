namespace BuffStatHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShiftLeft_Text = new System.Windows.Forms.TextBox();
            this.BuffStat_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShiftLeft_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Buffstat_Button = new System.Windows.Forms.Button();
            this.BuffValue_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShiftLeft_Text
            // 
            this.ShiftLeft_Text.Location = new System.Drawing.Point(12, 33);
            this.ShiftLeft_Text.Name = "ShiftLeft_Text";
            this.ShiftLeft_Text.Size = new System.Drawing.Size(235, 21);
            this.ShiftLeft_Text.TabIndex = 0;
            // 
            // BuffStat_Text
            // 
            this.BuffStat_Text.Location = new System.Drawing.Point(12, 129);
            this.BuffStat_Text.Name = "BuffStat_Text";
            this.BuffStat_Text.Size = new System.Drawing.Size(235, 21);
            this.BuffStat_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ShiftLeft to BuffStat";
            // 
            // ShiftLeft_Button
            // 
            this.ShiftLeft_Button.Location = new System.Drawing.Point(12, 60);
            this.ShiftLeft_Button.Name = "ShiftLeft_Button";
            this.ShiftLeft_Button.Size = new System.Drawing.Size(235, 32);
            this.ShiftLeft_Button.TabIndex = 3;
            this.ShiftLeft_Button.Text = "변환하기";
            this.ShiftLeft_Button.UseVisualStyleBackColor = true;
            this.ShiftLeft_Button.Click += new System.EventHandler(this.ShiftLeft_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "BuffStat to ShiftLeft";
            // 
            // Buffstat_Button
            // 
            this.Buffstat_Button.Location = new System.Drawing.Point(12, 156);
            this.Buffstat_Button.Name = "Buffstat_Button";
            this.Buffstat_Button.Size = new System.Drawing.Size(235, 32);
            this.Buffstat_Button.TabIndex = 5;
            this.Buffstat_Button.Text = "변환하기";
            this.Buffstat_Button.UseVisualStyleBackColor = true;
            this.Buffstat_Button.Click += new System.EventHandler(this.Buffstat_Button_Click);
            // 
            // BuffValue_Text
            // 
            this.BuffValue_Text.ForeColor = System.Drawing.Color.Blue;
            this.BuffValue_Text.Location = new System.Drawing.Point(12, 222);
            this.BuffValue_Text.Name = "BuffValue_Text";
            this.BuffValue_Text.Size = new System.Drawing.Size(235, 21);
            this.BuffValue_Text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "결과 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuffValue_Text);
            this.Controls.Add(this.Buffstat_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShiftLeft_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuffStat_Text);
            this.Controls.Add(this.ShiftLeft_Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "버프스탯";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShiftLeft_Text;
        private System.Windows.Forms.TextBox BuffStat_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShiftLeft_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buffstat_Button;
        private System.Windows.Forms.TextBox BuffValue_Text;
        private System.Windows.Forms.Label label3;
    }
}

