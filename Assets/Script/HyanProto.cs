using Google.Protobuf;
using System.IO;

namespace HyanProtobuf
{
    class HyanProto
    {
        /// <summary>
        /// Serialize
        /// </summary>
        public static byte[] Marshal<T>(T t) where T : IMessage
        {
            using (MemoryStream ms = new MemoryStream())
            {
                t.WriteTo(ms);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Deserialize
        /// </summary>
        public static T UnMarshal<T>(byte[] b) where T : class, IMessage, new()
        {
            return (T)new T().Descriptor.Parser.ParseFrom(b);
        }
    }
}
