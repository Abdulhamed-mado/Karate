<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamearabicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameenglishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClubidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet30 = New karate.karateDataSet30()
        Me.PlayerTableAdapter = New karate.karateDataSet30TableAdapters.playerTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"سكاي", "اساريا"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 171)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(1138, 24)
        Me.ComboBox1.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1261, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "اسم النادي"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(107, 207)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(1137, 22)
        Me.DateTimePicker2.TabIndex = 146
        Me.DateTimePicker2.Value = New Date(2022, 3, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1257, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "تاريخ الميلاد"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1260, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "اسم(انجليزي)"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(106, 131)
        Me.txt3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(1138, 22)
        Me.txt3.TabIndex = 143
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1260, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "اسم(عربي)"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(106, 94)
        Me.txt2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(1138, 22)
        Me.txt2.TabIndex = 141
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 3)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 31)
        Me.Button6.TabIndex = 140
        Me.Button6.Text = "الصفحة الرئسية"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(286, 420)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(219, 101)
        Me.Button5.TabIndex = 138
        Me.Button5.Text = "حذف"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1260, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "ملاحاضات"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(816, 420)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 101)
        Me.Button4.TabIndex = 136
        Me.Button4.Text = "ادخال"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1261, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "رقم الاعب"
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(106, 285)
        Me.txt5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt5.Multiline = True
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(1138, 74)
        Me.txt5.TabIndex = 134
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(107, 53)
        Me.txt1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(1138, 22)
        Me.txt1.TabIndex = 133
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(552, 420)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 101)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(106, 244)
        Me.txt4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(1138, 22)
        Me.txt4.TabIndex = 147
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1260, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "رقم جواز السفر"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamearabicDataGridViewTextBoxColumn, Me.NameenglishDataGridViewTextBoxColumn, Me.PassnumDataGridViewTextBoxColumn, Me.BdateDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.BeltDataGridViewTextBoxColumn, Me.BedateDataGridViewTextBoxColumn, Me.ClubidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlayerBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(188, 568)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1057, 150)
        Me.DataGridView1.TabIndex = 152
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "رقم الاعب"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 200
        '
        'NamearabicDataGridViewTextBoxColumn
        '
        Me.NamearabicDataGridViewTextBoxColumn.DataPropertyName = "Name_arabic"
        Me.NamearabicDataGridViewTextBoxColumn.HeaderText = "اسم(عربي)"
        Me.NamearabicDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamearabicDataGridViewTextBoxColumn.Name = "NamearabicDataGridViewTextBoxColumn"
        Me.NamearabicDataGridViewTextBoxColumn.Width = 200
        '
        'NameenglishDataGridViewTextBoxColumn
        '
        Me.NameenglishDataGridViewTextBoxColumn.DataPropertyName = "Name_english"
        Me.NameenglishDataGridViewTextBoxColumn.HeaderText = "اسم(انجليزي)"
        Me.NameenglishDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameenglishDataGridViewTextBoxColumn.Name = "NameenglishDataGridViewTextBoxColumn"
        Me.NameenglishDataGridViewTextBoxColumn.Width = 200
        '
        'PassnumDataGridViewTextBoxColumn
        '
        Me.PassnumDataGridViewTextBoxColumn.DataPropertyName = "pass_num"
        Me.PassnumDataGridViewTextBoxColumn.HeaderText = "pass_num"
        Me.PassnumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PassnumDataGridViewTextBoxColumn.Name = "PassnumDataGridViewTextBoxColumn"
        Me.PassnumDataGridViewTextBoxColumn.Visible = False
        Me.PassnumDataGridViewTextBoxColumn.Width = 125
        '
        'BdateDataGridViewTextBoxColumn
        '
        Me.BdateDataGridViewTextBoxColumn.DataPropertyName = "bdate"
        Me.BdateDataGridViewTextBoxColumn.HeaderText = "bdate"
        Me.BdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BdateDataGridViewTextBoxColumn.Name = "BdateDataGridViewTextBoxColumn"
        Me.BdateDataGridViewTextBoxColumn.Visible = False
        Me.BdateDataGridViewTextBoxColumn.Width = 125
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.Visible = False
        Me.NoteDataGridViewTextBoxColumn.Width = 125
        '
        'BeltDataGridViewTextBoxColumn
        '
        Me.BeltDataGridViewTextBoxColumn.DataPropertyName = "belt"
        Me.BeltDataGridViewTextBoxColumn.HeaderText = "حزام"
        Me.BeltDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BeltDataGridViewTextBoxColumn.Name = "BeltDataGridViewTextBoxColumn"
        Me.BeltDataGridViewTextBoxColumn.Width = 200
        '
        'BedateDataGridViewTextBoxColumn
        '
        Me.BedateDataGridViewTextBoxColumn.DataPropertyName = "bedate"
        Me.BedateDataGridViewTextBoxColumn.HeaderText = "bedate"
        Me.BedateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BedateDataGridViewTextBoxColumn.Name = "BedateDataGridViewTextBoxColumn"
        Me.BedateDataGridViewTextBoxColumn.Visible = False
        Me.BedateDataGridViewTextBoxColumn.Width = 125
        '
        'ClubidDataGridViewTextBoxColumn
        '
        Me.ClubidDataGridViewTextBoxColumn.DataPropertyName = "club_id"
        Me.ClubidDataGridViewTextBoxColumn.HeaderText = "النادي"
        Me.ClubidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClubidDataGridViewTextBoxColumn.Name = "ClubidDataGridViewTextBoxColumn"
        Me.ClubidDataGridViewTextBoxColumn.Width = 200
        '
        'PlayerBindingSource
        '
        Me.PlayerBindingSource.DataMember = "player"
        Me.PlayerBindingSource.DataSource = Me.KarateDataSet30
        '
        'KarateDataSet30
        '
        Me.KarateDataSet30.DataSetName = "karateDataSet30"
        Me.KarateDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayerTableAdapter
        '
        Me.PlayerTableAdapter.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1355, 758)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form8"
        Me.Text = "صفحة الاعبين"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KarateDataSet30 As karateDataSet30
    Friend WithEvents PlayerBindingSource As BindingSource
    Friend WithEvents PlayerTableAdapter As karateDataSet30TableAdapters.playerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamearabicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameenglishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeltDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClubidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
