using System.Collections.Generic;

namespace KO.Core.Models.Settings
{
    public class FormSettingsModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TabIndex { get; set; }
        public List<FormSettingsValueModel> Value { get; set; }
        public List<FormSettingsModel> Children { get; set; }
    }

    public class FormSettingsValueModel
    {
        public int Index { get; set; }
        public object Data { get; set; }
        public bool Checked { get; set; }
        public bool Selected { get; set; }
        public List<FormSettingsValueModel> Children { get; set; }
    }
}
