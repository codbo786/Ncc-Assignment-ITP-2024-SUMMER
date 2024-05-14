<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSort))
        Me.Btn_4 = New System.Windows.Forms.Button()
        Me.Btn_3 = New System.Windows.Forms.Button()
        Me.Btn_5 = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Btn_4
        '
        Me.Btn_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_4.Location = New System.Drawing.Point(124, 200)
        Me.Btn_4.Name = "Btn_4"
        Me.Btn_4.Size = New System.Drawing.Size(358, 60)
        Me.Btn_4.TabIndex = 16
        Me.Btn_4.Text = "INSERTION SORTING"
        Me.Btn_4.UseVisualStyleBackColor = False
        '
        'Btn_3
        '
        Me.Btn_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_3.Location = New System.Drawing.Point(124, 60)
        Me.Btn_3.Name = "Btn_3"
        Me.Btn_3.Size = New System.Drawing.Size(358, 60)
        Me.Btn_3.TabIndex = 15
        Me.Btn_3.Text = "BUBBLE SORTING"
        Me.Btn_3.UseVisualStyleBackColor = False
        '
        'Btn_5
        '
        Me.Btn_5.BackColor = System.Drawing.Color.DarkGray
        Me.Btn_5.Font = New System.Drawing.Font("Algerian", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_5.Location = New System.Drawing.Point(81, 381)
        Me.Btn_5.Name = "Btn_5"
        Me.Btn_5.Size = New System.Drawing.Size(160, 53)
        Me.Btn_5.TabIndex = 14
        Me.Btn_5.Text = "BACK TO MAIN MENU"
        Me.Btn_5.UseVisualStyleBackColor = False
        '
        'ListBox
        '
        Me.ListBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 18
        Me.ListBox.Location = New System.Drawing.Point(566, 17)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(153, 382)
        Me.ListBox.TabIndex = 13
        '
        'FrmSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_4)
        Me.Controls.Add(Me.Btn_3)
        Me.Controls.Add(Me.Btn_5)
        Me.Controls.Add(Me.ListBox)
        Me.Name = "FrmSort"
        Me.Text = "FrmSort"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_4 As Button
    Friend WithEvents Btn_3 As Button
    Friend WithEvents Btn_5 As Button
    Friend WithEvents ListBox As ListBox
End Class
