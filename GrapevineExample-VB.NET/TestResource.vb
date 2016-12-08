Imports Grapevine.Server
Imports Grapevine.Server.Attributes
Imports Grapevine.Interfaces.Server

<RestResource>
Public Class TestResource

    <RestRoute>
    Public Function HelloWorld(ByVal content As IHttpContext) As IHttpContext
        content.Response.SendResponse("Hello World")
        Return content
    End Function

End Class