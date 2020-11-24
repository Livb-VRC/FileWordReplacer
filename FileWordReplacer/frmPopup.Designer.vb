<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopup
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
        Me.lblPopupMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPopupMessage
        '
        Me.lblPopupMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblPopupMessage.Name = "lblPopupMessage"
        Me.lblPopupMessage.Size = New System.Drawing.Size(232, 66)
        Me.lblPopupMessage.TabIndex = 0
        Me.lblPopupMessage.Text = "Placeholder"
        '
        'frmPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 87)
        Me.Controls.Add(Me.lblPopupMessage)
        Me.Name = "frmPopup"
        Me.Text = "Popup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPopupMessage As Label
End Class
