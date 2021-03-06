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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\BasicShapesSample.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\BasicShapesSample.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BasicShapesSample")]
    public partial class BasicShapesSample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\BasicShapesSample.razor"
      

    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        nodes = new DiagramObjectCollection<Node>(){
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Rectangle } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Ellipse } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Hexagon } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Parallelogram } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Triangle } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Plus } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Star } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Pentagon } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Heptagon } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Octagon } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Trapezoid } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Decagon } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.RightTriangle } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Cylinder } },
            new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Diamond } },
        };
        int offsetX = 100; int offsetY = 100; int width = 50; int height = 50; double count = 1;
        for (int i = 1; i <= nodes.Count; i++)
        {
            nodes[i - 1].ID = "node" + i;
            nodes[i - 1].Width = width;
            nodes[i - 1].Height = height;
            nodes[i - 1].OffsetX = count * offsetX;
            nodes[i - 1].OffsetY = offsetY;

            count += 1.5;
            if (i % 5 == 0)
            {
                count = 1;
                offsetX = 100;
                offsetY = offsetY + 200;
            }

            if (i != 1 && i != 2)
            {
                nodes[i - 1].Style.Fill = "#19aa8d";
                nodes[i - 1].Style.StrokeColor = "#ff2020";
                nodes[i - 1].Style.StrokeWidth = 2;
                nodes[i - 1].Style.StrokeDashArray = "2,2";
                nodes[i - 1].Style.Opacity = 0.9;
            }
        }

        nodes[0].Style.Gradient = new LinearGradient()
        {
            Type = GradientType.Linear,
            X1 = 0,
            X2 = 50,
            Y1 = 0,
            Y2 = 50,
            Stops = new DiagramObjectCollection<GradientStop>()
            {
                    new GradientStop(){ Color= "white", Offset=0},
                    new GradientStop(){Color ="#6BA5D7", Offset=100}
                }
        };

        nodes[1].Style.Gradient = new RadialGradient()
        {
            Type = GradientType.Radial,
            Cx = 50,
            Cy = 50,
            Fx = 50,
            Fy = 50,
            Stops = new DiagramObjectCollection<GradientStop>()
            {
                    new GradientStop(){ Color= "white", Offset=0},
                    new GradientStop(){Color ="red", Offset=50}
                }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
