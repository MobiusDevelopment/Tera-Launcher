<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pbxStart = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        CType(Me.pbxStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxStart
        '
        Me.pbxStart.BackColor = System.Drawing.Color.Transparent
        Me.pbxStart.Image = Global.TERA_Launcher.My.Resources.Resources.start_normal
        Me.pbxStart.Location = New System.Drawing.Point(247, 264)
        Me.pbxStart.Name = "pbxStart"
        Me.pbxStart.Size = New System.Drawing.Size(257, 107)
        Me.pbxStart.TabIndex = 12
        Me.pbxStart.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(285, 179)
        Me.txtPassword.MaxLength = 32
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 27)
        Me.txtPassword.TabIndex = 11
        '
        'txtAccount
        '
        Me.txtAccount.BackColor = System.Drawing.Color.White
        Me.txtAccount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtAccount.ForeColor = System.Drawing.Color.Black
        Me.txtAccount.Location = New System.Drawing.Point(285, 141)
        Me.txtAccount.MaxLength = 32
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(180, 27)
        Me.txtAccount.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(203, 182)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 19)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblAccount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.ForeColor = System.Drawing.Color.Silver
        Me.lblAccount.Location = New System.Drawing.Point(213, 144)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(66, 19)
        Me.lblAccount.TabIndex = 8
        Me.lblAccount.Text = "Account"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.TERA_Launcher.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(734, 417)
        Me.Controls.Add(Me.pbxStart)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TERA-Launcher"
        CType(Me.pbxStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pbxStart As PictureBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtAccount As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents lblAccount As Label
End Class
