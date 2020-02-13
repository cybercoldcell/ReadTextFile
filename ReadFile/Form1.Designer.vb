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
        Me.oFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'oFile
        '
        Me.oFile.FileName = "oFile"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(218, 544)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(150, 44)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(24, 23)
        Me.txtString.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtString.Multiline = True
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(756, 489)
        Me.txtString.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(409, 544)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 44)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 612)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnOpen)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As Button
End Class
