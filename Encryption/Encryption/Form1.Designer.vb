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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtinput = New System.Windows.Forms.RichTextBox()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.txtletter = New System.Windows.Forms.TextBox()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.btnreverse = New System.Windows.Forms.Button()
        Me.txtplain = New System.Windows.Forms.RichTextBox()
        Me.txtpad = New System.Windows.Forms.RichTextBox()
        Me.txtencrypted = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lblcharacter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(6, 7)
        Me.btn1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(70, 45)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Input text"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(115, 7)
        Me.txtinput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(240, 179)
        Me.txtinput.TabIndex = 2
        Me.txtinput.Text = ""
        '
        'lbloutput
        '
        Me.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloutput.Location = New System.Drawing.Point(360, 7)
        Me.lbloutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(239, 178)
        Me.lbloutput.TabIndex = 5
        '
        'txtletter
        '
        Me.txtletter.Location = New System.Drawing.Point(79, 160)
        Me.txtletter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtletter.Name = "txtletter"
        Me.txtletter.Size = New System.Drawing.Size(32, 20)
        Me.txtletter.TabIndex = 6
        '
        'lblcount
        '
        Me.lblcount.Location = New System.Drawing.Point(6, 153)
        Me.lblcount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(70, 33)
        Me.lblcount.TabIndex = 7
        Me.lblcount.Text = "Count this letter"
        Me.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(6, 56)
        Me.Btnclear.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(70, 45)
        Me.Btnclear.TabIndex = 8
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'btnreverse
        '
        Me.btnreverse.Location = New System.Drawing.Point(6, 106)
        Me.btnreverse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreverse.Name = "btnreverse"
        Me.btnreverse.Size = New System.Drawing.Size(70, 45)
        Me.btnreverse.TabIndex = 9
        Me.btnreverse.Text = "Reverse"
        Me.btnreverse.UseVisualStyleBackColor = True
        '
        'txtplain
        '
        Me.txtplain.Location = New System.Drawing.Point(115, 205)
        Me.txtplain.Name = "txtplain"
        Me.txtplain.Size = New System.Drawing.Size(239, 212)
        Me.txtplain.TabIndex = 13
        Me.txtplain.Text = ""
        '
        'txtpad
        '
        Me.txtpad.Location = New System.Drawing.Point(360, 205)
        Me.txtpad.Name = "txtpad"
        Me.txtpad.Size = New System.Drawing.Size(239, 212)
        Me.txtpad.TabIndex = 14
        Me.txtpad.Text = ""
        '
        'txtencrypted
        '
        Me.txtencrypted.Location = New System.Drawing.Point(605, 205)
        Me.txtencrypted.Name = "txtencrypted"
        Me.txtencrypted.Size = New System.Drawing.Size(239, 212)
        Me.txtencrypted.TabIndex = 15
        Me.txtencrypted.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Plain Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "One Time Pad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(602, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Encrypted"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 205)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 98)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Encrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 319)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 98)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Decrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lblcharacter
        '
        Me.Lblcharacter.AutoSize = True
        Me.Lblcharacter.Location = New System.Drawing.Point(438, 420)
        Me.Lblcharacter.Name = "Lblcharacter"
        Me.Lblcharacter.Size = New System.Drawing.Size(110, 13)
        Me.Lblcharacter.TabIndex = 21
        Me.Lblcharacter.Text = "Characters Required: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 446)
        Me.Controls.Add(Me.Lblcharacter)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtencrypted)
        Me.Controls.Add(Me.txtpad)
        Me.Controls.Add(Me.txtplain)
        Me.Controls.Add(Me.btnreverse)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.txtletter)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.btn1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txtinput As RichTextBox
    Friend WithEvents lbloutput As Label
    Friend WithEvents txtletter As TextBox
    Friend WithEvents lblcount As Label
    Friend WithEvents Btnclear As Button
    Friend WithEvents btnreverse As Button
    Friend WithEvents txtplain As RichTextBox
    Friend WithEvents txtpad As RichTextBox
    Friend WithEvents txtencrypted As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Lblcharacter As Label
End Class
