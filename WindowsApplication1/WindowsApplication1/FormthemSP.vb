Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmthemSP
    'Tạo biến lấy dữ liệu từ Database
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
    Private Sub frmthemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sử dụng hàm loadDB để lấy dữ liệu
        loadDB()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 dòng bất kỳ, sẽ đổ dữ liệu về textbox tương ứng
            Dim getdata As Integer = DataGridView1.CurrentCell.RowIndex
            txtmaSP.Text = DataGridView1.Item(0, getdata).Value
            txttenSP.Text = DataGridView1.Item(1, getdata).Value
        txtmotaSP.Text = DataGridView1.Item(2, getdata).Value
            txtgiaSP.Text = DataGridView1.Item(3, getdata).Value
        cboloaiSP.Text = DataGridView1.Item(4, getdata).Value
        'Nếu các textbox không rỗng thì sẽ ẩn nút thêm
        If txtgiaSP.Text OrElse txtmaSP.Text OrElse txtmotaSP.Text OrElse txttenSP.Text Is Nothing Then
            btnthem.Enabled = False
        End If
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        'Khi click sẽ thêm sản phẩm vào Database
        'Kết nối tới Database
        Dim connect As New SqlConnection(connectDB)
        'Câu truy vấn thêm dữ liệu
        Dim input As New SqlDataAdapter("INSERT INTO SAN_PHAM VALUES('" & txtmaSP.Text & "','" & txttenSP.Text & "','" & txtmotaSP.Text & "','" & txtgiaSP.Text & "','" & cboloaiSP.Text & "')", connect)        
            Try
                connect.Open()
                input.Fill(table)
            Catch ex As Exception
                MessageBox.Show("Không được trùng Mã SP và vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtmaSP.Focus()
            End Try

        'Load lại danh sách SP
        table.Clear()
        DataGridView1.DataSource = table
        DataGridView1.DataSource = Nothing
        loadDB()
        connect.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        'Xóa dữ liệu trong textbox và hiện nút Thêm
        txtmaSP.Clear()
        txtgiaSP.Clear()
        txtmotaSP.Clear()
        txttenSP.Clear()
        cboloaiSP.Text = "T01"
        btnthem.Enabled = True
        txtmaSP.Focus()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'hiện nút thêm và đóng form
        btnthem.Enabled = True
        Me.Close()
    End Sub
End Class