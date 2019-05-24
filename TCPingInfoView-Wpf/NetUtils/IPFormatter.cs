﻿using System.Net;
using System.Text.RegularExpressions;

namespace TCPingInfoView.NetUtils
{
	public static class IPFormatter
	{
		public static readonly Regex EndPointRegexStr = new Regex(@"^\[(.*)\]:(\d{1,5})|(.*):(\d{1,5})$");

		public static bool IsIPAddress(string input)
		{
			return IPAddress.TryParse(input, out _);
		}

		public static bool IsPort(int port)
		{
			if (port >= IPEndPoint.MinPort && port <= IPEndPoint.MaxPort)
			{
				return true;
			}

			return false;
		}

		public static IPEndPoint ToIPEndPoint(string str, int defaultPort = 443)
		{
			if (string.IsNullOrWhiteSpace(str) || !IsPort(defaultPort))
			{
				return null;
			}

			var sp = EndPointRegexStr.Match(str).Groups;
			if (sp.Count == 5)
			{
				var hostname = string.IsNullOrWhiteSpace(sp[1].Value) ? sp[3].Value : sp[1].Value;
				if (IPAddress.TryParse(hostname, out var ip))
				{
					if (int.TryParse(string.IsNullOrWhiteSpace(sp[2].Value) ? sp[4].Value : sp[2].Value, out var port))
					{
						if (IsPort(port))
						{
							return new IPEndPoint(ip, port);
						}
					}
				}
			}
			else if (sp.Count == 1)
			{
				var groups = Regex.Match(str, @"^\[(.*)\]$").Groups;
				if (groups.Count == 2)
				{
					if (IPAddress.TryParse(groups[1].Value, out var ip))
					{
						return new IPEndPoint(ip, defaultPort);
					}
				}
				else
				{
					if (IPAddress.TryParse(str, out var ip))
					{
						return new IPEndPoint(ip, defaultPort);
					}
				}
			}

			return null;
		}
	}
}