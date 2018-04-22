<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proxysettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proxysettingsForm))
        Me.iplabel = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'iplabel
        '
        Me.iplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.iplabel.Location = New System.Drawing.Point(55, 6)
        Me.iplabel.Name = "iplabel"
        Me.iplabel.Size = New System.Drawing.Size(232, 30)
        Me.iplabel.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(343, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 30)
        Me.TextBox2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(18, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 48)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Use Proxy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(293, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "IP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Current Proxy:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(157, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 25)
        Me.Label4.TabIndex = 13
        '
        'proxysettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(455, 159)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.iplabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "proxysettingsForm"
        Me.Text = "Proxy Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents iplabel As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
