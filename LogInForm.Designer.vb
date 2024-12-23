<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.btn_test = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_un = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_test
        '
        Me.btn_test.Location = New System.Drawing.Point(31, 22)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(154, 23)
        Me.btn_test.TabIndex = 0
        Me.btn_test.Text = "CHECK CONNECTION"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(603, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(603, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtbox_un
        '
        Me.txtbox_un.Location = New System.Drawing.Point(692, 196)
        Me.txtbox_un.Name = "txtbox_un"
        Me.txtbox_un.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_un.TabIndex = 3
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(692, 224)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtbox_pass.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_pass.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(706, 272)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 531)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_un)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_test)
        Me.Name = "LogInForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_test As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_un As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents btn_login As Button
End Class
