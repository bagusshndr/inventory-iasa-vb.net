﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi_maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi_maintenance))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_tanda_terima = New System.Windows.Forms.Button()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ppn_nominal = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_shiphand = New System.Windows.Forms.TextBox()
        Me.txt_ppn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PPN = New System.Windows.Forms.Label()
        Me.txt_harga_total = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_client = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kd_transaksi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_harga_akhir = New System.Windows.Forms.TextBox()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_kwitansi = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.harga_maintance = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_pt = New System.Windows.Forms.TextBox()
        Me.txt_kdpos_ship = New System.Windows.Forms.TextBox()
        Me.txt_kota_ship = New System.Windows.Forms.TextBox()
        Me.txt_alamat_ship = New System.Windows.Forms.TextBox()
        Me.txt_client_ship = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dt_barang_keluar_fix = New System.Windows.Forms.DataGridView()
        Me.nama_jenis_maintenance2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periode_maintenance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maintenance_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.maintenance_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_kdpos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_kota = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(789, 822)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 17)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "PPN Nominal"
        '
        'txt_diskon
        '
        Me.txt_diskon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_diskon.Location = New System.Drawing.Point(537, 848)
        Me.txt_diskon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(236, 22)
        Me.txt_diskon.TabIndex = 112
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(411, 890)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 17)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Harga Akhir"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(411, 848)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 17)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Diskon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(411, 810)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Harga Total"
        '
        'btn_tanda_terima
        '
        Me.btn_tanda_terima.Location = New System.Drawing.Point(1179, 897)
        Me.btn_tanda_terima.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tanda_terima.Name = "btn_tanda_terima"
        Me.btn_tanda_terima.Size = New System.Drawing.Size(227, 30)
        Me.btn_tanda_terima.TabIndex = 120
        Me.btn_tanda_terima.Text = "Cetak Tanda Terima"
        Me.btn_tanda_terima.UseVisualStyleBackColor = True
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
        Me.btn_kembali.TabIndex = 30
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1210, 7)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(180, 86)
        Me.pict_logo.TabIndex = 48
        Me.pict_logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1406, 97)
        Me.Panel1.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(585, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 58)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Maintenance"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ppn_nominal
        '
        Me.txt_ppn_nominal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn_nominal.Enabled = False
        Me.txt_ppn_nominal.Location = New System.Drawing.Point(916, 822)
        Me.txt_ppn_nominal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn_nominal.Name = "txt_ppn_nominal"
        Me.txt_ppn_nominal.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn_nominal.TabIndex = 115
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(916, 891)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(236, 22)
        Me.txt_subtotal.TabIndex = 117
        '
        'txt_shiphand
        '
        Me.txt_shiphand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_shiphand.Location = New System.Drawing.Point(916, 852)
        Me.txt_shiphand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_shiphand.Name = "txt_shiphand"
        Me.txt_shiphand.Size = New System.Drawing.Size(236, 22)
        Me.txt_shiphand.TabIndex = 116
        '
        'txt_ppn
        '
        Me.txt_ppn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn.Location = New System.Drawing.Point(537, 924)
        Me.txt_ppn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn.Name = "txt_ppn"
        Me.txt_ppn.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn.TabIndex = 114
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(789, 894)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 127
        Me.Label18.Text = "SubTotal "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(789, 852)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 17)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "ShipingHandling"
        '
        'PPN
        '
        Me.PPN.AutoSize = True
        Me.PPN.Location = New System.Drawing.Point(411, 927)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(36, 17)
        Me.PPN.TabIndex = 125
        Me.PPN.Text = "PPN"
        '
        'txt_harga_total
        '
        Me.txt_harga_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_total.Enabled = False
        Me.txt_harga_total.Location = New System.Drawing.Point(537, 810)
        Me.txt_harga_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_total.Name = "txt_harga_total"
        Me.txt_harga_total.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_total.TabIndex = 111
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(455, 210)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 17)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Nama Perusahaan"
        '
        'cmb_client
        '
        Me.cmb_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_client.FormattingEnabled = True
        Me.cmb_client.Location = New System.Drawing.Point(209, 162)
        Me.cmb_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_client.Name = "cmb_client"
        Me.cmb_client.Size = New System.Drawing.Size(236, 24)
        Me.cmb_client.TabIndex = 4
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(209, 70)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_jenis_barang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Maintenance"
        '
        'txt_kd_transaksi
        '
        Me.txt_kd_transaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kd_transaksi.Location = New System.Drawing.Point(209, 26)
        Me.txt_kd_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kd_transaksi.Name = "txt_kd_transaksi"
        Me.txt_kd_transaksi.Size = New System.Drawing.Size(236, 22)
        Me.txt_kd_transaksi.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Client"
        '
        'btn_invoice
        '
        Me.btn_invoice.Location = New System.Drawing.Point(1179, 817)
        Me.btn_invoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(227, 30)
        Me.btn_invoice.TabIndex = 118
        Me.btn_invoice.Text = "Cetak Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(453, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Maintenance"
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(604, 112)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(236, 22)
        Me.date_tgl_keluar.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Transaksi"
        '
        'txt_harga_akhir
        '
        Me.txt_harga_akhir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_akhir.Enabled = False
        Me.txt_harga_akhir.Location = New System.Drawing.Point(537, 887)
        Me.txt_harga_akhir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_akhir.Name = "txt_harga_akhir"
        Me.txt_harga_akhir.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_akhir.TabIndex = 113
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(105, 810)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(93, 60)
        Me.btn_hapus.TabIndex = 110
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_kwitansi
        '
        Me.btn_kwitansi.Location = New System.Drawing.Point(1177, 858)
        Me.btn_kwitansi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kwitansi.Name = "btn_kwitansi"
        Me.btn_kwitansi.Size = New System.Drawing.Size(227, 30)
        Me.btn_kwitansi.TabIndex = 119
        Me.btn_kwitansi.Text = "Cetak Kwitansi"
        Me.btn_kwitansi.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(5, 809)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(93, 60)
        Me.btn_simpan.TabIndex = 109
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.harga_maintance)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txt_pt)
        Me.Panel2.Controls.Add(Me.txt_kdpos_ship)
        Me.Panel2.Controls.Add(Me.txt_kota_ship)
        Me.Panel2.Controls.Add(Me.txt_alamat_ship)
        Me.Panel2.Controls.Add(Me.txt_client_ship)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar_fix)
        Me.Panel2.Controls.Add(Me.txt_kdpos)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_kota)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_alamat)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_kd_transaksi)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.date_tgl_keluar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmb_client)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1759, 693)
        Me.Panel2.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Harga Maintance"
        '
        'harga_maintance
        '
        Me.harga_maintance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.harga_maintance.Location = New System.Drawing.Point(209, 113)
        Me.harga_maintance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.harga_maintance.Name = "harga_maintance"
        Me.harga_maintance.Size = New System.Drawing.Size(236, 22)
        Me.harga_maintance.TabIndex = 77
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(889, 159)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 32)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_pt
        '
        Me.txt_pt.Location = New System.Drawing.Point(604, 209)
        Me.txt_pt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pt.Name = "txt_pt"
        Me.txt_pt.Size = New System.Drawing.Size(236, 22)
        Me.txt_pt.TabIndex = 74
        '
        'txt_kdpos_ship
        '
        Me.txt_kdpos_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_ship.Location = New System.Drawing.Point(1073, 117)
        Me.txt_kdpos_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos_ship.Multiline = True
        Me.txt_kdpos_ship.Name = "txt_kdpos_ship"
        Me.txt_kdpos_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos_ship.TabIndex = 14
        '
        'txt_kota_ship
        '
        Me.txt_kota_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_ship.Location = New System.Drawing.Point(1073, 71)
        Me.txt_kota_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota_ship.Multiline = True
        Me.txt_kota_ship.Name = "txt_kota_ship"
        Me.txt_kota_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota_ship.TabIndex = 13
        '
        'txt_alamat_ship
        '
        Me.txt_alamat_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_ship.Location = New System.Drawing.Point(1073, 28)
        Me.txt_alamat_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat_ship.Multiline = True
        Me.txt_alamat_ship.Name = "txt_alamat_ship"
        Me.txt_alamat_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat_ship.TabIndex = 12
        '
        'txt_client_ship
        '
        Me.txt_client_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_client_ship.Location = New System.Drawing.Point(604, 162)
        Me.txt_client_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_client_ship.Multiline = True
        Me.txt_client_ship.Name = "txt_client_ship"
        Me.txt_client_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_client_ship.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(453, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 17)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Ship To Name"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(885, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 17)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Ship To Kodepos"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(885, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Ship To Kota"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(885, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 17)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Ship To Alamat Transaksi"
        '
        'dt_barang_keluar_fix
        '
        Me.dt_barang_keluar_fix.AllowUserToOrderColumns = True
        Me.dt_barang_keluar_fix.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar_fix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_barang_keluar_fix.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dt_barang_keluar_fix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar_fix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_jenis_maintenance2, Me.harga2, Me.periode_maintenance, Me.maintenance_type, Me.maintenance_exp})
        Me.dt_barang_keluar_fix.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar_fix.Location = New System.Drawing.Point(0, 351)
        Me.dt_barang_keluar_fix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_barang_keluar_fix.Name = "dt_barang_keluar_fix"
        Me.dt_barang_keluar_fix.RowHeadersWidth = 51
        Me.dt_barang_keluar_fix.RowTemplate.Height = 24
        Me.dt_barang_keluar_fix.Size = New System.Drawing.Size(1414, 146)
        Me.dt_barang_keluar_fix.TabIndex = 17
        '
        'nama_jenis_maintenance2
        '
        Me.nama_jenis_maintenance2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nama_jenis_maintenance2.Frozen = True
        Me.nama_jenis_maintenance2.HeaderText = "Jenis Maintenance"
        Me.nama_jenis_maintenance2.MinimumWidth = 125
        Me.nama_jenis_maintenance2.Name = "nama_jenis_maintenance2"
        Me.nama_jenis_maintenance2.Width = 125
        '
        'harga2
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.harga2.DefaultCellStyle = DataGridViewCellStyle6
        Me.harga2.HeaderText = "Harga Maintance"
        Me.harga2.MinimumWidth = 125
        Me.harga2.Name = "harga2"
        Me.harga2.Width = 125
        '
        'periode_maintenance
        '
        Me.periode_maintenance.HeaderText = "Periode Maintenance"
        Me.periode_maintenance.MinimumWidth = 125
        Me.periode_maintenance.Name = "periode_maintenance"
        Me.periode_maintenance.Width = 125
        '
        'maintenance_type
        '
        Me.maintenance_type.HeaderText = "Maintenance Type"
        Me.maintenance_type.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.maintenance_type.MinimumWidth = 125
        Me.maintenance_type.Name = "maintenance_type"
        Me.maintenance_type.Width = 125
        '
        'maintenance_exp
        '
        Me.maintenance_exp.HeaderText = "Maintenance Exp"
        Me.maintenance_exp.MinimumWidth = 125
        Me.maintenance_exp.Name = "maintenance_exp"
        Me.maintenance_exp.Width = 125
        '
        'txt_kdpos
        '
        Me.txt_kdpos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos.Location = New System.Drawing.Point(604, 70)
        Me.txt_kdpos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos.Name = "txt_kdpos"
        Me.txt_kdpos.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(453, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Kodepos"
        '
        'txt_kota
        '
        Me.txt_kota.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota.Location = New System.Drawing.Point(604, 28)
        Me.txt_kota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota.Name = "txt_kota"
        Me.txt_kota.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(453, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Kota Client"
        '
        'txt_alamat
        '
        Me.txt_alamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat.Location = New System.Drawing.Point(209, 203)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Alamat"
        '
        'transaksi_maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1371, 818)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_tanda_terima)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_ppn_nominal)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.txt_shiphand)
        Me.Controls.Add(Me.txt_ppn)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.txt_harga_total)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.txt_harga_akhir)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_kwitansi)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "transaksi_maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaksi_maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_tanda_terima As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ppn_nominal As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_shiphand As TextBox
    Friend WithEvents txt_ppn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PPN As Label
    Friend WithEvents txt_harga_total As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmb_client As ComboBox
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_kd_transaksi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_invoice As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_harga_akhir As TextBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_kwitansi As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_pt As TextBox
    Friend WithEvents txt_kdpos_ship As TextBox
    Friend WithEvents txt_kota_ship As TextBox
    Friend WithEvents txt_alamat_ship As TextBox
    Friend WithEvents txt_client_ship As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dt_barang_keluar_fix As DataGridView
    Friend WithEvents txt_kdpos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_kota As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents harga_maintance As TextBox
    Friend WithEvents nama_jenis_maintenance2 As DataGridViewTextBoxColumn
    Friend WithEvents harga2 As DataGridViewTextBoxColumn
    Friend WithEvents periode_maintenance As DataGridViewTextBoxColumn
    Friend WithEvents maintenance_type As DataGridViewComboBoxColumn
    Friend WithEvents maintenance_exp As DataGridViewTextBoxColumn
End Class
