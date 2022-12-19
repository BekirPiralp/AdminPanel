using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Linq.Expressions;
using System.Reflection;

namespace AdminPanel.ExpressionQuery
{
    public static class ExpressionQueryStringExtensions
        
    {
        public static string? ConvertToSearchQuery<T>(this string searchText,params string[]? removeItemsName)
        {
            if(searchText == null || searchText.Trim().Length<=0)
                throw new ArgumentNullException(nameof(searchText));

            Type type = typeof(T);
            IEnumerable<PropertyInfo> properties = type.GetRuntimeProperties();

            if(removeItemsName != null && removeItemsName.Length > 0)
                foreach (var removeItemName in removeItemsName)
                {
                    if (removeItemName.Trim().Length > 0)
                        properties = properties.Where(i => i.Name.ToLower() != removeItemName.ToLower());
                }



            string? result = null;

            if (properties != null && properties.Count() > 0)
            {
                result = "p => ";
                char karakter = '"';
                foreach (var property in properties)
                { 
                    if(property.PropertyType == typeof(string))
                        result += "p." + property.Name + ".ToLower().TrimStart().TrimEnd().Contains(" + karakter + searchText.TrimStart().TrimEnd().ToLower() + karakter + ") ||";
                    else
                        result += "p." + property.Name + ".ToString().ToLower().TrimStart().TrimEnd().Contains(" + karakter + searchText.TrimStart().TrimEnd().ToLower() + karakter + ") ||";
                }
                result = result.Substring(0, result.Length - 2); // en son daki ya da karakteri kaldırılıyor.
            }

            return result;

        }

        public async static Task<Expression<Func<T,bool>>?> ConvertToExpressionFilterAsync<T>(this string filterText)
            where T : class
        {
            if(filterText == null || filterText.Trim().Length<=0)
                throw new ArgumentNullException(nameof(filterText));
            Expression<Func<T, bool>>? result;
            
            var opt = ScriptOptions.Default.AddReferences(typeof(T).Assembly);
            result = await CSharpScript.EvaluateAsync<Expression<Func<T, bool>>?>(filterText, opt);

            return result;
        }
    }
}