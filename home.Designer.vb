<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Panel1 = New Panel()
        btnSistema = New Button()
        btnUsuarios = New Button()
        btnReportes = New Button()
        btnDevoluciones = New Button()
        btnRenta = New Button()
        btnClientes = New Button()
        btnCatalogo = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        panelPrincipal = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        lblNombreUsuario = New ToolStripStatusLabel()
        lblUsuario = New ToolStripStatusLabel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Panel1.Controls.Add(StatusStrip1)
        Panel1.Controls.Add(btnSistema)
        Panel1.Controls.Add(btnUsuarios)
        Panel1.Controls.Add(btnReportes)
        Panel1.Controls.Add(btnDevoluciones)
        Panel1.Controls.Add(btnRenta)
        Panel1.Controls.Add(btnClientes)
        Panel1.Controls.Add(btnCatalogo)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 518)
        Panel1.TabIndex = 0
        ' 
        ' btnSistema
        ' 
        btnSistema.BackColor = Color.Sienna
        btnSistema.FlatStyle = FlatStyle.Flat
        btnSistema.ForeColor = SystemColors.Control
        btnSistema.Location = New Point(9, 421)
        btnSistema.Name = "btnSistema"
        btnSistema.Size = New Size(182, 35)
        btnSistema.TabIndex = 7
        btnSistema.Text = "Sistema"
        btnSistema.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.Sienna
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.ForeColor = SystemColors.Control
        btnUsuarios.Location = New Point(9, 363)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(182, 35)
        btnUsuarios.TabIndex = 6
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnReportes
        ' 
        btnReportes.BackColor = Color.Sienna
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.ForeColor = SystemColors.Control
        btnReportes.Location = New Point(9, 308)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(182, 35)
        btnReportes.TabIndex = 5
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = False
        ' 
        ' btnDevoluciones
        ' 
        btnDevoluciones.BackColor = Color.Sienna
        btnDevoluciones.FlatStyle = FlatStyle.Flat
        btnDevoluciones.ForeColor = SystemColors.Control
        btnDevoluciones.Location = New Point(9, 252)
        btnDevoluciones.Name = "btnDevoluciones"
        btnDevoluciones.Size = New Size(182, 35)
        btnDevoluciones.TabIndex = 4
        btnDevoluciones.Text = "Devoluciones"
        btnDevoluciones.UseVisualStyleBackColor = False
        ' 
        ' btnRenta
        ' 
        btnRenta.BackColor = Color.Sienna
        btnRenta.FlatStyle = FlatStyle.Flat
        btnRenta.ForeColor = SystemColors.Control
        btnRenta.Location = New Point(9, 197)
        btnRenta.Name = "btnRenta"
        btnRenta.Size = New Size(182, 35)
        btnRenta.TabIndex = 3
        btnRenta.Text = "Renta"
        btnRenta.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.Sienna
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.ForeColor = SystemColors.Control
        btnClientes.Location = New Point(9, 140)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(182, 35)
        btnClientes.TabIndex = 2
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnCatalogo
        ' 
        btnCatalogo.BackColor = Color.Sienna
        btnCatalogo.FlatStyle = FlatStyle.Flat
        btnCatalogo.ForeColor = SystemColors.Control
        btnCatalogo.Location = New Point(9, 83)
        btnCatalogo.Name = "btnCatalogo"
        btnCatalogo.Size = New Size(182, 35)
        btnCatalogo.TabIndex = 1
        btnCatalogo.Text = "Catálogo"
        btnCatalogo.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 30)
        Label1.TabIndex = 0
        Label1.Text = "Renta Moviliario"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 43)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(301, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 30)
        Label2.TabIndex = 8
        Label2.Text = "Renta Moviliario"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panelPrincipal
        ' 
        panelPrincipal.BackColor = Color.Transparent
        panelPrincipal.BackgroundImage = CType(resources.GetObject("panelPrincipal.BackgroundImage"), Image)
        panelPrincipal.BackgroundImageLayout = ImageLayout.Stretch
        panelPrincipal.Dock = DockStyle.Fill
        panelPrincipal.Location = New Point(200, 43)
        panelPrincipal.Name = "panelPrincipal"
        panelPrincipal.Size = New Size(800, 475)
        panelPrincipal.TabIndex = 2
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripSplitButton1, lblNombreUsuario, lblUsuario})
        StatusStrip1.Location = New Point(0, 486)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(200, 32)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(45, 29)
        ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        ' 
        ' lblNombreUsuario
        ' 
        lblNombreUsuario.Name = "lblNombreUsuario"
        lblNombreUsuario.Size = New Size(75, 25)
        lblNombreUsuario.Text = "nombre"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(22, 25)
        lblUsuario.Text = "0"
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1000, 518)
        Controls.Add(panelPrincipal)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "home"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents lblNombreUsuario As ToolStripStatusLabel
    Friend WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents btnRenta As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents btnSistema As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnDevoluciones As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
