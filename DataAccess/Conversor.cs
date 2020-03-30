using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Conversor
    {
        public static T ConvertDictionaryTo<T>(IDictionary<string, object> dictionary) where T : new()
        {
            Type type = typeof(T);
            T ret = new T();


            foreach(var keyValue in dictionary)
            {

                if (!string.IsNullOrWhiteSpace(keyValue.Value.ToString()))
                {
                    //System.Diagnostics.Debug.WriteLine(keyValue.Value.GetType().ToString());

                    object obj = null;
                    switch (Type.GetTypeCode(keyValue.Value.GetType()))
                    {
                        case TypeCode.Int64:
                            obj = keyValue.Value;
                            break;
                        case TypeCode.DateTime:
                            obj = keyValue.Value;
                            break;
                        case TypeCode.String:
                            obj = keyValue.Value.ToString();
                            break;
                        case TypeCode.Decimal:
                            obj = keyValue.Value;
                            break;
                        default:
                            break;
                    }

                    type.GetProperty(keyValue.Key).SetValue(ret, obj, null);

                }
            }
       

            return ret;
        }
    }
}
