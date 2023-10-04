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
		BtnCompute = New Button()
		Label1 = New Label()
		TextBox1 = New TextBox()
		Label2 = New Label()
		SuspendLayout()
		' 
		' BtnCompute
		' 
		BtnCompute.Location = New Point(208, 231)
		BtnCompute.Name = "BtnCompute"
		BtnCompute.Size = New Size(190, 34)
		BtnCompute.TabIndex = 0
		BtnCompute.Text = "Compute Grade"
		BtnCompute.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(144, 125)
		Label1.Name = "Label1"
		Label1.Size = New Size(137, 25)
		Label1.TabIndex = 1
		Label1.Text = "Enter Your Mark"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(303, 125)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Showcard Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point)
		Label2.Location = New Point(272, 41)
		Label2.Name = "Label2"
		Label2.Size = New Size(350, 44)
		Label2.TabIndex = 3
		Label2.Text = "Grade Generator"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ControlDark
		ClientSize = New Size(800, 450)
		Controls.Add(Label2)
		Controls.Add(TextBox1)
		Controls.Add(Label1)
		Controls.Add(BtnCompute)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BtnCompute As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
End Class
