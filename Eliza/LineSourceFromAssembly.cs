using System;
using System.IO;

namespace Eliza
{
    public class LineSourceFromAssembly : ILineSource
    {
        private readonly StreamReader reader;

        public LineSourceFromAssembly(string script)
        {
            var names = this.GetType().Assembly.GetManifestResourceNames();
            var stream = this.GetType().Assembly.GetManifestResourceStream(script);
            if (stream == null)
            {
                throw new ArgumentException(script + " is not an embedded resource : " + string.Join(" ", names));
            }
            reader = new StreamReader(stream);
        }

        #region ILineSource implementation

        public string ReadLine() => reader.ReadLine();

        public void Close() => reader.Dispose();

        #endregion ILineSource implementation
    }
}