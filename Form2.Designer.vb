﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(178, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 51)
        Button1.TabIndex = 0
        Button1.Text = "Student"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(386, 256)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 51)
        Button2.TabIndex = 1
        Button2.Text = "Course"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(599, 256)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 51)
        Button3.TabIndex = 2
        Button3.Text = "Marks"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(435, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 34)
        Label1.TabIndex = 3
        Label1.Text = "Dashboard"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(481, 431)
        Button4.Name = "Button4"
        Button4.Size = New Size(102, 33)
        Button4.TabIndex = 4
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightGoldenrodYellow
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Location = New Point(808, 256)
        Button5.Name = "Button5"
        Button5.Size = New Size(120, 51)
        Button5.TabIndex = 5
        Button5.Text = "Reports"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(1224, 729)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
