﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterTipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterTipe))
        Me.txt_tipe_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.image_url = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_foto = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_master_tipe = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_tipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto_tipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.hapus_data_tipe = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.image_url, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_master_tipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tipe_barang
        '
        Me.txt_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tipe_barang.Location = New System.Drawing.Point(213, 21)
        Me.txt_tipe_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tipe_barang.Name = "txt_tipe_barang"
        Me.txt_tipe_barang.Size = New System.Drawing.Size(236, 22)
        Me.txt_tipe_barang.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Tipe Barang"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(213, 126)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.image_url)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_foto)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_tipe)
        Me.Panel2.Controls.Add(Me.txt_tipe_barang)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 97)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 461)
        Me.Panel2.TabIndex = 16
        '
        'image_url
        '
        Me.image_url.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.image_url.Location = New System.Drawing.Point(779, 24)
        Me.image_url.Margin = New System.Windows.Forms.Padding(4)
        Me.image_url.Name = "image_url"
        Me.image_url.Size = New System.Drawing.Size(235, 159)
        Me.image_url.TabIndex = 58
        Me.image_url.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Foto"
        '
        'txt_foto
        '
        Me.txt_foto.Location = New System.Drawing.Point(518, 22)
        Me.txt_foto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_foto.Multiline = True
        Me.txt_foto.Name = "txt_foto"
        Me.txt_foto.Size = New System.Drawing.Size(211, 24)
        Me.txt_foto.TabIndex = 56
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(518, 52)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 30)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Browse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(213, 58)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_jenis_barang.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Jenis Barang"
        '
        'data_master_tipe
        '
        Me.data_master_tipe.AllowUserToOrderColumns = True
        Me.data_master_tipe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_tipe.BackgroundColor = System.Drawing.Color.White
        Me.data_master_tipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_tipe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_tipe, Me.jenis_barang, Me.foto_tipe})
        Me.data_master_tipe.Location = New System.Drawing.Point(3, 205)
        Me.data_master_tipe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_tipe.Name = "data_master_tipe"
        Me.data_master_tipe.RowHeadersWidth = 51
        Me.data_master_tipe.RowTemplate.Height = 24
        Me.data_master_tipe.Size = New System.Drawing.Size(1368, 254)
        Me.data_master_tipe.TabIndex = 16
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nama_tipe
        '
        Me.nama_tipe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_tipe.HeaderText = "Nama Tipe Barang"
        Me.nama_tipe.MinimumWidth = 6
        Me.nama_tipe.Name = "nama_tipe"
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Nama Jenis Barang"
        Me.jenis_barang.MinimumWidth = 6
        Me.jenis_barang.Name = "jenis_barang"
        '
        'foto_tipe
        '
        Me.foto_tipe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.foto_tipe.HeaderText = "Foto"
        Me.foto_tipe.MinimumWidth = 6
        Me.foto_tipe.Name = "foto_tipe"
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(12, 7)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(101, 80)
        Me.btn_kembali.TabIndex = 52
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'hapus_data_tipe
        '
        Me.hapus_data_tipe.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hapus_data_tipe.FlatAppearance.BorderSize = 0
        Me.hapus_data_tipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus_data_tipe.Location = New System.Drawing.Point(20, 577)
        Me.hapus_data_tipe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hapus_data_tipe.Name = "hapus_data_tipe"
        Me.hapus_data_tipe.Size = New System.Drawing.Size(93, 39)
        Me.hapus_data_tipe.TabIndex = 54
        Me.hapus_data_tipe.Text = "Hapus"
        Me.hapus_data_tipe.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 97)
        Me.Panel1.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1213, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 86)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(609, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 58)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "TIPE BARANG"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MasterTipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.hapus_data_tipe)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterTipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterTipe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.image_url, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_master_tipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_tipe_barang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents data_master_tipe As DataGridView
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_foto As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_tipe As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents foto_tipe As DataGridViewTextBoxColumn
    Friend WithEvents hapus_data_tipe As Button
    Friend WithEvents image_url As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
End Class
