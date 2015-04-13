Public Class frmmain
    Private Sub mnslogout_Click(sender As Object, e As EventArgs) Handles mnslogout.Click
        'Đăng xuất
        frmdangnhap.Show()
        Me.Close()
    End Sub

    Private Sub mnslicense_Click(sender As Object, e As EventArgs) Handles mnslicense.Click
        'Mở form bản quyền
        frmlicense.Show()
    End Sub

    Private Sub mnsxemSP_Click(sender As Object, e As EventArgs) Handles mnsxemSP.Click
        'Mở form xem sản phẩm
        frmxemSP.Show()
    End Sub

    Private Sub mnsthemSP_Click(sender As Object, e As EventArgs) Handles mnsthemSP.Click
        'Mở form thêm sản phẩm
        frmthemSP.Show()
    End Sub

    Private Sub mnssuaSP_Click(sender As Object, e As EventArgs) Handles mnssuaSP.Click
        'Mở form sửa sản phẩm
        frmsuaSP.Show()
    End Sub

    Private Sub mnsxoaSP_Click(sender As Object, e As EventArgs) Handles mnsxoaSP.Click
        'Mở form xóa sản phẩm
        frmxoaSP.Show()
    End Sub

    Private Sub mnsexit_Click(sender As Object, e As EventArgs) Handles mnsexit.Click
        Me.Close()
        frmdangnhap.Close()
    End Sub

End Class