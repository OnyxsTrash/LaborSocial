<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorMaintenance
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
        tbLastname = New TextBox()
        Label3 = New Label()
        tbName = New TextBox()
        Label2 = New Label()
        tbCip = New TextBox()
        Label1 = New Label()
        btnRefresh = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        dgvTutor = New DataGridView()
        btnReturn = New Button()
        CType(dgvTutor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbLastname
        ' 
        tbLastname.Location = New Point(569, 38)
        tbLastname.Name = "tbLastname"
        tbLastname.Size = New Size(126, 23)
        tbLastname.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(474, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 21)
        Label3.TabIndex = 10
        Label3.Text = "Apellido"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(328, 36)
        tbName.Name = "tbName"
        tbName.Size = New Size(126, 23)
        tbName.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(228, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' tbCip
        ' 
        tbCip.Location = New Point(71, 36)
        tbCip.Name = "tbCip"
        tbCip.Size = New Size(126, 23)
        tbCip.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(22, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 21)
        Label1.TabIndex = 6
        Label1.Text = "Id"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(440, 98)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(84, 33)
        btnRefresh.TabIndex = 19
        btnRefresh.Text = "Refrescar"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(340, 98)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 33)
        btnSearch.TabIndex = 18
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(237, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 33)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(128, 98)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 33)
        btnSave.TabIndex = 16
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dgvTutor
        ' 
        dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTutor.Location = New Point(108, 164)
        dgvTutor.Name = "dgvTutor"
        dgvTutor.RowTemplate.Height = 25
        dgvTutor.Size = New Size(539, 150)
        dgvTutor.TabIndex = 20
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(546, 98)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 33)
        btnReturn.TabIndex = 21
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' TutorMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(724, 450)
        Controls.Add(btnReturn)
        Controls.Add(dgvTutor)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(tbLastname)
        Controls.Add(Label3)
        Controls.Add(tbName)
        Controls.Add(Label2)
        Controls.Add(tbCip)
        Controls.Add(Label1)
        Name = "TutorMaintenance"
        Text = "Mantenimiento de Tutor"
        CType(dgvTutor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbLastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvTutor As DataGridView
    Friend WithEvents btnReturn As Button
End Class
