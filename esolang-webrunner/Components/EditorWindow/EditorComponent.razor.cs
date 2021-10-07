using BlazorMonaco;

namespace esolang_webrunner.Components.EditorWindow
{
    public partial class EditorComponent
    { 
        public string language { get; set; }

        public StandaloneEditorConstructionOptions getEditorConstructionOptions(MonacoEditor editor)
        {
            return new StandaloneEditorConstructionOptions
            {
                Language = language,
                Value = "yolobhaisaab",
                Dimension = new Dimension
                {
                    Height = 500
                },
                Folding = false,
                AutomaticLayout = true,
                Theme = "vs-dark",
                QuickSuggestions = new QuickSuggestionsOptions
                {
                    Comments = false,
                    Other = false,
                    Strings = false
                }
            };
        }
    }
}

