﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TCPingInfoViewLib.Model;

namespace TCPingInfoViewLib.NetUtils
{
	public static class NetTest
	{
		public static async Task<TCPingStatus> TCPingAsync(IPAddress ip, int port = 80, int timeout = 1000, CancellationToken ct = default)
		{
			if (ip == null)
			{
				return new TCPingStatus { Status = IPStatus.BadDestination };
			}

			using (var client = new TcpClient(ip.AddressFamily))
			{
				var task = client.ConnectAsync(ip, port);

				var stopwatch = new Stopwatch();
				stopwatch.Start();

				var resTask = await Task.WhenAny(Task.Delay(timeout, ct), task);

				stopwatch.Stop();
				if (resTask == task)
				{
					if (client.Connected)
					{
						var t = Convert.ToInt64(stopwatch.Elapsed.TotalMilliseconds);
						Debug.WriteLine($@"TCPing [{ip}]:{port}:{t}ms");
						return new TCPingStatus { Status = IPStatus.Success, RTT = t };
					}
					return new TCPingStatus { Status = IPStatus.BadDestination };
				}
				else
				{
					if (ct.IsCancellationRequested)
					{
						Debug.WriteLine($@"TCPing [{ip}]:{port} Task was cancelled");
						return null;
					}
					else
					{
						Debug.WriteLine($@"TCPing [{ip}]:{port}:超时 > {timeout}ms");
						return new TCPingStatus { Status = IPStatus.TimedOut };
					}
				}
			}
		}

		public static async Task<ICMPingStatus> ICMPingAsync(IPAddress ip, int timeout = 1000, CancellationToken ct = default)
		{
			var res = new ICMPingStatus();
			if (ip == null)
			{
				return new ICMPingStatus { Status = IPStatus.BadDestination };
			}

			var p1 = new Ping();

			var task = p1.SendPingAsync(ip, timeout);

			if (await Task.WhenAny(Task.Delay(int.MaxValue, ct), task) == task)
			{
				var reply = await task;
				if (reply != null && reply.Status == IPStatus.Success)
				{
					res.Status = reply.Status;
					res.Address = reply.Address;
					res.RTT = reply.RoundtripTime;
					res.TTL = reply.Options?.Ttl;
					res.bytes = reply.Buffer.Length;
#if DEBUG
					//Debug info
					var sb = new StringBuilder();
					sb.AppendLine($@"Status: {res.Status}");
					sb.AppendLine($@"Address: {res.Address}");
					sb.AppendLine($@"RTT: {res.RTT}");
					sb.AppendLine($@"TTL: {res.TTL}");
					sb.AppendLine($@"Buffer size: {res.bytes}");
					Debug.WriteLine(sb.ToString());
#endif
				}
				else if (reply != null && reply.Status == IPStatus.TimedOut)
				{
					Debug.WriteLine($@"ICMPing {ip} Timeout");
					res.Status = reply.Status;
				}
				else
				{
					Debug.WriteLine($@"ICMPing {ip} failed");
					res.Status = IPStatus.Unknown;
				}
				return res;
			}
			else
			{
				Debug.WriteLine($@"ICMPing {ip} Task was cancelled");

				return null;
			}
		}
	}
}