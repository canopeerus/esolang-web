using BlazorMonaco;

namespace esolang_webrunner.Components.ConsoleWindow
{
    public partial class ConsoleComponent
    {
        private string outputText { get; set; }

        public StandaloneEditorConstructionOptions getEditorConstructionOptions(MonacoEditor editor)
        {
            return new StandaloneEditorConstructionOptions
            {
                Language = "javascript",
                Value = "yolo",
                Dimension = new Dimension
                {
                    Height = 200
                },
                ReadOnly = true,
                Theme = "hc-black",
                Folding = false,
                LineNumbers = "off",
                AutomaticLayout = true,
                RoundedSelection = true

            };
        }
    }
}

