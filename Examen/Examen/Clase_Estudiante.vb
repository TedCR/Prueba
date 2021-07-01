Public Class Clase_Estudiante
    Private Nombre As String
    Private Tipo As String
    Private NombreCurso As String

    Public Property Gs_Nombre() As String
        Get
            Return Nombre

        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Gs_Tipo() As String
        Get
            Return Tipo

        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Gs_Nombrecurso() As String
        Get
            Return NombreCurso

        End Get
        Set(value As String)

        End Set
    End Property

    Public Function Insertar(ByVal Lista As ArrayList, ByVal objeto As Object
                             )
        Try
            Lista.Add(objeto)
        Catch ex As Exception
        End Try



    End Function

    Public Function Eliminar(ByVal Lista As ArrayList, ByVal objeto As Object
                            )
        Try
            Lista.Remove(objeto)
        Catch ex As Exception
        End Try



    End Function
    Public Function Actualizar(ByVal Lista As ArrayList, ByVal objeto As Object
                            )
        Try


        Catch ex As Exception
        End Try



    End Function

End Class
