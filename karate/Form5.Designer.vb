<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamearabicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Refdegree3viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet39 = New karate.karateDataSet39()
        Me.RefdegreeviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet31 = New karate.karateDataSet31()
        Me.Ref_degree_viewTableAdapter = New karate.karateDataSet31TableAdapters.ref_degree_viewTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.KarateDataSet34 = New karate.karateDataSet34()
        Me.Refdegree2viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ref_degree2_viewTableAdapter = New karate.karateDataSet34TableAdapters.ref_degree2_viewTableAdapter()
        Me.Ref_degree3_viewTableAdapter = New karate.karateDataSet39TableAdapters.ref_degree3_viewTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KarateDataSet42 = New karate.karateDataSet42()
        Me.Refdegree5viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ref_degree5_viewTableAdapter = New karate.karateDataSet42TableAdapters.ref_degree5_viewTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Refdegree3viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefdegreeviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Refdegree2viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Refdegree5viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"درجة ثالثة", "درجة ثانية", "درجة اولة", "درجة عربية", "درجة افرقية", "درجة دولية"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 127)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(1119, 24)
        Me.ComboBox1.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1242, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "درجة الحكم"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(0, 2)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 28)
        Me.Button6.TabIndex = 92
        Me.Button6.Text = "الصفحة الرئسية"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(887, 293)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 101)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "ادخال"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1242, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "رقم القرار"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 50)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1119, 22)
        Me.TextBox3.TabIndex = 85
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(585, 293)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 101)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(107, 171)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(1119, 22)
        Me.DateTimePicker2.TabIndex = 105
        Me.DateTimePicker2.Value = New Date(2022, 3, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1239, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "تاريخ الحصول درجة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1242, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "ملاحظات"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 209)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1119, 22)
        Me.TextBox1.TabIndex = 106
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DIDDataGridViewTextBoxColumn, Me.NamearabicDataGridViewTextBoxColumn, Me.DegreeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Refdegree5viewBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(259, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(856, 150)
        Me.DataGridView1.TabIndex = 108
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "d_ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "رقم القرار"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 200
        '
        'DIDDataGridViewTextBoxColumn
        '
        Me.DIDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.DIDDataGridViewTextBoxColumn.HeaderText = "رقم الحكم"
        Me.DIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DIDDataGridViewTextBoxColumn.Name = "DIDDataGridViewTextBoxColumn"
        Me.DIDDataGridViewTextBoxColumn.Width = 200
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
        Me.DegreeDataGridViewTextBoxColumn.HeaderText = "درجة الحكم"
        Me.DegreeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DegreeDataGridViewTextBoxColumn.Name = "DegreeDataGridViewTextBoxColumn"
        Me.DegreeDataGridViewTextBoxColumn.Width = 200
        '
        'Refdegree3viewBindingSource
        '
        Me.Refdegree3viewBindingSource.DataMember = "ref_degree3_view"
        Me.Refdegree3viewBindingSource.DataSource = Me.KarateDataSet39
        '
        'KarateDataSet39
        '
        Me.KarateDataSet39.DataSetName = "karateDataSet39"
        Me.KarateDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RefdegreeviewBindingSource
        '
        Me.RefdegreeviewBindingSource.DataMember = "ref_degree_view"
        Me.RefdegreeviewBindingSource.DataSource = Me.KarateDataSet31
        '
        'KarateDataSet31
        '
        Me.KarateDataSet31.DataSetName = "karateDataSet31"
        Me.KarateDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ref_degree_viewTableAdapter
        '
        Me.Ref_degree_viewTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1242, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "رقم الحكم"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 86)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1119, 22)
        Me.TextBox2.TabIndex = 109
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KarateDataSet34
        '
        Me.KarateDataSet34.DataSetName = "karateDataSet34"
        Me.KarateDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Refdegree2viewBindingSource
        '
        Me.Refdegree2viewBindingSource.DataMember = "ref_degree2_view"
        Me.Refdegree2viewBindingSource.DataSource = Me.KarateDataSet34
        '
        'Ref_degree2_viewTableAdapter
        '
        Me.Ref_degree2_viewTableAdapter.ClearBeforeFill = True
        '
        'Ref_degree3_viewTableAdapter
        '
        Me.Ref_degree3_viewTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(259, 293)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 101)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "حذف"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'KarateDataSet42
        '
        Me.KarateDataSet42.DataSetName = "karateDataSet42"
        Me.KarateDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Refdegree5viewBindingSource
        '
        Me.Refdegree5viewBindingSource.DataMember = "ref_degree5_view"
        Me.Refdegree5viewBindingSource.DataSource = Me.KarateDataSet42
        '
        'Ref_degree5_viewTableAdapter
        '
        Me.Ref_degree5_viewTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1350, 744)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "Form5"
        Me.Text = "صفحة درجات الحكام"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Refdegree3viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefdegreeviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Refdegree2viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Refdegree5viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KarateDataSet31 As karateDataSet31
    Friend WithEvents RefdegreeviewBindingSource As BindingSource
    Friend WithEvents Ref_degree_viewTableAdapter As karateDataSet31TableAdapters.ref_degree_viewTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents KarateDataSet34 As karateDataSet34
    Friend WithEvents Refdegree2viewBindingSource As BindingSource
    Friend WithEvents Ref_degree2_viewTableAdapter As karateDataSet34TableAdapters.ref_degree2_viewTableAdapter
    Friend WithEvents KarateDataSet39 As karateDataSet39
    Friend WithEvents Refdegree3viewBindingSource As BindingSource
    Friend WithEvents Ref_degree3_viewTableAdapter As karateDataSet39TableAdapters.ref_degree3_viewTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamearabicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DegreeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents KarateDataSet42 As karateDataSet42
    Friend WithEvents Refdegree5viewBindingSource As BindingSource
    Friend WithEvents Ref_degree5_viewTableAdapter As karateDataSet42TableAdapters.ref_degree5_viewTableAdapter
End Class
