<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamearabicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sensidegree3viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet37 = New karate.karateDataSet37()
        Me.SensidegreeviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet32 = New karate.karateDataSet32()
        Me.Sensi_degree_viewTableAdapter = New karate.karateDataSet32TableAdapters.sensi_degree_viewTableAdapter()
        Me.KarateDataSet35 = New karate.karateDataSet35()
        Me.Sensidegree2viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sensi_degree2_viewTableAdapter = New karate.karateDataSet35TableAdapters.sensi_degree2_viewTableAdapter()
        Me.Sensi_degree3_viewTableAdapter = New karate.karateDataSet37TableAdapters.sensi_degree3_viewTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KarateDataSet41 = New karate.karateDataSet41()
        Me.Sensidegree6viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sensi_degree6_viewTableAdapter = New karate.karateDataSet41TableAdapters.sensi_degree6_viewTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sensidegree3viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SensidegreeviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sensidegree2viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sensidegree6viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1240, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "ملاحظات"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 217)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1110, 22)
        Me.TextBox1.TabIndex = 122
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(114, 177)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(1110, 22)
        Me.DateTimePicker2.TabIndex = 121
        Me.DateTimePicker2.Value = New Date(2022, 3, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1237, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "تاريخ الحصول عليه"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"مساعد مدرب", "مدرب درجة ثانية", "مدرب درجة اولة"})
        Me.ComboBox1.Location = New System.Drawing.Point(114, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(1110, 24)
        Me.ComboBox1.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1240, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "درجةالمدرب"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 2)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 28)
        Me.Button6.TabIndex = 117
        Me.Button6.Text = "الصفحة الرئسية"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(853, 313)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 101)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "ادخال"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1240, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "رقم القرار"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 61)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1110, 22)
        Me.TextBox3.TabIndex = 110
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(558, 313)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 101)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1240, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "رقم المدرب"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 100)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1110, 22)
        Me.TextBox2.TabIndex = 124
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIDDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.NamearabicDataGridViewTextBoxColumn, Me.DegreeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Sensidegree6viewBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(243, 441)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(857, 150)
        Me.DataGridView1.TabIndex = 126
        '
        'DIDDataGridViewTextBoxColumn
        '
        Me.DIDDataGridViewTextBoxColumn.DataPropertyName = "d_ID"
        Me.DIDDataGridViewTextBoxColumn.HeaderText = "رقم القرار"
        Me.DIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DIDDataGridViewTextBoxColumn.Name = "DIDDataGridViewTextBoxColumn"
        Me.DIDDataGridViewTextBoxColumn.Width = 200
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "رقم المدرب"
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
        'DegreeDataGridViewTextBoxColumn
        '
        Me.DegreeDataGridViewTextBoxColumn.DataPropertyName = "degree"
        Me.DegreeDataGridViewTextBoxColumn.HeaderText = "درجة المدرب"
        Me.DegreeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DegreeDataGridViewTextBoxColumn.Name = "DegreeDataGridViewTextBoxColumn"
        Me.DegreeDataGridViewTextBoxColumn.Width = 200
        '
        'Sensidegree3viewBindingSource
        '
        Me.Sensidegree3viewBindingSource.DataMember = "sensi_degree3_view"
        Me.Sensidegree3viewBindingSource.DataSource = Me.KarateDataSet37
        '
        'KarateDataSet37
        '
        Me.KarateDataSet37.DataSetName = "karateDataSet37"
        Me.KarateDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SensidegreeviewBindingSource
        '
        Me.SensidegreeviewBindingSource.DataMember = "sensi_degree_view"
        Me.SensidegreeviewBindingSource.DataSource = Me.KarateDataSet32
        '
        'KarateDataSet32
        '
        Me.KarateDataSet32.DataSetName = "karateDataSet32"
        Me.KarateDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sensi_degree_viewTableAdapter
        '
        Me.Sensi_degree_viewTableAdapter.ClearBeforeFill = True
        '
        'KarateDataSet35
        '
        Me.KarateDataSet35.DataSetName = "karateDataSet35"
        Me.KarateDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sensidegree2viewBindingSource
        '
        Me.Sensidegree2viewBindingSource.DataMember = "sensi_degree2_view"
        Me.Sensidegree2viewBindingSource.DataSource = Me.KarateDataSet35
        '
        'Sensi_degree2_viewTableAdapter
        '
        Me.Sensi_degree2_viewTableAdapter.ClearBeforeFill = True
        '
        'Sensi_degree3_viewTableAdapter
        '
        Me.Sensi_degree3_viewTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(243, 313)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 101)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "حذف"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'KarateDataSet41
        '
        Me.KarateDataSet41.DataSetName = "karateDataSet41"
        Me.KarateDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sensidegree6viewBindingSource
        '
        Me.Sensidegree6viewBindingSource.DataMember = "sensi_degree6_view"
        Me.Sensidegree6viewBindingSource.DataSource = Me.KarateDataSet41
        '
        'Sensi_degree6_viewTableAdapter
        '
        Me.Sensi_degree6_viewTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1348, 773)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form7"
        Me.Text = "صفحة درجات المدربين"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sensidegree3viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SensidegreeviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sensidegree2viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sensidegree6viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KarateDataSet32 As karateDataSet32
    Friend WithEvents SensidegreeviewBindingSource As BindingSource
    Friend WithEvents Sensi_degree_viewTableAdapter As karateDataSet32TableAdapters.sensi_degree_viewTableAdapter
    Friend WithEvents KarateDataSet35 As karateDataSet35
    Friend WithEvents Sensidegree2viewBindingSource As BindingSource
    Friend WithEvents Sensi_degree2_viewTableAdapter As karateDataSet35TableAdapters.sensi_degree2_viewTableAdapter
    Friend WithEvents KarateDataSet37 As karateDataSet37
    Friend WithEvents Sensidegree3viewBindingSource As BindingSource
    Friend WithEvents Sensi_degree3_viewTableAdapter As karateDataSet37TableAdapters.sensi_degree3_viewTableAdapter
    Friend WithEvents DIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamearabicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DegreeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents KarateDataSet41 As karateDataSet41
    Friend WithEvents Sensidegree6viewBindingSource As BindingSource
    Friend WithEvents Sensi_degree6_viewTableAdapter As karateDataSet41TableAdapters.sensi_degree6_viewTableAdapter
End Class
