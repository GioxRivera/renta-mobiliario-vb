<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblDireccion = New Label()
        Label5 = New Label()
        txtboxNombre = New TextBox()
        txtboxDirec = New TextBox()
        txtboxTel = New TextBox()
        txtboxBuscar = New TextBox()
        txtboxId = New TextBox()
        btnSelec = New Button()
        gdviewClientes = New DataGridView()
        txtboxApellidoP = New TextBox()
        Label4 = New Label()
        txtboxApellidoM = New TextBox()
        Label6 = New Label()
        btnNuevo = New FontAwesome.Sharp.IconButton()
        btnGuardar = New FontAwesome.Sharp.IconButton()
        btnEliminar = New FontAwesome.Sharp.IconButton()
        btnBuscar = New FontAwesome.Sharp.IconButton()
        CType(gdviewClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 270)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 25)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 343)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(323, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 2
        Label3.Text = "Nombre"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(343, 368)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(85, 25)
        lblDireccion.TabIndex = 3
        lblDireccion.Text = "Dirección"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(71, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 4
        Label5.Text = "Teléfono"
        ' 
        ' txtboxNombre
        ' 
        txtboxNombre.Location = New Point(422, 264)
        txtboxNombre.Name = "txtboxNombre"
        txtboxNombre.Size = New Size(304, 31)
        txtboxNombre.TabIndex = 5
        ' 
        ' txtboxDirec
        ' 
        txtboxDirec.Location = New Point(434, 365)
        txtboxDirec.Multiline = True
        txtboxDirec.Name = "txtboxDirec"
        txtboxDirec.Size = New Size(292, 51)
        txtboxDirec.TabIndex = 7
        ' 
        ' txtboxTel
        ' 
        txtboxTel.Location = New Point(156, 365)
        txtboxTel.Name = "txtboxTel"
        txtboxTel.Size = New Size(151, 31)
        txtboxTel.TabIndex = 8
        ' 
        ' txtboxBuscar
        ' 
        txtboxBuscar.Location = New Point(45, 24)
        txtboxBuscar.Name = "txtboxBuscar"
        txtboxBuscar.Size = New Size(295, 31)
        txtboxBuscar.TabIndex = 9
        ' 
        ' txtboxId
        ' 
        txtboxId.Enabled = False
        txtboxId.Location = New Point(107, 267)
        txtboxId.Name = "txtboxId"
        txtboxId.Size = New Size(129, 31)
        txtboxId.TabIndex = 10
        txtboxId.Text = "0"
        ' 
        ' btnSelec
        ' 
        btnSelec.Location = New Point(637, 24)
        btnSelec.Name = "btnSelec"
        btnSelec.Size = New Size(112, 34)
        btnSelec.TabIndex = 15
        btnSelec.Text = "Seleccionar"
        btnSelec.UseVisualStyleBackColor = True
        ' 
        ' gdviewClientes
        ' 
        gdviewClientes.BackgroundColor = SystemColors.ButtonFace
        gdviewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gdviewClientes.Location = New Point(45, 64)
        gdviewClientes.Name = "gdviewClientes"
        gdviewClientes.ReadOnly = True
        gdviewClientes.RowHeadersWidth = 62
        gdviewClientes.Size = New Size(704, 179)
        gdviewClientes.TabIndex = 16
        ' 
        ' txtboxApellidoP
        ' 
        txtboxApellidoP.Location = New Point(170, 319)
        txtboxApellidoP.Name = "txtboxApellidoP"
        txtboxApellidoP.Size = New Size(214, 31)
        txtboxApellidoP.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(71, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 17
        Label4.Text = "Apellido P."
        ' 
        ' txtboxApellidoM
        ' 
        txtboxApellidoM.Location = New Point(510, 319)
        txtboxApellidoM.Name = "txtboxApellidoM"
        txtboxApellidoM.Size = New Size(216, 31)
        txtboxApellidoM.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(400, 322)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 25)
        Label6.TabIndex = 19
        Label6.Text = "Apellido M."
        ' 
        ' btnNuevo
        ' 
        btnNuevo.IconChar = FontAwesome.Sharp.IconChar.CirclePlus
        btnNuevo.IconColor = Color.DodgerBlue
        btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNuevo.IconSize = 35
        btnNuevo.ImageAlign = ContentAlignment.TopLeft
        btnNuevo.Location = New Point(244, 427)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(97, 37)
        btnNuevo.TabIndex = 21
        btnNuevo.Text = " Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleRight
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save
        btnGuardar.IconColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnGuardar.IconSize = 35
        btnGuardar.ImageAlign = ContentAlignment.TopLeft
        btnGuardar.Location = New Point(347, 427)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(112, 37)
        btnGuardar.TabIndex = 22
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleRight
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashCan
        btnEliminar.IconColor = Color.Red
        btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnEliminar.IconSize = 30
        btnEliminar.ImageAlign = ContentAlignment.TopLeft
        btnEliminar.Location = New Point(465, 427)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 37)
        btnEliminar.TabIndex = 23
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.MiddleRight
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        btnBuscar.IconColor = Color.RoyalBlue
        btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBuscar.IconSize = 25
        btnBuscar.ImageAlign = ContentAlignment.MiddleLeft
        btnBuscar.Location = New Point(347, 24)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 32)
        btnBuscar.TabIndex = 24
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleRight
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' formClientes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 475)
        Controls.Add(btnBuscar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(txtboxApellidoM)
        Controls.Add(Label6)
        Controls.Add(txtboxApellidoP)
        Controls.Add(Label4)
        Controls.Add(gdviewClientes)
        Controls.Add(btnSelec)
        Controls.Add(txtboxId)
        Controls.Add(txtboxBuscar)
        Controls.Add(txtboxTel)
        Controls.Add(txtboxDirec)
        Controls.Add(txtboxNombre)
        Controls.Add(Label5)
        Controls.Add(lblDireccion)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formClientes"
        CType(gdviewClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxNombre As TextBox
    Friend WithEvents txtboxDirec As TextBox
    Friend WithEvents txtboxTel As TextBox
    Friend WithEvents txtboxBuscar As TextBox
    Friend WithEvents txtboxId As TextBox
    Friend WithEvents btnSelec As Button
    Friend WithEvents gdviewClientes As DataGridView
    Friend WithEvents txtboxApellidoP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxApellidoM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
End Class
