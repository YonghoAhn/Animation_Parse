namespace Animation_Parse
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
            this.components = new System.ComponentModel.Container();
            this.img_Title = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로고침RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.최근본애니ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최근본영상RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.완결애니CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방영애니BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Title
            // 
            this.img_Title.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.img_Title.ImageSize = new System.Drawing.Size(16, 16);
            this.img_Title.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(897, 531);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.보기VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로고침RToolStripMenuItem,
            this.최근본애니ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로고침RToolStripMenuItem
            // 
            this.새로고침RToolStripMenuItem.Name = "새로고침RToolStripMenuItem";
            this.새로고침RToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.새로고침RToolStripMenuItem.Text = "새로 고침(&R)";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(877, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // 최근본애니ToolStripMenuItem
            // 
            this.최근본애니ToolStripMenuItem.Name = "최근본애니ToolStripMenuItem";
            this.최근본애니ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.최근본애니ToolStripMenuItem.Text = "최근 본 애니";
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.최근본영상RToolStripMenuItem,
            this.완결애니CToolStripMenuItem,
            this.방영애니BToolStripMenuItem});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기VToolStripMenuItem.Text = "보기(&V)";
            // 
            // 최근본영상RToolStripMenuItem
            // 
            this.최근본영상RToolStripMenuItem.Name = "최근본영상RToolStripMenuItem";
            this.최근본영상RToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.최근본영상RToolStripMenuItem.Text = "최근 본 영상(&R)";
            // 
            // 완결애니CToolStripMenuItem
            // 
            this.완결애니CToolStripMenuItem.Name = "완결애니CToolStripMenuItem";
            this.완결애니CToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.완결애니CToolStripMenuItem.Text = "완결 애니(&C)";
            // 
            // 방영애니BToolStripMenuItem
            // 
            this.방영애니BToolStripMenuItem.Name = "방영애니BToolStripMenuItem";
            this.방영애니BToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.방영애니BToolStripMenuItem.Text = "방영 애니(&B)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 555);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList img_Title;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로고침RToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem 최근본애니ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 최근본영상RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 완결애니CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방영애니BToolStripMenuItem;
    }
}

