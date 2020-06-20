<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatStart))
        Me.lbComputers = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'lbComputers
        '
        Me.lbComputers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbComputers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbComputers.FormattingEnabled = True
        Me.lbComputers.IntegralHeight = False
        Me.lbComputers.ItemHeight = 15
        Me.lbComputers.Location = New System.Drawing.Point(5, 5)
        Me.lbComputers.Name = "lbComputers"
        Me.lbComputers.Size = New System.Drawing.Size(513, 367)
        Me.lbComputers.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(431, 376)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(87, 27)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnChat
        '
        Me.btnChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChat.Location = New System.Drawing.Point(235, 376)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(194, 27)
        Me.btnChat.TabIndex = 2
        Me.btnChat.Text = "Start Chat"
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'ChatStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 406)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lbComputers)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(301, 190)
        Me.Name = "ChatStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect To..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbComputers As System.Windows.Forms.ListBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnChat As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
