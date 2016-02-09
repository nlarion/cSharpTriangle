using Nancy;
using Triangles.Objects;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/shipping"] = _ => {
        Triangle myTriangle = new Triangle(Request.Query["a"],Request.Query["b"],Request.Query["c"]);
        TriangleVariables triangleVariables = new TriangleVariables
        {
          A = myTriangle.GetA(),
          B = myTriangle.GetB(),
          C = myTriangle.GetC(),
          TriangleType = myTriangle.TriangleType()
        };
        return View["output.html", triangleVariables];
      };
    }
  }
}
