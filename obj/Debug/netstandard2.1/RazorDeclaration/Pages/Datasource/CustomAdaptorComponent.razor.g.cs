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
#line 1 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using static WasmNativeImplementation.Pages.Datasource.SQLData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using System.Data.OleDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    public partial class CustomAdaptorComponent : DataAdaptor<HierarchicalDetails>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Diagram Blazor\GitHub\NativeDiagramWasm\Pages\Datasource\CustomAdaptorComponent.razor"
       
    [Parameter]
    [JsonIgnore]
    public RenderFragment ChildContent { get; set; }
    // Performs data Read operation
    public override object Read(DataManagerRequest dm, string key = null)
    {
        // Connection string and SQL query    
        string path = "Pages/Datasource/Employee.mdb";
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;

        string strSQL = "SELECT * FROM Employees"; DataSet data = new DataSet();
        // Create a connection    
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            // Create a command and set its connection    
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Open the connection and execute the select command.    
            try
            {
                connection.Open();
                // Open connecton    
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    data.Tables.Add(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Orders = ConvertDataTable<HierarchicalDetails>(data.Tables[0]);
        }
        IEnumerable<HierarchicalDetails> DataSource = Orders;
        return (object)DataSource;
    }

    private static List<T> ConvertDataTable<T>(DataTable dt)
    {
        List<T> data = new List<T>();
        foreach (DataRow row in dt.Rows)
        {
            T item = GetItem<T>(row);
            data.Add(item);
        }
        return data;
    }
    private static T GetItem<T>(DataRow dr)
    {
        Type temp = typeof(T);
        T obj = Activator.CreateInstance<T>();

        foreach (DataColumn column in dr.Table.Columns)
        {
            foreach (System.Reflection.PropertyInfo pro in temp.GetProperties())
            {
                if (pro.Name == column.ColumnName)
                    pro.SetValue(obj, dr[column.ColumnName].ToString());
                else
                    continue;
            }
        }
        return obj;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
