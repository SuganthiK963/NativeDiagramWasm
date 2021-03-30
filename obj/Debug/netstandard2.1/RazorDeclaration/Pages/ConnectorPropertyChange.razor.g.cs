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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\ConnectorPropertyChange.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\ConnectorPropertyChange.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\ConnectorPropertyChange.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConnectorPropertyChange")]
    public partial class ConnectorPropertyChange : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\ConnectorPropertyChange.razor"
      

    SfDiagramWasm diagram;

    DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        Connector connector1 = new Connector() { ID = "connector1", SourcePoint = new Point() { X = 100, Y = 10 }, TargetPoint = new Point() { X = 200, Y = 100 }, Type = Segments.Straight };
        connectors.Add(connector1);

        Connector connector2 = new Connector() { ID = "connector2", SourcePoint = new Point() { X = 300, Y = 10 }, TargetPoint = new Point() { X = 400, Y = 100 }, Type = Segments.Orthogonal };
        connectors.Add(connector2);

        Connector connector3 = new Connector() { ID = "connector3", SourcePoint = new Point() { X = 500, Y = 10 }, TargetPoint = new Point() { X = 600, Y = 100 }, Type = Segments.Bezier };
        connectors.Add(connector3);

    }

    Connector connector;

    private void OnSelectConnector(ChangeEventArgs args)
    {
        int index = int.Parse(args.Value.ToString());
        connector = connectors[index];
    }

    private void OnSourcePointXChange(ChangeEventArgs args)
    {
        connector.SourcePoint.X = double.Parse(args.Value.ToString());
    }

    private void OnSourcePointYChange(ChangeEventArgs args)
    {
        connector.SourcePoint = new Point { Y = double.Parse(args.Value.ToString()), X = connector.SourcePoint.X };
    }

    private void OnTargetPointXChange(ChangeEventArgs args)
    {
        connector.TargetPoint = new Point { X = double.Parse(args.Value.ToString()), Y = connector.SourcePoint.Y };
    }

    private void OnTargetPointYChange(ChangeEventArgs args)
    {
        connector.TargetPoint.Y = double.Parse(args.Value.ToString());
    }

    Decorator decorator;

    private void OnSelectDecorator(ChangeEventArgs args)
    {
        decorator = (args.Value.ToString() == "source") ? connector.SourceDecorator : connector.TargetDecorator;
    }

    private void OnDecoratorShapeChange(ChangeEventArgs args)
    {
        DecoratorShapes shape = (DecoratorShapes)Enum.Parse(typeof(DecoratorShapes), args.Value.ToString());
        decorator.Shape = shape;
        StateHasChanged();
    }

    private void OnPivotPointXChange(ChangeEventArgs args)
    {
        decorator.Pivot = new Point { X = double.Parse(args.Value.ToString()), Y = connector.SourcePoint.Y };
    }

    private void OnPivotPointYChange(ChangeEventArgs args)
    {
        decorator.Pivot.Y = double.Parse(args.Value.ToString());
    }

    private void OnDecoratorWidthChange(ChangeEventArgs args)
    {
        decorator.Width = double.Parse(args.Value.ToString());
    }

    private void OnDecoratorHeightChange(ChangeEventArgs args)
    {
        decorator.Height = double.Parse(args.Value.ToString());
    }

    private void OnPathShapeChange(ChangeEventArgs args)
    {
        string pathData = args.Value.ToString();
        decorator.PathData = args.Value.ToString();
    }


    string ToChangeStyle = "Connector";

    private void SelectStyleToShape(ChangeEventArgs args)
    {
        ToChangeStyle = args.Value.ToString();
    }

    public void FillColorChange(ChangeEventArgs args)
    {
        string value = (string)args.Value;
        if (ToChangeStyle == "Connector")
        {
            connector.Style.Fill = value;
        }
        else if (ToChangeStyle == "SourceDecorator")
        {
            connector.SourceDecorator.Style.Fill = value;
        }
        else
        {
            connector.TargetDecorator.Style.Fill = value;
        }
    }

    public void StrokeColorChange(ChangeEventArgs args)
    {
        string value = (string)args.Value;
        if (ToChangeStyle == "Connector")
        {
            connector.Style.StrokeColor = value;
        }
        else if (ToChangeStyle == "SourceDecorator")
        {
            connector.SourceDecorator.Style.StrokeColor = value;
        }
        else
        {
            connector.TargetDecorator.Style.StrokeColor = value;
        }
    }

    public void StrokeDashArrayChange(ChangeEventArgs args)
    {
        string value = (string)args.Value;
        if (ToChangeStyle == "Connector")
        {
            connector.Style.StrokeDashArray = value;
        }
        else if (ToChangeStyle == "SourceDecorator")
        {
            connector.SourceDecorator.Style.StrokeDashArray = value;
        }
        else
        {
            connector.TargetDecorator.Style.StrokeDashArray = value;
        }
    }

    public void StrokeWidthChange(ChangeEventArgs args)
    {
        double value = double.Parse(args.Value.ToString());
        if (ToChangeStyle == "Connector")
        {
            connector.Style.StrokeWidth = value;
        }
        else if (ToChangeStyle == "SourceDecorator")
        {
            connector.SourceDecorator.Style.StrokeWidth = value;
        }
        else
        {
            connector.TargetDecorator.Style.StrokeWidth = value;
        }
    }

    public void OpacityChange(ChangeEventArgs args)
    {
        double value = double.Parse(args.Value.ToString());
        if (ToChangeStyle == "Connector")
        {
            connector.Style.Opacity = value;
        }
        else if (ToChangeStyle == "SourceDecorator")
        {
            connector.SourceDecorator.Style.Opacity = value;
        }
        else
        {
            connector.TargetDecorator.Style.Opacity = value;
        }
    }

    private void OnChangeConnectorType(ChangeEventArgs args)
    {
        Segments segments = (Segments)Enum.Parse(typeof(Segments), args.Value.ToString());
        connector.Type = segments;
    }

    private void OnCornerRadiusChange(ChangeEventArgs args)
    {
        connector.CornerRadius = double.Parse(args.Value.ToString());
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
