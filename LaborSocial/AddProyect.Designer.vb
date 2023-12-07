<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProyect
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
        tbIdProject = New TextBox()
        btnSearch = New Button()
        Label2 = New Label()
        tbName = New TextBox()
        tbEntity = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cbTutor = New ComboBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        tbHours = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        tbPhone = New TextBox()
        Label9 = New Label()
        tbLastname = New TextBox()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label11 = New Label()
        tbCip = New TextBox()
        Label12 = New Label()
        tbGender = New TextBox()
        Label7 = New Label()
        Label13 = New Label()
        cbCareer = New ComboBox()
        Label14 = New Label()
        TextBox2 = New TextBox()
        Label15 = New Label()
        btnAdd = New Button()
        btnClear = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(39, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 21)
        Label1.TabIndex = 1
        Label1.Text = "Id-Proyecto"
        ' 
        ' tbIdProject
        ' 
        tbIdProject.Location = New Point(144, 42)
        tbIdProject.Name = "tbIdProject"
        tbIdProject.Size = New Size(148, 23)
        tbIdProject.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(309, 42)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(39, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 4
        Label2.Text = "Nombre"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(118, 105)
        tbName.Name = "tbName"
        tbName.Size = New Size(377, 23)
        tbName.TabIndex = 5
        ' 
        ' tbEntity
        ' 
        tbEntity.Location = New Point(142, 153)
        tbEntity.Name = "tbEntity"
        tbEntity.Size = New Size(288, 23)
        tbEntity.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(39, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 21)
        Label3.TabIndex = 6
        Label3.Text = "Ente Rector"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(39, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 21)
        Label4.TabIndex = 8
        Label4.Text = "Tutor"
        ' 
        ' cbTutor
        ' 
        cbTutor.DropDownStyle = ComboBoxStyle.DropDownList
        cbTutor.FormattingEnabled = True
        cbTutor.Location = New Point(104, 207)
        cbTutor.Name = "cbTutor"
        cbTutor.Size = New Size(171, 23)
        cbTutor.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(447, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 21)
        Label5.TabIndex = 10
        Label5.Text = "Fecha de Ejecución"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(608, 155)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 11
        ' 
        ' tbHours
        ' 
        tbHours.Location = New Point(602, 199)
        tbHours.Name = "tbHours"
        tbHours.Size = New Size(148, 23)
        tbHours.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(448, 201)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 21)
        Label6.TabIndex = 12
        Label6.Text = "Cantidad de horas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(39, 442)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 26
        Label8.Text = "Género"
        ' 
        ' tbPhone
        ' 
        tbPhone.Location = New Point(137, 401)
        tbPhone.Name = "tbPhone"
        tbPhone.Size = New Size(126, 23)
        tbPhone.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(39, 401)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 21)
        Label9.TabIndex = 24
        Label9.Text = "Teléfono"
        ' 
        ' tbLastname
        ' 
        tbLastname.Location = New Point(137, 359)
        tbLastname.Name = "tbLastname"
        tbLastname.Size = New Size(126, 23)
        tbLastname.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(39, 357)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 21)
        Label10.TabIndex = 22
        Label10.Text = "Apellido"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 321)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(126, 23)
        TextBox1.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(39, 319)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 21)
        Label11.TabIndex = 20
        Label11.Text = "Nombre"
        ' 
        ' tbCip
        ' 
        tbCip.Location = New Point(137, 279)
        tbCip.Name = "tbCip"
        tbCip.Size = New Size(126, 23)
        tbCip.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(39, 279)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 21)
        Label12.TabIndex = 18
        Label12.Text = "Cédula"
        ' 
        ' tbGender
        ' 
        tbGender.Location = New Point(137, 444)
        tbGender.Name = "tbGender"
        tbGender.Size = New Size(126, 23)
        tbGender.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(104, 244)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 21)
        Label7.TabIndex = 32
        Label7.Text = "ESTUDIANTE"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(447, 255)
        Label13.Name = "Label13"
        Label13.Size = New Size(165, 21)
        Label13.TabIndex = 33
        Label13.Text = "Estudiante-Proyecto"
        ' 
        ' cbCareer
        ' 
        cbCareer.DropDownStyle = ComboBoxStyle.DropDownList
        cbCareer.FormattingEnabled = True
        cbCareer.Location = New Point(526, 302)
        cbCareer.Name = "cbCareer"
        cbCareer.Size = New Size(171, 23)
        cbCareer.TabIndex = 35
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(455, 300)
        Label14.Name = "Label14"
        Label14.Size = New Size(65, 21)
        Label14.TabIndex = 34
        Label14.Text = "Carrera"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(567, 332)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(241, 92)
        TextBox2.TabIndex = 37
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(455, 364)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 21)
        Label15.TabIndex = 36
        Label15.Text = "Observación"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(469, 444)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 38
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(567, 444)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 39
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(662, 444)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 23)
        btnReturn.TabIndex = 40
        btnReturn.Text = "Retornar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' AddProyect
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 490)
        Controls.Add(btnReturn)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(TextBox2)
        Controls.Add(Label15)
        Controls.Add(cbCareer)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label7)
        Controls.Add(tbGender)
        Controls.Add(Label8)
        Controls.Add(tbPhone)
        Controls.Add(Label9)
        Controls.Add(tbLastname)
        Controls.Add(Label10)
        Controls.Add(TextBox1)
        Controls.Add(Label11)
        Controls.Add(tbCip)
        Controls.Add(Label12)
        Controls.Add(tbHours)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
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
        Name = "AddProyect"
        Text = "Captura de Información de Proyecto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbIdProject As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbEntity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTutor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbCip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbGender As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbCareer As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReturn As Button
End Class
