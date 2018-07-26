Public Class UI
    Private Sub Hostel_Click(sender As Object, e As EventArgs) Handles Hostel.Click
        Hostels.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Wardens_Click(sender As Object, e As EventArgs) Handles Wardens.Click
        Warden.Show()
        Me.Hide()
    End Sub

    Private Sub Student_Details_Click(sender As Object, e As EventArgs) Handles Student_Details.Click
        Student.Show()
        Me.Hide()
    End Sub

    Private Sub Allocation_Click(sender As Object, e As EventArgs) Handles Allocation.Click
        Allocate.Show()
        Me.Hide()
    End Sub

    Private Sub Hostel_occupants_Click(sender As Object, e As EventArgs) Handles Hostel_occupants.Click
        Occupants.Show()
        Me.Hide()
    End Sub
End Class