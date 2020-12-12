using System.IO;
using System.Text;

namespace Consulo.MSBuildBuilder.IO
{
	/// <summary>
	/// Binary Writer with more simple string writer
	/// </summary>
	public class SimpleBinaryWriter : BinaryWriter
	{
		public SimpleBinaryWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
		{
		}

		public SimpleBinaryWriter(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public SimpleBinaryWriter(Stream output) : base(output)
		{
		}

		private SimpleBinaryWriter()
		{
		}

		public override void Write(string value)
		{
			var bytes = Encoding.UTF8.GetBytes(value);

			Write(bytes.Length);

			Write(bytes);
		}
	}
}