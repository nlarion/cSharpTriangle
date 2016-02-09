namespace Triangles.Objects
{
  public class TriangleVariables
  {
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public string TriangleType { get; set; }
  }
  public class Triangle
  {
    private int _a;
    private int _b;
    private int _c;

    public Triangle(int a = 0, int b = 0, int c = 0)
    {
      _a = a;
      _b = b;
      _c = c;
    }

    public void SetA(int a)
    {
      _a = a;
    }

    public int GetA()
    {
      return _a;
    }

    public void SetB(int b)
    {
      _b = b;
    }

    public int GetB()
    {
      return _b;
    }

    public void SetC(int c)
    {
      _c = c;
    }

    public int GetC()
    {
      return _c;
    }

    public string TriangleType()
    {
      int a = GetA();
      int b = GetB();
      int c = GetC();

      if(a == b && b == c)
      {
          return "Equllateral";
      }
      else if (a == b || b == c || c == a)
      {
        return "Isosceles";
      }
      else if(a>=b+c || b>=a+c || c>=a+b)
      {
        return "Not a Triangle sucker!";
      }
      else
      {
        return "Scalene";
      }
    }
  }
}
