namespace Meeting_Notes
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
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Menu_Configuration_BT = new System.Windows.Forms.Button();
            this.Menu_Search_BT = new System.Windows.Forms.Button();
            this.Left_Top_Panel = new System.Windows.Forms.Panel();
            this.Main_Label = new System.Windows.Forms.Label();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Close_BT = new System.Windows.Forms.Button();
            this.Menu_Tab_Control = new System.Windows.Forms.TabControl();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.Action_Item = new System.Windows.Forms.TabPage();
            this.Action_Item_List_Box = new System.Windows.Forms.ListBox();
            this.Issue = new System.Windows.Forms.TabPage();
            this.Issu_List_Box = new System.Windows.Forms.ListBox();
            this.Date = new System.Windows.Forms.TabPage();
            this.Date_List_Box = new System.Windows.Forms.ListBox();
            this.List_Search_Tab = new System.Windows.Forms.TabControl();
            this.Action_Item_List_View = new System.Windows.Forms.ListView();
            this.Issue_List_View = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.Left_Panel.SuspendLayout();
            this.Left_Top_Panel.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            this.Menu_Tab_Control.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.Search.SuspendLayout();
            this.Action_Item.SuspendLayout();
            this.Issue.SuspendLayout();
            this.Date.SuspendLayout();
            this.List_Search_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.DimGray;
            this.Left_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Left_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Left_Panel.Controls.Add(this.Menu_Configuration_BT);
            this.Left_Panel.Controls.Add(this.Menu_Search_BT);
            this.Left_Panel.Controls.Add(this.Left_Top_Panel);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(146, 947);
            this.Left_Panel.TabIndex = 2;
            // 
            // Menu_Configuration_BT
            // 
            this.Menu_Configuration_BT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Configuration_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Menu_Configuration_BT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Configuration_BT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_Configuration_BT.Location = new System.Drawing.Point(-1, 104);
            this.Menu_Configuration_BT.Name = "Menu_Configuration_BT";
            this.Menu_Configuration_BT.Size = new System.Drawing.Size(146, 55);
            this.Menu_Configuration_BT.TabIndex = 1;
            this.Menu_Configuration_BT.Text = "Configuration";
            this.Menu_Configuration_BT.UseMnemonic = false;
            this.Menu_Configuration_BT.UseVisualStyleBackColor = false;
            this.Menu_Configuration_BT.Click += new System.EventHandler(this.Menu_Configuration_BT_Click);
            // 
            // Menu_Search_BT
            // 
            this.Menu_Search_BT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Search_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Menu_Search_BT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Search_BT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_Search_BT.Location = new System.Drawing.Point(-1, 56);
            this.Menu_Search_BT.Name = "Menu_Search_BT";
            this.Menu_Search_BT.Size = new System.Drawing.Size(146, 55);
            this.Menu_Search_BT.TabIndex = 1;
            this.Menu_Search_BT.Text = "Search";
            this.Menu_Search_BT.UseMnemonic = false;
            this.Menu_Search_BT.UseVisualStyleBackColor = false;
            this.Menu_Search_BT.Click += new System.EventHandler(this.Menu_Search_BT_Click);
            // 
            // Left_Top_Panel
            // 
            this.Left_Top_Panel.BackColor = System.Drawing.Color.DarkOrange;
            this.Left_Top_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Left_Top_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Left_Top_Panel.Controls.Add(this.Main_Label);
            this.Left_Top_Panel.Location = new System.Drawing.Point(-1, -1);
            this.Left_Top_Panel.Name = "Left_Top_Panel";
            this.Left_Top_Panel.Size = new System.Drawing.Size(146, 59);
            this.Left_Top_Panel.TabIndex = 0;
            // 
            // Main_Label
            // 
            this.Main_Label.AutoSize = true;
            this.Main_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.Location = new System.Drawing.Point(56, 9);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(86, 44);
            this.Main_Label.TabIndex = 4;
            this.Main_Label.Text = "Meeting\r\nNotes";
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Top_Panel.Controls.Add(this.Close_BT);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(146, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(779, 59);
            this.Top_Panel.TabIndex = 3;
            this.Top_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseDown);
            this.Top_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_Panel_MouseMove);
            // 
            // Close_BT
            // 
            this.Close_BT.BackColor = System.Drawing.Color.White;
            this.Close_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_BT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_BT.ForeColor = System.Drawing.Color.Black;
            this.Close_BT.Location = new System.Drawing.Point(729, 11);
            this.Close_BT.Name = "Close_BT";
            this.Close_BT.Size = new System.Drawing.Size(28, 29);
            this.Close_BT.TabIndex = 0;
            this.Close_BT.Text = "X";
            this.Close_BT.UseVisualStyleBackColor = false;
            this.Close_BT.Click += new System.EventHandler(this.Close_BT_Click);
            // 
            // Menu_Tab_Control
            // 
            this.Menu_Tab_Control.Controls.Add(this.Configuration);
            this.Menu_Tab_Control.Controls.Add(this.Search);
            this.Menu_Tab_Control.Location = new System.Drawing.Point(146, 34);
            this.Menu_Tab_Control.Name = "Menu_Tab_Control";
            this.Menu_Tab_Control.SelectedIndex = 0;
            this.Menu_Tab_Control.Size = new System.Drawing.Size(777, 913);
            this.Menu_Tab_Control.TabIndex = 0;
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.Color.LightGray;
            this.Configuration.Controls.Add(this.button1);
            this.Configuration.Location = new System.Drawing.Point(4, 26);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(769, 861);
            this.Configuration.TabIndex = 1;
            this.Configuration.Text = "Configuration";
            // 
            // Search
            // 
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search.Controls.Add(this.Action_Item_List_View);
            this.Search.Controls.Add(this.List_Search_Tab);
            this.Search.Controls.Add(this.Issue_List_View);
            this.Search.Location = new System.Drawing.Point(4, 26);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(769, 883);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Action_Item
            // 
            this.Action_Item.Controls.Add(this.Action_Item_List_Box);
            this.Action_Item.Location = new System.Drawing.Point(4, 26);
            this.Action_Item.Name = "Action_Item";
            this.Action_Item.Padding = new System.Windows.Forms.Padding(3);
            this.Action_Item.Size = new System.Drawing.Size(253, 554);
            this.Action_Item.TabIndex = 2;
            this.Action_Item.Text = "Action Item";
            this.Action_Item.UseVisualStyleBackColor = true;
            // 
            // Action_Item_List_Box
            // 
            this.Action_Item_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Action_Item_List_Box.FormattingEnabled = true;
            this.Action_Item_List_Box.ItemHeight = 17;
            this.Action_Item_List_Box.Location = new System.Drawing.Point(3, 3);
            this.Action_Item_List_Box.Name = "Action_Item_List_Box";
            this.Action_Item_List_Box.Size = new System.Drawing.Size(247, 548);
            this.Action_Item_List_Box.TabIndex = 4;
            // 
            // Issue
            // 
            this.Issue.Controls.Add(this.Issu_List_Box);
            this.Issue.Location = new System.Drawing.Point(4, 26);
            this.Issue.Name = "Issue";
            this.Issue.Padding = new System.Windows.Forms.Padding(3);
            this.Issue.Size = new System.Drawing.Size(253, 554);
            this.Issue.TabIndex = 1;
            this.Issue.Text = "Issue";
            this.Issue.UseVisualStyleBackColor = true;
            // 
            // Issu_List_Box
            // 
            this.Issu_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Issu_List_Box.FormattingEnabled = true;
            this.Issu_List_Box.ItemHeight = 17;
            this.Issu_List_Box.Location = new System.Drawing.Point(3, 3);
            this.Issu_List_Box.Name = "Issu_List_Box";
            this.Issu_List_Box.Size = new System.Drawing.Size(247, 548);
            this.Issu_List_Box.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.Controls.Add(this.Date_List_Box);
            this.Date.Location = new System.Drawing.Point(4, 26);
            this.Date.Name = "Date";
            this.Date.Padding = new System.Windows.Forms.Padding(3);
            this.Date.Size = new System.Drawing.Size(253, 554);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            this.Date.UseVisualStyleBackColor = true;
            // 
            // Date_List_Box
            // 
            this.Date_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_List_Box.FormattingEnabled = true;
            this.Date_List_Box.ItemHeight = 17;
            this.Date_List_Box.Location = new System.Drawing.Point(3, 3);
            this.Date_List_Box.Name = "Date_List_Box";
            this.Date_List_Box.Size = new System.Drawing.Size(247, 548);
            this.Date_List_Box.TabIndex = 4;
            // 
            // List_Search_Tab
            // 
            this.List_Search_Tab.Controls.Add(this.Date);
            this.List_Search_Tab.Controls.Add(this.Issue);
            this.List_Search_Tab.Controls.Add(this.Action_Item);
            this.List_Search_Tab.Location = new System.Drawing.Point(23, 61);
            this.List_Search_Tab.Name = "List_Search_Tab";
            this.List_Search_Tab.SelectedIndex = 0;
            this.List_Search_Tab.Size = new System.Drawing.Size(261, 584);
            this.List_Search_Tab.TabIndex = 1;
            // 
            // Action_Item_List_View
            // 
            this.Action_Item_List_View.Location = new System.Drawing.Point(305, 237);
            this.Action_Item_List_View.Name = "Action_Item_List_View";
            this.Action_Item_List_View.Size = new System.Drawing.Size(296, 375);
            this.Action_Item_List_View.TabIndex = 4;
            this.Action_Item_List_View.UseCompatibleStateImageBehavior = false;
            // 
            // Issue_List_View
            // 
            this.Issue_List_View.Location = new System.Drawing.Point(305, 61);
            this.Issue_List_View.Name = "Issue_List_View";
            this.Issue_List_View.Size = new System.Drawing.Size(296, 141);
            this.Issue_List_View.TabIndex = 4;
            this.Issue_List_View.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 194);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(925, 947);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Menu_Tab_Control);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Left_Panel.ResumeLayout(false);
            this.Left_Top_Panel.ResumeLayout(false);
            this.Left_Top_Panel.PerformLayout();
            this.Top_Panel.ResumeLayout(false);
            this.Menu_Tab_Control.ResumeLayout(false);
            this.Configuration.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Action_Item.ResumeLayout(false);
            this.Issue.ResumeLayout(false);
            this.Date.ResumeLayout(false);
            this.List_Search_Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel Left_Top_Panel;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Close_BT;
        private System.Windows.Forms.TabControl Menu_Tab_Control;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.Button Menu_Search_BT;
        private System.Windows.Forms.Button Menu_Configuration_BT;
        private System.Windows.Forms.ListView Action_Item_List_View;
        private System.Windows.Forms.TabControl List_Search_Tab;
        private System.Windows.Forms.TabPage Date;
        private System.Windows.Forms.ListBox Date_List_Box;
        private System.Windows.Forms.TabPage Issue;
        private System.Windows.Forms.ListBox Issu_List_Box;
        private System.Windows.Forms.TabPage Action_Item;
        private System.Windows.Forms.ListBox Action_Item_List_Box;
        private System.Windows.Forms.ListView Issue_List_View;
        private System.Windows.Forms.Button button1;
    }
}

