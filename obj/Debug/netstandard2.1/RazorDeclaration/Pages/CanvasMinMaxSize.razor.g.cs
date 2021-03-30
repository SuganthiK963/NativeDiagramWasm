// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WasmNativeImplementation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using WasmNativeImplementation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\_Imports.razor"
using WasmNativeImplementation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\CanvasMinMaxSize.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\CanvasMinMaxSize.razor"
using Syncfusion.Blazor.Diagrams.Wasm.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\CanvasMinMaxSize.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CanvasMinMaxSize")]
    public partial class CanvasMinMaxSize : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\CanvasMinMaxSize.razor"
      

    DiagramObjectCollection<ICommonElement> basicElements = new DiagramObjectCollection<ICommonElement>();

    protected override void OnInitialized()
    {
        Canvas canvas = new Canvas();
        canvas.Pivot = new Point() { X = 0, Y= 0 };
        canvas.OffsetX = 200;
        canvas.OffsetY = 100;
        canvas.Width = 200;
        canvas.Height = 200;
        canvas.MinWidth = canvas.MinHeight = 125;
        canvas.MaxWidth = canvas.MaxHeight = 150;

        Canvas canvasWithMinMaxSize = new Canvas();
        canvasWithMinMaxSize.Pivot = new Point() { X = 0, Y= 0 };
        canvasWithMinMaxSize.OffsetX = 400;
        canvasWithMinMaxSize.OffsetY = 100;
        canvasWithMinMaxSize.MinWidth = canvasWithMinMaxSize.MinHeight = 125;
        canvasWithMinMaxSize.MaxWidth = canvasWithMinMaxSize.MaxHeight = 150;

        Canvas canvasWithoutSize = new Canvas();
        canvasWithoutSize.Pivot = new Point(){ X= 0, Y= 0 };
        canvasWithoutSize.OffsetX = 600;
        canvasWithoutSize.OffsetY = 100;

        basicElements.Add(canvas);
        basicElements.Add(canvasWithMinMaxSize);
        basicElements.Add(canvasWithoutSize);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
