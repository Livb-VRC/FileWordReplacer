<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.AutoSize = True
        Me.lblInfoTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblInfoTitle.Location = New System.Drawing.Point(269, 30)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(60, 31)
        Me.lblInfoTitle.TabIndex = 0
        Me.lblInfoTitle.Text = "Info"
        Me.lblInfoTitle.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 66)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnExitInfo
        '
        Me.btnExitInfo.Location = New System.Drawing.Point(265, 219)
        Me.btnExitInfo.Name = "btnExitInfo"
        Me.btnExitInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnExitInfo.TabIndex = 2
        Me.btnExitInfo.Text = "Ok"
        Me.btnExitInfo.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 264)
        Me.Controls.Add(Me.btnExitInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfoTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInfo"
        Me.Text = "frmInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExitInfo As Button
End Class
