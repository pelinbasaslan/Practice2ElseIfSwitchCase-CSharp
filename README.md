
# Grocery Store Application with If/Else and Switch-Case in C

### Description

This simple console application simulates a grocery store system where the user can select a fruit and get the corresponding price. The application provides the option to choose from five fruits, and based on the selection, it displays the price of that fruit.

### Features
- **Fruit Price Display**: The user is shown the available fruits and their prices.
- **Case Insensitivity**: The user input is normalized to lowercase using `ToLower()` to handle both uppercase and lowercase inputs, so "apple", "Apple", "APPLE" will all be treated the same.
- **Control Structures**: The application demonstrates two popular control structures in C#:
  - **If/Else Statements**: A simple decision-making structure.
  - **Switch-Case Statements**: A more structured way to handle multiple conditions.

### How It Works
1. The user is prompted to enter the name of the fruit they wish to purchase.
2. The input is converted to lowercase using `ToLower()` to ensure that the input is case-insensitive.
3. The application then uses two methods to display the price of the fruit:
   - **If/Else**: This checks each fruit condition one by one.
   - **Switch-Case**: This matches the input with the available fruit cases and displays the price accordingly.

### Code Walkthrough
- **If/Else Implementation**: 
  The application checks for each fruit using a series of `if` and `else if` statements to match the user’s input. This method is simple but can become unwieldy if the number of conditions grows significantly.
  
- **Switch-Case Implementation**:
  The `switch` statement checks the user input against each fruit case, making the code cleaner and more readable, especially when there are many conditions. This is preferred when there are a finite number of known options to check.


### Sample C# Code

Here is a C# implementation of the described problem using both `If/Else` and `Switch-Case` control structures:

```csharp

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uygulama1");
        Console.WriteLine("Rüya manavına hoşgeldiniz.");
        string apple, pear, strawberry, banana, other;
        apple = "Elma";
        pear = "Armut";
        strawberry = "Çilek";
        banana = "Muz";
        other = "Diğer";
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Çilek = 2 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diğer = 4 TL");
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer)");
        string userInput = Console.ReadLine();
        if (userInput != null)
        {
            userInput = userInput.ToLower();
            switch (userInput)
            {
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyve {apple} fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyve {pear} fiyatı 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine($"Seçtiğiniz meyve {strawberry} fiyatı 2 TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyve {banana} fiyatı 3 TL");
                    break;
                case "diğer":
                    Console.WriteLine($"Seçtiğiniz meyve {other} fiyatı 4 TL");
                    break;
                default:
                    Console.WriteLine("Girdiğiniz bilgi yanlıştır.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Girdiğiniz bilgi yanlıştır.");
        }
    }
}
```

### Which Control Structure Is Better?

- **If/Else** is useful when:
  - You have only a few conditions to check.
  - The conditions involve more complex logical expressions (like comparisons or ranges).
  
- **Switch-Case** is preferred when:
  - You have multiple distinct values to check (like in this case with fruit names).
  - It makes the code cleaner and more maintainable, especially when the number of conditions is large.

In this case, **Switch-Case** is more suitable because:
- We are checking exact values (fruit names), making the `switch` statement more efficient and easier to maintain as the number of fruits grows.

### How to Run
1. Clone the repository to your local machine.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the application.
4. The console will prompt you to enter a fruit name, and the application will display the price.

---

### Conclusion
This project demonstrates how to use `If/Else` and `Switch-Case` statements in C# to solve a basic real-world problem. It highlights the strengths and limitations of both control structures and provides a simple example of their usage.

---

### Next Steps
- **Enhance the application**: Add more fruits and prices, or allow the user to purchase multiple fruits.
- **Error Handling**: Add input validation to handle invalid fruit names or other user input errors.

---

### License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
