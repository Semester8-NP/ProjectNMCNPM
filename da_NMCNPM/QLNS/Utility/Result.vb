Public Class Result
    Private flag As Boolean
    Private appMessage As String
    Private sysMessage As String

    Public Property FlagResult As Boolean
        Get
            Return flag
        End Get
        Set(value As Boolean)
            flag = value
        End Set
    End Property

    Public Property ApplicationMessage As String
        Get
            Return appMessage
        End Get
        Set(value As String)
            appMessage = value
        End Set
    End Property

    Public Property SystemMessage As String
        Get
            Return sysMessage
        End Get
        Set(value As String)
            sysMessage = value
        End Set
    End Property

    Public Sub New()
        Me.flag = True
        Me.appMessage = String.Empty
        Me.sysMessage = String.Empty
    End Sub
    Public Sub New(flag As Boolean)
        Me.flag = flag
        Me.appMessage = String.Empty
        Me.sysMessage = String.Empty
    End Sub
    Public Sub New(flag As Boolean, appMessage As String, sysMessage As String)
        Me.flag = flag
        Me.appMessage = appMessage
        Me.sysMessage = sysMessage
    End Sub
    Public Sub StackTrace()
        System.Console.WriteLine(flag)
        System.Console.WriteLine(appMessage)
        System.Console.WriteLine(sysMessage)
    End Sub

End Class
