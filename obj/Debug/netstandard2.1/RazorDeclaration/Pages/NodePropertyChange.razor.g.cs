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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\NodePropertyChange.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\NodePropertyChange.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\NodePropertyChange.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NodePropertyChange")]
    public partial class NodePropertyChange : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 214 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\NodePropertyChange.razor"
      

    #region DiagramArea
    SfDiagramWasm diagram;
    DiagramObjectCollection<Node> nodes = new DiagramObjectCollection<Node>();

    protected override void OnInitialized()
    {
        nodes = new DiagramObjectCollection<Node>(){
        new Node() {
                Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Rectangle },
                Shadow= new Shadow(){Angle=45, Distance=15, Color="red", Opacity=0.5 },
                Constraints= NodeConstraints.Default | NodeConstraints.Shadow,
                Visible = true,

                Ports=new DiagramObjectCollection<PointPort>(){ new PointPort(){ID="port1", Offset=new Point() { X = 0, Y = 0.5 }, Visibility=PortVisibility.Visible, Style=new ShapeStyle() { Fill = "green" } } }
        },

        new Node() { Shape = new BasicShape() { Type = Shapes.Basic, Shape = BasicShapes.Ellipse },
                Shadow= new Shadow(){Angle=45, Distance=15, Color="blue", Opacity=0.5 },
                Constraints= NodeConstraints.Default | NodeConstraints.Shadow },
        new Node(){ Shape = new BasicShape(){Type=Shapes.Basic, Shape=BasicShapes.Polygon,
            Points= new Point[]{
                new Point() { X=35},
                new Point() { X=65 },
                new Point() { X = 100, Y=35 },
                new Point() { X = 100, Y = 65 },
                new Point() { X = 65, Y=100 },
                new Point() { X = 35, Y=100 },
                new Point() { Y=65 },
                new Point{ Y=35 }
            }
        }
            },
        new Node() { ID = "pathNode", Width = 100, Height = 100, OffsetX = 700, OffsetY = 100, Shape=new Path() { Type = Shapes.Path, Data = "M 355.31 12.07 C 352.11 5.95 345.35 -1.14 331.41 0.15 C 290.33 3.93 209.61 81.48 190.42 111.69 C 189.66 107.76 187.9 101.49 184.12 98.05 C 189.5 87.75 198.01 69.64 201.57 52.48 C 202.4 52.26 203.12 51.68 203.34 50.44 C 203.72 48.34 204 46.22 204.39 44.13 C 205.01 40.62 199.99 39.43 199.42 42.91 C 199.06 45.06 198.69 47.15 198.35 49.31 C 198.16 50.6 198.69 51.62 199.54 52.14 C 196.08 68.87 187.75 86.63 182.43 96.81 C 181.52 96.29 180.53 95.87 179.41 95.7 C 179.09 95.65 178.8 95.72 178.5 95.71 C 178.19 95.72 177.91 95.65 177.59 95.7 C 176.46 95.87 175.48 96.29 174.56 96.81 C 169.24 86.63 160.92 68.87 157.46 52.14 C 158.3 51.62 158.83 50.6 158.65 49.31 C 158.3 47.15 157.93 45.06 157.58 42.91 C 157.01 39.43 151.99 40.62 152.61 44.13 C 152.99 46.22 153.28 48.34 153.66 50.44 C 153.87 51.68 154.6 52.27 155.42 52.48 C 158.98 69.63 167.49 87.75 172.87 98.05 C 169.09 101.49 167.33 107.76 166.57 111.69 C 147.39 81.48 66.67 3.93 25.59 0.15 C 11.65 -1.14 4.89 5.95 1.69 12.07 C -2.05 19.07 0.84 33.48 6.24 58.46 C 8.66 69.55 11.16 80.96 12.94 92.2 C 13.89 98.36 14.79 104.49 15.64 110.36 C 19.39 136.89 22.52 158.97 32.64 166.04 C 35.41 167.98 38.65 168.78 42.61 168.24 C 52.26 165.95 63.79 164.03 75.99 162.67 C 64.03 171.47 49.08 185.81 44.17 204.84 C 40.38 219.72 43.37 234.86 53.01 250.05 C 64.37 267.81 76.02 279.48 86.91 287.09 C 108.68 302.31 127.52 301.24 135.48 300.78 C 136.3 300.77 136.94 300.71 137.56 300.69 C 143.62 300.61 147.76 291.39 156.6 270.51 C 160.94 260.34 167.39 245.19 172.83 237.47 C 173.97 240.31 177.22 242.31 178.92 242.87 C 178.78 242.94 178.62 243.07 178.49 243.12 C 178.65 243.08 178.83 242.97 179 242.91 C 179.1 242.94 179.25 243.02 179.34 243.04 C 179.26 243.01 179.13 242.93 179.04 242.89 C 180.83 242.24 183.05 240.25 184.16 237.48 C 189.6 245.19 196.05 260.34 200.39 270.52 C 209.23 291.4 213.38 300.61 219.43 300.7 C 220.05 300.72 220.69 300.77 221.51 300.78 C 229.47 301.25 248.31 302.31 270.08 287.1 C 280.97 279.49 292.62 267.81 303.98 250.05 C 313.62 234.86 316.6 219.72 312.82 204.84 C 307.91 185.82 292.96 171.48 281 162.67 C 293.2 164.03 304.73 165.95 314.38 168.24 C 318.34 168.78 321.58 167.98 324.35 166.04 C 334.47 158.97 337.6 136.89 341.35 110.37 C 342.19 104.49 343.1 98.37 344.05 92.2 C 345.83 80.96 348.33 69.55 350.75 58.46 C 356.16 33.48 359.05 19.07 355.31 12.07 z M 183.92 237.56 C 182.35 240.3 180.35 242.13 178.97 242.86 C 177.49 242.19 174.7 240.38 173.08 237.56 C 173.08 237.56 166.19 138.22 166.91 113.58 C 166.91 113.58 169.24 97.92 178.5 97.81 C 187.76 97.92 190.09 113.58 190.09 113.58 C 190.81 138.22 183.92 237.56 183.92 237.56 z" } }

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

    #endregion

    #region Properties change

    Node node;

    private void OnSelectNode(ChangeEventArgs args)
    {
        int index = int.Parse(args.Value.ToString());
        node = nodes[index];
    }

    private void NodeWidthChange(ChangeEventArgs args)
    {
        node.Width = double.Parse(args.Value.ToString());
    }

    private void NodeHeightChange(ChangeEventArgs args)
    {
        node.Height = double.Parse(args.Value.ToString());
    }

    private void NodeMinWidthChange(ChangeEventArgs args)
    {
        node.MinWidth = double.Parse(args.Value.ToString());
    }

    private void NodeMinHeightChange(ChangeEventArgs args)
    {
        node.MinHeight = double.Parse(args.Value.ToString());
    }

    private void NodeMaxWidthChange(ChangeEventArgs args)
    {
        node.MaxWidth = double.Parse(args.Value.ToString());
    }

    private void NodeMaxHeightChange(ChangeEventArgs args)
    {
        node.MaxHeight = double.Parse(args.Value.ToString());
    }

    private void NodeOffsetXChange(ChangeEventArgs args)
    {
        node.OffsetX = double.Parse(args.Value.ToString());
    }

    private void NodeOffsetYChange(ChangeEventArgs args)
    {
        node.OffsetY = double.Parse(args.Value.ToString());
    }

    private void RotateAngleChange(ChangeEventArgs args)
    {
        node.RotateAngle = double.Parse(args.Value.ToString());
    }

    private void NodeVisibleChange(ChangeEventArgs args)
    {
        node.Visible = (bool)args.Value;
    }


    private void UpdateStyle()
    {
        node.Style = new ShapeStyle() { Fill = "orange", StrokeColor = "blue", Opacity = 1 };
        StateHasChanged();
    }

    public void FillColorChange(ChangeEventArgs args)
    {
        node.Style.Fill = (string)args.Value;
    }

    public void StrokeColorChange(ChangeEventArgs args)
    {
        node.Style.StrokeColor = (string)args.Value;
    }

    public void StrokeDashArrayChange(ChangeEventArgs args)
    {
        node.Style.StrokeDashArray = (string)args.Value;
    }

    public void StrokeWidthChange(ChangeEventArgs args)
    {
        node.Style.StrokeWidth = double.Parse(args.Value.ToString());
    }

    public void OpacityChange(ChangeEventArgs args)
    {
        node.Style.Opacity = double.Parse(args.Value.ToString());
    }

    public void GradientChange(ChangeEventArgs args)
    {
        string value = args.Value.ToString();
        if (value == "linear")
        {
            node.Style.Gradient = new LinearGradient()
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

        }
        else if (value == "radial") {
            node.Style.Gradient = new RadialGradient()
            {
                Type = GradientType.Radial,
                Cx = 50,
                Cy = 50,
                Fx = 50,
                Fy = 50,
                Stops = new DiagramObjectCollection<GradientStop>()
                {
                    new GradientStop(){ Color= "white", Offset=0},
                    new GradientStop(){Color ="violet", Offset=50}
                }
            };
        }
        else if(value == "stops") {
            node.Style.Gradient.Stops = new DiagramObjectCollection<GradientStop>()
            {
                new GradientStop(){ Color= "#dc234e", Offset=0},
                new GradientStop(){Color ="#ebc614", Offset=30},
                new GradientStop(){Color ="#4a9d7e", Offset=70}
            };
        }
        else
        {
            node.Style.Gradient.Stops = new DiagramObjectCollection<GradientStop>()
            {
                new GradientStop(){Color ="#ebc614", Offset=30},
                new GradientStop(){ Color= "#dc234e", Offset=70},
            };
        }
    }

    public void LinearGradientChange(ChangeEventArgs args)
    {
        string value = args.Value.ToString();
        if (value == "linear")
        {
            diagram.BeginUpdate();
            LinearGradient gradient = (node.Style.Gradient as LinearGradient);
            gradient.X1 = 10;
            gradient.X2 = 70;
            gradient.Y1 = 10;
            gradient.Y2 = 70;
            gradient.Stops[0].Color = "brown";
            gradient.Stops[0].Color = "green";
            diagram.EndUpdate();
        }
        else
        {
            RadialGradientChange();
        }
    }

    public void RadialGradientChange() {
        diagram.BeginUpdate();
        RadialGradient gradient = node.Style.Gradient as RadialGradient;
        gradient.Cx = 60; gradient.Cy = 60;
        gradient.Fx = 60; gradient.Fy = 60;
        gradient.Stops[0].Color = "red";
        gradient.Stops[0].Color = "white";
        diagram.EndUpdate();
    }

    private void OnUpdateShadow()
    {
        node.Constraints = NodeConstraints.Default | NodeConstraints.Shadow;
        node.Shadow = new Shadow() { Angle = 20, Color = "green", Distance = 20, Opacity = 0.3 };
        StateHasChanged();
    }

    public void ShadowColorChange(ChangeEventArgs args)
    {
        node.Constraints = NodeConstraints.Default | NodeConstraints.Shadow;
        node.Shadow.Color = (string)args.Value;
    }

    public void ShadowDistanceChange(ChangeEventArgs args)
    {
        node.Constraints = NodeConstraints.Default | NodeConstraints.Shadow;
        node.Shadow.Distance = double.Parse(args.Value.ToString());
    }

    public void ShadowAngleChange(ChangeEventArgs args)
    {
        node.Constraints = NodeConstraints.Default | NodeConstraints.Shadow;
        node.Shadow.Angle = double.Parse(args.Value.ToString());
    }

    public void ShadowOpacityChange(ChangeEventArgs args)
    {
        node.Constraints = NodeConstraints.Default | NodeConstraints.Shadow;
        node.Shadow.Opacity = double.Parse(args.Value.ToString());
    }


    private void UpdateCornerRadius()
    {
        (node.Shape as BasicShape).CornerRadius = 20;
    }

    private void UpdatePivot()
    {
        nodes[0].Pivot.X = nodes[0].Pivot.X == 1 ? 0 : 1;
        nodes[0].Pivot.Y = nodes[0].Pivot.Y == 1 ? 0 : 1;
        StateHasChanged();
    }



    private void UpdateMargin()
    {
        nodes[1].Margin.Left += 10;
        nodes[1].Margin.Top += 10;
        StateHasChanged();
    }

    private void UpdateShape()
    {
        nodes[1].Shape = new BasicShape() { Shape = BasicShapes.Plus, Type = Shapes.Basic };
        StateHasChanged();
    }

    private void UpdateBasicToFlowShape()
    {
        nodes[1].Shape = new FlowShape() { Shape = FlowShapes.Decision, Type = Shapes.Flow };
        StateHasChanged();
    }

    private void UpdateToPathShape()
    {
        diagram.BeginUpdate();
        nodes[1].Shape = new Path() { Type = Shapes.Path, Data = "M 355.31 12.07 C 352.11 5.95 345.35 -1.14 331.41 0.15 C 290.33 3.93 209.61 81.48 190.42 111.69 C 189.66 107.76 187.9 101.49 184.12 98.05 C 189.5 87.75 198.01 69.64 201.57 52.48 C 202.4 52.26 203.12 51.68 203.34 50.44 C 203.72 48.34 204 46.22 204.39 44.13 C 205.01 40.62 199.99 39.43 199.42 42.91 C 199.06 45.06 198.69 47.15 198.35 49.31 C 198.16 50.6 198.69 51.62 199.54 52.14 C 196.08 68.87 187.75 86.63 182.43 96.81 C 181.52 96.29 180.53 95.87 179.41 95.7 C 179.09 95.65 178.8 95.72 178.5 95.71 C 178.19 95.72 177.91 95.65 177.59 95.7 C 176.46 95.87 175.48 96.29 174.56 96.81 C 169.24 86.63 160.92 68.87 157.46 52.14 C 158.3 51.62 158.83 50.6 158.65 49.31 C 158.3 47.15 157.93 45.06 157.58 42.91 C 157.01 39.43 151.99 40.62 152.61 44.13 C 152.99 46.22 153.28 48.34 153.66 50.44 C 153.87 51.68 154.6 52.27 155.42 52.48 C 158.98 69.63 167.49 87.75 172.87 98.05 C 169.09 101.49 167.33 107.76 166.57 111.69 C 147.39 81.48 66.67 3.93 25.59 0.15 C 11.65 -1.14 4.89 5.95 1.69 12.07 C -2.05 19.07 0.84 33.48 6.24 58.46 C 8.66 69.55 11.16 80.96 12.94 92.2 C 13.89 98.36 14.79 104.49 15.64 110.36 C 19.39 136.89 22.52 158.97 32.64 166.04 C 35.41 167.98 38.65 168.78 42.61 168.24 C 52.26 165.95 63.79 164.03 75.99 162.67 C 64.03 171.47 49.08 185.81 44.17 204.84 C 40.38 219.72 43.37 234.86 53.01 250.05 C 64.37 267.81 76.02 279.48 86.91 287.09 C 108.68 302.31 127.52 301.24 135.48 300.78 C 136.3 300.77 136.94 300.71 137.56 300.69 C 143.62 300.61 147.76 291.39 156.6 270.51 C 160.94 260.34 167.39 245.19 172.83 237.47 C 173.97 240.31 177.22 242.31 178.92 242.87 C 178.78 242.94 178.62 243.07 178.49 243.12 C 178.65 243.08 178.83 242.97 179 242.91 C 179.1 242.94 179.25 243.02 179.34 243.04 C 179.26 243.01 179.13 242.93 179.04 242.89 C 180.83 242.24 183.05 240.25 184.16 237.48 C 189.6 245.19 196.05 260.34 200.39 270.52 C 209.23 291.4 213.38 300.61 219.43 300.7 C 220.05 300.72 220.69 300.77 221.51 300.78 C 229.47 301.25 248.31 302.31 270.08 287.1 C 280.97 279.49 292.62 267.81 303.98 250.05 C 313.62 234.86 316.6 219.72 312.82 204.84 C 307.91 185.82 292.96 171.48 281 162.67 C 293.2 164.03 304.73 165.95 314.38 168.24 C 318.34 168.78 321.58 167.98 324.35 166.04 C 334.47 158.97 337.6 136.89 341.35 110.37 C 342.19 104.49 343.1 98.37 344.05 92.2 C 345.83 80.96 348.33 69.55 350.75 58.46 C 356.16 33.48 359.05 19.07 355.31 12.07 z M 183.92 237.56 C 182.35 240.3 180.35 242.13 178.97 242.86 C 177.49 242.19 174.7 240.38 173.08 237.56 C 173.08 237.56 166.19 138.22 166.91 113.58 C 166.91 113.58 169.24 97.92 178.5 97.81 C 187.76 97.92 190.09 113.58 190.09 113.58 C 190.81 138.22 183.92 237.56 183.92 237.56 z" };
        (nodes[3].Shape as Path).Data = "M540.3643,137.9336L546.7973,159.7016L570.3633,159.7296L550.7723,171.9366L558.9053,194.9966L540.3643,179.4996L521.8223,194.9966L529.9553,171.9366L510.3633,159.7296L533.9313,159.7016L540.3643,137.9336z";
        (nodes[2].Shape as BasicShape).Points = new Point[]{
                new Point() { X = 100, Y=35 },
                new Point() { X = 100, Y = 65 },
                new Point() { X = 65, Y=100 },
                new Point() { X = 35, Y=100 },
                new Point() { Y=65 },
                new Point{ Y=35 }
            };
        diagram.EndUpdate();
    }

    internal void UpdatePort()
    {
        nodes[0].Ports[0].Style = new ShapeStyle() { Opacity = 0.5 };
    }

    internal void UpdateGradient()
    {
        nodes[1].Style.Gradient.Stops[0].Color = "blue";
        nodes[0].Style.Gradient = new RadialGradient()
        {
            Type = GradientType.Radial,
            Cx = 50,
            Cy = 50,
            Fx = 50,
            Fy = 50,
            Stops = new DiagramObjectCollection<GradientStop>()
            {
            new GradientStop(){ Color= "white", Offset=0},
            new GradientStop(){Color ="violet", Offset=50}
        }
        };

    }

    private void OnBasicShapeChange(ChangeEventArgs args)
    {
        diagram.BeginUpdate();
        BasicShapes shape = (BasicShapes)Enum.Parse(typeof(BasicShapes), args.Value.ToString());
        if(node.Shape is BasicShape)
        {
            (node.Shape as BasicShape).Shape = shape;
            if (shape == BasicShapes.Polygon)
            {
                (node.Shape as BasicShape).Points = new Point[]{
                    new Point() { X = 100, Y=35 },
                    new Point() { X = 100, Y = 65 },
                    new Point() { X = 65, Y=100 },
                    new Point() { X = 35, Y=100 },
                    new Point() { Y=65 },
                    new Point{ Y=35 }
                };
            }
        }
        else
        {
            BasicShape shape1 = new BasicShape() { Type = Shapes.Basic, Shape = shape };
            if (shape == BasicShapes.Polygon)
            {
                shape1.Points = new Point[]{
                    new Point() { X = 100, Y=35 },
                    new Point() { X = 100, Y = 65 },
                    new Point() { X = 65, Y=100 },
                    new Point() { X = 35, Y=100 },
                    new Point() { Y=65 },
                    new Point{ Y=35 }
                };
            }
            node.Shape = shape1;
        }
        diagram.EndUpdate();
    }

    private void OnFlowShapeChange(ChangeEventArgs args)
    {
        FlowShapes shape = (FlowShapes)Enum.Parse(typeof(FlowShapes), args.Value.ToString());
        if (node.Shape is FlowShape)
        {
            (node.Shape as FlowShape).Shape = shape;
        }
        else
        {
            node.Shape = new FlowShape() { Type = Shapes.Flow, Shape = shape };
        }
    }

    private void OnPathShapeChange(ChangeEventArgs args)
    {
        string pathData = args.Value.ToString();
        if (node.Shape is Path)
        {
            (node.Shape as Path).Data = pathData;
        }
        else
        {
            node.Shape = new Path() { Type = Shapes.Path, Data = pathData };
        }
    }

    #endregion

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
