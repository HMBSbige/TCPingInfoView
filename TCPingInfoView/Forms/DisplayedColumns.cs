﻿using System;
using System.Windows.Forms;
using TCPingInfoView.I18n;

namespace TCPingInfoView.Forms
{
	public partial class DisplayedColumns : Form
	{
		public DisplayedColumns(DataGridViewColumnCollection columns)
		{
			InitializeComponent();
			Columns = columns;
		}

		private readonly DataGridViewColumnCollection Columns;

		private void LoadI18N()
		{
			Text = I18N.GetString(@"Column Settings");
			OK_button.Text = I18N.GetString(@"OK");
			Cancel_button.Text = I18N.GetString(@"Cancel");
		}

		private void DisplayedColumns_Load(object sender, EventArgs e)
		{
			LoadI18N();
			foreach (DataGridViewColumn column in Columns)
			{
				checkedListBox1.Items.Add(column.HeaderText);
			}

			Width = Math.Max(GetWidth(), Width);

			for (var i = 0; i < Columns.Count; ++i)
			{
				checkedListBox1.SetItemChecked(i, Columns[i].Visible);
			}
		}

		private int GetWidth()
		{
			var max = 0;
			foreach (string str in checkedListBox1.Items)
			{
				int width = TextRenderer.MeasureText(str, checkedListBox1.Font).Width;
				if (width > max)
				{
					max = width;
				}
			}
			return max + 100;
		}

		private void OK_button_Click(object sender, EventArgs e)
		{
			for (var i = 1; i < Columns.Count; ++i)
			{
				Columns[i].Visible = checkedListBox1.GetItemChecked(i);
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.Index == 0)
			{
				e.NewValue = CheckState.Checked;
			}
		}
	}
}
