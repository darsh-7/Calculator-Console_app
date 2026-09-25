# Calculator (Console App)

A small C# console calculator (v2.2), from my early days learning C#. It keeps a running total: you enter a number, then keep applying operations to the result until you quit.

## Operations

| Key | Operation |
|-----|-----------|
| `+` `-` `*` `/` | Add, subtract, multiply, divide (asks again if you divide by 0) |
| `%` | Remainder (it works, but it isn't listed in the menu) |
| `^` | Power with a whole-number exponent (loop-based, negative exponents included) |
| `!` | Factorial |
| `r` | Square root (prints √n, but the running total stays unchanged) |
| `c` | Clear, then enter a new number |
| `q` | Quit and print the total |

Bad input is caught, and the app asks you to enter the value again.

## Run

The repo contains only `cal2.2.cs`, with no project file. With the .NET SDK installed:

```bash
dotnet new console -o Calculator
cp cal2.2.cs Calculator/Program.cs
dotnet run --project Calculator
```

---
Author: [Mostafa Ahmed (darsh-7)](https://github.com/darsh-7)
