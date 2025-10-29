using System.Web;

namespace PerimeterX.CustomBehavior
{
    public interface ICustomParametersHandler
    {
        CustomParameters Handle(HttpRequest httpRequest);
    }
}

