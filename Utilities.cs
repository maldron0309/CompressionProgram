using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;

namespace Utilities
{
    public class Compressor
    {
        /// <summary>
        /// 바이트 배열 압축
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] CompressBytes(byte[] bytes)
        {
            using (var outputStream = new MemoryStream())
            {
                // GZipStream으로 사용해 스트림으로 압축
                using (var compressionStream = new GZipStream(outputStream, CompressionLevel.Optimal))
                {
                    compressionStream.Write(bytes, 0, bytes.Length);
                }
                return outputStream.ToArray(); // 압축된 바이트 배열 반환
            }
        }

        /// <summary>
        /// 압축된 바이트 배열 해제
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] DecompressBytes(byte[] bytes)
        {
            using (var inputStream = new MemoryStream(bytes))
            {
                using (var outputStream = new MemoryStream())
                {
                    // GZipStream으로 압축된 스트림 압축 해제
                    using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        compressionStream.CopyTo(outputStream);
                    }
                    return outputStream.ToArray(); // 압축 해제된 바이트 배열 반환
                }
            }
        }
    }
}
