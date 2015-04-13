Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmxoaSP
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
    Private Sub frmxoaSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sử dụng hàm loadDB để lấy dữ liệu và vô hiệu hóa các textbox trừ mã SP 
        loadDB()
        txtgiaSP.Enabled = False
        txtloaiSP.Enabled = False
        txtmaSP.Enabled = True
        txtmotaSP.Enabled = False
        txttenSP.Enabled = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 dòng bất kỳ, sẽ đổ dữ liệu về textbox tương ứng và ẩn textbox mã SP
        Dim getdata As Integer = DataGridView1.CurrentCell.RowIndex
        txtmaSP.Text = DataGridView1.Item(0, getdata).Value
        txttenSP.Text = DataGridView1.Item(1, getdata).Value
        txtmotaSP.Text = DataGridView1.Item(2, getdata).Value
        txtgiaSP.Text = DataGridView1.Item(3, getdata).Value
        txtloaiSP.Text = DataGridView1.Item(4, getdata).Value
        txtmaSP.Enabled = False
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        'Xóa dữ liệu trong textbox và hiện textbox mã SP
        txtmaSP.Clear()
        txtgiaSP.Clear()
        txtloaiSP.Clear()
        txtmotaSP.Clear()
        txttenSP.Clear()
        txtmaSP.Enabled = True
        txtmaSP.Focus()
        txtmaSP.Enabled = True
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Đóng form
        Me.Close()
    End Sub

    Private Sub btnxoaSP_Click(sender As Object, e As EventArgs) Handles btnxoaSP.Click
        Dim connect As New SqlConnection(connectDB)
        connect.Open()
        Dim delete As String = "DELETE from SAN_PHAM WHERE San_pham_ID =@San_pham_ID"
        Dim nhap As New SqlCommand(delete, connect)
            Try
                nhap.Parameters.AddWithValue("@San_pham_ID", txtmaSP.Text)
                nhap.ExecuteNonQuery()
                connect.Close()
            Catch ex As Exception
                MessageBox.Show("Vui lòng nhập đúng mã SP", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            table.Clear()
            DataGridView1.DataSource = table
            DataGridView1.DataSource = Nothing
            loadDB()
        txtmaSP.Clear()
        txtgiaSP.Clear()
        txtloaiSP.Clear()
        txtmotaSP.Clear()
        txttenSP.Clear()
        txtmaSP.Focus()
        txtmaSP.Enabled = True
    End Sub
End Class