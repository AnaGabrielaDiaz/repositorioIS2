<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculos
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
        btnCalcular = New Button()
        btnCalcularCosto = New Button()
        Atras = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(142, 177)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(119, 48)
        btnCalcular.TabIndex = 0
        btnCalcular.Text = "Calcular Sueldo"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnCalcularCosto
        ' 
        btnCalcularCosto.Location = New Point(487, 177)
        btnCalcularCosto.Name = "btnCalcularCosto"
        btnCalcularCosto.Size = New Size(141, 48)
        btnCalcularCosto.TabIndex = 1
        btnCalcularCosto.Text = "Calcular Costo"
        btnCalcularCosto.UseVisualStyleBackColor = True
        ' 
        ' Atras
        ' 
        Atras.Location = New Point(322, 324)
        Atras.Name = "Atras"
        Atras.Size = New Size(94, 29)
        Atras.TabIndex = 2
        Atras.Text = "Atras"
        Atras.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(322, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 29)
        Label1.TabIndex = 3
        Label1.Text = "CALCULOS "
        ' 
        ' calculos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Atras)
        Controls.Add(btnCalcularCosto)
        Controls.Add(btnCalcular)
        Name = "calculos"
        Text = "calculos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnCalcularCosto As Button
    Friend WithEvents Atras As Button
    Friend WithEvents Label1 As Label
End Class
