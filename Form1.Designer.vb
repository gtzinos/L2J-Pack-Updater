<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.old_pack_url = New System.Windows.Forms.TextBox()
        Me.new_pack_url = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.logo_icon = New System.Windows.Forms.PictureBox()
        Me.folder_broswer = New System.Windows.Forms.FolderBrowserDialog()
        Me.error_provider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.logo_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_provider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "L2J Old Pack Folder "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "L2J New Pack Folder"
        '
        'old_pack_url
        '
        Me.old_pack_url.Location = New System.Drawing.Point(155, 100)
        Me.old_pack_url.Name = "old_pack_url"
        Me.old_pack_url.Size = New System.Drawing.Size(220, 20)
        Me.old_pack_url.TabIndex = 2
        '
        'new_pack_url
        '
        Me.new_pack_url.Location = New System.Drawing.Point(155, 150)
        Me.new_pack_url.Name = "new_pack_url"
        Me.new_pack_url.Size = New System.Drawing.Size(220, 20)
        Me.new_pack_url.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Start Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(419, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'logo_icon
        '
        Me.logo_icon.Image = Global.L2J_Pack_Updater.My.Resources.Resources.small_8995_8799772
        Me.logo_icon.Location = New System.Drawing.Point(19, 12)
        Me.logo_icon.Name = "logo_icon"
        Me.logo_icon.Size = New System.Drawing.Size(122, 53)
        Me.logo_icon.TabIndex = 7
        Me.logo_icon.TabStop = False
        '
        'folder_broswer
        '
        Me.folder_broswer.Description = "Select a folder"
        '
        'error_provider
        '
        Me.error_provider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 287)
        Me.Controls.Add(Me.logo_icon)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.new_pack_url)
        Me.Controls.Add(Me.old_pack_url)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.logo_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_provider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents old_pack_url As TextBox
    Friend WithEvents new_pack_url As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents logo_icon As PictureBox
    Friend WithEvents folder_broswer As FolderBrowserDialog
    Friend WithEvents error_provider As ErrorProvider
End Class
