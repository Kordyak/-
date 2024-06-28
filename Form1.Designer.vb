<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_stop
        '
        Me.Button_stop.Location = New System.Drawing.Point(303, 135)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(295, 57)
        Me.Button_stop.TabIndex = 0
        Me.Button_stop.Text = "stop"
        Me.Button_stop.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(303, 44)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(295, 57)
        Me.start.TabIndex = 1
        Me.start.Text = "start"
        Me.start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 304)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Button_stop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_stop As Button
    Friend WithEvents start As Button
End Class
