[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UserInterfaceMVC.MVCGridConfig), "RegisterGrids")]

namespace UserInterfaceMVC
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using System.Linq;
    using System.Collections.Generic;

    using MVCGrid.Models;
    using MVCGrid.Web;
    using EntitiesLayer;

    public static class MVCGridConfig 
    {
        public static void RegisterGrids()
        {
            //.WithAuthorizationType(AuthorizationType.AllowAnonymous)
            MVCGridDefinitionTable.Add("UsageExample", new MVCGridBuilder<Customer>() 
                .AddColumns(cols =>
                { 
                    // Add your columns here

                    cols.Add().WithColumnName("FirstName")
                      .WithHeaderText("FirstName")
                      .WithValueExpression(i => i.FirstName); // use the Value Expression to return the cell text for this column

                    cols.Add().WithColumnName("Email")
                        .WithHeaderText("Email")
                        .WithValueExpression(i => i.Email); // use the Value Expression to return the cell text for this column

                    
                    cols.Add().WithColumnName("LastName")
                       .WithHeaderText("LastName")
                       .WithValueExpression(i => i.LastName); // use the Value Expression to return the cell text for this column

                    cols.Add().WithColumnName("PhoneNumber")
                       .WithHeaderText("PhoneNumber")
                       .WithValueExpression(i => i.PhoneNumber); // use the Value Expression to return the cell text for this column
                     

                    //cols.Add().WithColumnName("UrlExample")
                    //    .WithHeaderText("Edit")
                    //    .WithValueExpression((i, c) => c.UrlHelper.Action("detail", "demo", new { id = i.Id }));
                })
                .WithRetrieveDataMethod((context) =>
                {
                    // Query your data here. Obey Ordering, paging and filtering parameters given in the context.QueryOptions.
                    // Use Entity Framework, a module from your IoC Container, or any other method.
                    // Return QueryResult object containing IEnumerable<YouModelItem>

                    return new QueryResult<Customer>()
                    {
                        Items = new List<Customer>(),
                        TotalRecords = 0 // if paging is enabled, return the total number of records of all pages
                    };

                })
            );
            
        }
    }
}