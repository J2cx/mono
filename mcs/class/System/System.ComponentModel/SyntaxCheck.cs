//
// System.ComponentModel.SyntaxCheck.cs
//
// Author:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2003 Andreas Nahr
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.IO;

namespace System.ComponentModel
{
#if NET_2_0
	static
#endif
	public class SyntaxCheck
	{
#if !NET_2_0
		private SyntaxCheck ()
		{
		}
#endif

		public static bool CheckMachineName (string value)
		{
			if (value == null || value.Trim ().Length == 0)
				return false;

			return value.IndexOf ('\\') == -1;
		}

		public static bool CheckPath (string value)
		{
			if (value == null || value.Trim ().Length == 0)
				return false;

			return value.StartsWith (@"\\");
		}

		public static bool CheckRootedPath (string value)
		{
			if (value == null || value.Trim ().Length == 0)
				return false;

			return Path.IsPathRooted (value);
		}
	}
}

