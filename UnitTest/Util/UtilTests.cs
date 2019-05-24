﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace UnitTest.Util
{
	[TestClass]
	public class UtilTests
	{
		[TestMethod]
		public void StringLine2DataTest()
		{
			var s1 = @"[2607:f8b0:4007:801::2004]:4154";
			var s2 = @"172.217.14.68:1513";
			var s3 = @"www.google.com:12313";
			var s4 = @"[2607:f8b0:4007:80e::200e]";
			var s5 = @"172.217.14.78";
			var s6 = @"www.youtube.com";
			var s7 = @"2409:8a55:260:1a60:a183:ee9e:98c3:df85:2080";

			var r1 = TCPingInfoView.Utils.Util.StringLine2Data(s1);
			var r2 = TCPingInfoView.Utils.Util.StringLine2Data(s2);
			var r3 = TCPingInfoView.Utils.Util.StringLine2Data(s3);
			var r4 = TCPingInfoView.Utils.Util.StringLine2Data(s4);
			var r5 = TCPingInfoView.Utils.Util.StringLine2Data(s5);
			var r6 = TCPingInfoView.Utils.Util.StringLine2Data(s6);
			var r7 = TCPingInfoView.Utils.Util.StringLine2Data(s7);

			Assert.AreEqual(r1.Ip, IPAddress.Parse(@"2607:f8b0:4007:801::2004"));
			Assert.AreEqual(r1.HostsName, @"2607:f8b0:4007:801::2004");
			Assert.AreEqual(r1.Port, 4154);

			Assert.AreEqual(r2.Ip, IPAddress.Parse(@"172.217.14.68"));
			Assert.AreEqual(r2.HostsName, @"172.217.14.68");
			Assert.AreEqual(r2.Port, 1513);

			Assert.AreEqual(r3.Ip, null);
			Assert.AreEqual(r3.HostsName, @"www.google.com");
			Assert.AreEqual(r3.Port, 12313);

			Assert.AreEqual(r4.Ip, IPAddress.Parse(@"2607:f8b0:4007:80e::200e"));
			Assert.AreEqual(r4.HostsName, @"2607:f8b0:4007:80e::200e");
			Assert.AreEqual(r4.Port, 443);

			Assert.AreEqual(r5.Ip, IPAddress.Parse(@"172.217.14.78"));
			Assert.AreEqual(r5.HostsName, @"172.217.14.78");
			Assert.AreEqual(r5.Port, 443);

			Assert.AreEqual(r6.Ip, null);
			Assert.AreEqual(r6.HostsName, @"www.youtube.com");
			Assert.AreEqual(r6.Port, 443);

			Assert.AreEqual(r7.Ip, IPAddress.Parse(@"2409:8a55:260:1a60:a183:ee9e:98c3:df85"));
			Assert.AreEqual(r7.HostsName, @"2409:8a55:260:1a60:a183:ee9e:98c3:df85");
			Assert.AreEqual(r7.Port, 2080);
		}
	}
}