using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;

namespace CascToolHost
{
	public static class BLTE
    {
        public static byte[] Parse(byte[] content)
        {
            using (var result = new MemoryStream())
            using (var bin = new BinaryReader(new MemoryStream(content)))
            {
                if (bin.ReadUInt32() != 0x45544c42) { throw new Exception("Not a BLTE file");  }

            }
        }
    }
}