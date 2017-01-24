using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVParammer.GUI.Editors
{
    public class EventCommand : Panel
    {
        #region Public (constructor and interface)

        public EventCommand(Data.Enums.EventCommandCode code)
        {
            switch (code)
            {
                case Data.Enums.EventCommandCode.ShowText:
                    InitializeFor_MessageWindowOptions(); break;
                default:
                    throw new NotImplementedException("Event command code not supported");
            }
        }

        public Func<Logic.Args.EditEventCommandsArgs> GetLogicArgs { get; set; }

        #endregion

        #region Common

        private Panel CreateStringField(string name, string description, string defaultValue)
        {
            var field = new Panel();
            return field;
        }

        private Panel CreateNumberField(string name, string description, int defaultValue)
        {
            var field = new Panel();
            return field;
        }

        private Panel CreateBooleanField(string name, string description, bool defaultValue)
        {
            var field = new Panel();
            return field;
        }

        private void AddWhereParamField()
        {

        }

        private void AddSetParamField()
        {

        }

        #endregion

        #region Specific Initializers

        private void InitializeFor_MessageWindowOptions()
        {


            GetLogicArgs = () =>
            {
                return new Logic.Args.EditEventCommandsArgs { };
            };
        }

        #endregion
    }
}
