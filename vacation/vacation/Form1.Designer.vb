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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn1 = New System.Windows.Forms.RadioButton()
        Me.rbtn2 = New System.Windows.Forms.RadioButton()
        Me.rbtn3 = New System.Windows.Forms.RadioButton()
        Me.Rbtn4 = New System.Windows.Forms.RadioButton()
        Me.rbtn5 = New System.Windows.Forms.RadioButton()
        Me.rbtn6 = New System.Windows.Forms.RadioButton()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.rbtn6)
        Me.GroupBox1.Controls.Add(Me.rbtn5)
        Me.GroupBox1.Controls.Add(Me.Rbtn4)
        Me.GroupBox1.Controls.Add(Me.rbtn3)
        Me.GroupBox1.Controls.Add(Me.rbtn2)
        Me.GroupBox1.Controls.Add(Me.rbtn1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.Location = New System.Drawing.Point(6, 19)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(54, 17)
        Me.rbtn1.TabIndex = 0
        Me.rbtn1.TabStop = True
        Me.rbtn1.Text = "Japan"
        Me.rbtn1.UseVisualStyleBackColor = True
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.Location = New System.Drawing.Point(102, 19)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(57, 17)
        Me.rbtn2.TabIndex = 1
        Me.rbtn2.TabStop = True
        Me.rbtn2.Text = "Russia"
        Me.rbtn2.UseVisualStyleBackColor = True
        '
        'rbtn3
        '
        Me.rbtn3.AutoSize = True
        Me.rbtn3.Location = New System.Drawing.Point(198, 19)
        Me.rbtn3.Name = "rbtn3"
        Me.rbtn3.Size = New System.Drawing.Size(67, 17)
        Me.rbtn3.TabIndex = 2
        Me.rbtn3.TabStop = True
        Me.rbtn3.Text = "Germany"
        Me.rbtn3.UseVisualStyleBackColor = True
        '
        'Rbtn4
        '
        Me.Rbtn4.AutoSize = True
        Me.Rbtn4.Location = New System.Drawing.Point(6, 40)
        Me.Rbtn4.Name = "Rbtn4"
        Me.Rbtn4.Size = New System.Drawing.Size(65, 17)
        Me.Rbtn4.TabIndex = 3
        Me.Rbtn4.TabStop = True
        Me.Rbtn4.Text = "Australia"
        Me.Rbtn4.UseVisualStyleBackColor = True
        '
        'rbtn5
        '
        Me.rbtn5.AutoSize = True
        Me.rbtn5.Location = New System.Drawing.Point(102, 40)
        Me.rbtn5.Name = "rbtn5"
        Me.rbtn5.Size = New System.Drawing.Size(82, 17)
        Me.rbtn5.TabIndex = 4
        Me.rbtn5.TabStop = True
        Me.rbtn5.Text = "North Korea"
        Me.rbtn5.UseVisualStyleBackColor = True
        '
        'rbtn6
        '
        Me.rbtn6.AutoSize = True
        Me.rbtn6.Location = New System.Drawing.Point(198, 40)
        Me.rbtn6.Name = "rbtn6"
        Me.rbtn6.Size = New System.Drawing.Size(58, 17)
        Me.rbtn6.TabIndex = 5
        Me.rbtn6.TabStop = True
        Me.rbtn6.Text = "France"
        Me.rbtn6.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.chk1.Location = New System.Drawing.Point(12, 81)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(100, 33)
        Me.chk1.TabIndex = 1
        Me.chk1.Text = "King Sized Bed"
        Me.chk1.UseVisualStyleBackColor = False
        '
        'chk2
        '
        Me.chk2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.chk2.Location = New System.Drawing.Point(12, 120)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(100, 33)
        Me.chk2.TabIndex = 2
        Me.chk2.Text = "Food Plan"
        Me.chk2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(119, 81)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(185, 72)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = "Calculate"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(10, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price ($):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblprice.Location = New System.Drawing.Point(118, 156)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(186, 23)
        Me.lblprice.TabIndex = 5
        Me.lblprice.Text = "0"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 188)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn6 As RadioButton
    Friend WithEvents rbtn5 As RadioButton
    Friend WithEvents Rbtn4 As RadioButton
    Friend WithEvents rbtn3 As RadioButton
    Friend WithEvents rbtn2 As RadioButton
    Friend WithEvents rbtn1 As RadioButton
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblprice As Label
End Class
