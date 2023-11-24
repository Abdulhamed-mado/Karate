<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.BeltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Playerbelt3viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet38 = New karate.karateDataSet38()
        Me.PlayerbeltviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet33 = New karate.karateDataSet33()
        Me.Player_belt_viewTableAdapter = New karate.karateDataSet33TableAdapters.player_belt_viewTableAdapter()
        Me.KarateDataSet36 = New karate.karateDataSet36()
        Me.Playerbelt2viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Player_belt2_viewTableAdapter = New karate.karateDataSet36TableAdapters.player_belt2_viewTableAdapter()
        Me.Player_belt3_viewTableAdapter = New karate.karateDataSet38TableAdapters.player_belt3_viewTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KarateDataSet40 = New karate.karateDataSet40()
        Me.Playerbelt4viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Player_belt4_viewTableAdapter = New karate.karateDataSet40TableAdapters.player_belt4_viewTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playerbelt3viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerbeltviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playerbelt2viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playerbelt4viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1253, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "ملاحظات"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 211)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1126, 22)
        Me.TextBox1.TabIndex = 138
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(111, 170)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(1126, 22)
        Me.DateTimePicker2.TabIndex = 137
        Me.DateTimePicker2.Value = New Date(2022, 3, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1250, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "تاريخ الحصول عليه"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ابيض", "اصفر", "برتقالي", "اخضر", "ازرق", "بني درجة ثانية", "بني درجة اولة", "اسود دان واحد", "اسود دان اثنين", "اسود دان ثلاثة", "اسود دان اربعة", "اسود دان خمسة", "اسود دان ستة", "اسود دان سبعة", "اسود دان ثمانية", "اسود دان تسعة"})
        Me.ComboBox1.Location = New System.Drawing.Point(111, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(1126, 24)
        Me.ComboBox1.TabIndex = 135
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1253, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "الحزام"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1, 2)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 28)
        Me.Button6.TabIndex = 133
        Me.Button6.Text = "الصفحة الرئسية"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(799, 301)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 101)
        Me.Button4.TabIndex = 128
        Me.Button4.Text = "ادخال"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1253, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "رقم القرار"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(111, 55)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1126, 22)
        Me.TextBox3.TabIndex = 126
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(518, 301)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 101)
        Me.Button2.TabIndex = 124
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1253, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "رقم الاعب"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 92)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1126, 22)
        Me.TextBox2.TabIndex = 140
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIDDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.NamearabicDataGridViewTextBoxColumn, Me.BeltDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Playerbelt4viewBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(237, 450)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 60
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(862, 150)
        Me.DataGridView1.TabIndex = 142
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
        'BeltDataGridViewTextBoxColumn
        '
        Me.BeltDataGridViewTextBoxColumn.DataPropertyName = "belt"
        Me.BeltDataGridViewTextBoxColumn.HeaderText = "حزام"
        Me.BeltDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BeltDataGridViewTextBoxColumn.Name = "BeltDataGridViewTextBoxColumn"
        Me.BeltDataGridViewTextBoxColumn.Width = 200
        '
        'Playerbelt3viewBindingSource
        '
        Me.Playerbelt3viewBindingSource.DataMember = "player_belt3_view"
        Me.Playerbelt3viewBindingSource.DataSource = Me.KarateDataSet38
        '
        'KarateDataSet38
        '
        Me.KarateDataSet38.DataSetName = "karateDataSet38"
        Me.KarateDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayerbeltviewBindingSource
        '
        Me.PlayerbeltviewBindingSource.DataMember = "player_belt_view"
        Me.PlayerbeltviewBindingSource.DataSource = Me.KarateDataSet33
        '
        'KarateDataSet33
        '
        Me.KarateDataSet33.DataSetName = "karateDataSet33"
        Me.KarateDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Player_belt_viewTableAdapter
        '
        Me.Player_belt_viewTableAdapter.ClearBeforeFill = True
        '
        'KarateDataSet36
        '
        Me.KarateDataSet36.DataSetName = "karateDataSet36"
        Me.KarateDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Playerbelt2viewBindingSource
        '
        Me.Playerbelt2viewBindingSource.DataMember = "player_belt2_view"
        Me.Playerbelt2viewBindingSource.DataSource = Me.KarateDataSet36
        '
        'Player_belt2_viewTableAdapter
        '
        Me.Player_belt2_viewTableAdapter.ClearBeforeFill = True
        '
        'Player_belt3_viewTableAdapter
        '
        Me.Player_belt3_viewTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(237, 301)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 101)
        Me.Button1.TabIndex = 143
        Me.Button1.Text = "حذف"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'KarateDataSet40
        '
        Me.KarateDataSet40.DataSetName = "karateDataSet40"
        Me.KarateDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Playerbelt4viewBindingSource
        '
        Me.Playerbelt4viewBindingSource.DataMember = "player_belt4_view"
        Me.Playerbelt4viewBindingSource.DataSource = Me.KarateDataSet40
        '
        'Player_belt4_viewTableAdapter
        '
        Me.Player_belt4_viewTableAdapter.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1352, 775)
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
        Me.Name = "Form9"
        Me.Text = "صفحة احزمة الاعبين"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playerbelt3viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerbeltviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playerbelt2viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playerbelt4viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KarateDataSet33 As karateDataSet33
    Friend WithEvents PlayerbeltviewBindingSource As BindingSource
    Friend WithEvents Player_belt_viewTableAdapter As karateDataSet33TableAdapters.player_belt_viewTableAdapter
    Friend WithEvents KarateDataSet36 As karateDataSet36
    Friend WithEvents Playerbelt2viewBindingSource As BindingSource
    Friend WithEvents Player_belt2_viewTableAdapter As karateDataSet36TableAdapters.player_belt2_viewTableAdapter
    Friend WithEvents KarateDataSet38 As karateDataSet38
    Friend WithEvents Playerbelt3viewBindingSource As BindingSource
    Friend WithEvents Player_belt3_viewTableAdapter As karateDataSet38TableAdapters.player_belt3_viewTableAdapter
    Friend WithEvents DIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamearabicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeltDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents KarateDataSet40 As karateDataSet40
    Friend WithEvents Playerbelt4viewBindingSource As BindingSource
    Friend WithEvents Player_belt4_viewTableAdapter As karateDataSet40TableAdapters.player_belt4_viewTableAdapter
End Class
