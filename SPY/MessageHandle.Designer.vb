﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageHandle
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageHandle))
        Me.LabelHwnd = New System.Windows.Forms.Label()
        Me.TextBoxHwnd = New System.Windows.Forms.TextBox()
        Me.LabelMsgID = New System.Windows.Forms.Label()
        Me.TextBoxMsgID = New System.Windows.Forms.TextBox()
        Me.LabelWP = New System.Windows.Forms.Label()
        Me.TextBoxLP = New System.Windows.Forms.TextBox()
        Me.LabelLP = New System.Windows.Forms.Label()
        Me.TextBoxWP = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.CheckBoxAutoSync = New System.Windows.Forms.CheckBox()
        Me.LabelHwnd16 = New System.Windows.Forms.Label()
        Me.LabelMsg16 = New System.Windows.Forms.Label()
        Me.LabelWP16 = New System.Windows.Forms.Label()
        Me.LabelLP16 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'LabelHwnd
        '
        Me.LabelHwnd.AutoSize = True
        Me.LabelHwnd.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelHwnd.Location = New System.Drawing.Point(31, 20)
        Me.LabelHwnd.Name = "LabelHwnd"
        Me.LabelHwnd.Size = New System.Drawing.Size(65, 19)
        Me.LabelHwnd.TabIndex = 0
        Me.LabelHwnd.Text = "窗口句柄"
        '
        'TextBoxHwnd
        '
        Me.TextBoxHwnd.Font = New System.Drawing.Font("SimSun", 10.0!)
        Me.TextBoxHwnd.Location = New System.Drawing.Point(19, 52)
        Me.TextBoxHwnd.Name = "TextBoxHwnd"
        Me.TextBoxHwnd.Size = New System.Drawing.Size(86, 23)
        Me.TextBoxHwnd.TabIndex = 1
        '
        'LabelMsgID
        '
        Me.LabelMsgID.AutoSize = True
        Me.LabelMsgID.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMsgID.Location = New System.Drawing.Point(149, 20)
        Me.LabelMsgID.Name = "LabelMsgID"
        Me.LabelMsgID.Size = New System.Drawing.Size(57, 19)
        Me.LabelMsgID.TabIndex = 0
        Me.LabelMsgID.Text = "消息 ID"
        '
        'TextBoxMsgID
        '
        Me.TextBoxMsgID.Font = New System.Drawing.Font("SimSun", 10.0!)
        Me.TextBoxMsgID.Location = New System.Drawing.Point(136, 52)
        Me.TextBoxMsgID.Name = "TextBoxMsgID"
        Me.TextBoxMsgID.Size = New System.Drawing.Size(86, 23)
        Me.TextBoxMsgID.TabIndex = 1
        '
        'LabelWP
        '
        Me.LabelWP.AutoSize = True
        Me.LabelWP.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelWP.Location = New System.Drawing.Point(266, 20)
        Me.LabelWP.Name = "LabelWP"
        Me.LabelWP.Size = New System.Drawing.Size(66, 19)
        Me.LabelWP.TabIndex = 0
        Me.LabelWP.Text = "wParam"
        '
        'TextBoxLP
        '
        Me.TextBoxLP.Font = New System.Drawing.Font("SimSun", 10.0!)
        Me.TextBoxLP.Location = New System.Drawing.Point(254, 52)
        Me.TextBoxLP.Name = "TextBoxLP"
        Me.TextBoxLP.Size = New System.Drawing.Size(86, 23)
        Me.TextBoxLP.TabIndex = 1
        Me.TextBoxLP.Text = "0"
        '
        'LabelLP
        '
        Me.LabelLP.AutoSize = True
        Me.LabelLP.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelLP.Location = New System.Drawing.Point(379, 20)
        Me.LabelLP.Name = "LabelLP"
        Me.LabelLP.Size = New System.Drawing.Size(58, 19)
        Me.LabelLP.TabIndex = 0
        Me.LabelLP.Text = "lParam"
        '
        'TextBoxWP
        '
        Me.TextBoxWP.Font = New System.Drawing.Font("SimSun", 10.0!)
        Me.TextBoxWP.Location = New System.Drawing.Point(368, 52)
        Me.TextBoxWP.Name = "TextBoxWP"
        Me.TextBoxWP.Size = New System.Drawing.Size(86, 23)
        Me.TextBoxWP.TabIndex = 1
        Me.TextBoxWP.Text = "0"
        '
        'ButtonSend
        '
        Me.ButtonSend.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonSend.Location = New System.Drawing.Point(343, 116)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(119, 33)
        Me.ButtonSend.TabIndex = 2
        Me.ButtonSend.Text = "发送消息"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoSync
        '
        Me.CheckBoxAutoSync.AutoSize = True
        Me.CheckBoxAutoSync.Checked = True
        Me.CheckBoxAutoSync.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAutoSync.Location = New System.Drawing.Point(19, 126)
        Me.CheckBoxAutoSync.Name = "CheckBoxAutoSync"
        Me.CheckBoxAutoSync.Size = New System.Drawing.Size(98, 17)
        Me.CheckBoxAutoSync.TabIndex = 3
        Me.CheckBoxAutoSync.Text = "自动同步句柄"
        Me.CheckBoxAutoSync.UseVisualStyleBackColor = True
        '
        'LabelHwnd16
        '
        Me.LabelHwnd16.AutoSize = True
        Me.LabelHwnd16.Location = New System.Drawing.Point(24, 90)
        Me.LabelHwnd16.Name = "LabelHwnd16"
        Me.LabelHwnd16.Size = New System.Drawing.Size(0, 13)
        Me.LabelHwnd16.TabIndex = 4
        '
        'LabelMsg16
        '
        Me.LabelMsg16.AutoSize = True
        Me.LabelMsg16.Location = New System.Drawing.Point(139, 90)
        Me.LabelMsg16.Name = "LabelMsg16"
        Me.LabelMsg16.Size = New System.Drawing.Size(0, 13)
        Me.LabelMsg16.TabIndex = 4
        '
        'LabelWP16
        '
        Me.LabelWP16.AutoSize = True
        Me.LabelWP16.Location = New System.Drawing.Point(257, 90)
        Me.LabelWP16.Name = "LabelWP16"
        Me.LabelWP16.Size = New System.Drawing.Size(0, 13)
        Me.LabelWP16.TabIndex = 4
        '
        'LabelLP16
        '
        Me.LabelLP16.AutoSize = True
        Me.LabelLP16.Location = New System.Drawing.Point(371, 90)
        Me.LabelLP16.Name = "LabelLP16"
        Me.LabelLP16.Size = New System.Drawing.Size(0, 13)
        Me.LabelLP16.TabIndex = 4
        '
        'MessageHandle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(473, 161)
        Me.Controls.Add(Me.LabelLP16)
        Me.Controls.Add(Me.LabelWP16)
        Me.Controls.Add(Me.LabelMsg16)
        Me.Controls.Add(Me.LabelHwnd16)
        Me.Controls.Add(Me.CheckBoxAutoSync)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.TextBoxWP)
        Me.Controls.Add(Me.LabelLP)
        Me.Controls.Add(Me.TextBoxLP)
        Me.Controls.Add(Me.LabelWP)
        Me.Controls.Add(Me.TextBoxMsgID)
        Me.Controls.Add(Me.LabelMsgID)
        Me.Controls.Add(Me.TextBoxHwnd)
        Me.Controls.Add(Me.LabelHwnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "MessageHandle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message Handle"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents LabelHwnd As Label
    Friend WithEvents TextBoxHwnd As TextBox
    Friend WithEvents LabelMsgID As Label
    Friend WithEvents TextBoxMsgID As TextBox
    Friend WithEvents LabelWP As Label
    Friend WithEvents TextBoxLP As TextBox
    Friend WithEvents LabelLP As Label
    Friend WithEvents TextBoxWP As TextBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents CheckBoxAutoSync As CheckBox
    Friend WithEvents LabelHwnd16 As Label
    Friend WithEvents LabelMsg16 As Label
    Friend WithEvents LabelWP16 As Label
    Friend WithEvents LabelLP16 As Label
End Class
