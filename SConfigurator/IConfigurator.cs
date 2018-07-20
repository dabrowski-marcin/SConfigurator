using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace SConfigurator
{
    public interface IConfigurator
    {
        T Get<T>();
    }
}