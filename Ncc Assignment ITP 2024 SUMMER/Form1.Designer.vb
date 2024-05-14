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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn_2 = New System.Windows.Forms.Button()
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_2
        '
        Me.Btn_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_2.Location = New System.Drawing.Point(215, 344)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(358, 60)
        Me.Btn_2.TabIndex = 5
        Me.Btn_2.Text = "Searching"
        Me.Btn_2.UseVisualStyleBackColor = False
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Btn_1.Location = New System.Drawing.Point(215, 199)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(358, 54)
        Me.Btn_1.TabIndex = 4
        Me.Btn_1.Text = "Sorting"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BackColor = System.Drawing.Color.White
        Me.Lbl1.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.Olive
        Me.Lbl1.Location = New System.Drawing.Point(60, 47)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(681, 33)
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "Welcome  to  my  first  VB  application"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_2)
        Me.Controls.Add(Me.Btn_1)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_2 As Button
    Friend WithEvents Btn_1 As Button
    Friend WithEvents Lbl1 As Label
End Class
