<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnfile = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(119, 11)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(519, 20)
        Me.txtcustomer.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(119, 37)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(519, 20)
        Me.txtname.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(119, 63)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(519, 20)
        Me.txtaddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Street address"
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(119, 89)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(519, 20)
        Me.txtcity.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "City"
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(119, 115)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(519, 20)
        Me.txtphone.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(119, 141)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(519, 20)
        Me.txtemail.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 144)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Email"
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(119, 167)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(518, 263)
        Me.txtnote.TabIndex = 12
        Me.txtnote.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Notes"
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(119, 436)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(248, 36)
        Me.Btnsave.TabIndex = 14
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(389, 436)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(248, 36)
        Me.btnload.TabIndex = 15
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'txtpath
        '
        Me.txtpath.Location = New System.Drawing.Point(119, 478)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(488, 20)
        Me.txtpath.TabIndex = 16
        Me.txtpath.Text = "C:\Users\Public\Documents"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Path"
        '
        'btnfile
        '
        Me.btnfile.Location = New System.Drawing.Point(608, 478)
        Me.btnfile.Name = "btnfile"
        Me.btnfile.Size = New System.Drawing.Size(29, 20)
        Me.btnfile.TabIndex = 18
        Me.btnfile.Text = "..."
        Me.btnfile.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\Users\Public\Documents"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 506)
        Me.Controls.Add(Me.btnfile)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpath)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents txtnote As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btnsave As Button
    Friend WithEvents btnload As Button
    Friend WithEvents txtpath As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnfile As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
