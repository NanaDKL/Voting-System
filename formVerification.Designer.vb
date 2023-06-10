<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVerification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVerification))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnManual)
        Me.Panel1.Controls.Add(Me.btnScan)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 768)
        Me.Panel1.TabIndex = 0
        '
        'btnManual
        '
        Me.btnManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnManual.FlatAppearance.BorderSize = 0
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.Color.White
        Me.btnManual.Image = CType(resources.GetObject("btnManual.Image"), System.Drawing.Image)
        Me.btnManual.Location = New System.Drawing.Point(686, 309)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(150, 150)
        Me.btnManual.TabIndex = 7
        Me.btnManual.Text = "Manual"
        Me.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnManual.UseVisualStyleBackColor = False
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnScan.FlatAppearance.BorderSize = 0
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.Color.White
        Me.btnScan.Image = CType(resources.GetObject("btnScan.Image"), System.Drawing.Image)
        Me.btnScan.Location = New System.Drawing.Point(530, 309)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(150, 150)
        Me.btnScan.TabIndex = 6
        Me.btnScan.Text = "Scan"
        Me.btnScan.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'formVerification
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formVerification"
        Me.Size = New System.Drawing.Size(1366, 768)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManual As Button
    Friend WithEvents btnScan As Button
End Class
