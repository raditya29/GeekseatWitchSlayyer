using System;

namespace GeekseatWitch
{
    public class InvalidDeceasedDataException : Exception
    {
        public InvalidDeceasedDataException() { }

        public InvalidDeceasedDataException(string message) : base(message) { }
    }
}
