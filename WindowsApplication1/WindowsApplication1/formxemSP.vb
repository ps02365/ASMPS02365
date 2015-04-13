Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmxemSP
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

    Private Sub frmxemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sử dụng hàm loadDB để lấy dữ liệu và ẩn các text box
        loadDB()
        txtgiaSP.Enabled = False
        txtloaiSP.Enabled = False
        txtmaSP.Enabled = False
        txtmotaSP.Enabled = False
        txttenSP.Enabled = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 dòng bất kỳ, sẽ đổ dữ liệu về textbox tương ứng
        Dim getdata As Integer = DataGridView1.CurrentCell.RowIndex
        txtmaSP.Text = DataGridView1.Item(0, getdata).Value
        txttenSP.Text = DataGridView1.Item(1, getdata).Value
        txtmotaSP.Text = DataGridView1.Item(2, getdata).Value
        txtgiaSP.Text = DataGridView1.Item(3, getdata).Value
        txtloaiSP.Text = DataGridView1.Item(4, getdata).Value
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class