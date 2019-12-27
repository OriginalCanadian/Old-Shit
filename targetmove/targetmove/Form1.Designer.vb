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
        Me.components = New System.ComponentModel.Container()
        Me.picbullet = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbullet
        '
        Me.picbullet.BackColor = System.Drawing.Color.Maroon
        Me.picbullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbullet.Location = New System.Drawing.Point(284, 176)
        Me.picbullet.Name = "picbullet"
        Me.picbullet.Size = New System.Drawing.Size(68, 18)
        Me.picbullet.TabIndex = 0
        Me.picbullet.TabStop = False
        '
        'pic1
        '
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Location = New System.Drawing.Point(264, 25)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(118, 67)
        Me.pic1.TabIndex = 1
        Me.pic1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'pic4
        '
        Me.pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic4.Location = New System.Drawing.Point(264, 299)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(118, 67)
        Me.pic4.TabIndex = 2
        Me.pic4.TabStop = False
        '
        'pic2
        '
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic2.Location = New System.Drawing.Point(59, 165)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(118, 67)
        Me.pic2.TabIndex = 3
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic3.Location = New System.Drawing.Point(532, 165)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(118, 67)
        Me.pic3.TabIndex = 4
        Me.pic3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 396)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.picbullet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbullet As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
End Class
