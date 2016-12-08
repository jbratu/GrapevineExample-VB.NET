Imports Grapevine.Server
Imports Grapevine.Server.Attributes
Imports Grapevine.Interfaces.Server
Imports ConsoleApplication1.TestResource

Module Module1

    Sub Main()
        Dim server As New RestServer()

        server.LogToConsole().Start()
        Console.ReadLine()
        server.Stop()

    End Sub

End Module
