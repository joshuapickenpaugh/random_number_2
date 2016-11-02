<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnDidIGuessCorrectly = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(12, 32)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(260, 20)
        Me.txtGuess.TabIndex = 0
        Me.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDidIGuessCorrectly
        '
        Me.btnDidIGuessCorrectly.Location = New System.Drawing.Point(12, 56)
        Me.btnDidIGuessCorrectly.Name = "btnDidIGuessCorrectly"
        Me.btnDidIGuessCorrectly.Size = New System.Drawing.Size(260, 93)
        Me.btnDidIGuessCorrectly.TabIndex = 1
        Me.btnDidIGuessCorrectly.Text = "Did I guess Correctly?"
        Me.btnDidIGuessCorrectly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Guess between 1 and 50:"
        '
        'lblResponse
        '
        Me.lblResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResponse.Location = New System.Drawing.Point(12, 153)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(260, 93)
        Me.lblResponse.TabIndex = 3
        Me.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 260)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDidIGuessCorrectly)
        Me.Controls.Add(Me.txtGuess)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnDidIGuessCorrectly As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResponse As Label
End Class
