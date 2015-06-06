using System;

namespace SnapMD.Sdk
{
    public class SnapSdkException : Exception
    {
        public SnapSdkException(string message) : base(message)
        {
        }

        public SnapSdkException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}