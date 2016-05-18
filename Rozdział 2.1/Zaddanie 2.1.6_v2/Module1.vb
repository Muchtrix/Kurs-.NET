Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace Zadanie_2._1._6_v1
    Friend Class Program
        Private Shared Sub Main(args As String())
            Dim foo As foo = New foo()
            Dim sluchacz As sluchacz = New sluchacz(foo)
            For i As Integer = 0 To 10 - 1
                Console.WriteLine(foo(i))
            Next
            Dim random As Random = New Random()
            Dim num As Integer = random.[Next]() Mod 3
            If num <> 0 Then
                If num = 1 Then
                    Console.WriteLine(AddressOf foo.Licznik)
                End If
            Else
                foo.przedstaw()
            End If
            Console.ReadKey()
        End Sub
    End Class

    Friend Class foo
        Public Delegate Sub handler(sender As Object)

        Private _licznik As Integer = 0

        <CompilerGenerated()>
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated()>
        Public Event zdarzenie As foo.handler

        Default Public ReadOnly Property Item(x As Integer) As Integer
            Get
                Return x * x
            End Get
        End Property

        Public ReadOnly Property Licznik() As Integer
            Get
                Me.zmianaStanu()
                Dim num As Integer = Me._licznik + 1
                Me._licznik = num
                Return num
            End Get
        End Property

        Public Function przedstaw() As String
            Return String.Format("Hej, jestem {0}", MyBase.[GetType]())
        End Function

        Private Sub zmianaStanu()
            Dim flag As Boolean = Me.zdarzenie IsNot Nothing
            If flag Then
                Me.zdarzenie(Me)
            End If
        End Sub
    End Class

    Friend Class sluchacz
        Public Sub New(x As foo)
            AddHandler AddressOf x.zdarzenie, AddressOf Me.wolaj
        End Sub

        Private Sub wolaj(x As Object)
            Console.WriteLine(String.Format("Obiekt {0} zmieni" & ChrW(322) & " stan.", x.[GetType]()))
        End Sub
    End Class
End Namespace
