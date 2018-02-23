<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnP33eR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnP33eR
        '
        Me.btnP33eR.Image = CType(resources.GetObject("btnP33eR.Image"), System.Drawing.Image)
        Me.btnP33eR.Location = New System.Drawing.Point(12, 12)
        Me.btnP33eR.Name = "btnP33eR"
        Me.btnP33eR.Size = New System.Drawing.Size(184, 184)
        Me.btnP33eR.TabIndex = 0
        Me.btnP33eR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 184)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 210)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnP33eR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(496, 249)
        Me.MinimumSize = New System.Drawing.Size(496, 249)
        Me.Name = "Form2"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnP33eR As Button
    Friend WithEvents Label1 As Label
End Class
