﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        button10 = New Button()
        label_contador_maquina = New Label()
        label_contador_usuario = New Label()
        label4 = New Label()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        button_reiniciar = New Button()
        button7 = New Button()
        button8 = New Button()
        button9 = New Button()
        button4 = New Button()
        button5 = New Button()
        button6 = New Button()
        button3 = New Button()
        button2 = New Button()
        button1 = New Button()
        MenuStrip1 = New MenuStrip()
        SuspendLayout()
        ' 
        ' button10
        ' 
        button10.Location = New Point(143, 287)
        button10.Margin = New Padding(3, 4, 3, 4)
        button10.Name = "button10"
        button10.Size = New Size(86, 31)
        button10.TabIndex = 33
        button10.Text = "Atrás"
        button10.UseVisualStyleBackColor = True
        ' 
        ' label_contador_maquina
        ' 
        label_contador_maquina.AutoSize = True
        label_contador_maquina.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label_contador_maquina.Location = New Point(178, 203)
        label_contador_maquina.Name = "label_contador_maquina"
        label_contador_maquina.Size = New Size(31, 32)
        label_contador_maquina.TabIndex = 32
        label_contador_maquina.Text = "0"
        label_contador_maquina.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label_contador_usuario
        ' 
        label_contador_usuario.AutoSize = True
        label_contador_usuario.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label_contador_usuario.Location = New Point(43, 203)
        label_contador_usuario.Name = "label_contador_usuario"
        label_contador_usuario.Size = New Size(31, 32)
        label_contador_usuario.TabIndex = 31
        label_contador_usuario.Text = "0"
        label_contador_usuario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.BackColor = SystemColors.Control
        label4.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label4.Location = New Point(143, 175)
        label4.Name = "label4"
        label4.Size = New Size(114, 29)
        label4.TabIndex = 30
        label4.Text = "Máquina (0):"
        label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(13, 175)
        label3.Name = "label3"
        label3.Size = New Size(107, 29)
        label3.TabIndex = 29
        label3.Text = "Usuario (X):"
        label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(45, 97)
        label2.Name = "label2"
        label2.Size = New Size(201, 56)
        label2.TabIndex = 28
        label2.Text = "Haz click en una casilla " & vbCrLf & "para hacer tu movimiento"
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(19, 41)
        label1.Name = "label1"
        label1.Size = New Size(246, 39)
        label1.TabIndex = 27
        label1.Text = "!Que empiece el juego!"
        label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' button_reiniciar
        ' 
        button_reiniciar.Location = New Point(24, 287)
        button_reiniciar.Margin = New Padding(3, 4, 3, 4)
        button_reiniciar.Name = "button_reiniciar"
        button_reiniciar.Size = New Size(86, 31)
        button_reiniciar.TabIndex = 26
        button_reiniciar.Text = "Reiniciar"
        button_reiniciar.UseVisualStyleBackColor = True
        ' 
        ' button7
        ' 
        button7.Font = New Font("Verdana", 15.75F)
        button7.Location = New Point(303, 228)
        button7.Margin = New Padding(3, 4, 3, 4)
        button7.Name = "button7"
        button7.Size = New Size(59, 67)
        button7.TabIndex = 25
        button7.UseVisualStyleBackColor = True
        ' 
        ' button8
        ' 
        button8.Font = New Font("Verdana", 15.75F)
        button8.Location = New Point(369, 227)
        button8.Margin = New Padding(3, 4, 3, 4)
        button8.Name = "button8"
        button8.Size = New Size(59, 67)
        button8.TabIndex = 24
        button8.UseVisualStyleBackColor = True
        ' 
        ' button9
        ' 
        button9.Font = New Font("Verdana", 15.75F)
        button9.Location = New Point(435, 227)
        button9.Margin = New Padding(3, 4, 3, 4)
        button9.Name = "button9"
        button9.Size = New Size(59, 67)
        button9.TabIndex = 23
        button9.UseVisualStyleBackColor = True
        ' 
        ' button4
        ' 
        button4.Font = New Font("Verdana", 15.75F)
        button4.Location = New Point(303, 153)
        button4.Margin = New Padding(3, 4, 3, 4)
        button4.Name = "button4"
        button4.Size = New Size(59, 67)
        button4.TabIndex = 22
        button4.UseVisualStyleBackColor = True
        ' 
        ' button5
        ' 
        button5.Font = New Font("Verdana", 15.75F)
        button5.Location = New Point(369, 152)
        button5.Margin = New Padding(3, 4, 3, 4)
        button5.Name = "button5"
        button5.Size = New Size(59, 67)
        button5.TabIndex = 21
        button5.UseVisualStyleBackColor = True
        ' 
        ' button6
        ' 
        button6.Font = New Font("Verdana", 15.75F)
        button6.Location = New Point(435, 152)
        button6.Margin = New Padding(3, 4, 3, 4)
        button6.Name = "button6"
        button6.Size = New Size(59, 67)
        button6.TabIndex = 20
        button6.UseVisualStyleBackColor = True
        ' 
        ' button3
        ' 
        button3.Font = New Font("Verdana", 15.75F)
        button3.Location = New Point(435, 77)
        button3.Margin = New Padding(3, 4, 3, 4)
        button3.Name = "button3"
        button3.Size = New Size(59, 67)
        button3.TabIndex = 19
        button3.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        button2.Font = New Font("Verdana", 15.75F)
        button2.Location = New Point(369, 77)
        button2.Margin = New Padding(3, 4, 3, 4)
        button2.Name = "button2"
        button2.Size = New Size(59, 67)
        button2.TabIndex = 18
        button2.UseVisualStyleBackColor = True
        ' 
        ' button1
        ' 
        button1.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button1.Location = New Point(303, 77)
        button1.Margin = New Padding(3, 4, 3, 4)
        button1.Name = "button1"
        button1.Size = New Size(59, 67)
        button1.TabIndex = 17
        button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(520, 24)
        MenuStrip1.TabIndex = 34
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TicTacToe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 357)
        Controls.Add(button10)
        Controls.Add(label_contador_maquina)
        Controls.Add(label_contador_usuario)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(button_reiniciar)
        Controls.Add(button7)
        Controls.Add(button8)
        Controls.Add(button9)
        Controls.Add(button4)
        Controls.Add(button5)
        Controls.Add(button6)
        Controls.Add(button3)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "TicTacToe"
        Text = "TicTacToe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents button10 As Button
    Private WithEvents label_contador_maquina As Label
    Private WithEvents label_contador_usuario As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button_reiniciar As Button
    Private WithEvents button7 As Button
    Private WithEvents button8 As Button
    Private WithEvents button9 As Button
    Private WithEvents button4 As Button
    Private WithEvents button5 As Button
    Private WithEvents button6 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
