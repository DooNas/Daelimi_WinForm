﻿namespace UserChat
{
    partial class User_Chat
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.End = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tail = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.Ai_ChatText = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // End
            // 
            this.End.Dock = System.Windows.Forms.DockStyle.Left;
            this.End.Location = new System.Drawing.Point(0, 0);
            this.End.MinimumSize = new System.Drawing.Size(18, 0);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(18, 53);
            this.End.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.tail);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(268, 0);
            this.panel5.MinimumSize = new System.Drawing.Size(18, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(34, 53);
            this.panel5.TabIndex = 3;
            // 
            // tail
            // 
            this.tail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tail.BackgroundImage = global::UserChat.Properties.Resources.tail;
            this.tail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tail.Location = new System.Drawing.Point(0, 14);
            this.tail.Name = "tail";
            this.tail.Size = new System.Drawing.Size(25, 23);
            this.tail.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.BackgroundImage = global::UserChat.Properties.Resources.main;
            this.Main.Controls.Add(this.Ai_ChatText);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(18, 14);
            this.Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Main.Size = new System.Drawing.Size(250, 25);
            this.Main.TabIndex = 2;
            // 
            // Ai_ChatText
            // 
            this.Ai_ChatText.AutoSize = true;
            this.Ai_ChatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ai_ChatText.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Ai_ChatText.Location = new System.Drawing.Point(4, 3);
            this.Ai_ChatText.MaximumSize = new System.Drawing.Size(219, 0);
            this.Ai_ChatText.Name = "Ai_ChatText";
            this.Ai_ChatText.Size = new System.Drawing.Size(79, 19);
            this.Ai_ChatText.TabIndex = 0;
            this.Ai_ChatText.Text = "안녕하세요";
            // 
            // Top
            // 
            this.Top.AutoScroll = true;
            this.Top.BackColor = System.Drawing.Color.Transparent;
            this.Top.BackgroundImage = global::UserChat.Properties.Resources.top;
            this.Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(18, 0);
            this.Top.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(250, 14);
            this.Top.TabIndex = 1;
            // 
            // Bottom
            // 
            this.Bottom.AllowDrop = true;
            this.Bottom.BackgroundImage = global::UserChat.Properties.Resources.bottom;
            this.Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(18, 39);
            this.Bottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(250, 14);
            this.Bottom.TabIndex = 2;
            // 
            // User_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.End);
            this.MaximumSize = new System.Drawing.Size(302, 0);
            this.Name = "User_Chat";
            this.Size = new System.Drawing.Size(306, 53);
            this.panel5.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel End;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Ai_ChatText;
        private System.Windows.Forms.Panel tail;
    }
}
