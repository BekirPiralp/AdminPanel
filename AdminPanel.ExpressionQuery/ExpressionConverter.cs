using System.Linq.Expressions;
using System.Reflection;

namespace AdminPanel.ExpressionQuery
{
    public class ExpressionConverter<T>
        where T : class
    {
        public static async Task<Expression<Func<T, bool>>?> ConvertToSearchAsync(string? searchString, string? removeItemName)
        {
            Expression<Func<T, bool>>? result = null;

            if (searchString != null && searchString.Trim().Length > 0)
            {
                string? query = searchString.ConvertToSearchQuery<T>(removeItemName);
                
                if(query is not null)
                    result = await query.ConvertToExpressionFilterAsync<T>();
            }

            return result;
        }

        public static async Task<Expression<Func<T, object>>?> ConvertToOrderAsync(string? orderPropertyName)
        {
            if (orderPropertyName == null)
                throw new ArgumentNullException(nameof(orderPropertyName));

            Expression<Func<T, object>>? result = null;

            PropertyInfo? property = typeof(T).GetProperties().GetPropertyByName(orderPropertyName);

            if(property is not null)
                result = await property.GetOrderQueryExpressionAsync<T>();

            return result;
        }
    }
}
