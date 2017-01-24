namespace MVParammer.Logic.Args
{
    public class EditEventCommandsArgs
    {
        public Data.Enums.EventCommandCode code { get; set; }

        public KeyValueList<int, object> WhereParameters { get; set; }

        public KeyValueList<int, object> SetParameters { get; set; }
    }
}
