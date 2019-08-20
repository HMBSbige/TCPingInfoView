﻿using System.Collections.Generic;
using TCPingInfoView.ViewModel;

namespace TCPingInfoView.Model
{
	public class Config
	{
		public double StartTop { get; set; }
		public double StartLeft { get; set; }
		public double StartWidth { get; set; }
		public double StartHeight { get; set; }
		public bool Topmost { get; set; }
		public int Interval { get; set; }
		public IEnumerable<EndPointInfo> EndPointInfo { get; set; }

		public Config()
		{
			StartTop = 0;
			StartLeft = 0;
			StartWidth = 1000;
			StartHeight = 618;
			Topmost = false;
			Interval = 60;
			EndPointInfo = new List<EndPointInfo>();
		}
	}
}
