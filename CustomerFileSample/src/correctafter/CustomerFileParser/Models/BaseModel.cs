using System.Reflection;
using System.Text;

namespace CustomerFileParser.Models
{
    public abstract class BaseModel
    {
        private PropertyInfo[] _propertyInfos;
        
        public override string ToString()
        {
            if (_propertyInfos == null)
                _propertyInfos = GetType().GetProperties();
            var sb = new StringBuilder();

            foreach (var info in _propertyInfos)
            {
                var value = info.GetValue(this, null) ?? "(null)";
                sb.AppendLine(info.Name + ": " + value);
            }

            return sb.ToString();
        }
    }
}
