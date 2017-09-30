using System.Security;
using nucs.JsonSettings.Fluent;

namespace nucs.JsonSettings.xTests {
    public class CasualExampleSettings : JsonSettings {
        public override string FileName { get; set; } = "casual.json";
        public string SomeProperty { get; set; }
        public int SomeNumeralProperty { get; set; } = -1; //with default value.
        public SmallClass SomeClassProperty { get; set; }

        protected override void OnConfigure() {
            base.OnConfigure();
        }

        public CasualExampleSettings() { }
        public CasualExampleSettings(string fileName) : base(fileName) { }
    }
}