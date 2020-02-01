#### Control flow

```csharp
  /* ternary operator */
  condition ? true : false

  var hour = 10;

  if (hor > 0 && hour < 12)
  {
    Console.WriteLine("Good Morning")
  }
  else if (hour > 12 && hour < 18)
  {
     Console.WriteLine("Good afternoon")
  }
  else
  {
    Console.WriteLine("Good evening")
  }
```

```csharp
  using System;

  public enum Season
  {
    Spring,
    Summer,
    Autumn,
    Winter
  }

  switch(Season)
  {
    case Season.Spring:
    /* your code here */
    break;

    case Season.Summer:
    /* your code here */
    break;

    case Season.Autumn:
    /* your code here */
    break;

    case Season.Winter:
    /* your code here */
    break;

    default:
    /* your code here */
    break

  }
```

#### Loops

```csharp
const int count = 7;
var list = new int[count] { 1, 2, 3, 4, 5, 6, 7 };
for (var i = 0; i < count; i++)
{
    Console.WriteLine(list[i]);
}
```

```csharp
var list = new int[count] { 1, 2, 3, 4, 5, 6, 7 };
for i in list
{
    Console.WriteLine(list[i]);
}
```
