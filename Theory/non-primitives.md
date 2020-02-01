#### Non-primitive types

Class  is the blueprint
Object is an instance of blueprint

```csharp
/* make it accessible with public keyword */
public class Person
{
  public string Name;

  public void Introduce()
  {
    Console.WriteLine("hi my name is ", Name);
  }
}
int number;
var person = new Person();
person.Name = "Deniss";
person.Introduce();

```

```csharp
public class Calculator
{
  public static int Add(int a, int b)
  {
    return a + b;
  }
}
/* we do not need to create object to call method#Add, as it is defined as static.
*/
Calculator.Add(1, 4);
```

#### Declaring Struct

```csharp
public struct RgbColor
{
  public int Red;
  public int Green;
  public int Blue;
}
```

#### Declaring Arrays

```csharp

int[] numbers = new int[3] {1,2,3,4};
/* same as notation, just shorter */
numbers[0] = 1
numbers[1] = 2
...
```
#### Strings
Strings are immutable, you can read them but can not modify.

```csharp
var firstName = "James";
var lastName = "Hawks";
string name = string.Format("{0} {1}", firstName, lastName);

var numbers = new int[3] {1,2,3};
string list = string.Join(",", numbers);

string path = "c:\\projects\\project1\\folder1";

/* verbatim string */
string path = @"c:\project\project1\folder1";
```

#### Enums

```csharp
 public enum ShippingMethod : byte /* optional define with custom type,
 default value is int */
 {
   RegularAirMail = 1,
   RegisteredAirMail = 2,
   Express = 3;
 }
 var method = ShippingMethod.Express
 var methodId = 3;

 Console.WriteLine((ShippingMethod)methodId); //Express
 var methodName = "Express";
 var s = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
 Console.WriteLine("shippingMethod id is {0}", (int)s);
```


Value types (values copied)
 - Structures
 * Allocated on stack
 * Memory allocation done automatically
 * Immediately remove when out of scope

 ```csharp
    var a = 10;
    var b = a;
    b++
    Console.WriteLine("a: {0}, b: {1}", a, b);//a = 10, b = 11
 ```

Example: Int

Reference Types
- Classes
* You need to allocate memory
* Memory allocated on heap
* Garbage collected by CLR

Example: new

```csharp
  var array1 = new int[3] { 1, 3, 5}
  var array2 = array1;
  array2[0] = 0
  Console.WriteLine("array1[0]: {0}, array2[0], {1}", array1[0], array2[0]);
```