// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WasmNativeImplementation.Pages.Interaction
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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Interaction\Selection.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Interaction\Selection.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Selection")]
    public partial class Selection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Interaction\Selection.razor"
      

        DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();
        DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

        string EventValue = string.Empty;
        bool IsCancelEvent = false;

        protected override void OnInitialized()
        {
            nodes.Add(
                new Node()
                {
                    ID = "node1",
                    Width = 100,
                    Height = 100,
                    OffsetX = 50,
                    OffsetY = 50,
                });
            nodes.Add(new Node()
            {
                ID = "node2",
                OffsetX = 2000,
                OffsetY = 2000,
                Width = 80,
                Height = 130,
            });
            nodes.Add(new Node()
            {
                ID = "node3",
                OffsetX = 300,
                OffsetY = 350,
                Width = 100,
                Height = 75
            });

            connectors.Add(new Connector() { Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb, SourcePoint = new Point { X = 200, Y = 100 }, TargetPoint = new Point { X = 340, Y = 150 }, Segments = new DiagramObjectCollection<ConnectorSegment> { new StraightSegment() { Type = Segments.Straight, Point = new Point { X = 300, Y = 200 } } } });
            connectors.Add(new Connector() { Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb, Type = Segments.Orthogonal, SourcePoint = new Point { X = 400, Y = 100 }, TargetPoint = new Point { X = 500, Y = 200 }, Segments = new DiagramObjectCollection<ConnectorSegment>() { new OrthogonalSegment() { Direction = Direction.Top, Length = 50 }, new OrthogonalSegment() { Direction = Direction.Left, Length = 100 } } });
        connectors.Add(new Connector() { Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb, Type = Segments.Bezier, SourcePoint = new Point { X = 100, Y = 200 }, TargetPoint = new Point { X = 200, Y = 300 }, Segments = new DiagramObjectCollection<ConnectorSegment> { new BezierSegment() { Type = Segments.Bezier, Point = new Point { X = 100, Y = 150 } } } });
    }

    SfDiagramWasm diagram;


    private void OnSelectionChange(SelectionChangeEventArgs args)
    {
        args.Cancel = IsCancelEvent;
        EventValue += "SelectionChange:\n";
        EventValue += "args.State:" + args.State +
        "\n args.Type:" + args.Type + "\n args.Cancel:" + args.Cancel + "\n args.Cause:" + args.Cause +
        "args.NewValue.Count:" + args.NewValue.Count + "\n";

        NodeBase obj;

        if (args.NewValue.Count > 0)
        {
            for (int i = 0; i < args.NewValue.Count; i++)
            {
                obj = args.NewValue[i] as NodeBase;
                EventValue += "args.NewValue[" + i + "].ID" + obj.ID + "\n";
            }
        }

        EventValue += "args.OldValue.Count:" + args.OldValue.Count+ "\n";

        if (args.OldValue.Count > 0)
        {
            for (int i = 0; i < args.OldValue.Count; i++)
            {
                obj = args.OldValue[i] as NodeBase;
                EventValue += "args.OldValue[" + i + "].ID" + obj.ID + "\n";
            }
        }
    }

    private void OnClearSelection()
    {
        diagram.ClearSelection();
    }

    private void OnSelectAll()
    {
        diagram.SelectAll();
    }

    private void OnSelectNode()
    {
        bool isMultipleSelection = (diagram.SelectedItems.Nodes.Count + diagram.SelectedItems.Connectors.Count) > 0 ? true : false;
        diagram.Select(new ObservableCollection<IDiagramObject>{ diagram.Nodes[0] }, isMultipleSelection);
    }

    private void OnSelectConnector()
    {
        bool isMultipleSelection = (diagram.SelectedItems.Nodes.Count + diagram.SelectedItems.Connectors.Count) > 0 ? true: false;
        diagram.Select(new ObservableCollection<IDiagramObject> { diagram.Connectors[0] }, isMultipleSelection);
    }

    private void OnUnSelect()
    {
        IDiagramObject obj;
        obj = diagram.SelectedItems.Nodes.Count > 0 ? diagram.SelectedItems.Nodes[0] as IDiagramObject : (diagram.SelectedItems.Connectors.Count > 0) ? diagram.SelectedItems.Connectors[0] as IDiagramObject : null;
        diagram.UnSelect(obj);
    }

    private void OnClearEventTracker()
    {
        EventValue = "";
    }

    private void OnPositionChange(DraggingEventArgs args)
    {
        args.Cancel = IsCancelEvent;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
