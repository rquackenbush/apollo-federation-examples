namespace WidgetSubgraph.Types
{
    public class Payload
    {
        public Payload(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
