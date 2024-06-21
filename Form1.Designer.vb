<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
       
        btnViewSubmissions.BackColor = SystemColors.Info
        btnViewSubmissions.Location = New Point(144, 218)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(579, 77)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "&View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = False
       
        btnCreateSubmission.BackColor = SystemColors.MenuHighlight
        btnCreateSubmission.ForeColor = SystemColors.ButtonFace
        btnCreateSubmission.Location = New Point(144, 320)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(579, 72)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "&Create New Submission"
        btnCreateSubmission.UseVisualStyleBackColor = False
        
        Label1.AutoSize = True
        Label1.Location = New Point(244, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 25)
        Label1.TabIndex = 2
        Label1.Text = "Tenzin Delek Sildely AI Task 2 / Slidely Form App"
       
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(907, 509)
        Controls.Add(Label1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Label1 As Label

End Class
