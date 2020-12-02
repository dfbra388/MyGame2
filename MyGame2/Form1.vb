Public Class Form1

    Dim xdir1 As Integer = -5
    Dim ydir1 As Integer = 5
    Dim xdir2 As Integer = -5
    Dim ydir2 As Integer = 5
    Dim xdir3 As Integer = -5
    Dim ydir3 As Integer = 5
    Dim xdir4 As Integer = -5
    Dim ydir4 As Integer = 5
    Dim xdir5 As Integer = -5
    Dim ydir5 As Integer = 5
    Dim xdir6 As Integer = -5
    Dim ydir6 As Integer = 5

    Function Collision(p As String, t As String, Optional ByRef other As Object = vbNull)
        For Each c In Controls
            If c.name.toupper = p.ToUpper Then
                Return Collision(c, t, other)
            End If
        Next
        Return False
    End Function
    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing

        If Collision("Bullet1", "Astroid", other) Then
            other.visible = False
            Return
        End If
        If Collision("Astroid1", "Ground", other) Then
            ydir1 = -5
            Return
        End If
        If Collision("Astroid1", "LeftSide", other) Then
            xdir1 = 5
            Return
        End If
        If Collision("Astroid1", "RightSide", other) Then
            xdir1 = -5
            Return
        End If
        If Collision("Astroid1", "Top", other) Then
            ydir1 = 5
            Return
        End If
        If Collision("Astroid2", "Ground", other) Then
            ydir2 = -5
            Return
        End If
        If Collision("Astroid2", "LeftSide", other) Then
            xdir2 = 5
            Return
        End If
        If Collision("Astroid2", "RightSide", other) Then
            xdir2 = -5
            Return
        End If
        If Collision("Astroid2", "Top", other) Then
            ydir2 = 5
            Return
        End If
        If Collision("Astroid3", "Ground", other) Then
            ydir3 = -5
            Return
        End If
        If Collision("Astroid3", "LeftSide", other) Then
            xdir3 = 5
            Return
        End If
        If Collision("Astroid3", "RightSide", other) Then
            xdir3 = -5
            Return
        End If
        If Collision("Astroid3", "Top", other) Then
            ydir3 = 5
            Return
        End If
        If Collision("Astroid4", "Ground", other) Then
            ydir4 = -5
            Return
        End If
        If Collision("Astroid4", "LeftSide", other) Then
            xdir4 = 5
            Return
        End If
        If Collision("Astroid4", "RightSide", other) Then
            xdir4 = -5
            Return
        End If
        If Collision("Astroid4", "Top", other) Then
            ydir4 = 5
            Return
        End If
        If Collision("Astroid5", "Ground", other) Then
            ydir5 = -5
            Return
        End If
        If Collision("Astroid5", "LeftSide", other) Then
            xdir5 = 5
            Return
        End If
        If Collision("Astroid5", "RightSide", other) Then
            xdir5 = -5
            Return
        End If
        If Collision("Astroid5", "Top", other) Then
            ydir5 = 5
            Return
        End If
        If Collision("Astroid6", "Ground", other) Then
            ydir6 = -5
            Return
        End If
        If Collision("Astroid6", "LeftSide", other) Then
            xdir6 = 5
            Return
        End If
        If Collision("Astroid6", "RightSide", other) Then
            xdir6 = -5
            Return
        End If
        If Collision("Astroid6", "Top", other) Then
            ydir6 = 5
            Return
        End If
        If Collision("Picturebox1", "WIN", other) Then
            Me.BackColor = Color.Green
            other.visible = False
            Return
        End If

    End Sub
    Sub MoveTo(p As String, distx As Integer, disty As Integer)
        For Each c In Controls
            If c.name.toupper = p.ToUpper Then
                MoveTo(c, distx, disty)
            End If
        Next
    End Sub
    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveTo("Bullet1", 0, -50)
        MoveTo("Astroid1", xdir1, ydir1)
        MoveTo("Astroid2", xdir2, ydir2)
        MoveTo("Astroid3", xdir3, ydir3)
        MoveTo("Astroid4", xdir4, ydir4)
        MoveTo("Astroid5", xdir5, ydir5)
        MoveTo("Astroid6", xdir6, ydir6)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.J
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
                Me.Refresh()
            Case Keys.Left
                MoveTo("Picturebox1", -15, 0)
            Case Keys.Right
                MoveTo("Picturebox1", 15, 0)
            Case Keys.Space
                CreateNew("Bullet1", Bullet, PictureBox1.Location)
            Case Else
        End Select
    End Sub
End Class