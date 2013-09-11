using System;
using Eliza;
using System.IO;
using System.Linq;

namespace Eliza
{
	public class LineSourceFromAssembly :ILineSource
	{
		private readonly StreamReader reader;

		public LineSourceFromAssembly(string script){

			var names = this.GetType ().Assembly.GetManifestResourceNames ();
			var stream = this.GetType ().Assembly.GetManifestResourceStream (script);
			if (stream == null) {
				throw new ArgumentException(script + " is not an embedded resource : " + string.Join(" ", names));
			}
			reader = new StreamReader(stream);
		}

		#region ILineSource implementation
		public string ReadLine ()
		{
			return reader.ReadLine ();

		}
		public void Close ()
		{
			reader.Dispose ();
		}
		#endregion
	}
}
