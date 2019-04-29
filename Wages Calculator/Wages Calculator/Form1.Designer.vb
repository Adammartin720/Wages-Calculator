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
        Me.grpdataentry = New System.Windows.Forms.GroupBox()
        Me.grppay = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpagegro = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.chkbankholiday = New System.Windows.Forms.CheckBox()
        Me.cbmhours = New System.Windows.Forms.ComboBox()
        Me.cbmpayrate = New System.Windows.Forms.ComboBox()
        Me.radunder18 = New System.Windows.Forms.RadioButton()
        Me.rad18orover = New System.Windows.Forms.RadioButton()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtempnumb = New System.Windows.Forms.TextBox()
        Me.txtbasicpay = New System.Windows.Forms.TextBox()
        Me.txtovertime = New System.Windows.Forms.TextBox()
        Me.txtgrosspay = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.txtnetpay = New System.Windows.Forms.TextBox()
        Me.grpdataentry.SuspendLayout()
        Me.grppay.SuspendLayout()
        Me.grpagegro.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpdataentry
        '
        Me.grpdataentry.Controls.Add(Me.txtempnumb)
        Me.grpdataentry.Controls.Add(Me.txtname)
        Me.grpdataentry.Controls.Add(Me.cbmpayrate)
        Me.grpdataentry.Controls.Add(Me.cbmhours)
        Me.grpdataentry.Controls.Add(Me.chkbankholiday)
        Me.grpdataentry.Controls.Add(Me.Label5)
        Me.grpdataentry.Controls.Add(Me.Label4)
        Me.grpdataentry.Controls.Add(Me.grpagegro)
        Me.grpdataentry.Controls.Add(Me.Label3)
        Me.grpdataentry.Controls.Add(Me.Label2)
        Me.grpdataentry.Controls.Add(Me.Label1)
        Me.grpdataentry.Location = New System.Drawing.Point(54, 12)
        Me.grpdataentry.Name = "grpdataentry"
        Me.grpdataentry.Size = New System.Drawing.Size(530, 153)
        Me.grpdataentry.TabIndex = 0
        Me.grpdataentry.TabStop = False
        Me.grpdataentry.Text = "Data Entry"
        '
        'grppay
        '
        Me.grppay.Controls.Add(Me.txtnetpay)
        Me.grppay.Controls.Add(Me.txttax)
        Me.grppay.Controls.Add(Me.txtgrosspay)
        Me.grppay.Controls.Add(Me.txtovertime)
        Me.grppay.Controls.Add(Me.txtbasicpay)
        Me.grppay.Controls.Add(Me.Label10)
        Me.grppay.Controls.Add(Me.Label9)
        Me.grppay.Controls.Add(Me.Label8)
        Me.grppay.Controls.Add(Me.Label7)
        Me.grppay.Controls.Add(Me.Label6)
        Me.grppay.Location = New System.Drawing.Point(54, 171)
        Me.grppay.Name = "grppay"
        Me.grppay.Size = New System.Drawing.Size(530, 136)
        Me.grppay.TabIndex = 1
        Me.grppay.TabStop = False
        Me.grppay.Text = "Pay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bank Holiday"
        '
        'grpagegro
        '
        Me.grpagegro.Controls.Add(Me.rad18orover)
        Me.grpagegro.Controls.Add(Me.radunder18)
        Me.grpagegro.Location = New System.Drawing.Point(304, 19)
        Me.grpagegro.Name = "grpagegro"
        Me.grpagegro.Size = New System.Drawing.Size(220, 49)
        Me.grpagegro.TabIndex = 3
        Me.grpagegro.TabStop = False
        Me.grpagegro.Text = "Age Group"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pay Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Basic Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Overtime Pay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Gross Pay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Tax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Net Pay"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(54, 344)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(120, 35)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(258, 344)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(120, 35)
        Me.btncalculate.TabIndex = 3
        Me.btncalculate.Text = "Calculate Pay"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(458, 344)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(120, 35)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'chkbankholiday
        '
        Me.chkbankholiday.AutoSize = True
        Me.chkbankholiday.Location = New System.Drawing.Point(109, 103)
        Me.chkbankholiday.Name = "chkbankholiday"
        Me.chkbankholiday.Size = New System.Drawing.Size(15, 14)
        Me.chkbankholiday.TabIndex = 6
        Me.chkbankholiday.UseVisualStyleBackColor = True
        '
        'cbmhours
        '
        Me.cbmhours.FormattingEnabled = True
        Me.cbmhours.Items.AddRange(New Object() {"1 Hour", "2 Hours", "3 Hours", "4 Hours", "5 Hours Or More"})
        Me.cbmhours.Location = New System.Drawing.Point(364, 80)
        Me.cbmhours.Name = "cbmhours"
        Me.cbmhours.Size = New System.Drawing.Size(121, 21)
        Me.cbmhours.TabIndex = 7
        '
        'cbmpayrate
        '
        Me.cbmpayrate.FormattingEnabled = True
        Me.cbmpayrate.Location = New System.Drawing.Point(364, 119)
        Me.cbmpayrate.Name = "cbmpayrate"
        Me.cbmpayrate.Size = New System.Drawing.Size(121, 21)
        Me.cbmpayrate.TabIndex = 8
        '
        'radunder18
        '
        Me.radunder18.AutoSize = True
        Me.radunder18.Location = New System.Drawing.Point(14, 20)
        Me.radunder18.Name = "radunder18"
        Me.radunder18.Size = New System.Drawing.Size(69, 17)
        Me.radunder18.TabIndex = 0
        Me.radunder18.TabStop = True
        Me.radunder18.Text = "Under 18"
        Me.radunder18.UseVisualStyleBackColor = True
        '
        'rad18orover
        '
        Me.rad18orover.AutoSize = True
        Me.rad18orover.Location = New System.Drawing.Point(100, 20)
        Me.rad18orover.Name = "rad18orover"
        Me.rad18orover.Size = New System.Drawing.Size(73, 17)
        Me.rad18orover.TabIndex = 1
        Me.rad18orover.TabStop = True
        Me.rad18orover.Text = "18 or over"
        Me.rad18orover.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(95, 32)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(133, 20)
        Me.txtname.TabIndex = 9
        '
        'txtempnumb
        '
        Me.txtempnumb.Location = New System.Drawing.Point(112, 66)
        Me.txtempnumb.Name = "txtempnumb"
        Me.txtempnumb.Size = New System.Drawing.Size(133, 20)
        Me.txtempnumb.TabIndex = 10
        '
        'txtbasicpay
        '
        Me.txtbasicpay.Location = New System.Drawing.Point(95, 26)
        Me.txtbasicpay.Name = "txtbasicpay"
        Me.txtbasicpay.Size = New System.Drawing.Size(133, 20)
        Me.txtbasicpay.TabIndex = 10
        '
        'txtovertime
        '
        Me.txtovertime.Location = New System.Drawing.Point(97, 61)
        Me.txtovertime.Name = "txtovertime"
        Me.txtovertime.Size = New System.Drawing.Size(133, 20)
        Me.txtovertime.TabIndex = 10
        '
        'txtgrosspay
        '
        Me.txtgrosspay.Location = New System.Drawing.Point(95, 102)
        Me.txtgrosspay.Name = "txtgrosspay"
        Me.txtgrosspay.Size = New System.Drawing.Size(133, 20)
        Me.txtgrosspay.TabIndex = 10
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(364, 26)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(133, 20)
        Me.txttax.TabIndex = 10
        '
        'txtnetpay
        '
        Me.txtnetpay.Location = New System.Drawing.Point(364, 81)
        Me.txtnetpay.Name = "txtnetpay"
        Me.txtnetpay.Size = New System.Drawing.Size(133, 20)
        Me.txtnetpay.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 401)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.grppay)
        Me.Controls.Add(Me.grpdataentry)
        Me.Name = "Form1"
        Me.Text = " "
        Me.grpdataentry.ResumeLayout(False)
        Me.grpdataentry.PerformLayout()
        Me.grppay.ResumeLayout(False)
        Me.grppay.PerformLayout()
        Me.grpagegro.ResumeLayout(False)
        Me.grpagegro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpdataentry As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpagegro As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grppay As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkbankholiday As System.Windows.Forms.CheckBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents cbmpayrate As System.Windows.Forms.ComboBox
    Friend WithEvents cbmhours As System.Windows.Forms.ComboBox
    Friend WithEvents rad18orover As System.Windows.Forms.RadioButton
    Friend WithEvents radunder18 As System.Windows.Forms.RadioButton
    Friend WithEvents txtempnumb As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtnetpay As System.Windows.Forms.TextBox
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents txtgrosspay As System.Windows.Forms.TextBox
    Friend WithEvents txtovertime As System.Windows.Forms.TextBox
    Friend WithEvents txtbasicpay As System.Windows.Forms.TextBox

End Class
