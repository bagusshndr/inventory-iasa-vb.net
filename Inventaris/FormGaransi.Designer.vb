﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGaransi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGaransi))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dt_garansi = New System.Windows.Forms.DataGridView()
        Me.kd_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_transaksi_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.device_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.warranty_end_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valid_warranty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btncari2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_garansi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.dt_garansi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1477, 718)
        Me.Panel1.TabIndex = 5
        '
        'dt_garansi
        '
        Me.dt_garansi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_garansi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_garansi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_client, Me.kd_transaksi_keluar, Me.nama_client, Me.device_type, Me.serial_number, Me.warranty_end_date, Me.valid_warranty})
        Me.dt_garansi.Location = New System.Drawing.Point(0, 330)
        Me.dt_garansi.Name = "dt_garansi"
        Me.dt_garansi.RowHeadersWidth = 51
        Me.dt_garansi.RowTemplate.Height = 24
        Me.dt_garansi.Size = New System.Drawing.Size(1477, 387)
        Me.dt_garansi.TabIndex = 114
        '
        'kd_client
        '
        Me.kd_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_client.HeaderText = "Client ID"
        Me.kd_client.MinimumWidth = 6
        Me.kd_client.Name = "kd_client"
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_transaksi_keluar.HeaderText = "Invoice Number"
        Me.kd_transaksi_keluar.MinimumWidth = 6
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        '
        'nama_client
        '
        Me.nama_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_client.HeaderText = "Client's Name"
        Me.nama_client.MinimumWidth = 6
        Me.nama_client.Name = "nama_client"
        '
        'device_type
        '
        Me.device_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.device_type.HeaderText = "Device Type"
        Me.device_type.MinimumWidth = 6
        Me.device_type.Name = "device_type"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 6
        Me.serial_number.Name = "serial_number"
        '
        'warranty_end_date
        '
        Me.warranty_end_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.warranty_end_date.HeaderText = "Warranty end Date"
        Me.warranty_end_date.MinimumWidth = 6
        Me.warranty_end_date.Name = "warranty_end_date"
        '
        'valid_warranty
        '
        Me.valid_warranty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.valid_warranty.HeaderText = "Valid Warranty"
        Me.valid_warranty.MinimumWidth = 6
        Me.valid_warranty.Name = "valid_warranty"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"No. Invoice", "Nama Client", "ID Client", "Device Type", "Valid Warranty"})
        Me.ComboBox2.Location = New System.Drawing.Point(524, 113)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 24)
        Me.ComboBox2.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1477, 119)
        Me.Panel2.TabIndex = 1
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(12, 11)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(100, 82)
        Me.btn_kembali.TabIndex = 49
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(497, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(462, 58)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Form Garansi"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1275, 11)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(180, 86)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"No. Invoice", "Nama Client", "ID Client", "Device Type", "Valid Warranty"})
        Me.ComboBox1.Location = New System.Drawing.Point(524, 80)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 24)
        Me.ComboBox1.TabIndex = 112
        '
        'btncari2
        '
        Me.btncari2.Location = New System.Drawing.Point(907, 113)
        Me.btncari2.Margin = New System.Windows.Forms.Padding(4)
        Me.btncari2.Name = "btncari2"
        Me.btncari2.Size = New System.Drawing.Size(52, 25)
        Me.btncari2.TabIndex = 111
        Me.btncari2.Text = "Cari"
        Me.btncari2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(669, 80)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 22)
        Me.TextBox1.TabIndex = 109
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(669, 113)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 22)
        Me.TextBox2.TabIndex = 110
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(666, 28)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(236, 22)
        Me.date_tgl_keluar.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(506, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Tanggal Pengembalian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.date_tgl_keluar)
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btncari2)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1477, 212)
        Me.Panel3.TabIndex = 115
        '
        'FormGaransi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormGaransi"
        Me.Text = "FormGaransi"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dt_garansi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btncari2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_garansi As DataGridView
    Friend WithEvents kd_client As DataGridViewTextBoxColumn
    Friend WithEvents kd_transaksi_keluar As DataGridViewTextBoxColumn
    Friend WithEvents nama_client As DataGridViewTextBoxColumn
    Friend WithEvents device_type As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents warranty_end_date As DataGridViewTextBoxColumn
    Friend WithEvents valid_warranty As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
End Class
