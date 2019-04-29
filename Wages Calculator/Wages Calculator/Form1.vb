Public Class Form1
   
    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click

        If txtempnumb.Text = "" Then
            MsgBox("Please Enter Employee Number")
        End If
        If txtname.Text = "" Then
            MsgBox("Please enter Name")
        End If
        If chkbankholiday.Checked = True And radunder18.Checked = True Then
            txtgrosspay.Text = (cbmpayrate.Text * cbmhours.Text) * 2
            txtbasicpay.Text = cbmpayrate.Text * cbmhours.Text
            txttax.Text = "0"
        End If
    End Sub
End Class
