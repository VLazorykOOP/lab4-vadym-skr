namespace pro100user;

public class ATriangle
{
 private int a;
 private int b;
 private int color;

 public ATriangle(int a, int b, int color)
 { 
  this.a = a;
  this.b = b;
  this.color = color;
 }

 public int this[int i]
 {
  get
  {
   switch (i)
   {
    case 0: return a;
    case 1: return b;
    case 3: return color;
    default: throw new Exception("Неприпустиме значення індексу");
   }
  }
 }

 public static ATriangle operator +(ATriangle aTriangle) =>
  new ATriangle(++aTriangle.a, ++aTriangle.b, aTriangle.color);

 public static ATriangle operator -(ATriangle aTriangle) =>
  new ATriangle(--aTriangle.a, --aTriangle.b, aTriangle.color);


 public static bool operator true(ATriangle aTriangle)
 {
  return true;
 }

 public static bool operator false(ATriangle aTriangle)
 {
  return false;
 }

 public static ATriangle operator *(ATriangle first, int scalar) =>
  new ATriangle(first.a * scalar, first.b * scalar, first.color);
}