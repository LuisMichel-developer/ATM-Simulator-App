# 📘 ATM Simulator Console App

🎮 A console-based ATM simulator written in C#. The app provides a simple menu where you can check your balance, make deposits, perform withdrawals, and exit the application.

---

## 📦 Technologies Used

- **Language**: C# (.NET 6 / 7 / 8)
- **IDE**: Visual Studio 2022+
- **Type of App**: Console
- **Platform**: Windows / Cross-platform

---

## 🎯 Main Features

- ✅ Check your balance (random starting amount)
- ✅ Simple ATM menu with 4 options
- ✅ Make deposits and withdrawals
- ✅ Exit safely from the application

---

## 🧠 Project Logic

This project uses a combination of `switch` statements, `if-else`, and loops to simulate an ATM interface. The menu repeats until the user selects the **Exit** option. The balance starts as a random number to simulate a real bank account.

Here’s an example of how the **Deposit** feature works:

```csharp
case "2":
    Console.WriteLine($"Your current balance is " + balance);
    Console.WriteLine("Enter amount to deposit: ");
    int depositAmount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You have deposited {depositAmount}");
    balance += depositAmount;
    Console.WriteLine($"Your new balance is {balance}");
    break;
```
---

# 🖥️ Sample Output

plaintext
```
Welcome to the ATM Simulator
Please select an option:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
3
Your current balance is 3887
Enter amount to withdraw:
1500
You have withdrawn $1500
Your new balance is 2387
```

---

## 🏁 How to Run the Project

1. Clone this repository:

   ```
   git clone https://github.com/LuisMichel-developer/ATM-Simulator-App.git
   ```

3. Open the `.sln` file in **Visual Studio**
4. Run the project with `Ctrl + F5`

---

## 🚀 Future Improvements

- [ ] Add PIN authentication for better simulation

- [ ] Improve console UI with clearer formatting and colors

- [ ] Refactor code into separate methods for better readability

- [ ] Add error handling for invalid inputs

---

## 🧑‍💻 Author

- 👤 **Luis Michel**
- 🎓 Software Engineering student
- 📍 Colima, Mexico
- 🌐 [LinkedIn Profile](https://www.linkedin.com/in/luis-michel-dev/)

---

## 📃 License

This project is licensed under the [MIT License](LICENSE).

