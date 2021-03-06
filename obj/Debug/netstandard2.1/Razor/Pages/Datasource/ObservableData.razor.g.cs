#pragma checksum "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252660c859e86b92443521688753db0aea829abf"
// <auto-generated/>
#pragma warning disable 1591
namespace WasmNativeImplementation.Pages.Datasource
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
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ObservableData")]
    public partial class ObservableData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width:100%");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "width:70%");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "value", "Add");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                   Add

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "value", "Remove");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                      Remove

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "value", "Reset");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                     Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "value", "Modify");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                      Modify

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Diagrams.Wasm.SfDiagramWasm>(26);
            __builder.AddAttribute(27, "Id", "diagram");
            __builder.AddAttribute(28, "Width", "1000px");
            __builder.AddAttribute(29, "Height", "500px");
            __builder.AddAttribute(30, "NodeDefaults", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Diagrams.Wasm.IDiagramObject>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Diagrams.Wasm.IDiagramObject>(this, 
#nullable restore
#line 14 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                     NodeDefaults

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(31, "ConnectorDefaults", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Diagrams.Wasm.IDiagramObject>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Diagrams.Wasm.IDiagramObject>(this, 
#nullable restore
#line 14 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                                      ConnectorDefaults

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "SetNodeTemplate", new System.Func<Syncfusion.Blazor.Diagrams.Wasm.IDiagramObject, Syncfusion.Blazor.Diagrams.Wasm.ICommonElement>(
#nullable restore
#line 14 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                                                                                          SetTemplate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Diagrams.Wasm.DataSourceSettings>(35);
                __builder2.AddAttribute(36, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                                            DataSource

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Id", "Name");
                __builder2.AddAttribute(38, "ParentId", "Category");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Diagrams.Wasm.ScrollSettings>(42);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 13 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
                             Diagram = (Syncfusion.Blazor.Diagrams.Wasm.SfDiagramWasm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\ObservableData.razor"
      
    SfDiagramWasm Diagram;

    float x = 100;
    float y = 100;
    Query Query = new Query().Select(new List<string>() { "EmployeeID", "ReportsTo", "FirstName" }).Take(9);
    public class HierarchicalDetails
    {
        public string Name { get; set; }
        public string FillColor { get; set; }
        public string Category { get; set; }
    }
    public ObservableCollection<HierarchicalDetails> DataSource = new ObservableCollection<HierarchicalDetails>()
{
        new HierarchicalDetails(){ Name ="Diagram", Category="",FillColor="#659be5"},
        new HierarchicalDetails(){ Name ="Layout", Category="Diagram",FillColor="#659be5"},
        new HierarchicalDetails(){ Name ="Organizational chart", Category="Diagram",FillColor="#659be5"},
        new HierarchicalDetails(){ Name ="Tree layout", Category="Layout",FillColor="#659be5"},
        new HierarchicalDetails(){ Name ="Hierarchical tree", Category="Tree layout",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="Mind map", Category="Hierarchical tree",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="Family tree", Category="Hierarchical tree",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="Management", Category="Organizational chart",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="Human resources", Category="Management",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="University", Category="Management",FillColor="#659be5"},
        //new HierarchicalDetails(){ Name ="Business", Category="#Management",FillColor="#659be5"}
    };

    private void NodeDefaults(IDiagramObject obj)
    {
        Node node = obj as Node;
        node.OffsetX = x;
        node.OffsetY = y;
        x += 100;

        HierarchicalDetails hierarchicalData = node.Data as HierarchicalDetails;
        node.Style.Fill = hierarchicalData.FillColor;
        node.Annotations = new DiagramObjectCollection<ShapeAnnotation>()
    {
            new ShapeAnnotation()
            {
                Content = hierarchicalData.Name
            }
        };
    }
    private void ConnectorDefaults(IDiagramObject connector)
    {

    }
    private ICommonElement SetTemplate(IDiagramObject node)
    {
        return null;
    }

    private void Add()
    {
        DataSource.Add(
        new HierarchicalDetails() { Name = "Radial tree", Category = "Tree layout", FillColor = "#659be5" });
        x = 100; y = 100;
        Diagram.RefreshDataSource();
    }
    private void Remove()
    {
        DataSource.Remove(DataSource[4]);
        x = 100; y = 100;
        Diagram.RefreshDataSource();
    }
    private async Task Reset()
    {
        x = 200; y = 200;
        DataSource = new ObservableCollection<HierarchicalDetails>()
    {
            new HierarchicalDetails(){ Name ="Diagram1", Category="",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Layout", Category="Diagram1",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Organizational chart", Category="Diagram1",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Tree layout", Category="Layout",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Hierarchical tree", Category="Tree layout",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Mind map", Category="Hierarchical tree",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Family tree", Category="Hierarchical tree",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Management", Category="Organizational chart",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Human resources", Category="Management",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="University", Category="Management",FillColor="#659be5"},
            new HierarchicalDetails(){ Name ="Business", Category="#Management",FillColor="#659be5"}
        };
        //await Diagram.RefreshDataSource();
    }
    private async Task Modify()
    {
        x = 100; y = 100;
        DataSource[0].FillColor = "red";
        await Diagram.RefreshDataSource();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
