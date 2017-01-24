namespace MVParammer.Data
{
    public class EventCommand
    {
        public int code { get; set; }
        public int? indent { get; set; }
        public object[] parameters { get; set; }
    }
}
