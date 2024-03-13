Imports System.Data.SqlClient

Public Class formClientes
    Private Sub formClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarTabla()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtboxId.Text = "0"
        txtboxNombre.Clear()
        txtboxApellidoP.Clear()
        txtboxApellidoM.Clear()
        txtboxBuscar.Clear()
        txtboxDirec.Clear()
        txtboxTel.Clear()
        txtboxNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtboxNombre.Text.Trim() <> "" AndAlso txtboxApellidoP.Text.Trim() <> "" AndAlso txtboxDirec.Text.Trim() <> "" AndAlso txtboxTel.Text.Trim() <> "" Then
            If txtboxId.Text = "0" Then
                Dim validacion = MessageBox.Show("Registrar a este cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If validacion = vbYes Then
                    registrar("INSERT INTO clientes VALUES ('" & txtboxNombre.Text.ToUpper & "', '" & txtboxApellidoP.Text.ToUpper & "', '" & txtboxApellidoM.Text.ToUpper & "', '" & txtboxTel.Text & "', '" & txtboxDirec.Text.ToUpper & "');")
                    llenarTabla()
                End If
            Else
                Dim validacion = MessageBox.Show("Guardar cambios?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If validacion = vbYes Then
                    actualizar(txtboxNombre.Text.ToUpper, txtboxId.Text.ToUpper, txtboxApellidoP.Text.ToUpper, txtboxApellidoM.Text.ToUpper, txtboxTel.Text.ToUpper, txtboxDirec.Text.ToUpper)
                    llenarTabla()
                End If
            End If
        Else
            MessageBox.Show("Por favor, ingresar la información completa", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub registrar(consulta)
        Dim datosConexion As String = "Data Source=LAPTOP-R2OV9B6E;Initial Catalog=renta_moviliario;User ID=sa;Password=Jovana2001;"

        Using connection As New SqlConnection(datosConexion)
            Try
                connection.Open()
                Using command As New SqlCommand(consulta, connection)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente Registrado Exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Using
            Catch ex As Exception
                Console.WriteLine("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function actualizar(nombre As String, id As String, apellidop As String, apellidom As String, tel As String, direc As String) As Boolean
        Dim datosConexion As String = "Data Source=LAPTOP-R2OV9B6E;Initial Catalog=renta_moviliario;User ID=sa;Password=Jovana2001;"

        Dim consulta As String = "UPDATE clientes SET nombre = '" & nombre & "', apellido_p = '" & apellidop & "',
                                    apellido_m = '" & apellidom & "', telefono = '" & tel & "', direccion = '" & direc & "'
                                    WHERE id = '" & id & "';"

        Using connection As New SqlConnection(datosConexion)
            Using command As New SqlCommand(consulta, connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@IdCliente", id)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Cliente actualizado correctamente.", "Actualizar Cliente", MessageBoxButtons.OK)
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Function

    Private Sub llenarTabla()
        Dim datosConexion As String = "Data Source=LAPTOP-R2OV9B6E;Initial Catalog=renta_moviliario;User ID=sa;Password=Jovana2001;"
        Dim query As String = "SELECT * FROM clientes"
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(datosConexion)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()

                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    gdviewClientes.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error al llenar el DataGridView: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub gdviewClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdviewClientes.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim fila As DataGridViewRow = gdviewClientes.Rows(e.RowIndex)

            txtboxId.Text = fila.Cells("id").Value.ToString()
            txtboxNombre.Text = fila.Cells("nombre").Value.ToString()
            txtboxApellidoP.Text = fila.Cells("apellido_p").Value.ToString()
            txtboxApellidoM.Text = fila.Cells("apellido_m").Value.ToString()
            txtboxDirec.Text = fila.Cells("direccion").Value.ToString()
            txtboxTel.Text = fila.Cells("telefono").Value.ToString()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        gdviewClientes.ClearSelection()
        Dim informacion As String = txtboxBuscar.Text.Trim()

        If informacion <> "" Then
            Dim filaIndex As Integer = gdviewClientes.Rows.Cast(Of DataGridViewRow)().ToList().FindIndex(Function(row) row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value.ToString().ToLower().Contains(informacion.ToLower())))

            If filaIndex >= 0 Then
                gdviewClientes.Rows(filaIndex).Selected = True
                gdviewClientes.FirstDisplayedScrollingRowIndex = filaIndex
            Else
                MessageBox.Show("No se encontraron resultados.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Ingrese un valor para buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtboxTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxTel.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxTel_TextChanged(sender As Object, e As EventArgs) Handles txtboxTel.TextChanged
        If txtboxTel.Text.Length > 10 Then
            txtboxTel.Text = txtboxTel.Text.Substring(0, 10)
            txtboxTel.SelectionStart = txtboxTel.Text.Length
        End If

    End Sub

    Private Sub txtboxNombre_TextChanged(sender As Object, e As EventArgs) Handles txtboxNombre.TextChanged
        If txtboxNombre.Text.Length > 50 Then
            txtboxNombre.Text = txtboxNombre.Text.Substring(0, 50)
            txtboxNombre.SelectionStart = txtboxNombre.Text.Length
        End If
    End Sub

    Private Sub txtboxApellidoP_TextChanged(sender As Object, e As EventArgs) Handles txtboxApellidoP.TextChanged
        If txtboxApellidoP.Text.Length > 20 Then
            txtboxApellidoP.Text = txtboxApellidoP.Text.Substring(0, 20)
            txtboxApellidoP.SelectionStart = txtboxApellidoP.Text.Length
        End If
    End Sub

    Private Sub txtboxApellidoM_TextChanged(sender As Object, e As EventArgs) Handles txtboxApellidoM.TextChanged
        If txtboxApellidoM.Text.Length > 20 Then
            txtboxApellidoM.Text = txtboxApellidoM.Text.Substring(0, 20)
            txtboxApellidoM.SelectionStart = txtboxApellidoM.Text.Length
        End If
    End Sub

    Private Sub txtboxDirec_TextChanged(sender As Object, e As EventArgs) Handles txtboxDirec.TextChanged
        If txtboxDirec.Text.Length > 150 Then
            txtboxDirec.Text = txtboxDirec.Text.Substring(0, 150)
            txtboxDirec.SelectionStart = txtboxDirec.Text.Length
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtboxId.Text = "0" Then
            MessageBox.Show("Seleccione el usuario a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim validacion = MessageBox.Show("Esta seguro de eliminar al cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If validacion = vbYes Then
                eliminar(txtboxId.Text)
                llenarTabla()
                limpiar()
            End If
        End If
    End Sub

    Private Sub eliminar(id As String)
        Dim datosConexion As String = "Data Source=LAPTOP-R2OV9B6E;Initial Catalog=renta_moviliario;User ID=sa;Password=Jovana2001;"

        ' Consulta SQL para eliminar el registro del cliente
        Dim query As String = "DELETE FROM clientes WHERE id = " & id.ToString

        Using connection As New SqlConnection(datosConexion)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@IdCliente", id)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Cliente eliminado correctamente.", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class