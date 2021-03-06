#pragma checksum "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e5f4a09e50369888c09f5c531782acb86dd5e9"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MultipleConnectorBezierSegment")]
    public partial class MultipleConBezierSeg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Diagrams.Wasm.SfDiagramWasm>(0);
            __builder.AddAttribute(1, "ID", "diagram");
            __builder.AddAttribute(2, "Width", "1000px");
            __builder.AddAttribute(3, "Height", "500px");
            __builder.AddAttribute(4, "Nodes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.Wasm.DiagramObjectCollection<Syncfusion.Blazor.Diagrams.Wasm.Node>>(
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor"
                                                                  nodes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Connectors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.Wasm.DiagramObjectCollection<Syncfusion.Blazor.Diagrams.Wasm.Connector>>(
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor"
                                                                                      connectors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultipleConBezierSeg.razor"
      

    DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        nodes.Add(
            new Node()
            {
                ID = "node1",
                OffsetX = 100,
                OffsetY = 300,
                Width = 100,
                Height = 100,
                Ports = new DiagramObjectCollection<PointPort>()
                {
                    new PointPort()
                    {
                        ID="Port1",
                        Visibility = PortVisibility.Visible,
                        Offset = new Point() { X = 0.5, Y = 0 },
                        Height = 20, Width = 20
                    },
                }
            });
        nodes.Add(new Node() {
            ID = "node2", OffsetX = 300, OffsetY = 400, Width = 100, Height = 100,
            Ports = new DiagramObjectCollection<PointPort>()
                {
                    new PointPort()
                    {
                        ID="Port1",
                        Visibility = PortVisibility.Visible,
                        Offset = new Point() { X = 0.5, Y = 0 },
                        Height = 20, Width = 20
                    },
                }
        });
        nodes.Add(new Node() { ID = "node3", OffsetX = 500, OffsetY = 300, Width = 100, Height = 100,
            Ports = new DiagramObjectCollection<PointPort>()
                {
                    new PointPort()
                    {
                        ID="Port1",
                        Visibility = PortVisibility.Visible,
                        Offset = new Point() { X = 0.5, Y = 0 },
                        Height = 20, Width = 20
                    },
                }
        });
        nodes.Add(new Node() { ID = "node4", OffsetX = 700, OffsetY = 400, Width = 100, Height = 100,
            Ports = new DiagramObjectCollection<PointPort>()
                {
                    new PointPort()
                    {
                        ID="Port1",
                        Visibility = PortVisibility.Visible,
                        Offset = new Point() { X = 0.5, Y = 0 },
                        Height = 20, Width = 20
                    },
                }
        });


        Connector connector1 = new Connector() {
            ID = "connector1", SourcePoint=new Point() { X = 100, Y = 10 },
            TargetPoint=new Point() { X = 200, Y = 100 }, Type= Segments.Bezier,
            Segments=new DiagramObjectCollection<ConnectorSegment>() {
            new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=150, Y=50 } },
            new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=100, Y=70 } }
        },
            SourceDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            TargetDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            Visible=false
        };
        connectors.Add(connector1);

        Connector connector2 = new Connector() { ID = "connector2",
            SourceID = "node1", TargetID="node2", Type = Segments.Bezier,
            Segments = new DiagramObjectCollection<ConnectorSegment>() {
            new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=150, Y=200 } },
            new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=250, Y=250 } }
            },
            SourceDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            TargetDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            TargetPadding = 20,
            SourcePadding = 20,
        };
        connectors.Add(connector2);

        Connector connector3 = new Connector() { ID = "connector3",
            SourceID = "node3", SourcePortID="Port1",
            TargetID = "node4", TargetPortID ="Port1",Type = Segments.Bezier,
            Segments = new DiagramObjectCollection<ConnectorSegment>()
            {
                new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=550, Y=200 } },
                new BezierSegment(){ Type = Segments.Bezier, Point=new Point(){X=800, Y=250 } }
            },
            SourceDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            TargetDecorator = new Decorator { Shape = DecoratorShapes.DoubleArrow, Style = new ShapeStyle { Fill = "red" } },
            TargetPadding = 20,
            SourcePadding = 20,
        };
        connectors.Add(connector3);


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
