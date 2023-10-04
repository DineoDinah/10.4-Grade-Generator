Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click


		Dim Mark As Integer
		Dim Grade As String
		Mark = Val(TextBox1.Text)
		If Mark >= 80 Then
			Grade = "A"
		ElseIf Mark >= 60 And Mark < 80 Then

			Grade = "B"

		ElseIf Mark >= 50 And Mark < 60 Then
			Grade = "C"
		Else
			Grade = "D"
		End If
		MsgBox("You grade is " & Grade)

	End Sub

End Class
