Module ModTitoloForm
    ' Metodo per personalizzare il titolo del form
    Public Sub CentraTitolo(ByVal frm As Form, ByVal titolo As String)

        ' Creazione della barra del titolo personalizzata
        Dim pnlTitolo As New Panel()
        Dim lblTitolo As New Label()
        Dim btnChiudi As New Button()
        Dim btnMinimizza As New Button()

        ' Configurazione del Panel (barra del titolo)
        With pnlTitolo
            .Dock = DockStyle.Top
            .Height = 40
            .BackColor = Color.DarkBlue
            .ForeColor = Color.White
            .Cursor = Cursors.Hand
        End With

        ' Configurazione del Label (titolo)
        With lblTitolo
            .Text = titolo  ' Usa il titolo passato come parametro
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Fill
        End With

        ' Configurazione del pulsante Chiudi
        With btnChiudi
            .Text = "X"
            .ForeColor = Color.White
            .BackColor = Color.DarkGreen
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .Size = New Size(40, 40)
            .Dock = DockStyle.Right
            AddHandler .Click, Sub(sender, e) frm.Close()
        End With

        ' Configurazione del pulsante Minimizza
        With btnMinimizza
            .Text = "—"
            .ForeColor = Color.White
            .BackColor = Color.DarkGreen
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .Size = New Size(40, 40)
            .Dock = DockStyle.Right
            AddHandler .Click, Sub(sender, e) frm.WindowState = FormWindowState.Minimized
        End With

        ' Aggiunta dei controlli al panel
        pnlTitolo.Controls.Add(lblTitolo)
        pnlTitolo.Controls.Add(btnMinimizza)
        pnlTitolo.Controls.Add(btnChiudi)


        ' Aggiunta del panel al form
        frm.Controls.Add(pnlTitolo)

        ' Rimozione della barra del titolo standard
        frm.FormBorderStyle = FormBorderStyle.None
    End Sub

End Module
