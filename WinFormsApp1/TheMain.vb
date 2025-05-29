Public Class TheMain
    Private Sub Button_subscriber_Click(sender As Object, e As EventArgs) Handles Button_subscriber.Click
        Subscriber.Show()
    End Sub

    Private Sub Button_donor_Click(sender As Object, e As EventArgs) Handles Button_donor.Click
        donor.Show()
    End Sub

    Private Sub Button_family_Click(sender As Object, e As EventArgs) Handles Button_family.Click
        family.Show()
    End Sub

    Private Sub Button_item_Click(sender As Object, e As EventArgs) Handles Button_item.Click
        Item.Show()
    End Sub

    Private Sub Button_need_Click(sender As Object, e As EventArgs) Handles Button_need.Click
        needs.Show()
    End Sub

    Private Sub Button_donation_Click(sender As Object, e As EventArgs) Handles Button_donation.Click
        Donation.Show()
    End Sub

    Private Sub Button_report_Click(sender As Object, e As EventArgs) Handles Button_report.Click
        Report.Show()
    End Sub

    Private Sub Button_medical_Click(sender As Object, e As EventArgs) Handles Button_medical.Click
        MedicalRecord.Show()
    End Sub
End Class