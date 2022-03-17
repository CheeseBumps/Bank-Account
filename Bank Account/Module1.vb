Module Module1

    Sub Main()
        Dim name, nameInput, password, passwordInput, reply As String
        Dim ID, amount, ID_input, chance, deposit, withdraw, total As Integer
        Console.WriteLine("   ************************************This is RichKidsBd Bank Account:************************")
        Console.WriteLine("                                             Enter your name:")
        name = Console.ReadLine
        Console.WriteLine("                                      Hello " & name)
        name = LCase(name)
        Console.WriteLine("                                       How are you today?")
        Console.ReadLine()


        Do
            Console.WriteLine("Enter your ID(5 digit number):")
            ID = Console.ReadLine
            If Len(CStr(ID)) <> 5 Then
                Console.WriteLine("Please enter a 5 digit number!")
            End If
        Loop Until Len(CStr(ID)) = 5

        Console.WriteLine("Enter your age:")
            Dim age As Integer = Console.ReadLine
        If age >= 18 Then
            Do
                Console.WriteLine("Enter a password (min 8 characters)")
                password = Console.ReadLine
                If Len(password) < 8 Then
                    Console.WriteLine("The password is too short!")
                End If
            Loop Until Len(password) > 7

            Do
                Console.WriteLine("Please deposit a minimum of  ₿20,000 to start your account.")
                Console.WriteLine("Deposit=")
                amount = Console.ReadLine
                If amount < 20000 Then
                    Console.WriteLine("Your deposit is too less!")
                End If
            Loop Until amount >= 20000

            Console.WriteLine("Thank you for you deposit!")
            Console.Clear()
            Console.WriteLine("Your bank account is succesfully registered!")
            Console.WriteLine("Now you can login to your account:")

            Do
                Console.WriteLine("Enter your name:")
                nameInput = Console.ReadLine()
                nameInput = LCase(nameInput)
                If nameInput <> name Then
                    Console.WriteLine("The name does not exist.")
                End If
            Loop Until nameInput = name

            Do
                Console.WriteLine("Enter your ID:")
                ID_input = Console.ReadLine()
                If ID_input <> ID Then
                    Console.WriteLine("The ID does not exist!")
                End If
            Loop Until ID_input = ID
            Console.Clear()
            chance = 3
            Do
                Console.WriteLine("Enter your password(you have three chances!):")
                passwordInput = Console.ReadLine()

                If passwordInput <> password Then
                    chance = chance - 1
                    Console.WriteLine("Incorrect password! You have " & chance & "  more remaining chances.")

                End If
            Loop Until passwordInput = password Or chance = 0
            Console.Clear()
            Do
                total = deposit + amount
                If chance > 0 Then
                    Console.WriteLine("Welcome to RichKidsBd Bank !")
                    Console.WriteLine("You have ₿ " & amount & " in your account.")
                    Console.WriteLine("Do you want to deposit money, withdraw money or log out? ")

                    reply = Console.ReadLine
                    reply = LCase(reply)

                    If reply = ("deposit") Then
                        Console.WriteLine("How much do you want to deposit?")
                        deposit = Console.ReadLine
                        total = deposit + amount
                        Console.WriteLine("You have " & "₿" & total & "  remaining in your account.")
                    ElseIf reply = ("withdraw") Then
                        Console.WriteLine("How much do you want to withdraw?")
                        withdraw = Console.ReadLine
                        If withdraw > total Then
                            Console.WriteLine("You don't have that much money in your account!")
                        Else
                            withdraw = amount - withdraw
                            Console.WriteLine("You have " & withdraw & " remaining in your account.")
                        End If
                    End If

                Else
                    Console.WriteLine("Sorry,your account is locked! ")
                End If
            Loop Until reply = "log out"
            Console.WriteLine("Goodbye " & nameInput)
            Console.WriteLine(" Have a nice day!")
        Else
            Console.WriteLine("You are too young to start a bank account! Wait until you turn 18 or restart the app and lie about your age.")
        End If



    End Sub

End Module



