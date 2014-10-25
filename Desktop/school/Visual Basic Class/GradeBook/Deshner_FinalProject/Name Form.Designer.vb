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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentsName = New System.Windows.Forms.TextBox()
        Me.btnSubmitName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter the Students Name :"
        '
        'txtStudentsName
        '
        Me.txtStudentsName.Location = New System.Drawing.Point(230, 13)
        Me.txtStudentsName.Name = "txtStudentsName"
        Me.txtStudentsName.Size = New System.Drawing.Size(146, 20)
        Me.txtStudentsName.TabIndex = 1
        '
        'btnSubmitName
        '
        Me.btnSubmitName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitName.Location = New System.Drawing.Point(16, 44)
        Me.btnSubmitName.Name = "btnSubmitName"
        Me.btnSubmitName.Size = New System.Drawing.Size(75, 30)
        Me.btnSubmitName.TabIndex = 2
        Me.btnSubmitName.Text = "Submit"
        Me.btnSubmitName.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 86)
        Me.Controls.Add(Me.btnSubmitName)
        Me.Controls.Add(Me.txtStudentsName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Student Name Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentsName As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmitName As System.Windows.Forms.Button
End Class
