using System.Reflection;

namespace AdminPanel.ExpressionQuery
{
    public static class ExpressionListPropertyInfoExtension
    {
        public static PropertyInfo? GetPropertyByName(this IEnumerable<PropertyInfo> properties, string propertyName)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            PropertyInfo? result;

            if (propertyName != null && propertyName.Trim().Length > 0)
                result = properties.Where(p => p.Name.ToLower() == propertyName.Trim().ToLower()).FirstOrDefault();
            else
                result = null;

            return result;
        }
    }
}
