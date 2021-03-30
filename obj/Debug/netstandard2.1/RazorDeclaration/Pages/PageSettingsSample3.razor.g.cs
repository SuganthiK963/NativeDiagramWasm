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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\PageSettingsSample3.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\PageSettingsSample3.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PageSettings3")]
    public partial class PageSettingsSample3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\PageSettingsSample3.razor"
      
    SfDiagramWasm diagram;

    double PageWidth = 300;
    double PageHeight = 300;
    PageOrientation pageOrientation = PageOrientation.Landscape;
    bool IsMultiplePage = true;
    bool IsShowPageBreaks = true;

    string imageSource = "https://www.w3schools.com/images/w3schools_green.jpg";
    Scale imageScale = Scale.Slice;
    ImageAlignment imageAlignment = ImageAlignment.XMinYMin;
    string bgmColor = "transparent";

    DiagramObjectCollection<Node> nodes; DiagramObjectCollection<Connector> connectors;

    protected override void OnInitialized()
    {
        nodes = new DiagramObjectCollection<Node>(){
            new Node { ID = "node1", Width = 150, Height = 100, OffsetX = 100, OffsetY = 100, Annotations = new DiagramObjectCollection<ShapeAnnotation>() { new ShapeAnnotation() { Content = "Node1" } } },
            new Node { ID = "node2", Width = 80, Height = 130, OffsetX = 200, OffsetY = 200, Annotations = new DiagramObjectCollection<ShapeAnnotation>() { new ShapeAnnotation() { Content = "Node2" } } },
            new Node { ID = "node3", Width = 100, Height = 75, OffsetX = 300, OffsetY = 350, Annotations = new DiagramObjectCollection<ShapeAnnotation>() { new ShapeAnnotation() { Content = "Node3" } } }
        };

        connectors = new DiagramObjectCollection<Connector> {
            new Connector { ID="connector1", SourcePoint=new Point { X=300, Y=400}, TargetPoint = new Point { X = 500, Y = 500 } }
        };
    }

    private void OnPageWidthChange(ChangeEventArgs args)
    {
        PageWidth = double.Parse(args.Value.ToString());
    }

    private void OnPageHeightChange(ChangeEventArgs args)
    {
        PageHeight = double.Parse(args.Value.ToString());
    }

    private void OnPageOrientationChange(ChangeEventArgs args)
    {
        PageOrientation orientation = (PageOrientation)Enum.Parse(typeof(PageOrientation), args.Value.ToString());
        pageOrientation = orientation;
    }

    private void OnChangeMultiplePage(ChangeEventArgs args)
    {
        IsMultiplePage = (bool)args.Value;
    }

    private void OnChangeShowPageBreaks(ChangeEventArgs args)
    {
        IsShowPageBreaks = (bool)args.Value;
    }

    private void BgmColorChange(ChangeEventArgs args)
    {
        string value = (string)args.Value;
        bgmColor = value == "Empty string" ? string.Empty : value;
    }

    private void BgmImageChange(ChangeEventArgs args)
    {
        string val = (string)args.Value;
        imageSource = val == "Empty string" ? string.Empty : val;
    }

    private void OnImageScaleChange(ChangeEventArgs args)
    {
        Scale scale = (Scale)Enum.Parse(typeof(Scale), args.Value.ToString());
        imageScale = scale;
    }

    private void OnImageAlignmentChange(ChangeEventArgs args)
    {
        ImageAlignment alignment = (ImageAlignment)Enum.Parse(typeof(ImageAlignment), args.Value.ToString());
        imageAlignment = alignment;
    }

    string json;

    private void OnSave()
    {
        //json = diagram.Save();
    }

    private async void OnLoad()
    {
        //await diagram.Load(json);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591