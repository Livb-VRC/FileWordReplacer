<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.txtFolderPath = New System.Windows.Forms.TextBox()
        Me.lblFolderPath = New System.Windows.Forms.Label()
        Me.btnFolderPath = New System.Windows.Forms.Button()
        Me.fbdSelectFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDestinationPath = New System.Windows.Forms.Button()
        Me.lblDestinationPath = New System.Windows.Forms.Label()
        Me.txtDestinationPath = New System.Windows.Forms.TextBox()
        Me.lblWordsToReplace = New System.Windows.Forms.Label()
        Me.btnCopyAndConvert = New System.Windows.Forms.Button()
        Me.lbWords = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtReplacement = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblReplacement = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblRemove = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(100, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Word replacer"
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(310, 12)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'txtFolderPath
        '
        Me.txtFolderPath.Location = New System.Drawing.Point(124, 67)
        Me.txtFolderPath.Name = "txtFolderPath"
        Me.txtFolderPath.Size = New System.Drawing.Size(140, 20)
        Me.txtFolderPath.TabIndex = 2
        '
        'lblFolderPath
        '
        Me.lblFolderPath.AutoSize = True
        Me.lblFolderPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFolderPath.Location = New System.Drawing.Point(58, 70)
        Me.lblFolderPath.Name = "lblFolderPath"
        Me.lblFolderPath.Size = New System.Drawing.Size(60, 13)
        Me.lblFolderPath.TabIndex = 3
        Me.lblFolderPath.Text = "Folder path"
        Me.lblFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFolderPath
        '
        Me.btnFolderPath.Location = New System.Drawing.Point(286, 64)
        Me.btnFolderPath.Name = "btnFolderPath"
        Me.btnFolderPath.Size = New System.Drawing.Size(75, 23)
        Me.btnFolderPath.TabIndex = 4
        Me.btnFolderPath.Text = "Select"
        Me.btnFolderPath.UseVisualStyleBackColor = True
        '
        'btnDestinationPath
        '
        Me.btnDestinationPath.Location = New System.Drawing.Point(286, 101)
        Me.btnDestinationPath.Name = "btnDestinationPath"
        Me.btnDestinationPath.Size = New System.Drawing.Size(75, 23)
        Me.btnDestinationPath.TabIndex = 7
        Me.btnDestinationPath.Text = "Select"
        Me.btnDestinationPath.UseVisualStyleBackColor = True
        '
        'lblDestinationPath
        '
        Me.lblDestinationPath.AutoSize = True
        Me.lblDestinationPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDestinationPath.Location = New System.Drawing.Point(34, 106)
        Me.lblDestinationPath.Name = "lblDestinationPath"
        Me.lblDestinationPath.Size = New System.Drawing.Size(84, 13)
        Me.lblDestinationPath.TabIndex = 6
        Me.lblDestinationPath.Text = "Destination path"
        Me.lblDestinationPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.Location = New System.Drawing.Point(124, 103)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(140, 20)
        Me.txtDestinationPath.TabIndex = 5
        '
        'lblWordsToReplace
        '
        Me.lblWordsToReplace.AutoSize = True
        Me.lblWordsToReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblWordsToReplace.Location = New System.Drawing.Point(30, 150)
        Me.lblWordsToReplace.Name = "lblWordsToReplace"
        Me.lblWordsToReplace.Size = New System.Drawing.Size(88, 13)
        Me.lblWordsToReplace.TabIndex = 8
        Me.lblWordsToReplace.Text = "Words to replace"
        Me.lblWordsToReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCopyAndConvert
        '
        Me.btnCopyAndConvert.Location = New System.Drawing.Point(106, 433)
        Me.btnCopyAndConvert.Name = "btnCopyAndConvert"
        Me.btnCopyAndConvert.Size = New System.Drawing.Size(177, 58)
        Me.btnCopyAndConvert.TabIndex = 10
        Me.btnCopyAndConvert.Text = "Copy and convert"
        Me.btnCopyAndConvert.UseVisualStyleBackColor = True
        '
        'lbWords
        '
        Me.lbWords.FormattingEnabled = True
        Me.lbWords.Location = New System.Drawing.Point(124, 184)
        Me.lbWords.Name = "lbWords"
        Me.lbWords.Size = New System.Drawing.Size(237, 173)
        Me.lbWords.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(286, 144)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtReplacement
        '
        Me.txtReplacement.Location = New System.Drawing.Point(197, 147)
        Me.txtReplacement.MaxLength = 150
        Me.txtReplacement.Name = "txtReplacement"
        Me.txtReplacement.Size = New System.Drawing.Size(67, 20)
        Me.txtReplacement.TabIndex = 15
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(124, 147)
        Me.txtWord.MaxLength = 150
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(67, 20)
        Me.txtWord.TabIndex = 14
        '
        'lblReplacement
        '
        Me.lblReplacement.AutoSize = True
        Me.lblReplacement.Location = New System.Drawing.Point(194, 129)
        Me.lblReplacement.Name = "lblReplacement"
        Me.lblReplacement.Size = New System.Drawing.Size(70, 13)
        Me.lblReplacement.TabIndex = 13
        Me.lblReplacement.Text = "Replacement"
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(137, 131)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(33, 13)
        Me.lblWord.TabIndex = 12
        Me.lblWord.Text = "Word"
        '
        'lblRemove
        '
        Me.lblRemove.AutoSize = True
        Me.lblRemove.Location = New System.Drawing.Point(164, 368)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(116, 13)
        Me.lblRemove.TabIndex = 18
        Me.lblRemove.Text = "Select word to remove:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(286, 363)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 527)
        Me.Controls.Add(Me.lblRemove)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtReplacement)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblReplacement)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lbWords)
        Me.Controls.Add(Me.btnCopyAndConvert)
        Me.Controls.Add(Me.lblWordsToReplace)
        Me.Controls.Add(Me.btnDestinationPath)
        Me.Controls.Add(Me.lblDestinationPath)
        Me.Controls.Add(Me.txtDestinationPath)
        Me.Controls.Add(Me.btnFolderPath)
        Me.Controls.Add(Me.lblFolderPath)
        Me.Controls.Add(Me.txtFolderPath)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Word replacer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents lblFolderPath As Label
    Friend WithEvents btnFolderPath As Button
    Friend WithEvents fbdSelectFolder As FolderBrowserDialog
    Friend WithEvents btnDestinationPath As Button
    Friend WithEvents lblDestinationPath As Label
    Friend WithEvents txtDestinationPath As TextBox
    Private WithEvents lblWordsToReplace As Label
    Friend WithEvents btnCopyAndConvert As Button
    Friend WithEvents lbWords As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtReplacement As TextBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents lblReplacement As Label
    Friend WithEvents lblWord As Label
    Friend WithEvents lblRemove As Label
    Friend WithEvents btnRemove As Button
End Class
