Public Class home
    Private dataBd As String = "Data Source=TuServidor;Initial Catalog=TuBaseDeDatos;User ID=TuUsuario;Password=TuContraseña;"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles panelPrincipal.Paint

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim formularioClient As New formClientes()
        formularioClient.TopLevel = False
        panelPrincipal.Controls.Add(formularioClient)
        formularioClient.Show()
    End Sub


End Class
