using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVParammer
{
    public partial class MainForm : Form
    {
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        private FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();
        private SaveFileDialog _saveFileDialog = new SaveFileDialog();

        /// <summary>
        /// Key is the file's absolute path, Value is the data object created from the file's contents when opened
        /// </summary>
        private Dictionary<string, Data.Map> _openMaps;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        private void btnOpenMap_Click(object sender, EventArgs e)
        {
            OpenMap();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            OpenMaps();
        }

        private void btnMakeHardcodedEdits_Click(object sender, EventArgs e)
        {
            if (_openMaps == null || _openMaps.Count() == 0)
            {
                MessageBox.Show("Open map(s) before saving changes!");
                return;
            }

            MakeHardcodedEdits();
        }

        #endregion

        #region Methods that do things

        public void OpenMap()
        {
            _openFileDialog.DefaultExt = ".json";
            _openFileDialog.Filter = "RPG Maker MV map files (*.json)|*.json";

            var result = _openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string json = File.ReadAllText(_openFileDialog.FileName);
                var map = Transformers.MapTransformer.JsonToMap(json);

                _openMaps = new Dictionary<string, Data.Map>{
                    { _openFileDialog.FileName, map }
                };

                lblCurrentlyOpen.Text = _openFileDialog.FileName;
            }
        }

        public void SaveMap()
        {
            if (_openMaps == null || _openMaps.Count() != 1)
            {
                throw new Exception("SaveMap can only be called if exactly one map is open");
            }

            var mapKvp = _openMaps.First();

            string newJson = Transformers.MapTransformer.MapToJson(mapKvp.Value);
            _saveFileDialog.DefaultExt = ".json";
            _saveFileDialog.Filter = "RPG Maker MV map files (*.json)|*.json";
            var saveRes = _saveFileDialog.ShowDialog();
            if (saveRes == DialogResult.OK)
            {
                File.WriteAllText(_saveFileDialog.FileName, newJson);
            }
        }

        public void OpenMaps()
        {
            var result = _folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _openMaps = new Dictionary<string, Data.Map>();

                foreach (var path in Directory.GetFiles(_folderBrowserDialog.SelectedPath))
                {
                    var fileNameWithoutPath = Path.GetFileName(path);
                    if (Regex.IsMatch(fileNameWithoutPath, @"^Map\d+.json$"))
                    {
                        string json = File.ReadAllText(path);
                        var map = Transformers.MapTransformer.JsonToMap(json);

                        _openMaps.Add(path, map);
                    }
                }

                lblCurrentlyOpen.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void MakeHardcodedEdits()
        {
            foreach (var mapKvp in _openMaps)
            {
                MakeHardcodedEditsToMap(mapKvp.Value);

                string newJson = Transformers.MapTransformer.MapToJson(mapKvp.Value);
                File.WriteAllText(mapKvp.Key, newJson);
            }
            MessageBox.Show("Finished! Any open maps have been resaved.");
        }

        private void MakeHardcodedEditsToMap(Data.Map map)
        {
            var mapEditor = new Logic.MapEditor(map);

            // Jimmy face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "Actor1" },
                        { 1, 0 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "Jimmydefaultface" },
                        { 1, 0 }
                    }
            });

            // Jimmy sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Actor1",
                WhereCharacterIndex = 0,
                SetCharacterName = "jimmywalk",
                SetCharacterIndex = 0
            });

            // Soap face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "Actor3" },
                        { 1, 2 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "soapdefaultface" },
                        { 1, 0 }
                    }
            });

            // Soap sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Actor3",
                WhereCharacterIndex = 2,
                SetCharacterName = "soapwalk",
                SetCharacterIndex = 0
            });

            // Ben face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "Evil" },
                        { 1, 1 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "bendefault" },
                        { 1, 0 }
                    }
            });

            // Ben sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Evil",
                WhereCharacterIndex = 1,
                SetCharacterName = "benwalk",
                SetCharacterIndex = 0
            });

            // Spat face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "Actor2" },
                        { 1, 6 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "Spatdefault" },
                        { 1, 0 }
                    }
            });

            // Spat sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Actor2",
                WhereCharacterIndex = 6,
                SetCharacterName = "spatwalk",
                SetCharacterIndex = 0
            });

            // Yoshi face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "Actor1" },
                        { 1, 7 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "yoshidefault" },
                        { 1, 0 }
                    }
            });

            // Yoshi sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Actor1",
                WhereCharacterIndex = 7,
                SetCharacterName = "yoshiwalk",
                SetCharacterIndex = 0
            });

            // Jon face
            mapEditor.EditEventCommands(new Logic.Args.EditEventCommandsArgs
            {
                code = Data.Enums.EventCommandCode.ShowText,
                WhereParameters = new KeyValueList<int, object>{
                        { 0, "What" },
                        { 1, 1 }
                    },
                SetParameters = new KeyValueList<int, object>{
                        { 0, "jondefault" },
                        { 1, 0 }
                    }
            });

            // Jon sprite
            mapEditor.EditEventPageImages(new Logic.Args.EditEventPageImagesArgs
            {
                WhereCharacterName = "Jon",
                WhereCharacterIndex = 0,
                SetCharacterName = "jonwalk",
                SetCharacterIndex = 0
            });
        }

        #endregion
    }
}
