using System;
using System.Collections.Generic;
using System.Text;

namespace RarsCore
{
    public struct Variant
    {
		public int Value;
		public string Description;

		public Variant(string desc, int value)
		{
			Description = desc;
			Value = value;
		}
    }
}
