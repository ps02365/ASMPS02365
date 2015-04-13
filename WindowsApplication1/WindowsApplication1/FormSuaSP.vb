Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmsuaSP
    Dim table As New DataTable
    Dim connectDB As String = "workstation id=hungnhps02365.mssql.somee.com;packet size=4096;user id=hungnh;pwd=123456a@;data source=hungnhps02365.mssql.somee.com;persist security info=False;initial catalog=hungnhps02365"
    'Tạo hàm lấy dữ liệu đổ vào datagridview
    Public Sub loadDB()
        Dim connect As New SqlConnection(connectDB)
        Dim sqladapter As New SqlDataAdapter("select * from SAN_PHAM", connect)
        Try
            sqladapter.Fill(table)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = table
        connect.Close()
    End Sub
    Private Sub frmsuaSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sử dụng hàm loadDB để lấy dữ liệu
        loadDB()
        'Ẩn các textbox và nút Sửa
        btnsua.Enabled = False
        txtgiaSP.Enabled = False
        cboloaiSP.Enabled = False
        txtmaSP.Enabled = False
        txtmotaSP.Enabled = False
        txttenSP.Enabled = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 dòng bất kỳ, sẽ đổ dữ liệu về textbox tương ứng và hiện các textbox và nút Sửa
        Dim getdata As Integer = DataGridView1.CurrentCell.RowIndex
        txtmaSP.Text = DataGridView1.Item(0, getdata).Value
        txttenSP.Text = DataGridView1.Item(1, getdata).Value
        txtmotaSP.Text = DataGridView1.Item(2, getdata).Value
        txtgiaSP.Text = DataGridView1.Item(3, getdata).Value
        cboloaiSP.Text = DataGridView1.Item(4, getdata).Value
        btnsua.Enabled = True
        txtgiaSP.Enabled = True
        cboloaiSP.Enabled = True
        txtmaSP.Enabled = False
        txtmotaSP.Enabled = True
        txttenSP.Enabled = True
        btnsua.Enabled = True
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        'Xóa dữ liệu trong textbox
        txtmaSP.Clear()
        txtgiaSP.Clear()
        cboloaiSP.Text = "T01"
        txtmotaSP.Clear()
        txttenSP.Clear()
        'Ẩn các textbox và nút Sửa
        btnsua.Enabled = False
        txtgiaSP.Enabled = False
        cboloaiSP.Enabled = False
        txtmaSP.Enabled = False
        txtmotaSP.Enabled = False
        txttenSP.Enabled = False
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Đóng form
        btnsua.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        'Kết nối tới Database
        Dim connect As New SqlConnection(connectDB)
        connect.Open()
        'Câu truy vấn thêm dữ liệu
        Dim update As String = "UPDATE SAN_PHAM SET Ten_san_pham =@Ten_san_pham, Chi_tiet_san_pham =@mo_ta, don_gia =@don_gia, LOAI_SAN_PHAM_Loai_san_pham_ID = @Loai_san_pham_ID WHERE San_pham_ID =@San_pham_ID"
        Dim nhap As New SqlCommand(update, connect)
        Try
            'Thêm dữ liệu vào câu lệnh truy vấn
            nhap.Parameters.AddWithValue("@San_pham_ID", txtmaSP.Text)
            nhap.Parameters.AddWithValue("@Ten_san_pham", txttenSP.Text)
            nhap.Parameters.AddWithValue("@don_gia", txtgiaSP.Text)
            nhap.Parameters.AddWithValue("@mo_ta", txtmotaSP.Text)
            nhap.Parameters.AddWithValue("@Loai_san_pham_ID", cboloaiSP.Text)
            'Thực thi câu lệnh truy vấn thêm dữ liệu
            nhap.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Load lại danh sách SP
        table.Clear()
        DataGridView1.DataSource = table
        DataGridView1.DataSource = Nothing
        loadDB()
        connect.Close()
    End Sub
End Class