﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extend_rental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extend_rental))
        Me.btn_kwitansi = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.dt_barang_keluar_fix = New System.Windows.Forms.DataGridView()
        Me.kd_transaksi_keluar_new = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catatan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periode_rental = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rental_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_harga_akhir = New System.Windows.Forms.TextBox()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.dt_barang_keluar = New System.Windows.Forms.DataGridView()
        Me.kd_transaksi_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periode_rental_lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_type_lama = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rental_exp_lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_tanda_terima = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_kd_transaksi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_client_ship = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_kdpos_ship = New System.Windows.Forms.TextBox()
        Me.txt_kota_ship = New System.Windows.Forms.TextBox()
        Me.txt_alamat_ship = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_client = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipe_barang = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.txt_harga_total = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_shiphand = New System.Windows.Forms.TextBox()
        Me.txt_ppn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PPN = New System.Windows.Forms.Label()
        Me.txt_ppn_nominal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_barang_keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_kwitansi
        '
        Me.btn_kwitansi.Location = New System.Drawing.Point(1196, 758)
        Me.btn_kwitansi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kwitansi.Name = "btn_kwitansi"
        Me.btn_kwitansi.Size = New System.Drawing.Size(227, 30)
        Me.btn_kwitansi.TabIndex = 96
        Me.btn_kwitansi.Text = "Cetak Kwitansi"
        Me.btn_kwitansi.UseVisualStyleBackColor = True
        '
        'btn_invoice
        '
        Me.btn_invoice.Location = New System.Drawing.Point(1197, 718)
        Me.btn_invoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(227, 30)
        Me.btn_invoice.TabIndex = 95
        Me.btn_invoice.Text = "Cetak Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(111, 718)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(93, 60)
        Me.btn_hapus.TabIndex = 88
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tambah.FlatAppearance.BorderSize = 0
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tambah.Location = New System.Drawing.Point(41, 395)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(237, 32)
        Me.btn_tambah.TabIndex = 56
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'dt_barang_keluar_fix
        '
        Me.dt_barang_keluar_fix.AllowUserToOrderColumns = True
        Me.dt_barang_keluar_fix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar_fix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_barang_keluar_fix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar_fix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_transaksi_keluar_new, Me.jenis_barang2, Me.tipe_barang2, Me.serial_number2, Me.kondisi2, Me.tested2, Me.lokasi2, Me.detail_lokasi2, Me.catatan2, Me.status2, Me.harga_jual2, Me.periode_rental, Me.rental_type, Me.rental_exp})
        Me.dt_barang_keluar_fix.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar_fix.Location = New System.Drawing.Point(0, 468)
        Me.dt_barang_keluar_fix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_barang_keluar_fix.Name = "dt_barang_keluar_fix"
        Me.dt_barang_keluar_fix.RowHeadersWidth = 51
        Me.dt_barang_keluar_fix.RowTemplate.Height = 24
        Me.dt_barang_keluar_fix.Size = New System.Drawing.Size(1845, 146)
        Me.dt_barang_keluar_fix.TabIndex = 55
        '
        'kd_transaksi_keluar_new
        '
        Me.kd_transaksi_keluar_new.HeaderText = "Kode Transaksi Keluar"
        Me.kd_transaksi_keluar_new.MinimumWidth = 120
        Me.kd_transaksi_keluar_new.Name = "kd_transaksi_keluar_new"
        Me.kd_transaksi_keluar_new.Width = 120
        '
        'jenis_barang2
        '
        Me.jenis_barang2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang2.HeaderText = "Jenis Barang"
        Me.jenis_barang2.MinimumWidth = 70
        Me.jenis_barang2.Name = "jenis_barang2"
        '
        'tipe_barang2
        '
        Me.tipe_barang2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang2.HeaderText = "Tipe Barang"
        Me.tipe_barang2.MinimumWidth = 70
        Me.tipe_barang2.Name = "tipe_barang2"
        '
        'serial_number2
        '
        Me.serial_number2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number2.HeaderText = "Serial Number"
        Me.serial_number2.MinimumWidth = 70
        Me.serial_number2.Name = "serial_number2"
        '
        'kondisi2
        '
        Me.kondisi2.HeaderText = "Kondisi"
        Me.kondisi2.MinimumWidth = 6
        Me.kondisi2.Name = "kondisi2"
        Me.kondisi2.Width = 125
        '
        'tested2
        '
        Me.tested2.HeaderText = "Tested"
        Me.tested2.MinimumWidth = 6
        Me.tested2.Name = "tested2"
        Me.tested2.Width = 125
        '
        'lokasi2
        '
        Me.lokasi2.HeaderText = "Lokasi"
        Me.lokasi2.MinimumWidth = 6
        Me.lokasi2.Name = "lokasi2"
        Me.lokasi2.Width = 125
        '
        'detail_lokasi2
        '
        Me.detail_lokasi2.HeaderText = "Detail Lokasi"
        Me.detail_lokasi2.MinimumWidth = 6
        Me.detail_lokasi2.Name = "detail_lokasi2"
        Me.detail_lokasi2.Width = 125
        '
        'catatan2
        '
        Me.catatan2.HeaderText = "Catatan"
        Me.catatan2.MinimumWidth = 6
        Me.catatan2.Name = "catatan2"
        Me.catatan2.Width = 125
        '
        'status2
        '
        Me.status2.HeaderText = "Status"
        Me.status2.MinimumWidth = 6
        Me.status2.Name = "status2"
        Me.status2.Width = 125
        '
        'harga_jual2
        '
        Me.harga_jual2.HeaderText = "Harga Rental Baru"
        Me.harga_jual2.MinimumWidth = 6
        Me.harga_jual2.Name = "harga_jual2"
        Me.harga_jual2.Width = 125
        '
        'periode_rental
        '
        Me.periode_rental.HeaderText = "Periode Rental Baru"
        Me.periode_rental.MinimumWidth = 6
        Me.periode_rental.Name = "periode_rental"
        Me.periode_rental.Width = 125
        '
        'rental_type
        '
        Me.rental_type.HeaderText = "Rental Type Baru"
        Me.rental_type.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.rental_type.MinimumWidth = 6
        Me.rental_type.Name = "rental_type"
        Me.rental_type.Width = 125
        '
        'rental_exp
        '
        Me.rental_exp.HeaderText = "Rental Exp Baru"
        Me.rental_exp.MinimumWidth = 6
        Me.rental_exp.Name = "rental_exp"
        Me.rental_exp.Width = 125
        '
        'txt_harga_akhir
        '
        Me.txt_harga_akhir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_akhir.Enabled = False
        Me.txt_harga_akhir.Location = New System.Drawing.Point(562, 794)
        Me.txt_harga_akhir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_akhir.Name = "txt_harga_akhir"
        Me.txt_harga_akhir.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_akhir.TabIndex = 94
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1196, 5)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(173, 86)
        Me.pict_logo.TabIndex = 48
        Me.pict_logo.TabStop = False
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(3, 718)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(93, 60)
        Me.btn_simpan.TabIndex = 87
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(6, 5)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(100, 90)
        Me.btn_kembali.TabIndex = 46
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(455, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Mulai Extend Rental"
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(650, 33)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(236, 22)
        Me.date_tgl_keluar.TabIndex = 22
        '
        'dt_barang_keluar
        '
        Me.dt_barang_keluar.AllowUserToOrderColumns = True
        Me.dt_barang_keluar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_barang_keluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_transaksi_keluar, Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested, Me.lokasi, Me.detail_lokasi, Me.catatan, Me.status, Me.harga_jual, Me.periode_rental_lama, Me.rental_type_lama, Me.rental_exp_lama})
        Me.dt_barang_keluar.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar.Location = New System.Drawing.Point(0, 222)
        Me.dt_barang_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_barang_keluar.Name = "dt_barang_keluar"
        Me.dt_barang_keluar.RowHeadersWidth = 51
        Me.dt_barang_keluar.RowTemplate.Height = 24
        Me.dt_barang_keluar.Size = New System.Drawing.Size(1846, 146)
        Me.dt_barang_keluar.TabIndex = 16
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.HeaderText = "Kode Transaksi Keluar"
        Me.kd_transaksi_keluar.MinimumWidth = 120
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        Me.kd_transaksi_keluar.Width = 120
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.MinimumWidth = 70
        Me.jenis_barang.Name = "jenis_barang"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Tipe Barang"
        Me.tipe_barang.MinimumWidth = 70
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 70
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.MinimumWidth = 6
        Me.kondisi.Name = "kondisi"
        Me.kondisi.Width = 125
        '
        'tested
        '
        Me.tested.HeaderText = "Tested"
        Me.tested.MinimumWidth = 6
        Me.tested.Name = "tested"
        Me.tested.Width = 125
        '
        'lokasi
        '
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.MinimumWidth = 6
        Me.lokasi.Name = "lokasi"
        Me.lokasi.Width = 125
        '
        'detail_lokasi
        '
        Me.detail_lokasi.HeaderText = "Detail Lokasi"
        Me.detail_lokasi.MinimumWidth = 6
        Me.detail_lokasi.Name = "detail_lokasi"
        Me.detail_lokasi.Width = 125
        '
        'catatan
        '
        Me.catatan.HeaderText = "Catatan"
        Me.catatan.MinimumWidth = 6
        Me.catatan.Name = "catatan"
        Me.catatan.Width = 125
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Width = 125
        '
        'harga_jual
        '
        Me.harga_jual.HeaderText = "Harga Rental Lama"
        Me.harga_jual.MinimumWidth = 6
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Width = 125
        '
        'periode_rental_lama
        '
        Me.periode_rental_lama.HeaderText = "Periode Rental Lama"
        Me.periode_rental_lama.MinimumWidth = 6
        Me.periode_rental_lama.Name = "periode_rental_lama"
        Me.periode_rental_lama.Width = 125
        '
        'rental_type_lama
        '
        Me.rental_type_lama.HeaderText = "Rental Type Lama"
        Me.rental_type_lama.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.rental_type_lama.MinimumWidth = 6
        Me.rental_type_lama.Name = "rental_type_lama"
        Me.rental_type_lama.Width = 125
        '
        'rental_exp_lama
        '
        Me.rental_exp_lama.HeaderText = "Rental Exp Lama"
        Me.rental_exp_lama.MinimumWidth = 6
        Me.rental_exp_lama.Name = "rental_exp_lama"
        Me.rental_exp_lama.Width = 125
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipe Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 716)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Harga Total"
        '
        'btn_tanda_terima
        '
        Me.btn_tanda_terima.Location = New System.Drawing.Point(1197, 798)
        Me.btn_tanda_terima.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tanda_terima.Name = "btn_tanda_terima"
        Me.btn_tanda_terima.Size = New System.Drawing.Size(227, 30)
        Me.btn_tanda_terima.TabIndex = 97
        Me.btn_tanda_terima.Text = "Cetak Tanda Terima"
        Me.btn_tanda_terima.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.txt_kd_transaksi)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_client_ship)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txt_kdpos_ship)
        Me.Panel2.Controls.Add(Me.txt_kota_ship)
        Me.Panel2.Controls.Add(Me.txt_alamat_ship)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.cmb_client)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btncari)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_tambah)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar_fix)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.date_tgl_keluar)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar)
        Me.Panel2.Controls.Add(Me.cmb_tipe_barang)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 96)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2186, 616)
        Me.Panel2.TabIndex = 86
        '
        'txt_kd_transaksi
        '
        Me.txt_kd_transaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kd_transaksi.Location = New System.Drawing.Point(201, 30)
        Me.txt_kd_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kd_transaksi.Name = "txt_kd_transaksi"
        Me.txt_kd_transaksi.Size = New System.Drawing.Size(236, 22)
        Me.txt_kd_transaksi.TabIndex = 107
        Me.txt_kd_transaksi.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Kode Transaksi"
        Me.Label5.Visible = False
        '
        'txt_client_ship
        '
        Me.txt_client_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_client_ship.Location = New System.Drawing.Point(650, 67)
        Me.txt_client_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_client_ship.Multiline = True
        Me.txt_client_ship.Name = "txt_client_ship"
        Me.txt_client_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_client_ship.TabIndex = 80
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(457, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 17)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Ship To Name"
        '
        'txt_kdpos_ship
        '
        Me.txt_kdpos_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_ship.Location = New System.Drawing.Point(1113, 86)
        Me.txt_kdpos_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos_ship.Multiline = True
        Me.txt_kdpos_ship.Name = "txt_kdpos_ship"
        Me.txt_kdpos_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos_ship.TabIndex = 78
        '
        'txt_kota_ship
        '
        Me.txt_kota_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_ship.Location = New System.Drawing.Point(650, 103)
        Me.txt_kota_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota_ship.Multiline = True
        Me.txt_kota_ship.Name = "txt_kota_ship"
        Me.txt_kota_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota_ship.TabIndex = 77
        '
        'txt_alamat_ship
        '
        Me.txt_alamat_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_ship.Location = New System.Drawing.Point(1113, 40)
        Me.txt_alamat_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat_ship.Multiline = True
        Me.txt_alamat_ship.Name = "txt_alamat_ship"
        Me.txt_alamat_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat_ship.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(923, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 17)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Ship To Kodepos"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(461, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Ship To Kota"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(923, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 17)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Ship To Alamat Transaksi"
        '
        'cmb_client
        '
        Me.cmb_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_client.FormattingEnabled = True
        Me.cmb_client.Location = New System.Drawing.Point(201, 63)
        Me.cmb_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_client.Name = "cmb_client"
        Me.cmb_client.Size = New System.Drawing.Size(236, 24)
        Me.cmb_client.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Client"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(650, 177)
        Me.btncari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(100, 28)
        Me.btncari.TabIndex = 59
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 179)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(388, 22)
        Me.TextBox1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Cari Barang / Serial Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_tipe_barang
        '
        Me.cmb_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe_barang.FormattingEnabled = True
        Me.cmb_tipe_barang.Location = New System.Drawing.Point(201, 136)
        Me.cmb_tipe_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tipe_barang.Name = "cmb_tipe_barang"
        Me.cmb_tipe_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_tipe_barang.TabIndex = 10
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(201, 101)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_jenis_barang.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
        '
        'txt_diskon
        '
        Me.txt_diskon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_diskon.Location = New System.Drawing.Point(562, 754)
        Me.txt_diskon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(236, 22)
        Me.txt_diskon.TabIndex = 93
        '
        'txt_harga_total
        '
        Me.txt_harga_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_total.Enabled = False
        Me.txt_harga_total.Location = New System.Drawing.Point(562, 716)
        Me.txt_harga_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_total.Name = "txt_harga_total"
        Me.txt_harga_total.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_total.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 796)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 17)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Harga Akhir"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 754)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 17)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Diskon"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(942, 794)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(236, 22)
        Me.txt_subtotal.TabIndex = 103
        '
        'txt_shiphand
        '
        Me.txt_shiphand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_shiphand.Location = New System.Drawing.Point(942, 755)
        Me.txt_shiphand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_shiphand.Name = "txt_shiphand"
        Me.txt_shiphand.Size = New System.Drawing.Size(236, 22)
        Me.txt_shiphand.TabIndex = 102
        '
        'txt_ppn
        '
        Me.txt_ppn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn.Location = New System.Drawing.Point(562, 835)
        Me.txt_ppn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn.Name = "txt_ppn"
        Me.txt_ppn.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn.TabIndex = 101
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(816, 797)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "SubTotal "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(816, 755)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 17)
        Me.Label19.TabIndex = 99
        Me.Label19.Text = "ShipingHandling"
        '
        'PPN
        '
        Me.PPN.AutoSize = True
        Me.PPN.Location = New System.Drawing.Point(436, 835)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(36, 17)
        Me.PPN.TabIndex = 98
        Me.PPN.Text = "PPN"
        '
        'txt_ppn_nominal
        '
        Me.txt_ppn_nominal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn_nominal.Enabled = False
        Me.txt_ppn_nominal.Location = New System.Drawing.Point(942, 718)
        Me.txt_ppn_nominal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn_nominal.Name = "txt_ppn_nominal"
        Me.txt_ppn_nominal.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn_nominal.TabIndex = 105
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(816, 718)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 17)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "PPN Nominal"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1424, 97)
        Me.Panel1.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(558, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 58)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Extend Rental"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'extend_rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1371, 922)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_ppn_nominal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.txt_shiphand)
        Me.Controls.Add(Me.txt_ppn)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.btn_kwitansi)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.txt_harga_akhir)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_tanda_terima)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.txt_harga_total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "extend_rental"
        Me.Text = "Extend Rental"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_barang_keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_kwitansi As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents dt_barang_keluar_fix As DataGridView
    Friend WithEvents txt_harga_akhir As TextBox
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents dt_barang_keluar As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_tanda_terima As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_tipe_barang As ComboBox
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents txt_harga_total As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btncari As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents kd_transaksi_keluar_new As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang2 As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang2 As DataGridViewTextBoxColumn
    Friend WithEvents serial_number2 As DataGridViewTextBoxColumn
    Friend WithEvents kondisi2 As DataGridViewTextBoxColumn
    Friend WithEvents tested2 As DataGridViewTextBoxColumn
    Friend WithEvents lokasi2 As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi2 As DataGridViewTextBoxColumn
    Friend WithEvents catatan2 As DataGridViewTextBoxColumn
    Friend WithEvents status2 As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual2 As DataGridViewTextBoxColumn
    Friend WithEvents periode_rental As DataGridViewTextBoxColumn
    Friend WithEvents rental_type As DataGridViewComboBoxColumn
    Friend WithEvents rental_exp As DataGridViewTextBoxColumn
    Friend WithEvents kd_transaksi_keluar As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents tested As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents catatan As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As DataGridViewTextBoxColumn
    Friend WithEvents periode_rental_lama As DataGridViewTextBoxColumn
    Friend WithEvents rental_type_lama As DataGridViewComboBoxColumn
    Friend WithEvents rental_exp_lama As DataGridViewTextBoxColumn
    Friend WithEvents cmb_client As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_kdpos_ship As TextBox
    Friend WithEvents txt_kota_ship As TextBox
    Friend WithEvents txt_alamat_ship As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_client_ship As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_shiphand As TextBox
    Friend WithEvents txt_ppn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PPN As Label
    Friend WithEvents txt_ppn_nominal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_kd_transaksi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
