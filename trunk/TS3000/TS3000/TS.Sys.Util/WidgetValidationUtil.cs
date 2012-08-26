using System;
using System.Text.RegularExpressions;

namespace TS.Business.Util
{
	/// <summary>
	/// Description of Validator.
	/// </summary>
	public class WidgetValidationUtil
	{
        private WidgetValidationUtil()
		{
		}
		public static bool checkRequired(string str)
		{
			if(str==null||str.Trim().Length==0)return false;
			return true;
		}
		public static bool checkPositiveInteger(string str)
		{
			string pattern = @"^([1-9]\d*|0)$";
			return Regex.IsMatch(str,pattern);
		}
		public static bool checkInteger(string str)
		{
			string pattern = @"^-?[1-9]\d*$";
			return Regex.IsMatch(str,pattern);
		}
		public static bool checkDouble(string str)
		{
			string pattern = @"^(-?([1-9]\d*|0?)\.\d*|0)$";
			return Regex.IsMatch(str,pattern);
		}
	}
}
