<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formManualVerification
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FormManualVerification_Doodle1 = New Voting_System.formManualVerification_Doodle()
        Me.FormManualVerification_Results1 = New Voting_System.formManualVerification_Results()
        Me.FormManualVerification_Initiate1 = New Voting_System.formManualVerification_Initiate()
        Me.FormManualVerification_Error1 = New Voting_System.formManualVerification_Error()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FormManualVerification_Error1)
        Me.Panel1.Controls.Add(Me.FormManualVerification_Doodle1)
        Me.Panel1.Controls.Add(Me.FormManualVerification_Results1)
        Me.Panel1.Controls.Add(Me.FormManualVerification_Initiate1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 768)
        Me.Panel1.TabIndex = 0
        '
        'FormManualVerification_Doodle1
        '
        Me.FormManualVerification_Doodle1.Location = New System.Drawing.Point(598, 0)
        Me.FormManualVerification_Doodle1.Name = "FormManualVerification_Doodle1"
        Me.FormManualVerification_Doodle1.Size = New System.Drawing.Size(768, 768)
        Me.FormManualVerification_Doodle1.TabIndex = 3
        '
        'FormManualVerification_Results1
        '
        Me.FormManualVerification_Results1.Location = New System.Drawing.Point(598, 0)
        Me.FormManualVerification_Results1.Name = "FormManualVerification_Results1"
        Me.FormManualVerification_Results1.Size = New System.Drawing.Size(768, 768)
        Me.FormManualVerification_Results1.TabIndex = 2
        '
        'FormManualVerification_Initiate1
        '
        Me.FormManualVerification_Initiate1.Location = New System.Drawing.Point(0, 0)
        Me.FormManualVerification_Initiate1.Name = "FormManualVerification_Initiate1"
        Me.FormManualVerification_Initiate1.Size = New System.Drawing.Size(598, 768)
        Me.FormManualVerification_Initiate1.TabIndex = 1
        '
        'FormManualVerification_Error1
        '
        Me.FormManualVerification_Error1.Location = New System.Drawing.Point(598, 0)
        Me.FormManualVerification_Error1.Name = "FormManualVerification_Error1"
        Me.FormManualVerification_Error1.Size = New System.Drawing.Size(768, 768)
        Me.FormManualVerification_Error1.TabIndex = 4
        '
        'formManualVerification
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formManualVerification"
        Me.Size = New System.Drawing.Size(1366, 768)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FormManualVerification_Results1 As formManualVerification_Results
    Friend WithEvents FormManualVerification_Initiate1 As formManualVerification_Initiate
    Friend WithEvents FormManualVerification_Doodle1 As formManualVerification_Doodle
    Friend WithEvents FormManualVerification_Error1 As formManualVerification_Error
End Class
