

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CentraTitolo(Me, "Gestione Titolo Form al Centro")
            ' Oppure se inserisci il titolo nelle Proprietà del Form
            ' CentraTitolo(Me, Me.Text)

        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento delle immagini: " & ex.Message)
        End Try
    End Sub


End Class
