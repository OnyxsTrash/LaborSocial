<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        tbUsername = New TextBox()
        btnLogin = New Button()
        btnClear = New Button()
        btnExit = New Button()
        tbPassword = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(247, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(359, 25)
        Label3.TabIndex = 3
        Label3.Text = "Programa de Labor Social Universitaria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(286, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(270, 25)
        Label2.TabIndex = 2
        Label2.Text = "Centro Regional de Veraguas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(248, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 25)
        Label1.TabIndex = 1
        Label1.Text = "Universidad Tecnológica  de Panamá"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(260, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 17)
        Label4.TabIndex = 4
        Label4.Text = "Usuario:"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(351, 217)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(100, 23)
        tbUsername.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(481, 201)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Ingresar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(481, 230)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 7
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(481, 271)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 8
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(351, 256)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(100, 23)
        tbPassword.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(260, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 17)
        Label5.TabIndex = 9
        Label5.Text = "Contraseña:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 359)
        Controls.Add(tbPassword)
        Controls.Add(Label5)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnLogin)
        Controls.Add(tbUsername)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Ingreso"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label5 As Label
End Class
