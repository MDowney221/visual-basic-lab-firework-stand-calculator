Module Module1

    Sub Main()

        'Declare variables'
        Dim fireworkPrice As Decimal = 0
        Dim totalPrice As Decimal = 0
        Dim fireworkCount As Integer = 1
        'Dim fireworkNumber As Integer = 0

        'Declare discount counstant'
        Const FIREWORKDISCOUNT = 0.1
        Const FIREWORKDISCOUNTMINIMUM = 50.0

        'Gets the user's input
        Console.WriteLine("Welcome to the firework stand. When finished entering prices for your fireworks, please enter -1")
        Do While fireworkPrice <> -1
            Console.Write("Please enter the price of your firework #" & fireworkCount & ": ")
            fireworkPrice = Console.ReadLine()
            If fireworkPrice > FIREWORKDISCOUNTMINIMUM Then
                fireworkPrice = fireworkPrice * (1 - FIREWORKDISCOUNT)
            Else
                fireworkPrice = fireworkPrice
            End If
            If fireworkPrice <> -1 Then
                totalPrice = totalPrice + fireworkPrice
                fireworkCount = fireworkCount + 1
                Console.WriteLine("Firework #" & fireworkCount & " is " & fireworkPrice.ToString("C"))
            Else
                fireworkPrice = fireworkPrice
                fireworkCount = fireworkCount - 1
            End If
        Loop

        Console.WriteLine("You purchased " & fireworkCount & " fireworks.")
        Console.WriteLine("The total cost of your order is " & totalPrice.ToString("C"))

        Console.ReadLine()


    End Sub

End Module
