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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultiConOrthSeg-PortToPort.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultiConOrthSeg-PortToPort.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MultipleConnectorOrthoSegment/PortToPort")]
    public partial class MultiConOrthSeg_PortToPort : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\MultiConOrthSeg-PortToPort.razor"
      

    DiagramObjectCollection<Connector> connectors = new DiagramObjectCollection<Connector>();

    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        int count = 1; int offsetY = 100; int offsetX = 100;
        for (var i = 0; i < 9; i++)
        {
            Node node = new Node {
                ID= "node" + i, OffsetX= ((count) * offsetX), OffsetY= offsetY, Width= 50, Height= 50,
                Ports=new DiagramObjectCollection<PointPort>()
                        {
                            new PointPort(){ID="Port1", Offset=new Point{X=0, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="Port2", Offset=new Point{X=0.5, Y=0}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="Port3", Offset=new Point{X=1, Y=0.5}, Visibility=PortVisibility.Visible},
                            new PointPort(){ID="Port4", Offset=new Point{X=0.5, Y=1}, Visibility=PortVisibility.Visible},
                        }
            };
            if (node.ID == "node1")
            {
                node.OffsetX = 550; node.OffsetY = 250;
            }
            else if (node.ID == "node3")
            {
                node.OffsetX = 250;  node.OffsetY = 250;
            }
            else if (node.ID == "node5")
            {
                node.OffsetX = 550; node.OffsetY = 400;
            }
            else if (node.ID == "node7")
            {
                node.OffsetX = 250; node.OffsetY = 400;
            }
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
        Direction[] dir = new Direction[] { Direction.Right, Direction.Left, Direction.Top, Direction.Bottom };
        string[] ports = new string[] { "port1", "port2", "port3", "port4" };
        string[] targetNodes = new string[] { "node0", "node2", "node6", "node8" };
        string[] sourceNodes = new string[] { "node3", "node1", "node7", "node5" };
        for (int i = 0; i < sourceNodes.Length; i++)
        {
            for (int j = 0; j < dir.Length; j++)
            {
                Connector connector = new Connector
                {
                    ID = "connector" + count,
                    Type = Segments.Orthogonal,
                    TargetID = targetNodes[i],
                    SourceID = sourceNodes[i],
                    SourcePortID= ports[i], TargetPortID= ports[j],
                    Segments = new DiagramObjectCollection<ConnectorSegment>(){
                        new OrthogonalSegment { Type= Segments.Orthogonal, Direction= dir[j], Length= 50 }
                    },
                    TargetPadding = 20, SourcePadding = 20,
                };
                connectors.Add(connector);
                count++;
            }
        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
