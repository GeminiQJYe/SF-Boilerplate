﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Core.Settings
{
	public interface IHaveSettings
	{
		ICollection<SettingEntry> Settings { get; set; }
	}
}
