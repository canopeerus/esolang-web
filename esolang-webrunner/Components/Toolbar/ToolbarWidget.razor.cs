using System;
using Microsoft.AspNetCore.Components;

namespace esolang_webrunner.Components.Toolbar
{
    public partial class ToolbarWidget
    {
        [Parameter]
        public Boolean isRunButtonEnabled { get; set; }

        [Parameter]
        public Boolean isStopButtonEnabled { get; set; }

        public ToolbarWidget()
        {
        }


    }
}

