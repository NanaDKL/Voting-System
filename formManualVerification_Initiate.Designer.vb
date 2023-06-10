<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formManualVerification_Initiate
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVerifyID = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtGhanaCardNumber = New Voting_System.WaterMarkTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.loadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.loadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.loadingProgressBar)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnVerifyID)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 768)
        Me.Panel1.TabIndex = 0
        '
        'btnVerifyID
        '
        Me.btnVerifyID.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnVerifyID.FlatAppearance.BorderSize = 0
        Me.btnVerifyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyID.ForeColor = System.Drawing.Color.White
        Me.btnVerifyID.Location = New System.Drawing.Point(140, 399)
        Me.btnVerifyID.Name = "btnVerifyID"
        Me.btnVerifyID.Size = New System.Drawing.Size(233, 45)
        Me.btnVerifyID.TabIndex = 28
        Me.btnVerifyID.Text = "Verify Identity"
        Me.btnVerifyID.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtGhanaCardNumber)
        Me.Panel3.Location = New System.Drawing.Point(140, 350)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 40)
        Me.Panel3.TabIndex = 26
        '
        'txtGhanaCardNumber
        '
        Me.txtGhanaCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGhanaCardNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhanaCardNumber.Location = New System.Drawing.Point(9, 9)
        Me.txtGhanaCardNumber.Name = "txtGhanaCardNumber"
        Me.txtGhanaCardNumber.Size = New System.Drawing.Size(308, 20)
        Me.txtGhanaCardNumber.TabIndex = 0
        Me.txtGhanaCardNumber.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtGhanaCardNumber.WaterMarkText = "Ghana Card Number"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(381, 399)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 45)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'loadingProgressBar
        '
        Me.loadingProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loadingProgressBar.Location = New System.Drawing.Point(0, 763)
        Me.loadingProgressBar.Name = "loadingProgressBar"
        Me.loadingProgressBar.Size = New System.Drawing.Size(598, 5)
        Me.loadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.loadingProgressBar.TabIndex = 30
        '
        'loadingTimer
        '
        '
        'formManualVerification_Initiate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formManualVerification_Initiate"
        Me.Size = New System.Drawing.Size(598, 768)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerifyID As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtGhanaCardNumber As WaterMarkTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents loadingProgressBar As ProgressBar
    Friend WithEvents loadingTimer As Timer
End Class
