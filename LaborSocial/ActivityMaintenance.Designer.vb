<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityMaintenance
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
        tbHours = New TextBox()
        Label6 = New Label()
        dt = New DateTimePicker()
        Label5 = New Label()
        cbTutor = New ComboBox()
        Label4 = New Label()
        tbEntity = New TextBox()
        Label3 = New Label()
        tbName = New TextBox()
        Label2 = New Label()
        btnSearch = New Button()
        tbIdProject = New TextBox()
        Label1 = New Label()
        dgvActivity = New DataGridView()
        btnReturn = New Button()
        btnRefresh = New Button()
        Button1 = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        tbLocation = New TextBox()
        Label7 = New Label()
        CType(dgvActivity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbHours
        ' 
        tbHours.Location = New Point(584, 193)
        tbHours.Name = "tbHours"
        tbHours.Size = New Size(148, 23)
        tbHours.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(430, 195)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 21)
        Label6.TabIndex = 25
        Label6.Text = "Cantidad de horas"
        ' 
        ' dt
        ' 
        dt.Location = New Point(590, 149)
        dt.Name = "dt"
        dt.Size = New Size(200, 23)
        dt.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(429, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 21)
        Label5.TabIndex = 23
        Label5.Text = "Fecha de Ejecución"
        ' 
        ' cbTutor
        ' 
        cbTutor.DropDownStyle = ComboBoxStyle.DropDownList
        cbTutor.FormattingEnabled = True
        cbTutor.Location = New Point(87, 235)
        cbTutor.Name = "cbTutor"
        cbTutor.Size = New Size(171, 23)
        cbTutor.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(22, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 21)
        Label4.TabIndex = 21
        Label4.Text = "Tutor"
        ' 
        ' tbEntity
        ' 
        tbEntity.Location = New Point(124, 147)
        tbEntity.Name = "tbEntity"
        tbEntity.Size = New Size(288, 23)
        tbEntity.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(21, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 21)
        Label3.TabIndex = 19
        Label3.Text = "Ente Rector"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(100, 99)
        tbName.Name = "tbName"
        tbName.Size = New Size(377, 23)
        tbName.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 17
        Label2.Text = "Nombre"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(291, 36)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 16
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' tbIdProject
        ' 
        tbIdProject.Location = New Point(126, 36)
        tbIdProject.Name = "tbIdProject"
        tbIdProject.Size = New Size(148, 23)
        tbIdProject.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 21)
        Label1.TabIndex = 14
        Label1.Text = "Id-Proyecto"
        ' 
        ' dgvActivity
        ' 
        dgvActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActivity.Location = New Point(12, 323)
        dgvActivity.Name = "dgvActivity"
        dgvActivity.RowTemplate.Height = 25
        dgvActivity.Size = New Size(776, 245)
        dgvActivity.TabIndex = 27
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(557, 273)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 33)
        btnReturn.TabIndex = 32
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(451, 273)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(84, 33)
        btnRefresh.TabIndex = 31
        btnRefresh.Text = "Refrescar"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(351, 273)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 33)
        Button1.TabIndex = 30
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(248, 273)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 33)
        btnDelete.TabIndex = 29
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(139, 273)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 33)
        btnSave.TabIndex = 28
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' tbLocation
        ' 
        tbLocation.Location = New Point(126, 193)
        tbLocation.Name = "tbLocation"
        tbLocation.Size = New Size(288, 23)
        tbLocation.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(23, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 21)
        Label7.TabIndex = 33
        Label7.Text = "Lugar"
        ' 
        ' ActivityMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 603)
        Controls.Add(tbLocation)
        Controls.Add(Label7)
        Controls.Add(btnReturn)
        Controls.Add(btnRefresh)
        Controls.Add(Button1)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(dgvActivity)
        Controls.Add(tbHours)
        Controls.Add(Label6)
        Controls.Add(dt)
        Controls.Add(Label5)
        Controls.Add(cbTutor)
        Controls.Add(Label4)
        Controls.Add(tbEntity)
        Controls.Add(Label3)
        Controls.Add(tbName)
        Controls.Add(Label2)
        Controls.Add(btnSearch)
        Controls.Add(tbIdProject)
        Controls.Add(Label1)
        Name = "ActivityMaintenance"
        Text = "Mantenimiento de Proyecto"
        CType(dgvActivity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTutor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEntity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbIdProject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvActivity As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label7 As Label
End Class
