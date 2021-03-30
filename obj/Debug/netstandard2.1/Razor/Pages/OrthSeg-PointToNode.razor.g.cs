#pragma checksum "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6059b0340e1ef8510d582b43c24a86ebe66c2a9a"
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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrthoSegment/PointToNode")]
    public partial class OrthSeg_PointToNode : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Diagrams.Wasm.SfDiagramWasm>(0);
            __builder.AddAttribute(1, "ID", "diagram");
            __builder.AddAttribute(2, "Width", "1000px");
            __builder.AddAttribute(3, "Height", "1000px");
            __builder.AddAttribute(4, "Nodes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.Wasm.DiagramObjectCollection<Syncfusion.Blazor.Diagrams.Wasm.Node>>(
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor"
                                                                   nodes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Connectors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.Wasm.DiagramObjectCollection<Syncfusion.Blazor.Diagrams.Wasm.Connector>>(
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor"
                                                                                       connectors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\OrthSeg-PointToNode.razor"
      

    DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        int count = 1; int offsetY = 100; int offsetX = 100;
        for (var i = 0; i < 9; i++)
        {
            Node node = new Node
            {
                ID = "node" + i,
                OffsetX = ((count) * offsetX),
                OffsetY = offsetY,
                Width = 50,
                Height = 50,
                Ports = new DiagramObjectCollection<PointPort>()
                    {
                            new PointPort(){ID="port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
            };
            if (node.ID != "node4")
                nodes.Add(node);
            count += 3;
            if (count == 10)
            {
                count = 1;
                offsetX = 100;
                offsetY = offsetY + 200;
            }
        }
        nodes.Add(new Node{ ID= "node9", OffsetX= 100, OffsetY= 700, Width= 50, Height= 50,
            Ports = new DiagramObjectCollection<PointPort>()
                    {
                            new PointPort(){ID="port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
        });
        nodes.Add(new Node{ ID= "node10", OffsetX= 700, OffsetY= 700, Width= 50, Height= 50,
            Ports = new DiagramObjectCollection<PointPort>()
                    {
                            new PointPort(){ID="port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
        });
        nodes.Add(new Node{ ID= "node11", OffsetX= 100, OffsetY= 1000, Width= 50, Height= 50,
            Ports = new DiagramObjectCollection<PointPort>()
                    {
                            new PointPort(){ID="port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
        });
        nodes.Add(new Node{ ID= "node12", OffsetX= 700, OffsetY= 900, Width= 50, Height= 50,
            Ports = new DiagramObjectCollection<PointPort>()
                    {
                            new PointPort(){ID="port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
        });

        Direction[] dir = new Direction[] { Direction.Left, Direction.Right, Direction.Top, Direction.Bottom };
        string[] ports = new string[] { "port1", "port2", "port3", "port4" };
        string[] targetNodes = new string[] { "node0", "node2", "node6", "node8",
        "node9", "node10", "node11", "node12" };
        Point[] sourcePoints = new Point[]{new Point{X= 300, Y= 200 }, new Point { X = 400, Y= 200 }, new Point{X= 300, Y= 300 }, new Point{X= 500, Y= 300 },
        new Point{X= 300, Y= 700 }, new Point{X= 450, Y= 700 }, new Point{X= 100, Y= 850 }, new Point{X= 700, Y= 1150 } };
        int con = 0;
        for (int i = 0; i < targetNodes.Length; i++)
        {
            for (int j = 0; j < dir.Length; j++)
            {
                Connector connector = new Connector
                {
                    ID = "connector" + con,
                    Type = Segments.Orthogonal,
                    TargetID = targetNodes[i],
                    SourcePoint = sourcePoints[i],
                    //SourcePortID = ports[k],
                    //TargetPortID = ports[l],
                    //Segments = new DiagramObjectCollection<ConnectorSegment>(){
                    //    new OrthogonalSegment { Type= Segments.Orthogonal, Direction= dir[j], Length= 50 }
                    //},
                    //TargetPadding = 20, SourcePadding = 20,
                };
                //if(con == 18)
                connectors.Add(connector);
                con++;
            }
        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591