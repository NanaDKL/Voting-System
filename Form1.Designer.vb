<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FormSplash1 = New Voting_System.formSplash()
        Me.FormVerification1 = New Voting_System.formVerification()
        Me.FormManualVerification1 = New Voting_System.formManualVerification()
        Me.SuspendLayout()
        '
        'FormSplash1
        '
        Me.FormSplash1.Location = New System.Drawing.Point(0, 0)
        Me.FormSplash1.Name = "FormSplash1"
        Me.FormSplash1.Size = New System.Drawing.Size(1366, 768)
        Me.FormSplash1.TabIndex = 0
        '
        'FormVerification1
        '
        Me.FormVerification1.Location = New System.Drawing.Point(0, 0)
        Me.FormVerification1.Name = "FormVerification1"
        Me.FormVerification1.Size = New System.Drawing.Size(1366, 768)
        Me.FormVerification1.TabIndex = 1
        '
        'FormManualVerification1
        '
        Me.FormManualVerification1.Location = New System.Drawing.Point(0, 0)
        Me.FormManualVerification1.Name = "FormManualVerification1"
        Me.FormManualVerification1.Size = New System.Drawing.Size(1366, 768)
        Me.FormManualVerification1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.FormVerification1)
        Me.Controls.Add(Me.FormSplash1)
        Me.Controls.Add(Me.FormManualVerification1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSplash1 As formSplash
    Friend WithEvents FormVerification1 As formVerification
    Friend WithEvents FormManualVerification1 As formManualVerification
End Class
