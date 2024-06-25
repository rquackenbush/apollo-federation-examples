﻿namespace Common
{
    public class Payload
    {
        public Payload(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
