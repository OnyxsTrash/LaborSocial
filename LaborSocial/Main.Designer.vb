<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Button1 = New Button()
        btnCareer = New Button()
        btnFaculty = New Button()
        btnTutor = New Button()
        btnPoeple = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(291, 251)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 37)
        Button1.TabIndex = 13
        Button1.Text = "Mantenimiento  de Proyectos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnCareer
        ' 
        btnCareer.Location = New Point(291, 197)
        btnCareer.Name = "btnCareer"
        btnCareer.Size = New Size(173, 37)
        btnCareer.TabIndex = 12
        btnCareer.Text = "Mantenimiento  de Carreras"
        btnCareer.UseVisualStyleBackColor = True
        ' 
        ' btnFaculty
        ' 
        btnFaculty.Location = New Point(291, 144)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Size = New Size(173, 37)
        btnFaculty.TabIndex = 11
        btnFaculty.Text = "Mantenimiento  de Facultad"
        btnFaculty.UseVisualStyleBackColor = True
        ' 
        ' btnTutor
        ' 
        btnTutor.Location = New Point(291, 92)
        btnTutor.Name = "btnTutor"
        btnTutor.Size = New Size(173, 37)
        btnTutor.TabIndex = 10
        btnTutor.Text = "Mantenimiento  de Tutores"
        btnTutor.UseVisualStyleBackColor = True
        ' 
        ' btnPoeple
        ' 
        btnPoeple.Location = New Point(291, 39)
        btnPoeple.Name = "btnPoeple"
        btnPoeple.Size = New Size(173, 37)
        btnPoeple.TabIndex = 9
        btnPoeple.Text = "Mantenimiento  de Personas"
        btnPoeple.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(825, 335)
        Controls.Add(Button1)
        Controls.Add(btnCareer)
        Controls.Add(btnFaculty)
        Controls.Add(btnTutor)
        Controls.Add(btnPoeple)
        Name = "Main"
        Text = "Menú Principal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnCareer As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnTutor As Button
    Friend WithEvents btnPoeple As Button
End Class
