﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text

Public Class extend_rental
    Public Property UserInfo As Object
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim listBarangMasuk As New List(Of Object)
    Dim clients As New List(Of Object)
    Dim listBarangMasukHandle As New List(Of Object)
    Dim listBarangKeluarFix As New List(Of Object)
    Dim listBarangKeluarFixHandle As New List(Of Object)
    Dim triggerTambahBarangKeluar As Boolean = False
    Dim isSelectedTipeJenis As Integer = 0
    Dim isCetakInvoice As Boolean = False
    Dim isCetakTandaTangan As Boolean = False
    Dim isCetakKwitansi As Boolean = False
    Sub VBnetSQLSeverConnection()
        Try
            'SQL connection script to SQL Server Instance
            CONN = New SqlConnection(ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString)
            CONN.Open()

            'Show a test connection message status
            'MsgBox("Successfully connected to SQL Server Instance")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CONN.Close()
    End Sub

    Function GetJenisBarang() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_jenis WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_jenis = reader("nama_jenis").ToString,
                            .id_jenis = reader("id_jenis")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetTipeJenisBarang(idJenis As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_tipe WHERE is_active = 1 AND id_jenis = " + idJenis
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_tipe = reader("nama_tipe").ToString,
                            .id_tipe = reader("id_tipe")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function MappingToDataGridBarangKeluar(result As List(Of Object))
        Dim index = 0
        For Each insertDataBarangMasuk As Object In result
            dt_barang_keluar.Rows.Add(1)
            Dim isTest As String
            If insertDataBarangMasuk.tested = 1 Then
                isTest = "Teruji"
            Else
                isTest = "Tidak Teruji"
            End If

            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.kd_transaksi_keluar
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_jenis
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.nama_tipe
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.serial_number
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.nama_kondisi
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(5).Value = isTest
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.nama_lokasi
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.detail_lokasi
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.catatan
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.nama_status
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(10).Value = insertDataBarangMasuk.harga_akhir
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(11).Value = insertDataBarangMasuk.periode_rental
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(12).Value = insertDataBarangMasuk.rental_type
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(13).Value = insertDataBarangMasuk.rental_exp

            If index = 0 And isSelectedTipeJenis = 0 Then
                isSelectedTipeJenis = 1
                dt_barang_keluar.Columns.Add("id_barang_keluar", "IdBarangKeluar")
                dt_barang_keluar.Columns(14).Visible = False
            End If
            dt_barang_keluar.Rows(dt_barang_keluar.RowCount - 2).Cells(14).Value = insertDataBarangMasuk.id_barang_keluar

            dt_barang_keluar.Update()
            index = index + 1


        Next
    End Function
    Function MappingToDataGridBarangKeluarFix(barangMasukHandle As Object)
        dt_barang_keluar_fix.Rows.Add(1)
        Dim isTest As String
        If barangMasukHandle.tested = 1 Then
            isTest = "Teruji"
        Else
            isTest = "Tidak Teruji"
        End If

        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(0).Value = barangMasukHandle.kd_transaksi_keluar
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(1).Value = barangMasukHandle.nama_jenis
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(2).Value = barangMasukHandle.nama_tipe
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(3).Value = barangMasukHandle.serial_number
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(4).Value = barangMasukHandle.nama_kondisi
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(5).Value = isTest
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(6).Value = barangMasukHandle.nama_lokasi
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(7).Value = barangMasukHandle.detail_lokasi
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(8).Value = barangMasukHandle.catatan
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(9).Value = barangMasukHandle.nama_status
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(10).Value = barangMasukHandle.harga_akhir
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(11).Value = barangMasukHandle.periode_rental
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(12).Value = barangMasukHandle.rental_type
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(13).Value = barangMasukHandle.rental_exp

        If triggerTambahBarangKeluar = False Then
            triggerTambahBarangKeluar = True
            dt_barang_keluar_fix.Columns.Add("id_barang_keluar", "IdBarangKeluar")
            dt_barang_keluar_fix.Columns(14).Visible = False
        End If
        dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(14).Value = barangMasukHandle.id_barang_keluar

        dt_barang_keluar_fix.Update()

    End Function
    Function GetBarangMasukByStatusTipeAndJenis(idStatus As Integer, idJenis As Integer, idTipe As Integer)
        Dim result As New List(Of Object)
        listBarangMasuk.Clear()
        Dim query As String = "SELECT * FROM tbl_barang_keluar bm
                                  INNER JOIN tbl_barang b ON bm.id_barang = b.id_barang
		                          INNER JOIN tbl_kondisi k ON b.id_kondisi = k.id_kondisi
		                          INNER JOIN tbl_jenis j ON b.id_jenis = j.id_jenis
		                          INNER JOIN tbl_tipe t ON b.id_tipe = t.id_tipe
		                          INNER JOIN tbl_lokasi l ON b.id_lokasi = l.id_lokasi
		                          INNER JOIN tbl_detail_lokasi dl ON b.id_detail_lokasi = dl.id_detail_lokasi
		                          INNER JOIN tbl_status_barang sb ON b.id_status_barang = sb.id_status_barang
                                  INNER JOIN tbl_transaksi trans ON bm.kd_transaksi_keluar = trans.kd_transaksi_keluar 
                                  WHERE 
                                    bm.is_active = 1 AND 
                                    sb.id_status_barang = " + idStatus.ToString + " AND 
                                    j.id_jenis = " + idJenis.ToString + " AND 
                                    t.id_tipe = " + idTipe.ToString

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        Try

            CONN.Open()
        Catch ex As Exception
            CONN.Close()
            CONN.Open()
        End Try
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim barang = New With
                {
                 .nama_jenis = reader("nama_jenis"),
                    .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .nama_kondisi = reader("nama_kondisi"),
            .tested = reader("tested"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .licence = reader("licence"),
            .catatan = reader("ios"),
            .nama_status = reader("nama_status"),
            .harga_beli = reader("harga_beli"),
            .harga_jual = reader("harga_jual"),
            .kd_transaksi_keluar = reader("kd_transaksi_keluar"),
            .id_alasan = Nothing,
            .id_toko = reader("id_toko"),
            .judul = "",
            .id_jenis = reader("id_jenis"),
            .id_tipe = reader("id_tipe"),
            .tgl_keluar = Nothing,
            .garansi = Nothing,
            .garansi_type = "",
            .garansi_exp = Nothing,
            .periode_rental = reader("periode_rental"),
            .rental_type = reader("rental_type"),
            .rental_exp = reader("rental_exp"),
            .id_client = reader("id_client"),
            .id_lokasi = reader("id_lokasi"),
            .id_detail_lokasi = reader("id_detail_lokasi"),
            .jumlah = reader("jumlah"),
            .id_status_barang = reader("id_status_barang"),
            .harga_total = reader("harga_total"),
            .diskon = reader("diskon"),
            .harga_akhir = reader("harga_akhir"),
            .alamat_pengiriman = reader("alamat_pengiriman"),
            .kota_pengiriman = reader("kota_pengiriman"),
            .kdpos_pengiriman = reader("kdpos_pengiriman"),
            .total_barang = reader("total_barang"),
            .id_barang = reader("id_barang"),
            .id_barang_keluar = reader("id_barang_keluar")
                }
            listBarangMasuk.Add(barang)
            result.Add(barang)

        End While

        MappingToDataGridBarangKeluar(result)

        CONN.Close()

        Return result
    End Function
    Function UpdateStatusBarang(idStatusBarang As Integer, userlogin As String, idBarang As Integer)
        Dim barangKeluarId
        Dim queryTblBarang As String = " UPDATE tbl_barang SET 
                                    id_status_barang = " + idStatusBarang.ToString + ",
                                    updated_by = '" + userlogin + "',
                                    updated_date =   CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                    WHERE id_barang = " + idBarang.ToString

        cmd.CommandText = queryTblBarang
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        barangKeluarId = cmd.ExecuteScalar()
        'reader = cmd.ExecuteReader()

        CONN.Close()
    End Function
    Function SimpanBarangKeluar(barangKeluar As Object, index As Integer)
        Dim idToko
        Dim userlogin As String = ""
        Dim barangKeluarId As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
            idToko = UserInfo.IdToko.ToString
        Else
            idToko = "NULL"
        End If
        Try
            If index = 0 Then
                Dim queryTblBarangKeluarTransaksi As String = " INSERT INTO tbl_transaksi (
                                    kd_transaksi_keluar,
                                    harga_total,
                                    diskon,
                                    harga_akhir,                                   
                                    id_client,
                                    alamat_pengiriman,
                                    kota_pengiriman,
                                    kdpos_pengiriman,
                                    tgl_keluar,
                                    total_barang,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + barangKeluar.kd_transaksi_keluar + "',
                                    " + barangKeluar.harga_total.ToString + ",
                                    " + barangKeluar.diskon.ToString + ",
                                     " + barangKeluar.harga_akhir.ToString + ",
                                     " + barangKeluar.id_client.ToString + ",
                                    '" + barangKeluar.alamat_pengiriman + "',
                                    '" + barangKeluar.kota_pengiriman + "',
                                    '" + barangKeluar.kdpos_pengiriman + "',
                                     CAST('" + DateTime.Parse(barangKeluar.tgl_keluar).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),                                  
                                     " + barangKeluar.total_barang.ToString + ",
                                    '" + userlogin + "',
                                     CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "

                cmd.CommandText = queryTblBarangKeluarTransaksi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                barangKeluarId = cmd.ExecuteScalar()
                'reader = cmd.ExecuteReader()

                CONN.Close()
            End If
            Dim queryTblBarangKeluar As String = " INSERT INTO tbl_barang_ext (
                                    id_barang_keluar,
                                    kd_transaksi_keluar,
                                    id_barang,
                                    id_alasan,
                                    id_toko,
                                    judul,
                                    id_jenis,
                                    id_tipe,
                                    serial_number,                                    
                                    tgl_keluar,
                                    periode_rental,
                                    rental_type,
                                    rental_exp,
                                    id_client,
                                    id_lokasi,
                                    id_detail_lokasi,
                                    harga_jual,
                                    jumlah,
                                    id_status_barang,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    " + barangKeluar.id_barang_keluar.ToString + ",
                                    '" + barangKeluar.kd_transaksi_keluar + "',
                                    " + barangKeluar.id_barang.ToString + ",
                                    " + barangKeluar.id_alasan.ToString + ",
                                     " + idToko + ",
                                    '" + barangKeluar.judul + "',
                                      " + barangKeluar.id_jenis.ToString + ",
                                     " + barangKeluar.id_tipe.ToString + ",
                                       '" + barangKeluar.serial_number + "',
                                     CAST('" + DateTime.Parse(barangKeluar.tgl_keluar).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),                                  
                                     " + barangKeluar.garansi.ToString + ",
                                     '" + barangKeluar.garansi_type + "',
                                      
                                    "
            If barangKeluar.garansi_exp = "NULL" Then
                queryTblBarangKeluar = queryTblBarangKeluar + "NULL,"

            Else
                queryTblBarangKeluar = queryTblBarangKeluar + "CAST('" + DateTime.Parse(barangKeluar.garansi_exp).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),"
            End If
            queryTblBarangKeluar = queryTblBarangKeluar + " " + barangKeluar.id_client.ToString + ",
                                       " + barangKeluar.id_lokasi.ToString + ",
                                      " + barangKeluar.id_detail_lokasi.ToString + ",
                                        " + barangKeluar.harga_jual.ToString + ",
                                    " + barangKeluar.jumlah.ToString + ",
                                        " + barangKeluar.id_status_barang.ToString + ",
                                    '" + userlogin + "',
                                     CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "

            cmd.CommandText = queryTblBarangKeluar
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            barangKeluarId = cmd.ExecuteScalar()
            'reader = cmd.ExecuteReader()

            CONN.Close()

            UpdateStatusBarang(barangKeluar.id_status_barang, userlogin, barangKeluar.id_barang)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GetBarangMasuk()
            'Me.Label1.Tag = 0
            'Me.Label2.Tag = 0
        End Try
        Return barangKeluarId

    End Function
    Function GetClient()
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_client WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim client As New With {
                            .id_client = reader("id_client"),
                            .nama_client = reader("nama_client"),
                              .alamat_client = reader("alamat_client"),
                            .kota_client = reader("kota_client"),
                             .kdpos_client = reader("kdpos_client")
                            }
            result.Add(client)
            clients.Add(client)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function RandomString(r As Random) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Sub extend_rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.txt_harga_total.Text = 0
            Me.txt_harga_akhir.Text = 0
            isSelectedTipeJenis = 0
            'Dim kdTransaksi As String = RandomString(New Random)
            'Me.txt_kd_transaksi.Text = kdTransaksi
            'Me.txt_kd_transaksi.Enabled = False
            VBnetSQLSeverConnection()
            Dim listbarang As List(Of Object) = GetJenisBarang()
            If listbarang.Count > 0 Then
                cmb_jenis_barang.DataSource = listbarang
                cmb_jenis_barang.DisplayMember = "nama_jenis"
                cmb_jenis_barang.ValueMember = "id_jenis"
            End If

            'Dim listClient As List(Of Object) = GetClient()
            'If listClient.Count > 0 Then
            '    cmb_client.DataSource = listClient
            '    cmb_client.DisplayMember = "nama_client"
            '    cmb_client.ValueMember = "id_client"
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'CONN.Close()
        End Try
    End Sub

    Private Sub cmb_jenis_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis_barang.SelectedIndexChanged
        If cmb_jenis_barang.SelectedIndex <> -1 Then
            Try
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue.id_jenis
            Catch ex As Exception
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue
                Dim listTipe As List(Of Object) = GetTipeJenisBarang(idJenisBarang)
                If listTipe.Count > 0 Then
                    cmb_tipe_barang.DataSource = listTipe
                    cmb_tipe_barang.DisplayMember = "nama_tipe"
                    cmb_tipe_barang.ValueMember = "id_tipe"
                Else
                    cmb_tipe_barang.DataSource = New List(Of Object)
                End If
            End Try

        End If
    End Sub

    Private Sub cmb_tipe_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipe_barang.SelectedIndexChanged
        Try
            dt_barang_keluar.Rows.Clear()
            GetBarangMasukByStatusTipeAndJenis(3, cmb_jenis_barang.SelectedValue, cmb_tipe_barang.SelectedValue.id_tipe)
        Catch ex As Exception
            dt_barang_keluar.Rows.Clear()
            GetBarangMasukByStatusTipeAndJenis(3, cmb_jenis_barang.SelectedValue, cmb_tipe_barang.SelectedValue)
        End Try
    End Sub

    Private Sub dt_barang_keluar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar.CellContentClick
        listBarangMasukHandle.Clear()
    End Sub

    Private Sub dt_barang_keluar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar.CellClick
        listBarangMasukHandle.Clear()
        Dim selectedIdBarangMasuk = dt_barang_keluar.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangMasuk

            Dim idBarangKeluar = selectedItem.Cells(14).Value
            'Dim checkDuplicate As Object = listBarangMasukHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            Dim barang As Object = listBarangMasuk.Where(Function(x) x.id_barang_keluar = idBarangKeluar).FirstOrDefault()
            If barang IsNot Nothing Then

                listBarangMasukHandle.Add(barang)
            End If
            'End If

        Next selectedItem

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        For Each barangMasukHandle As Object In listBarangMasukHandle
            If barangMasukHandle IsNot Nothing Then

                Dim checkValidationDataBarangKeluar As Object = listBarangKeluarFix.Where(Function(x) x.id_barang_keluar = barangMasukHandle.id_barang_keluar).FirstOrDefault()

                If checkValidationDataBarangKeluar Is Nothing Then
                    barangMasukHandle.periode_rental = ""
                    barangMasukHandle.rental_type = ""
                    barangMasukHandle.rental_exp = Nothing
                    barangMasukHandle.harga_akhir = ""
                    MappingToDataGridBarangKeluarFix(barangMasukHandle)
                    'Me.txt_harga_total.Text = Me.txt_harga_total.Text + barangMasukHandle.harga_jual
                    'Me.txt_harga_akhir.Text = Me.txt_harga_total.Text
                    listBarangKeluarFix.Add(barangMasukHandle)
                    'Index = Index + 1
                Else
                    MsgBox("Data Sudah Di Tambah!")
                End If


            End If
        Next

    End Sub

    Private Sub dt_barang_keluar_fix_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellContentClick

    End Sub

    Private Sub dt_barang_keluar_fix_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellClick
        listBarangKeluarFixHandle.Clear()
        Dim selectedIdBarangKeluar = dt_barang_keluar_fix.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangKeluar
            Dim idBarangKeluar = selectedItem.Cells(14).Value
            'Dim checkDuplicate As Object = listBarangKeluarFixHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            Dim barang As Object = listBarangKeluarFix.Where(Function(x) x.id_barang_keluar = idBarangKeluar).FirstOrDefault()
            listBarangKeluarFixHandle.Add(barang)
            'End If

        Next selectedItem
    End Sub

    Private Sub dt_barang_keluar_fix_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellEndEdit
        listBarangKeluarFixHandle.Clear()

        Dim changeHargaJualBarangKeluar = dt_barang_keluar_fix.SelectedCells

        Dim index = 0
        For Each selectedItem As DataGridViewCell In changeHargaJualBarangKeluar
            If selectedItem.ColumnIndex = 10 Then
                If selectedItem.Value IsNot Nothing Then
                    If System.Text.RegularExpressions.Regex.IsMatch(selectedItem.Value, "[  ^ 0-9]") Then
                        listBarangKeluarFix(selectedItem.RowIndex).harga_akhir = selectedItem.Value
                        If index = 0 Then
                            dt_barang_keluar_fix.Rows.Clear()
                        End If
                        Me.txt_harga_total.Text = 0
                        Me.txt_harga_akhir.Text = 0
                        For Each barangKeluarFix As Object In listBarangKeluarFix

                            MappingToDataGridBarangKeluarFix(barangKeluarFix)

                            Me.txt_harga_total.Text = Integer.Parse(Me.txt_harga_total.Text) + Integer.Parse(barangKeluarFix.harga_akhir)
                            Me.txt_harga_akhir.Text = Me.txt_harga_total.Text
                            'listBarangKeluarFix.Add(barangMasukHandle)
                            index = index + 1

                        Next
                    ElseIf selectedItem.Value = "" Then
                        MsgBox("harga Rental Tidak Boleh Kosong")
                    Else
                        MsgBox("harga Rental hanya bisa number")
                    End If
                Else
                    MsgBox("harga Rental tidak boleh kosong")
                End If

            ElseIf selectedItem.ColumnIndex = 11 Then
                If selectedItem.Value IsNot Nothing Then
                    If System.Text.RegularExpressions.Regex.IsMatch(selectedItem.Value, "[  ^ 0-9]") Then
                        listBarangKeluarFix(selectedItem.RowIndex).periode_rental = selectedItem.Value

                        If listBarangKeluarFix(selectedItem.RowIndex).periode_rental IsNot Nothing Then

                            If listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Hari" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddDays(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Bulan" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddMonths(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Tahun" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddYears(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp
                            End If
                        End If



                        If index = 0 Then
                            dt_barang_keluar_fix.Rows.Clear()
                        End If


                        For Each barangKeluarFix As Object In listBarangKeluarFix

                            MappingToDataGridBarangKeluarFix(barangKeluarFix)

                            'listBarangKeluarFix.Add(barangMasukHandle)
                            index = index + 1

                        Next
                    ElseIf selectedItem.Value = "" Then
                        'MsgBox("harga Jual Tidak Boleh Kosong")
                    Else
                        MsgBox("garansi hanya bisa number")
                    End If
                Else
                    MsgBox("garansi tidak boleh kosong")
                End If
            ElseIf selectedItem.ColumnIndex = 12 Then
                If selectedItem.Value IsNot Nothing Then
                    If selectedItem.Value <> "" Then

                        listBarangKeluarFix(selectedItem.RowIndex).rental_type = selectedItem.Value

                        If listBarangKeluarFix(selectedItem.RowIndex).rental_type <> "" Then
                            If listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Hari" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddDays(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Bulan" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddMonths(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).rental_type = "Tahun" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddYears(listBarangKeluarFix(selectedItem.RowIndex).periode_rental)
                                listBarangKeluarFix(selectedItem.RowIndex).rental_exp = calculateGaransiExp

                            End If
                        End If
                        If index = 0 Then
                            dt_barang_keluar_fix.Rows.Clear()
                        End If


                        For Each barangKeluarFix As Object In listBarangKeluarFix

                            MappingToDataGridBarangKeluarFix(barangKeluarFix)

                            'listBarangKeluarFix.Add(barangMasukHandle)
                            index = index + 1

                        Next
                    ElseIf selectedItem.Value = "" Then
                        'MsgBox("harga Jual Tidak Boleh Kosong")
                    Else
                        'MsgBox("harga Jual hanya bisa number")
                    End If
                Else
                    'MsgBox("harga Jual tidak boleh kosong")
                End If
            End If
        Next selectedItem
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Me.txt_harga_total.Text = 0
        Me.txt_harga_akhir.Text = 0
        For Each item As Object In listBarangKeluarFixHandle
            If item IsNot Nothing Then

                Dim deleteData As Object = listBarangKeluarFix.Where(Function(x) x.id_barang_keluar = item.id_barang_keluar).FirstOrDefault()
                listBarangKeluarFix.Remove(deleteData)
            End If
        Next
        dt_barang_keluar_fix.Rows.Clear()

        For Each barangKeluarFix As Object In listBarangKeluarFix

            MappingToDataGridBarangKeluarFix(barangKeluarFix)

            Me.txt_harga_total.Text = Me.txt_harga_total.Text + barangKeluarFix.harga_akhir
            Me.txt_harga_akhir.Text = Me.txt_harga_total.Text
            'listBarangKeluarFix.Add(barangMasukHandle)
            'Index = Index + 1

        Next
        If listBarangKeluarFix.Count = 0 Then
            triggerTambahBarangKeluar = False
            dt_barang_keluar_fix.Columns.RemoveAt(13)
        End If
    End Sub

    Private Sub txt_diskon_TextChanged(sender As Object, e As EventArgs) Handles txt_diskon.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txt_diskon.Text, "[  ^ 0-9]") Then
            Me.txt_harga_akhir.Text = Integer.Parse(Me.txt_harga_akhir.Text) - Integer.Parse(Me.txt_diskon.Text)
        ElseIf txt_diskon.Text = "" Then
            Me.txt_harga_akhir.Text = Me.txt_harga_total.Text
        Else
            MsgBox("Diskon hanya bisa numbering")
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim index = 0

        Dim kdTransaksi As String = RandomString(New Random)
        For Each insertDataBarangKeluar As Object In listBarangKeluarFix
            Dim diskon = 0
            Dim idToko As String
            Dim garansiType As String = ""
            Dim garansi = "NULL"
            Dim garansiExp = "NULL"

            If insertDataBarangKeluar.periode_rental IsNot Nothing And insertDataBarangKeluar.periode_rental <> "" Then
                garansi = insertDataBarangKeluar.periode_rental
            End If
            If insertDataBarangKeluar.rental_type <> "" Then
                garansiType = insertDataBarangKeluar.rental_type
            End If
            If insertDataBarangKeluar.rental_exp IsNot Nothing Then
                garansiExp = insertDataBarangKeluar.rental_exp
            End If
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                idToko = MenuUtama.MenuStrip1.Tag.IdToko
            End If
            If Me.txt_diskon.Text <> "" Then
                diskon = Me.txt_diskon.Text
            End If
            insertDataBarangKeluar.kd_transaksi_keluar = kdTransaksi
            'insertDataBarangKeluar.id_client = Me.cmb_client.SelectedValue
            'insertDataBarangKeluar.id_toko = idToko
            insertDataBarangKeluar.id_alasan = "NULL"
            'insertDataBarangKeluar.judul = ""
            insertDataBarangKeluar.tgl_keluar = Me.date_tgl_keluar.Value
            insertDataBarangKeluar.garansi = garansi
            insertDataBarangKeluar.garansi_type = garansiType
            insertDataBarangKeluar.garansi_exp = garansiExp
            'insertDataBarangKeluar.id_client = Me.cmb_client.SelectedValue
            'insertDataBarangKeluar.jumlah = reader("jumlah"),
            insertDataBarangKeluar.harga_total = Me.txt_harga_total.Text
            insertDataBarangKeluar.diskon = diskon
            insertDataBarangKeluar.harga_akhir = Me.txt_harga_akhir.Text
            'insertDataBarangKeluar.alamat_pengiriman = Me.txt_alamat.Text
            'insertDataBarangKeluar.kota_pengiriman = Me.txt_kota.Text
            'insertDataBarangKeluar.kdpos_pengiriman = Me.txt_kdpos.Text
            'insertDataBarangKeluar.total_barang = listBarangKeluarFix.Count
            insertDataBarangKeluar.id_status_barang = 3
            SimpanBarangKeluar(insertDataBarangKeluar, index)
            index = index + 1
        Next
        index = 0
        dt_barang_keluar.Rows.Clear()
        dt_barang_keluar_fix.Rows.Clear()
        listBarangKeluarFix.Clear()
        listBarangMasuk.Clear()
        'invoice_cetak.KdTransaksi = Me.txt_kd_transaksi.Text
        'Dim kdTransaksi As String = RandomString(New Random)
        'Me.txt_kd_transaksi.Text = kdTransaksi
        Me.txt_harga_total.Text = 0
        Me.txt_harga_akhir.Text = 0
        Me.txt_diskon.Text = 0
        MsgBox("Sukses Data Tersimpan!")

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim keywoard = TextBox1.Text
        dt_barang_keluar.Rows.Clear()
        Dim search As List(Of Object)
        If keywoard <> "" Then
            search = listBarangMasuk.Where(Function(x) keywoard.StartsWith(x.serial_number) Or
                                              keywoard.StartsWith(x.kd_transaksi_keluar) Or
                                              keywoard.StartsWith(x.nama_tipe) Or
                                              keywoard.StartsWith(x.nama_jenis)).ToList()
        Else
            search = listBarangMasuk.ToList()
        End If


        MappingToDataGridBarangKeluar(search)
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub
End Class