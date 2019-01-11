﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TCPingInfoView.Properties;
using TCPingInfoView.Steamworks;

namespace TCPingInfoView.I18n
{
	public static class I18N
	{
		private static readonly Dictionary<string, string> Strings;

		private static void Init(string res)
		{
			var lines = Regex.Split(res, "\r\n|\r|\n");
			foreach (var line in lines)
			{
				if (line.StartsWith("#"))
				{
					continue;
				}

				var kv = Regex.Split(line, @"=");
				if (kv.Length == 2)
				{
					var val = Regex.Replace(kv[1], "\\\\n", "\r\n");
#if DEBUG
					if (Strings.ContainsKey(kv[0]))
					{
						throw new Exception(@"翻译文本出错");
					}
#endif
					Strings[kv[0]] = val;
				}
			}
		}

		static I18N()
		{
			Strings = new Dictionary<string, string>();

			var name = SteamManager.GetCurrentGameLanguage();
			if (name == @"schinese")
			{
				Init(Resources.zh_CN);
			}
		}

		public static string GetString(string key)
		{
			return Strings.TryGetValue(key, out var value) ? value : key;
		}
	}
}
