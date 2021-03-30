// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
