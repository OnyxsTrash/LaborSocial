<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CareerMaintenance
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
        dgvCareers = New DataGridView()
        btnReturn = New Button()
        btnRefresh = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        tbName = New TextBox()
        Label2 = New Label()
        tbCip = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        cbSchools = New ComboBox()
        CType(dgvCareers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCareers
        ' 
        dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCareers.Location = New Point(112, 168)
        dgvCareers.Name = "dgvCareers"
        dgvCareers.RowTemplate.Height = 25
        dgvCareers.Size = New Size(449, 150)
        dgvCareers.TabIndex = 37
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(513, 113)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 33)
        btnReturn.TabIndex = 36
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(407, 113)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(84, 33)
        btnRefresh.TabIndex = 35
        btnRefresh.Text = "Refrescar"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(307, 113)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 33)
        btnSearch.TabIndex = 34
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(204, 113)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 33)
        btnDelete.TabIndex = 33
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(95, 113)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 33)
        btnSave.TabIndex = 32
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(274, 40)
        tbName.Name = "tbName"
        tbName.Size = New Size(126, 23)
        tbName.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(195, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 30
        Label2.Text = "Nombre"
        ' 
        ' tbCip
        ' 
        tbCip.Location = New Point(56, 40)
        tbCip.Name = "tbCip"
        tbCip.Size = New Size(126, 23)
        tbCip.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(25, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 21)
        Label1.TabIndex = 28
        Label1.Text = "Id"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(418, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 21)
        Label3.TabIndex = 38
        Label3.Text = "Facultad"
        ' 
        ' cbSchools
        ' 
        cbSchools.FormattingEnabled = True
        cbSchools.Location = New Point(499, 42)
        cbSchools.Name = "cbSchools"
        cbSchools.Size = New Size(121, 23)
        cbSchools.TabIndex = 39
        ' 
        ' CareerMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(685, 450)
        Controls.Add(cbSchools)
        Controls.Add(Label3)
        Controls.Add(dgvCareers)
        Controls.Add(btnReturn)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(tbName)
        Controls.Add(Label2)
        Controls.Add(tbCip)
        Controls.Add(Label1)
        Name = "CareerMaintenance"
        Text = "Mantenimiento de Carreras"
        CType(dgvCareers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCareers As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSchools As ComboBox
End Class
