#### CSharp
* CSharp Basics
  * Process: C# Compile code -> IL (Intermidiate language) -> Native machine code
  Transfering from intermidiate language(IL) to the native machine code is the job of CLR.
  **CLR - Common language Runtime**

  IL is independent of machine that it is running on.

  * .Net framework consists of:
   * CLR
     application sitting in the memory translates IL code into native machine code, it's called JIT (just in time compilation)
     As long as you have CLR you can run CSharp application.


 * Libraries to build applications.


* Architecture:
  * Building blocks - Classes.

    Class - Container has attributes and methods.
    Namespace - container for the related classes.
    Assembly - container for the related namespaces.
    Phisically it is file on the disk, could be EXE or DLL (Dynamicaly Linked Library).

    So when you compile an application the compiler builds one or more aassemblies depending on how you partition.

```csharp
using System;

namespace Hello
{
  class Program
  {
    /* this is application entry point, compiler will look for this
       "Main" case sencetive word */
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

```
Google C# primitive types

```charp
float number = 1.2f
decimal number = 1.2m
```

### Overflowing
```charp
/* Create variable rule */
dataType name = value

byte number = 255
number = number + 1 // 0
```
Because we excided boundary of the data type byte (0-255)

use keyword "checked" to avoid overflowing.

```csharp
checked
{
  byte number = 255;
  number = number + 1;
}
```

```csharp
//Implicit type conversion
int i; (4 bytes size)
byte b = 1; ( 1 byte size)
i = b;

// Explicit type conversion
int i = 1;
byte b = 1;
b = i; //wont compile

byte b = (byte)i //casting; will compile
```

Non-compatible types

```csharp
using System;
/* convert string to int */
string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);
Console.WriteLine("your number is {0}", j)
```
method#Parse may be used to parse data types that non-compatible.

