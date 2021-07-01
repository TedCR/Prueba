
Public Class Form1

    Dim estudiantes As New ArrayList()
    Dim CURSOS As New ArrayList()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim estudiante As New Clase_Estudiante
        Dim curso As New Clase_curso

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox1.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            estudiante.Gs_Nombre = TextBox1.ToString
            estudiante.Gs_Nombrecurso = TextBox2.ToString
            estudiante.Gs_Tipo = TextBox3.ToString
            estudiante.Insertar(estudiantes, estudiante)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()

            curso.Gs_Nombre = TextBox4.ToString
            curso.Gs_Profesor = TextBox5.ToString
            curso.Insertar(CURSOS, curso)
            TextBox4.Clear()
            TextBox5.Clear()
            MessageBox.Show("SE ELIMINARON LOS DATOS LOS DATOS")
        Else
            MessageBox.Show("LLENE LOS ESPACIOS CON LOS DATOS")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            TextBox1.Text = estudiantes(0).ToString
        Catch ex As Exception
            MessageBox.Show("NO HAY DATO")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim estudiante As New Clase_Estudiante
        Dim curso As New Clase_curso

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox1.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            estudiante.Eliminar(estudiantes, estudiantes(0))
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            curso.Eliminar(CURSOS, curso)
            TextBox4.Clear()
            TextBox5.Clear()
            MessageBox.Show("SE ELIMINARON LOS DATOS LOS DATOS")
        Else
            MessageBox.Show("LLENE LOS ESPACIOS CON LOS DATOS")
        End If

    End Sub
End Class
