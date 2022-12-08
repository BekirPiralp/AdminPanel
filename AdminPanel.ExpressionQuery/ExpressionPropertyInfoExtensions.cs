using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Linq.Expressions;
using System.Reflection;

namespace AdminPanel.ExpressionQuery
{
    public static class ExpressionPropertyInfoExtensions
    {
        public static async Task<Expression<Func<T, object>>> GetOrderQueryExpressionAsync <T>(this PropertyInfo propertyInfo)
            where T:class
        {
            if(propertyInfo == null)
                throw new ArgumentNullException(nameof(propertyInfo));

            Expression<Func<T, object>> result;

            var opt = ScriptOptions.Default.AddReferences(typeof(T).Assembly);
            result = await CSharpScript.EvaluateAsync<Expression<Func<T, object>>>($"p=>p.{propertyInfo.Name}", opt);
            return result;
        }
    }
}
