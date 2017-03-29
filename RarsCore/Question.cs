using System;
using System.Collections.Generic;
using System.Text;

namespace RarsCore
{
    public struct Question
    {
		public string Text;
		public List<Variant> Variants;

		public Question(string text, List<Variant> vars)
		{
			Text = text;
			Variants = vars;
		}
    }
}
