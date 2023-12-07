<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolManintenance
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
        tbName = New TextBox()
        Label2 = New Label()
        tbCip = New TextBox()
        Label1 = New Label()
        btnReturn = New Button()
        btnRefresh = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        dgvSchool = New DataGridView()
        CType(dgvSchool, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(398, 47)
        tbName.Name = "tbName"
        tbName.Size = New Size(126, 23)
        tbName.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(298, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 12
        Label2.Text = "Nombre"
        ' 
        ' tbCip
        ' 
        tbCip.Location = New Point(141, 47)
        tbCip.Name = "tbCip"
        tbCip.Size = New Size(126, 23)
        tbCip.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(92, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 21)
        Label1.TabIndex = 10
        Label1.Text = "Id"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(493, 108)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 33)
        btnReturn.TabIndex = 26
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(387, 108)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(84, 33)
        btnRefresh.TabIndex = 25
        btnRefresh.Text = "Refrescar"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(287, 108)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 33)
        btnSearch.TabIndex = 24
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(184, 108)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 33)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(75, 108)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 33)
        btnSave.TabIndex = 22
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dgvSchool
        ' 
        dgvSchool.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchool.Location = New Point(92, 163)
        dgvSchool.Name = "dgvSchool"
        dgvSchool.RowTemplate.Height = 25
        dgvSchool.Size = New Size(449, 150)
        dgvSchool.TabIndex = 27
        ' 
        ' SchoolManintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 450)
        Controls.Add(dgvSchool)
        Controls.Add(btnReturn)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(tbName)
        Controls.Add(Label2)
        Controls.Add(tbCip)
        Controls.Add(Label1)
        Name = "SchoolManintenance"
        Text = "Mantenimiento de Facultades"
        CType(dgvSchool, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvSchool As DataGridView
End Class
