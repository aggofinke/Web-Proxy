<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please login to continue"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.loginButton)
        Me.GroupBox1.Controls.Add(Me.passwordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.usernameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(11, 189)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(356, 39)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(11, 133)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(356, 35)
        Me.passwordTextBox.TabIndex = 3
        Me.passwordTextBox.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(11, 63)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(356, 35)
        Me.usernameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username:"
        '
        'loginForm
        '
        Me.AcceptButton = Me.loginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(419, 353)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(419, 353)
        Me.Name = "loginForm"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents loginButton As Button
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
