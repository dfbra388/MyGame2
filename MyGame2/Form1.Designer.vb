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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Astroid1 = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Ground = New System.Windows.Forms.PictureBox()
        Me.LeftSide = New System.Windows.Forms.PictureBox()
        Me.RightSide = New System.Windows.Forms.PictureBox()
        Me.Top = New System.Windows.Forms.PictureBox()
        Me.Win = New System.Windows.Forms.PictureBox()
        Me.Astroid3 = New System.Windows.Forms.PictureBox()
        Me.Astroid2 = New System.Windows.Forms.PictureBox()
        Me.Astroid6 = New System.Windows.Forms.PictureBox()
        Me.Astroid5 = New System.Windows.Forms.PictureBox()
        Me.Astroid4 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Astroid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(231, 362)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Astroid1
        '
        Me.Astroid1.BackColor = System.Drawing.Color.Transparent
        Me.Astroid1.Image = CType(resources.GetObject("Astroid1.Image"), System.Drawing.Image)
        Me.Astroid1.Location = New System.Drawing.Point(618, 162)
        Me.Astroid1.Name = "Astroid1"
        Me.Astroid1.Size = New System.Drawing.Size(129, 82)
        Me.Astroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid1.TabIndex = 1
        Me.Astroid1.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = CType(resources.GetObject("Bullet.Image"), System.Drawing.Image)
        Me.Bullet.Location = New System.Drawing.Point(385, 362)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(90, 50)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 5
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Ground
        '
        Me.Ground.BackColor = System.Drawing.Color.Transparent
        Me.Ground.Location = New System.Drawing.Point(0, 306)
        Me.Ground.Name = "Ground"
        Me.Ground.Size = New System.Drawing.Size(975, 50)
        Me.Ground.TabIndex = 7
        Me.Ground.TabStop = False
        '
        'LeftSide
        '
        Me.LeftSide.BackColor = System.Drawing.Color.Transparent
        Me.LeftSide.Location = New System.Drawing.Point(0, 2)
        Me.LeftSide.Name = "LeftSide"
        Me.LeftSide.Size = New System.Drawing.Size(61, 433)
        Me.LeftSide.TabIndex = 8
        Me.LeftSide.TabStop = False
        '
        'RightSide
        '
        Me.RightSide.BackColor = System.Drawing.Color.Transparent
        Me.RightSide.Location = New System.Drawing.Point(956, 2)
        Me.RightSide.Name = "RightSide"
        Me.RightSide.Size = New System.Drawing.Size(38, 449)
        Me.RightSide.TabIndex = 9
        Me.RightSide.TabStop = False
        '
        'Top
        '
        Me.Top.BackColor = System.Drawing.Color.Transparent
        Me.Top.Location = New System.Drawing.Point(0, 2)
        Me.Top.Name = "Top"
        Me.Top.Size = New System.Drawing.Size(994, 26)
        Me.Top.TabIndex = 10
        Me.Top.TabStop = False
        '
        'Win
        '
        Me.Win.BackColor = System.Drawing.Color.Transparent
        Me.Win.Location = New System.Drawing.Point(850, 364)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(100, 50)
        Me.Win.TabIndex = 11
        Me.Win.TabStop = False
        '
        'Astroid3
        '
        Me.Astroid3.BackColor = System.Drawing.Color.Transparent
        Me.Astroid3.Image = CType(resources.GetObject("Astroid3.Image"), System.Drawing.Image)
        Me.Astroid3.Location = New System.Drawing.Point(818, 162)
        Me.Astroid3.Name = "Astroid3"
        Me.Astroid3.Size = New System.Drawing.Size(97, 59)
        Me.Astroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid3.TabIndex = 12
        Me.Astroid3.TabStop = False
        '
        'Astroid2
        '
        Me.Astroid2.BackColor = System.Drawing.Color.Transparent
        Me.Astroid2.Image = CType(resources.GetObject("Astroid2.Image"), System.Drawing.Image)
        Me.Astroid2.Location = New System.Drawing.Point(364, 181)
        Me.Astroid2.Name = "Astroid2"
        Me.Astroid2.Size = New System.Drawing.Size(66, 40)
        Me.Astroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid2.TabIndex = 13
        Me.Astroid2.TabStop = False
        '
        'Astroid6
        '
        Me.Astroid6.BackColor = System.Drawing.Color.Transparent
        Me.Astroid6.Image = CType(resources.GetObject("Astroid6.Image"), System.Drawing.Image)
        Me.Astroid6.Location = New System.Drawing.Point(205, 49)
        Me.Astroid6.Name = "Astroid6"
        Me.Astroid6.Size = New System.Drawing.Size(170, 108)
        Me.Astroid6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid6.TabIndex = 14
        Me.Astroid6.TabStop = False
        '
        'Astroid5
        '
        Me.Astroid5.BackColor = System.Drawing.Color.Transparent
        Me.Astroid5.Image = CType(resources.GetObject("Astroid5.Image"), System.Drawing.Image)
        Me.Astroid5.Location = New System.Drawing.Point(746, 49)
        Me.Astroid5.Name = "Astroid5"
        Me.Astroid5.Size = New System.Drawing.Size(93, 59)
        Me.Astroid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid5.TabIndex = 15
        Me.Astroid5.TabStop = False
        '
        'Astroid4
        '
        Me.Astroid4.BackColor = System.Drawing.Color.Transparent
        Me.Astroid4.Image = CType(resources.GetObject("Astroid4.Image"), System.Drawing.Image)
        Me.Astroid4.Location = New System.Drawing.Point(466, 49)
        Me.Astroid4.Name = "Astroid4"
        Me.Astroid4.Size = New System.Drawing.Size(168, 101)
        Me.Astroid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Astroid4.TabIndex = 16
        Me.Astroid4.TabStop = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'Timer7
        '
        Me.Timer7.Enabled = True
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.Color.Transparent
        Me.Wall2.Location = New System.Drawing.Point(29, 362)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(32, 60)
        Me.Wall2.TabIndex = 17
        Me.Wall2.TabStop = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.Transparent
        Me.Wall.Location = New System.Drawing.Point(956, 350)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(33, 85)
        Me.Wall.TabIndex = 18
        Me.Wall.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Astroid4)
        Me.Controls.Add(Me.Astroid5)
        Me.Controls.Add(Me.Astroid6)
        Me.Controls.Add(Me.Astroid2)
        Me.Controls.Add(Me.Astroid3)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.Top)
        Me.Controls.Add(Me.RightSide)
        Me.Controls.Add(Me.LeftSide)
        Me.Controls.Add(Me.Ground)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Astroid1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "p"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftSide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightSide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Astroid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Astroid1 As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Ground As PictureBox
    Friend WithEvents LeftSide As PictureBox
    Friend WithEvents RightSide As PictureBox
    Friend WithEvents Top As PictureBox
    Friend WithEvents Win As PictureBox
    Friend WithEvents Astroid3 As PictureBox
    Friend WithEvents Astroid2 As PictureBox
    Friend WithEvents Astroid6 As PictureBox
    Friend WithEvents Astroid5 As PictureBox
    Friend WithEvents Astroid4 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents Wall As PictureBox
End Class
