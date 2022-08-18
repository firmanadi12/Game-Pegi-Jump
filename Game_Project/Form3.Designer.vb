<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.peggi = New System.Windows.Forms.PictureBox()
        Me.obstacel = New System.Windows.Forms.PictureBox()
        Me.ob1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrjump = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstacle = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.peggi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obstacel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ob1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.peggi)
        Me.Panel1.Controls.Add(Me.obstacel)
        Me.Panel1.Controls.Add(Me.ob1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 358)
        Me.Panel1.TabIndex = 9
        '
        'peggi
        '
        Me.peggi.Image = CType(resources.GetObject("peggi.Image"), System.Drawing.Image)
        Me.peggi.Location = New System.Drawing.Point(147, 270)
        Me.peggi.Name = "peggi"
        Me.peggi.Size = New System.Drawing.Size(73, 88)
        Me.peggi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.peggi.TabIndex = 0
        Me.peggi.TabStop = False
        '
        'obstacel
        '
        Me.obstacel.BackColor = System.Drawing.Color.Transparent
        Me.obstacel.Image = CType(resources.GetObject("obstacel.Image"), System.Drawing.Image)
        Me.obstacel.Location = New System.Drawing.Point(885, 291)
        Me.obstacel.Name = "obstacel"
        Me.obstacel.Size = New System.Drawing.Size(58, 67)
        Me.obstacel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.obstacel.TabIndex = 2
        Me.obstacel.TabStop = False
        '
        'ob1
        '
        Me.ob1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ob1.Location = New System.Drawing.Point(885, 291)
        Me.ob1.Name = "ob1"
        Me.ob1.Size = New System.Drawing.Size(58, 67)
        Me.ob1.TabIndex = 1
        Me.ob1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(171, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 40)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label6.Location = New System.Drawing.Point(22, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 40)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PLAYER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(1058, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 40)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(1060, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 40)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(911, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(911, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 40)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SPEED"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(386, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "---------  PRESS SPACE  --------"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmrjump
        '
        '
        'tmrScore
        '
        '
        'tmrObstacle
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "PRESS ""P"" FOR PAUSED"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1197, 646)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.peggi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obstacel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ob1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents peggi As PictureBox
    Friend WithEvents obstacel As PictureBox
    Friend WithEvents ob1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrjump As Timer
    Friend WithEvents tmrScore As Timer
    Friend WithEvents tmrObstacle As Timer
    Friend WithEvents Label7 As Label
End Class
