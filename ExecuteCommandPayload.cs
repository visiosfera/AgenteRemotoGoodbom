namespace AgenteRemotoGoodbom
{
    public class ExecuteCommandPayload
    {
        public string Action { get; set; } = default!;
        public string? Arguments { get; set; }
        public int TimeoutSeconds { get; set; }
        public string Message { get; set; }
    }
}
