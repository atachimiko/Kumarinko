﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mogami.Service.Request
{
	[DataContract]
	public class REQUEST_SAVEDEVICRSETTING
	{

		#region プロパティ

		[DataMember]
		public string Data { get; set; }

		#endregion プロパティ
	}
}
