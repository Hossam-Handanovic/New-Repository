<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageOfTime
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
        Me.lblTimeMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTimeMessage
        '
        Me.lblTimeMessage.Font = New System.Drawing.Font("Leelawadee UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeMessage.Location = New System.Drawing.Point(-2, 0)
        Me.lblTimeMessage.Name = "lblTimeMessage"
        Me.lblTimeMessage.Size = New System.Drawing.Size(324, 160)
        Me.lblTimeMessage.TabIndex = 0
        Me.lblTimeMessage.Text = " "
        Me.lblTimeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMessageOfTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTimeMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessageOfTime"
        Me.Text = "frmMessageOfTime"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTimeMessage As Label
End Class
