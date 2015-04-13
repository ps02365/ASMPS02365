Imports System.Data.SqlClient
Public Class frmdangnhap
    'Sự kiện nút đăng nhập
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'kết nối tới Database
        Dim ketnoiDB As String = "workstation id=hungnhps02365.mssql.somee.com;packet size=4096;user id=hungnh;pwd=123456a@;data source=hungnhps02365.mssql.somee.com;persist security info=False;initial catalog=hungnhps02365"
        Dim ketnoi As SqlConnection = New SqlConnection(ketnoiDB)
        'Câu lệnh truy vấn đến DB để xác thực tài khoản
        Dim sqlAdapter As New SqlDataAdapter("Select * from TAI_KHOAN where Username='" & txtID.Text & "' and password ='" & txtPW.Text & "'", ketnoi)
        Dim table As New DataTable
        Try
            ketnoi.Open()
            sqlAdapter.Fill(table)
            'Nếu để tróng tên đăng nhập hoặc mật khẩu sẽ báo lỗi
            If txtID.Text = "" OrElse txtPW.Text = "" Then
                lblmes.Text = ""
                lblmes2.Text = "Không được để trống tên đăng nhập hoặc mật khẩu"
            ElseIf table.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK)
                txtID.Clear()
                txtPW.Clear()
                txtID.Focus()
                lblmes.Text = ""
                lblmes2.Text = ""
                frmmain.Show()
                Me.Hide()
            Else
                lblmes2.Text = ""
                lblmes.Text = "Sai tên đăng nhập hoặc mật khẩu!"
            End If
        Catch ex As Exception
        End Try

    End Sub
    'Sự kiện nút Thoát
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtPW_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPW.KeyDown
        'Tại textbox mật khẩu nhấn Enter sẽ thực thi sự kiện nút đăng nhập
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
        End If
    End Sub

    Private Sub btnxoaID_Click(sender As Object, e As EventArgs) Handles btnxoaID.Click
        'Xóa dữ liệu textbox Tên tài khoản
        txtID.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnxoaPW_Click(sender As Object, e As EventArgs) Handles btnxoaPW.Click
        'Xóa dữ liệu textbox Mật khẩu
        txtPW.Clear()
        txtPW.Focus()
    End Sub

End Class
