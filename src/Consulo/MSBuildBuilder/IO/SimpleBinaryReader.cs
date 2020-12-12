using System.IO;
using System.Text;
using System;

namespace Consulo.MSBuildBuilder.IO
{
	/// <summary>
	/// Binary reader with simple string reader. See SimpleBinaryWriter
	/// </summary>
	public class SimpleBinaryReader : BinaryReader
	{
		public SimpleBinaryReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
		{
		}

		public SimpleBinaryReader(Stream input, Encoding encoding) : base(input, encoding)
		{
		}

		public SimpleBinaryReader(Stream input) : base(input)
		{
		}

		public override string ReadString()
		{
			int size = ReadInt32();

			var bytes = ReadBytes(size);

			return Encoding.UTF8.GetString(bytes);
		}
	}
}