<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPrimo = New System.Windows.Forms.Label()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.txtingresar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPrimo
        '
        Me.lblPrimo.AutoSize = True
        Me.lblPrimo.Location = New System.Drawing.Point(12, 47)
        Me.lblPrimo.Name = "lblPrimo"
        Me.lblPrimo.Size = New System.Drawing.Size(39, 13)
        Me.lblPrimo.TabIndex = 0
        Me.lblPrimo.Text = "Label1"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(138, 12)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 1
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'txtingresar
        '
        Me.txtingresar.Location = New System.Drawing.Point(15, 12)
        Me.txtingresar.Name = "txtingresar"
        Me.txtingresar.Size = New System.Drawing.Size(100, 20)
        Me.txtingresar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtingresar)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.lblPrimo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrimo As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents txtingresar As TextBox
End Class
