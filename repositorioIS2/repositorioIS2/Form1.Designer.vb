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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        btnCalculos = New Button()
        Salir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 16F)
        Label1.Location = New Point(49, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(303, 33)
        Label1.TabIndex = 0
        Label1.Text = "Repositorio en GitHub"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 63)
        Label2.TabIndex = 1
        Label2.Text = "Estudiantes:" & vbCrLf & "Ana Díaz" & vbCrLf & "Carlos Robles"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(104, 161)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 51)
        Button1.TabIndex = 2
        Button1.Text = "TicTacToe"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnCalculos
        ' 
        btnCalculos.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculos.Location = New Point(104, 267)
        btnCalculos.Margin = New Padding(3, 4, 3, 4)
        btnCalculos.Name = "btnCalculos"
        btnCalculos.Size = New Size(158, 51)
        btnCalculos.TabIndex = 3
        btnCalculos.Text = "Calculos"
        btnCalculos.UseVisualStyleBackColor = True
        ' 
        ' Salir
        ' 
        Salir.Location = New Point(269, 424)
        Salir.Name = "Salir"
        Salir.Size = New Size(94, 29)
        Salir.TabIndex = 4
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 465)
        Controls.Add(Salir)
        Controls.Add(btnCalculos)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Laboratorio No. 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCalculos As Button
    Friend WithEvents Salir As Button

End Class
