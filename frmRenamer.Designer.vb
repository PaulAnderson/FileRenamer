<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenamer
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.chkRemoveExistingExtensions = New System.Windows.Forms.CheckBox()
        Me.chkRenameFilesToNumbers = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectPath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(50, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(490, 20)
        Me.txtPath.TabIndex = 1
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(12, 38)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(174, 23)
        Me.btnRename.TabIndex = 3
        Me.btnRename.Text = "Change extensions of all files to"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(192, 41)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtExtension.TabIndex = 4
        Me.txtExtension.Text = "PNG"
        '
        'chkRemoveExistingExtensions
        '
        Me.chkRemoveExistingExtensions.AutoSize = True
        Me.chkRemoveExistingExtensions.Checked = True
        Me.chkRemoveExistingExtensions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRemoveExistingExtensions.Location = New System.Drawing.Point(192, 67)
        Me.chkRemoveExistingExtensions.Name = "chkRemoveExistingExtensions"
        Me.chkRemoveExistingExtensions.Size = New System.Drawing.Size(157, 17)
        Me.chkRemoveExistingExtensions.TabIndex = 5
        Me.chkRemoveExistingExtensions.Text = "Remove existing extensions"
        Me.chkRemoveExistingExtensions.UseVisualStyleBackColor = True
        '
        'chkRenameFilesToNumbers
        '
        Me.chkRenameFilesToNumbers.AutoSize = True
        Me.chkRenameFilesToNumbers.Checked = True
        Me.chkRenameFilesToNumbers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRenameFilesToNumbers.Location = New System.Drawing.Point(192, 90)
        Me.chkRenameFilesToNumbers.Name = "chkRenameFilesToNumbers"
        Me.chkRenameFilesToNumbers.Size = New System.Drawing.Size(142, 17)
        Me.chkRenameFilesToNumbers.TabIndex = 6
        Me.chkRenameFilesToNumbers.Text = "Rename files to numbers"
        Me.chkRenameFilesToNumbers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path:"
        '
        'btnSelectPath
        '
        Me.btnSelectPath.Location = New System.Drawing.Point(546, 10)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectPath.TabIndex = 2
        Me.btnSelectPath.Text = "Select..."
        Me.btnSelectPath.UseVisualStyleBackColor = True
        '
        'frmRenamer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 116)
        Me.Controls.Add(Me.btnSelectPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRenameFilesToNumbers)
        Me.Controls.Add(Me.chkRemoveExistingExtensions)
        Me.Controls.Add(Me.txtExtension)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.txtPath)
        Me.Name = "frmRenamer"
        Me.Text = "File renamer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents chkRemoveExistingExtensions As System.Windows.Forms.CheckBox
    Friend WithEvents chkRenameFilesToNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectPath As System.Windows.Forms.Button

End Class
