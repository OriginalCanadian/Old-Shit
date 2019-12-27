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
        Me.components = New System.ComponentModel.Container()
        Me.picgun = New System.Windows.Forms.PictureBox()
        Me.picbullet = New System.Windows.Forms.PictureBox()
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrfollow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrfire = New System.Windows.Forms.Timer(Me.components)
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.tmrcollide = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.tmrtarget = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picgun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picgun
        '
        Me.picgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picgun.Location = New System.Drawing.Point(564, 462)
        Me.picgun.Name = "picgun"
        Me.picgun.Size = New System.Drawing.Size(120, 61)
        Me.picgun.TabIndex = 0
        Me.picgun.TabStop = False
        '
        'picbullet
        '
        Me.picbullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbullet.Location = New System.Drawing.Point(614, 440)
        Me.picbullet.Name = "picbullet"
        Me.picbullet.Size = New System.Drawing.Size(15, 16)
        Me.picbullet.TabIndex = 1
        Me.picbullet.TabStop = False
        '
        'tmrleft
        '
        Me.tmrleft.Interval = 1
        '
        'tmrright
        '
        Me.tmrright.Interval = 1
        '
        'tmrfollow
        '
        Me.tmrfollow.Enabled = True
        Me.tmrfollow.Interval = 1
        '
        'tmrfire
        '
        Me.tmrfire.Interval = 1
        '
        'pic4
        '
        Me.pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic4.Location = New System.Drawing.Point(248, 80)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(120, 61)
        Me.pic4.TabIndex = 2
        Me.pic4.TabStop = False
        '
        'tmrcollide
        '
        Me.tmrcollide.Enabled = True
        Me.tmrcollide.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score: "
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Location = New System.Drawing.Point(46, 9)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(13, 13)
        Me.lblscore.TabIndex = 4
        Me.lblscore.Text = "0"
        '
        'pic1
        '
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Location = New System.Drawing.Point(736, 170)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(120, 61)
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic2.Location = New System.Drawing.Point(343, 282)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(120, 61)
        Me.pic2.TabIndex = 6
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic3.Location = New System.Drawing.Point(792, 15)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(120, 61)
        Me.pic3.TabIndex = 7
        Me.pic3.TabStop = False
        '
        'tmrtarget
        '
        Me.tmrtarget.Enabled = True
        Me.tmrtarget.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 535)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.picbullet)
        Me.Controls.Add(Me.picgun)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picgun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picgun As PictureBox
    Friend WithEvents picbullet As PictureBox
    Friend WithEvents tmrleft As Timer
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrfollow As Timer
    Friend WithEvents tmrfire As Timer
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents tmrcollide As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents tmrtarget As Timer
End Class
