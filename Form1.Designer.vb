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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dogs_radio = New System.Windows.Forms.RadioButton()
        Me.Cats_radio = New System.Windows.Forms.RadioButton()
        Me.Male_radio = New System.Windows.Forms.RadioButton()
        Me.Female_radio = New System.Windows.Forms.RadioButton()
        Me.Age_radio = New System.Windows.Forms.RadioButton()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Display_button = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtered Results:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filters:"
        '
        'Dogs_radio
        '
        Me.Dogs_radio.AutoSize = True
        Me.Dogs_radio.Location = New System.Drawing.Point(6, 5)
        Me.Dogs_radio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dogs_radio.Name = "Dogs_radio"
        Me.Dogs_radio.Size = New System.Drawing.Size(77, 27)
        Me.Dogs_radio.TabIndex = 2
        Me.Dogs_radio.TabStop = True
        Me.Dogs_radio.Text = "Dogs"
        Me.Dogs_radio.UseVisualStyleBackColor = True
        '
        'Cats_radio
        '
        Me.Cats_radio.AutoSize = True
        Me.Cats_radio.Location = New System.Drawing.Point(6, 42)
        Me.Cats_radio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Cats_radio.Name = "Cats_radio"
        Me.Cats_radio.Size = New System.Drawing.Size(69, 27)
        Me.Cats_radio.TabIndex = 3
        Me.Cats_radio.TabStop = True
        Me.Cats_radio.Text = "Cats"
        Me.Cats_radio.UseVisualStyleBackColor = True
        '
        'Male_radio
        '
        Me.Male_radio.AutoSize = True
        Me.Male_radio.Location = New System.Drawing.Point(6, 79)
        Me.Male_radio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Male_radio.Name = "Male_radio"
        Me.Male_radio.Size = New System.Drawing.Size(72, 27)
        Me.Male_radio.TabIndex = 4
        Me.Male_radio.TabStop = True
        Me.Male_radio.Text = "Male"
        Me.Male_radio.UseVisualStyleBackColor = True
        '
        'Female_radio
        '
        Me.Female_radio.AutoSize = True
        Me.Female_radio.Location = New System.Drawing.Point(6, 116)
        Me.Female_radio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Female_radio.Name = "Female_radio"
        Me.Female_radio.Size = New System.Drawing.Size(96, 27)
        Me.Female_radio.TabIndex = 5
        Me.Female_radio.TabStop = True
        Me.Female_radio.Text = "Female"
        Me.Female_radio.UseVisualStyleBackColor = True
        '
        'Age_radio
        '
        Me.Age_radio.AutoSize = True
        Me.Age_radio.Location = New System.Drawing.Point(6, 153)
        Me.Age_radio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Age_radio.Name = "Age_radio"
        Me.Age_radio.Size = New System.Drawing.Size(64, 27)
        Me.Age_radio.TabIndex = 6
        Me.Age_radio.TabStop = True
        Me.Age_radio.Text = "Age"
        Me.Age_radio.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 23
        Me.ListBox.Location = New System.Drawing.Point(31, 55)
        Me.ListBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(363, 464)
        Me.ListBox.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Dogs_radio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Cats_radio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Male_radio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Female_radio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Age_radio)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(400, 55)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(152, 239)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Display_button
        '
        Me.Display_button.Location = New System.Drawing.Point(400, 304)
        Me.Display_button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Display_button.Name = "Display_button"
        Me.Display_button.Size = New System.Drawing.Size(152, 59)
        Me.Display_button.TabIndex = 9
        Me.Display_button.Text = "Display"
        Me.Display_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 560)
        Me.Controls.Add(Me.Display_button)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Radius VB.NET Test App"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dogs_radio As RadioButton
    Friend WithEvents Cats_radio As RadioButton
    Friend WithEvents Male_radio As RadioButton
    Friend WithEvents Female_radio As RadioButton
    Friend WithEvents Age_radio As RadioButton
    Friend WithEvents ListBox As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Display_button As Button
End Class
