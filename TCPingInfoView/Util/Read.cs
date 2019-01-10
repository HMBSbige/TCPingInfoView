﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TCPingInfoView.Collection;
using TCPingInfoView.Model;

namespace TCPingInfoView.Util
{
	public static class Read
	{
		private static readonly UTF8Encoding Utf8WithoutBom = new UTF8Encoding(false);

		public static ConcurrentList<Data> ReadAddressFromString(string s)
		{
			var sl = new List<string>();

			var lines = s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var line in lines)
			{
				if (!string.IsNullOrWhiteSpace(line))
				{
					sl.Add(line);
				}
			}

			return Util.ToData(sl);
		}

		public static string ReadTextFromFile(string path)
		{
			using (var sr = new StreamReader(path, Utf8WithoutBom))
			{
				return sr.ReadToEnd();
			}
		}

		public static string GetFilePath()
		{
			var path = string.Empty;
			var openFileDialog = new OpenFileDialog
			{
				Multiselect = false,
				Title = @"请选择包含地址的文件",
				Filter = @"文本文件 (*.txt)|*.txt",
				InitialDirectory = Application.ExecutablePath
			};
			var result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				path = openFileDialog.FileName;
			}
			return path;
		}
	}
}
