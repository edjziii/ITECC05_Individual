<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btn_signout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtbox_eid = New System.Windows.Forms.TextBox()
        Me.txtbox_name = New System.Windows.Forms.TextBox()
        Me.txtbox_sname = New System.Windows.Forms.TextBox()
        Me.txtbox_age = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbox_searchname = New System.Windows.Forms.TextBox()
        Me.lbox_name = New System.Windows.Forms.ListBox()
        Me.cmb_name = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_loadtable = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btn_loadchart = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_signout
        '
        Me.btn_signout.Location = New System.Drawing.Point(13, 13)
        Me.btn_signout.Name = "btn_signout"
        Me.btn_signout.Size = New System.Drawing.Size(75, 23)
        Me.btn_signout.TabIndex = 0
        Me.btn_signout.Text = "Log Out"
        Me.btn_signout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DOB"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(25, 228)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(25, 257)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(25, 286)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txtbox_eid
        '
        Me.txtbox_eid.Location = New System.Drawing.Point(89, 52)
        Me.txtbox_eid.Name = "txtbox_eid"
        Me.txtbox_eid.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_eid.TabIndex = 10
        '
        'txtbox_name
        '
        Me.txtbox_name.Location = New System.Drawing.Point(89, 81)
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_name.TabIndex = 11
        '
        'txtbox_sname
        '
        Me.txtbox_sname.Location = New System.Drawing.Point(89, 111)
        Me.txtbox_sname.Name = "txtbox_sname"
        Me.txtbox_sname.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_sname.TabIndex = 12
        '
        'txtbox_age
        '
        Me.txtbox_age.Location = New System.Drawing.Point(89, 139)
        Me.txtbox_age.Name = "txtbox_age"
        Me.txtbox_age.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_age.TabIndex = 13
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(77, 168)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 20)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(167, 168)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 20)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Search"
        '
        'txtbox_searchname
        '
        Me.txtbox_searchname.Location = New System.Drawing.Point(167, 14)
        Me.txtbox_searchname.Name = "txtbox_searchname"
        Me.txtbox_searchname.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_searchname.TabIndex = 18
        '
        'lbox_name
        '
        Me.lbox_name.FormattingEnabled = True
        Me.lbox_name.ItemHeight = 16
        Me.lbox_name.Location = New System.Drawing.Point(313, 16)
        Me.lbox_name.Name = "lbox_name"
        Me.lbox_name.Size = New System.Drawing.Size(120, 20)
        Me.lbox_name.TabIndex = 19
        '
        'cmb_name
        '
        Me.cmb_name.FormattingEnabled = True
        Me.cmb_name.Location = New System.Drawing.Point(474, 16)
        Me.cmb_name.Name = "cmb_name"
        Me.cmb_name.Size = New System.Drawing.Size(121, 24)
        Me.cmb_name.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(289, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1025, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'btn_loadtable
        '
        Me.btn_loadtable.Location = New System.Drawing.Point(1320, 114)
        Me.btn_loadtable.Name = "btn_loadtable"
        Me.btn_loadtable.Size = New System.Drawing.Size(102, 23)
        Me.btn_loadtable.TabIndex = 22
        Me.btn_loadtable.Text = "Load Table"
        Me.btn_loadtable.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(289, 219)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "NAME_VS_AGE"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1025, 300)
        Me.Chart1.TabIndex = 23
        Me.Chart1.Text = "Chart1"
        '
        'btn_loadchart
        '
        Me.btn_loadchart.Location = New System.Drawing.Point(1320, 360)
        Me.btn_loadchart.Name = "btn_loadchart"
        Me.btn_loadchart.Size = New System.Drawing.Size(90, 23)
        Me.btn_loadchart.TabIndex = 24
        Me.btn_loadchart.Text = "Load Chart"
        Me.btn_loadchart.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 531)
        Me.Controls.Add(Me.btn_loadchart)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.btn_loadtable)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmb_name)
        Me.Controls.Add(Me.lbox_name)
        Me.Controls.Add(Me.txtbox_searchname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtbox_age)
        Me.Controls.Add(Me.txtbox_sname)
        Me.Controls.Add(Me.txtbox_name)
        Me.Controls.Add(Me.txtbox_eid)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_signout)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_signout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtbox_eid As TextBox
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents txtbox_sname As TextBox
    Friend WithEvents txtbox_age As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbox_searchname As TextBox
    Friend WithEvents lbox_name As ListBox
    Friend WithEvents cmb_name As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_loadtable As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btn_loadchart As Button
End Class
