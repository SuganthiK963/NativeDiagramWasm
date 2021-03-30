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
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\DynamicObj.razor"
using Syncfusion.Blazor.Diagrams.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\DynamicObj.razor"
using System.Dynamic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DynamicObject")]
    public partial class DynamicObj : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\DynamicObj.razor"
       
    SfDiagramWasm Diagram;
    float x = 100;
    float y = 100;
    List<DynamicDictionary> DataSource = new List<DynamicDictionary>();

    protected override void OnInitialized()
    {
        dynamic d = new DynamicDictionary();
        d.Name = "Diagram";
        d.Category = "";
        d.FillColor = "#659be5";

        DataSource.Add(d);
        d = new DynamicDictionary();
        d.Name = "Layout";
        d.Category = "Diagram";
        d.FillColor = "#659be5";

        DataSource.Add(d);
        d = new DynamicDictionary();
        d.Name = "Organizational chart";
        d.Category = "Diagram";
        d.FillColor = "#659be5";

        DataSource.Add(d);
        d = new DynamicDictionary();
        d.Name = "Tree layout";
        d.Category = "Layout";
        d.FillColor = "#659be5";

        DataSource.Add(d);
        d = new DynamicDictionary();
        d.Name = "Hierarchical tree";
        d.Category = "Tree layout";
        d.FillColor = "#659be5";

        DataSource.Add(d);


        //new HierarchicalDetails() { Name = "Diagram", Category = "", FillColor = "#659be5" },
        //new HierarchicalDetails() { Name = "Layout", Category = "Diagram", FillColor = "#659be5" },
        //new HierarchicalDetails() { Name = "Organizational chart", Category = "Diagram", FillColor = "#659be5" },
        //new HierarchicalDetails() { Name = "Tree layout", Category = "Layout", FillColor = "#659be5" },
        //new HierarchicalDetails() { Name = "Hierarchical tree", Category = "Tree layout", FillColor = "#659be5" },
        base.OnInitialized();
    }
    private void NodeDefaults(IDiagramObject obj)
    {
        Node node = obj as Node;
        node.OffsetX = x;
        node.OffsetY = y;
        x += 100;

        //DynamicDictionary hierarchicalData = node.Data as DynamicDictionary;
        //node.Style.Fill = hierarchicalData.FillColor;
        //node.Annotations = new DiagramObjectCollection<ShapeAnnotation>()
        //{
        //    new ShapeAnnotation()
        //    {
        //        Content = hierarchicalData.Name
        //    }
        //};
    }
    private void ConnectorDefaults(IDiagramObject connector)
    {

    }
    private ICommonElement SetTemplate(IDiagramObject node)
    {
        return null;
    }
    public class DynamicDictionary : System.Dynamic.DynamicObject
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string name = binder.Name;
            return dictionary.TryGetValue(name, out result);
        }
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            dictionary[binder.Name] = value;
            return true;
        }

        public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames()
        {
            return this.dictionary?.Keys;
        }

    }
    //public class HierarchicalDetails
    //{
    //    public string Name { get; set; }
    //    public string FillColor { get; set; }
    //    public string Category { get; set; }
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591