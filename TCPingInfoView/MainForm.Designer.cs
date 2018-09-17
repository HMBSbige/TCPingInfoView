﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TCPingInfoView
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.从文件载入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Load_Button = new System.Windows.Forms.ToolStripButton();
			this.Test_Button = new System.Windows.Forms.ToolStripButton();
			this.Start_Button = new System.Windows.Forms.ToolStripButton();
			this.Exit_Button = new System.Windows.Forms.ToolStripButton();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.NotifyIcon_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowHide_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartStop_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.DatelistView = new TCPingInfoView.DoubleBufferListView();
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Latency2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MainlistView = new TCPingInfoView.DoubleBufferListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.NotifyIcon_MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(912, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// File_MenuItem
			// 
			this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从文件载入ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
			this.File_MenuItem.Name = "File_MenuItem";
			this.File_MenuItem.Size = new System.Drawing.Size(44, 21);
			this.File_MenuItem.Text = "文件";
			// 
			// 从文件载入ToolStripMenuItem
			// 
			this.从文件载入ToolStripMenuItem.Name = "从文件载入ToolStripMenuItem";
			this.从文件载入ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.从文件载入ToolStripMenuItem.Text = "从文件载入";
			this.从文件载入ToolStripMenuItem.Click += new System.EventHandler(this.从文件载入ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 656);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(912, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(277, 17);
			this.toolStripStatusLabel1.Text = "https://github.com/HMBSbige/TCPingInfoView";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load_Button,
            this.Test_Button,
            this.Start_Button,
            this.Exit_Button});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(912, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Load_Button
			// 
			this.Load_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Load_Button.Image = ((System.Drawing.Image)(resources.GetObject("Load_Button.Image")));
			this.Load_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Load_Button.Name = "Load_Button";
			this.Load_Button.Size = new System.Drawing.Size(36, 22);
			this.Load_Button.Text = "载入";
			this.Load_Button.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// Test_Button
			// 
			this.Test_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Test_Button.Image = global::TCPingInfoView.Properties.Resources.Test;
			this.Test_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Test_Button.Name = "Test_Button";
			this.Test_Button.Size = new System.Drawing.Size(23, 22);
			this.Test_Button.Text = "测试";
			this.Test_Button.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// Start_Button
			// 
			this.Start_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Start_Button.Image = global::TCPingInfoView.Properties.Resources.Start;
			this.Start_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Start_Button.Name = "Start_Button";
			this.Start_Button.Size = new System.Drawing.Size(23, 22);
			this.Start_Button.Text = "开始";
			this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
			// 
			// Exit_Button
			// 
			this.Exit_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
			this.Exit_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Exit_Button.Name = "Exit_Button";
			this.Exit_Button.Size = new System.Drawing.Size(36, 22);
			this.Exit_Button.Text = "退出";
			this.Exit_Button.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.NotifyIcon_MenuStrip;
			this.notifyIcon1.Text = "TCPingInfoView";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// NotifyIcon_MenuStrip
			// 
			this.NotifyIcon_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHide_MenuItem,
            this.StartStop_MenuItem,
            this.toolStripSeparator2,
            this.Exit_MenuItem});
			this.NotifyIcon_MenuStrip.Name = "NotifyIcon_MenuStrip";
			this.NotifyIcon_MenuStrip.Size = new System.Drawing.Size(130, 76);
			// 
			// ShowHide_MenuItem
			// 
			this.ShowHide_MenuItem.Name = "ShowHide_MenuItem";
			this.ShowHide_MenuItem.Size = new System.Drawing.Size(129, 22);
			this.ShowHide_MenuItem.Text = "显示/隐藏";
			this.ShowHide_MenuItem.Click += new System.EventHandler(this.ShowHide_MenuItem_Click);
			// 
			// StartStop_MenuItem
			// 
			this.StartStop_MenuItem.Name = "StartStop_MenuItem";
			this.StartStop_MenuItem.Size = new System.Drawing.Size(129, 22);
			this.StartStop_MenuItem.Text = "开始";
			this.StartStop_MenuItem.Click += new System.EventHandler(this.StartStop_MenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
			// 
			// Exit_MenuItem
			// 
			this.Exit_MenuItem.Name = "Exit_MenuItem";
			this.Exit_MenuItem.Size = new System.Drawing.Size(129, 22);
			this.Exit_MenuItem.Text = "退出";
			this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Succeed.png");
			this.imageList1.Images.SetKeyName(1, "Failed.png");
			// 
			// DatelistView
			// 
			this.DatelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Latency2});
			this.DatelistView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DatelistView.FullRowSelect = true;
			this.DatelistView.GridLines = true;
			this.DatelistView.Location = new System.Drawing.Point(0, 527);
			this.DatelistView.MultiSelect = false;
			this.DatelistView.Name = "DatelistView";
			this.DatelistView.OwnerDraw = true;
			this.DatelistView.ShowItemToolTips = true;
			this.DatelistView.Size = new System.Drawing.Size(912, 129);
			this.DatelistView.SmallImageList = this.imageList1;
			this.DatelistView.TabIndex = 5;
			this.DatelistView.UseCompatibleStateImageBehavior = false;
			this.DatelistView.View = System.Windows.Forms.View.Details;
			// 
			// Date
			// 
			this.Date.Text = "TCPing 通信时间";
			this.Date.Width = 170;
			// 
			// Latency2
			// 
			this.Latency2.Text = "延迟(ms)";
			// 
			// MainlistView
			// 
			this.MainlistView.AllowDrop = true;
			this.MainlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.MainlistView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainlistView.FullRowSelect = true;
			this.MainlistView.GridLines = true;
			this.MainlistView.Location = new System.Drawing.Point(0, 50);
			this.MainlistView.MultiSelect = false;
			this.MainlistView.Name = "MainlistView";
			this.MainlistView.OwnerDraw = true;
			this.MainlistView.ShowItemToolTips = true;
			this.MainlistView.Size = new System.Drawing.Size(912, 474);
			this.MainlistView.SmallImageList = this.imageList1;
			this.MainlistView.TabIndex = 6;
			this.MainlistView.UseCompatibleStateImageBehavior = false;
			this.MainlistView.View = System.Windows.Forms.View.Details;
			this.MainlistView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MainlistView_ColumnClick);
			this.MainlistView.SelectedIndexChanged += new System.EventHandler(this.MainlistView_SelectedIndexChanged);
			this.MainlistView.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainlistView_DragDrop);
			this.MainlistView.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainlistView_DragEnter);
			this.MainlistView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainlistView_MouseDown);
			this.MainlistView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainlistView_MouseMove);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "列表顺序";
			this.columnHeader1.Width = 68;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "主机名";
			this.columnHeader2.Width = 129;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "IP:端口";
			this.columnHeader3.Width = 95;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "失败率";
			this.columnHeader4.Width = 54;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "延迟(ms)";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "说明";
			this.columnHeader6.Width = 141;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 524);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(912, 3);
			this.splitter1.TabIndex = 7;
			this.splitter1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 678);
			this.Controls.Add(this.MainlistView);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.DatelistView);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "TCPingInfoView";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.NotifyIcon_MenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem File_MenuItem;
		private ToolStripMenuItem 从文件载入ToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem 退出ToolStripMenuItem;
		private StatusStrip statusStrip1;
		private ToolStrip toolStrip1;
		private ToolStripButton Test_Button;
		private ToolStripButton Exit_Button;
		private ToolStripButton Load_Button;
		private ToolStripButton Start_Button;
		private NotifyIcon notifyIcon1;
		private ContextMenuStrip NotifyIcon_MenuStrip;
		private ToolStripMenuItem ShowHide_MenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem StartStop_MenuItem;
		private ToolStripMenuItem Exit_MenuItem;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private DoubleBufferListView DatelistView;
		private ColumnHeader Date;
		private ColumnHeader Latency2;
		private DoubleBufferListView MainlistView;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ImageList imageList1;
		private Splitter splitter1;
	}
}

