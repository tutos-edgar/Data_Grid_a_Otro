Public Class Form1

    Dim id, nombre As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        DG1.Rows.Add("1", "Maria Fernand Gonzales")
        DG1.Rows.Add("2", "Rodrigo Mendez")
        DG1.Rows.Add("3", "Mario Alexander Martinez")
        DG1.Rows.Add("4", "Fernanda Ramirez")
        DG1.Rows.Add("5", "Jose Roberto Zapon")
        DG1.Rows.Add("6", "Angelica Batz")
    End Sub

    Private Sub btnTransportar_Click(sender As Object, e As EventArgs) Handles btnTransportar.Click
        Try
            If DG1.Rows.Count > 0 Then
                'Dim indice As Integer = DG1.CurrentRow.Index

                For i = 0 To DG1.Rows.Count - 1
                    id = DG1.Rows(i).Cells(0).Value
                    nombre = DG1.Rows(i).Cells(1).Value
                    Form2.DG2.Rows.Add(id, nombre)
                    DG2.Rows.Add(id, nombre)
                Next
            Else
                MessageBox.Show("EL DATA GRID NO TIENEN DATOS")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub btnMover_Click(sender As Object, e As EventArgs) Handles btnMover.Click
        Try
            If DG1.SelectedRows.Count > 0 Then
                Dim indice As Integer = DG1.CurrentRow.Index
                id = DG1.Rows(indice).Cells(0).Value
                nombre = DG1.Rows(indice).Cells(1).Value

                DG2.Rows.Add(id, nombre)
            Else
                MessageBox.Show("FAVOR DE SELECCIONAR UN DATO")
            End If

        Catch ex As Exception

        End Try
    End Sub



End Class
