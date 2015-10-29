<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigCycle
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
        Me.LbHoresFiltre = New System.Windows.Forms.Label()
        Me.NumUDHoresFiltre = New System.Windows.Forms.NumericUpDown()
        Me.BtConfigAndClose = New System.Windows.Forms.Button()
        Me.LabelHores = New System.Windows.Forms.Label()
        Me.BtResetAutoAlarm = New System.Windows.Forms.Button()
        CType(Me.NumUDHoresFiltre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbHoresFiltre
        '
        Me.LbHoresFiltre.AutoSize = True
        Me.LbHoresFiltre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHoresFiltre.Location = New System.Drawing.Point(23, 13)
        Me.LbHoresFiltre.Name = "LbHoresFiltre"
        Me.LbHoresFiltre.Size = New System.Drawing.Size(105, 16)
        Me.LbHoresFiltre.TabIndex = 5
        Me.LbHoresFiltre.Text = "Durada del filtre:"
        '
        'NumUDHoresFiltre
        '
        Me.NumUDHoresFiltre.Location = New System.Drawing.Point(131, 13)
        Me.NumUDHoresFiltre.Name = "NumUDHoresFiltre"
        Me.NumUDHoresFiltre.Size = New System.Drawing.Size(38, 20)
        Me.NumUDHoresFiltre.TabIndex = 6
        '
        'BtConfigAndClose
        '
        Me.BtConfigAndClose.Location = New System.Drawing.Point(25, 58)
        Me.BtConfigAndClose.Name = "BtConfigAndClose"
        Me.BtConfigAndClose.Size = New System.Drawing.Size(100, 30)
        Me.BtConfigAndClose.TabIndex = 32
        Me.BtConfigAndClose.Text = "Configurar"
        Me.BtConfigAndClose.UseVisualStyleBackColor = True
        '
        'LabelHores
        '
        Me.LabelHores.AutoSize = True
        Me.LabelHores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHores.Location = New System.Drawing.Point(177, 20)
        Me.LabelHores.Name = "LabelHores"
        Me.LabelHores.Size = New System.Drawing.Size(54, 13)
        Me.LabelHores.TabIndex = 33
        Me.LabelHores.Text = "(en hores)"
        '
        'BtResetAutoAlarm
        '
        Me.BtResetAutoAlarm.Location = New System.Drawing.Point(131, 58)
        Me.BtResetAutoAlarm.Name = "BtResetAutoAlarm"
        Me.BtResetAutoAlarm.Size = New System.Drawing.Size(100, 30)
        Me.BtResetAutoAlarm.TabIndex = 34
        Me.BtResetAutoAlarm.Text = "Reset"
        Me.BtResetAutoAlarm.UseVisualStyleBackColor = True
        '
        'ConfigCycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 98)
        Me.Controls.Add(Me.BtResetAutoAlarm)
        Me.Controls.Add(Me.LabelHores)
        Me.Controls.Add(Me.BtConfigAndClose)
        Me.Controls.Add(Me.NumUDHoresFiltre)
        Me.Controls.Add(Me.LbHoresFiltre)
        Me.Name = "ConfigCycle"
        Me.Text = "Configuració del cicle"
        CType(Me.NumUDHoresFiltre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbHoresFiltre As System.Windows.Forms.Label
    Friend WithEvents NumUDHoresFiltre As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtConfigAndClose As System.Windows.Forms.Button
    Friend WithEvents LabelHores As System.Windows.Forms.Label
    Friend WithEvents BtResetAutoAlarm As System.Windows.Forms.Button
End Class
