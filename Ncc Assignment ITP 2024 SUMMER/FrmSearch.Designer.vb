<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.Btn_8 = New System.Windows.Forms.Button()
        Me.Btn_7 = New System.Windows.Forms.Button()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.TxtBox_1 = New System.Windows.Forms.TextBox()
        Me.Btn_6 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Btn_9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_8
        '
        Me.Btn_8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_8.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_8.Location = New System.Drawing.Point(549, 341)
        Me.Btn_8.Name = "Btn_8"
        Me.Btn_8.Size = New System.Drawing.Size(210, 60)
        Me.Btn_8.TabIndex = 18
        Me.Btn_8.Text = "Binary Search From User Data"
        Me.Btn_8.UseVisualStyleBackColor = False
        '
        'Btn_7
        '
        Me.Btn_7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_7.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_7.Location = New System.Drawing.Point(549, 266)
        Me.Btn_7.Name = "Btn_7"
        Me.Btn_7.Size = New System.Drawing.Size(210, 54)
        Me.Btn_7.TabIndex = 17
        Me.Btn_7.Text = "Linear Search From User Data"
        Me.Btn_7.UseVisualStyleBackColor = False
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(12, 126)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(343, 20)
        Me.Lbl2.TabIndex = 16
        Me.Lbl2.Text = "Enter your number on the textbox above"
        '
        'TxtBox_1
        '
        Me.TxtBox_1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBox_1.Location = New System.Drawing.Point(48, 57)
        Me.TxtBox_1.Name = "TxtBox_1"
        Me.TxtBox_1.Size = New System.Drawing.Size(153, 22)
        Me.TxtBox_1.TabIndex = 15
        '
        'Btn_6
        '
        Me.Btn_6.BackColor = System.Drawing.Color.Black
        Me.Btn_6.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_6.Location = New System.Drawing.Point(573, 57)
        Me.Btn_6.Name = "Btn_6"
        Me.Btn_6.Size = New System.Drawing.Size(137, 57)
        Me.Btn_6.TabIndex = 13
        Me.Btn_6.Text = "Data From Ext. File"
        Me.Btn_6.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(387, 28)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(156, 400)
        Me.ListBox2.TabIndex = 12
        '
        'Btn_9
        '
        Me.Btn_9.BackColor = System.Drawing.Color.DarkGray
        Me.Btn_9.Font = New System.Drawing.Font("Algerian", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_9.Location = New System.Drawing.Point(0, 395)
        Me.Btn_9.Name = "Btn_9"
        Me.Btn_9.Size = New System.Drawing.Size(160, 53)
        Me.Btn_9.TabIndex = 11
        Me.Btn_9.Text = "BACK TO MAIN MENU"
        Me.Btn_9.UseVisualStyleBackColor = False
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_8)
        Me.Controls.Add(Me.Btn_7)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.TxtBox_1)
        Me.Controls.Add(Me.Btn_6)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Btn_9)
        Me.Name = "FrmSearch"
        Me.Text = "FrmSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_8 As Button
    Friend WithEvents Btn_7 As Button
    Friend WithEvents Lbl2 As Label
    Friend WithEvents TxtBox_1 As TextBox
    Friend WithEvents Btn_6 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Btn_9 As Button
End Class
