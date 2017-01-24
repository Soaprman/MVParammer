using System.Collections.Generic;
using System.Linq;

namespace MVParammer.Logic
{
    public class MapEditor
    {
        private Data.Map _map;

        public MapEditor(Data.Map map)
        {
            Load(map);
        }

        public void Load(Data.Map map)
        {
            _map = map;
        }

        public void EditEventCommands(Args.EditEventCommandsArgs args)
        {
            var allCommands = from e in _map.events
                              where e != null
                              from p in e.pages
                              where p != null
                              from cmd in p.list
                              where cmd != null
                              where (Data.Enums.EventCommandCode)cmd.code == args.code
                              select cmd;

            IEnumerable<Data.EventCommand> applicableCommands = allCommands;
            foreach (var param in args.WhereParameters)
            {
                applicableCommands = from cmd in applicableCommands
                                     where Utils.Comparison.AreEqual(cmd.parameters[param.Key], param.Value)
                                     select cmd;
            }

            foreach (var cmd in applicableCommands)
            foreach (var param in args.SetParameters)
            {
                cmd.parameters[param.Key] = param.Value;
            }
        }

        public void EditEventPageImages(Args.EditEventPageImagesArgs args)
        {
            var applicableImages = from e in _map.events
                                   where e != null
                                   from p in e.pages
                                   where p != null && p.image != null && p.image.characterName == args.WhereCharacterName && p.image.characterIndex == args.WhereCharacterIndex
                                   select p.image;

            foreach (var img in applicableImages)
            {
                img.characterName = args.SetCharacterName;
                img.characterIndex = args.SetCharacterIndex;
            }
        }
    }
}
