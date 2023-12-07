<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeopleMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        tbCip = New TextBox()
        tbName = New TextBox()
        Label2 = New Label()
        tbLastname = New TextBox()
        Label3 = New Label()
        dgvPeople = New DataGridView()
        tbPhone = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        tbPassword = New TextBox()
        Label6 = New Label()
        btnReturn = New Button()
        btnRefresh = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        CType(dgvPeople, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(33, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 21)
        Label1.TabIndex = 0
        Label1.Text = "Cédula"
        ' 
        ' tbCip
        ' 
        tbCip.Location = New Point(131, 36)
        tbCip.Name = "tbCip"
        tbCip.Size = New Size(126, 23)
        tbCip.TabIndex = 1
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(131, 78)
        tbName.Name = "tbName"
        tbName.Size = New Size(126, 23)
        tbName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(33, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 2
        Label2.Text = "Nombre"
        ' 
        ' tbLastname
        ' 
        tbLastname.Location = New Point(131, 116)
        tbLastname.Name = "tbLastname"
        tbLastname.Size = New Size(126, 23)
        tbLastname.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(33, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 21)
        Label3.TabIndex = 4
        Label3.Text = "Apellido"
        ' 
        ' dgvPeople
        ' 
        dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeople.Location = New Point(33, 280)
        dgvPeople.Name = "dgvPeople"
        dgvPeople.RowTemplate.Height = 25
        dgvPeople.Size = New Size(539, 150)
        dgvPeople.TabIndex = 6
        ' 
        ' tbPhone
        ' 
        tbPhone.Location = New Point(358, 38)
        tbPhone.Name = "tbPhone"
        tbPhone.Size = New Size(126, 23)
        tbPhone.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(279, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 21)
        Label4.TabIndex = 7
        Label4.Text = "Teléfono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(279, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 21)
        Label5.TabIndex = 9
        Label5.Text = "Género"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(358, 82)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(80, 19)
        rbMale.TabIndex = 10
        rbMale.TabStop = True
        rbMale.Text = "Masculino"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(358, 119)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(78, 19)
        rbFemale.TabIndex = 11
        rbFemale.TabStop = True
        rbFemale.Text = "Femenino"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(131, 160)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(126, 23)
        tbPassword.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(33, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 21)
        Label6.TabIndex = 16
        Label6.Text = "Contraseña"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(467, 213)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 33)
        btnReturn.TabIndex = 26
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(361, 213)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(84, 33)
        btnRefresh.TabIndex = 25
        btnRefresh.Text = "Refrescar"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(261, 213)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 33)
        btnSearch.TabIndex = 24
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(158, 213)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 33)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(49, 213)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 33)
        btnSave.TabIndex = 22
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' PeopleMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 560)
        Controls.Add(btnReturn)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(tbPassword)
        Controls.Add(Label6)
        Controls.Add(rbFemale)
        Controls.Add(rbMale)
        Controls.Add(Label5)
        Controls.Add(tbPhone)
        Controls.Add(Label4)
        Controls.Add(dgvPeople)
        Controls.Add(tbLastname)
        Controls.Add(Label3)
        Controls.Add(tbName)
        Controls.Add(Label2)
        Controls.Add(tbCip)
        Controls.Add(Label1)
        Name = "PeopleMaintenance"
        Text = "Mentenimiento de Personas"
        CType(dgvPeople, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbCip As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPeople As DataGridView
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
End Class
