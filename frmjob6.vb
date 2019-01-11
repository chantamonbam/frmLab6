Public Class frmjob6

    Dim startPrice As Integer = 1250000
    Dim Free1 As Integer = 25000
    Dim Free2 As Integer = 15000
    Dim Free3 As Integer = 35000

    Dim Itemsprice1 As Integer = 40000
    Dim Itemsprice2 As Integer = 50000
    Dim Itemsprice3 As Integer = 20000
    Dim Itemsprice4 As Integer = 30000
   

    Private Sub chkCarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.CheckedChanged

        If chkCarForMe.Checked = True Then

            grbaccessory.Enabled = True
            grbPrivilege.Enabled = True
            lblPaidPrice.Text = startPrice + Free1 + Free2 + Free3

        End If


        If chkCarForMe.Checked = False Then

            grbaccessory.Enabled = False
            grbPrivilege.Enabled = False

            Dim result As Integer = MessageBox.Show("ต้องกาารยกเลิกการซื้อรถยนต์ใช่หรือไม่", "เกิดข้อผิดพลาด", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                grbaccessory.Enabled = False
                grbPrivilege.Enabled = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False

                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                lblPaidPrice.Text = ""

            End If
            If result = DialogResult.No Then
                chkCarForMe.Checked = True
                grbaccessory.Enabled = True
                grbPrivilege.Enabled = True
            End If
        End If
    End Sub

      Private Sub frmjob6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grbaccessory.Enabled = False
        grbPrivilege.Enabled = False


    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        
        If chkFree1.Checked = True Then

            lblPaidPrice.Text = lblPaidPrice.Text - Free1
        ElseIf chkFree1.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + Free1

        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged

        If chkFree2.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text - Free2
        ElseIf chkFree2.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + Free2

        End If

    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged

        If chkFree3.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text - Free3
        ElseIf chkFree3.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + Free3
        End If

       
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged

        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + Itemsprice1
        ElseIf chkItemsAdd1.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - Itemsprice1
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged

        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + Itemsprice2
        ElseIf chkItemsAdd2.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - Itemsprice2
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged

        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + Itemsprice3
        ElseIf chkItemsAdd3.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - Itemsprice3
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged

        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + Itemsprice4
        ElseIf chkItemsAdd4.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - Itemsprice4
        End If
    End Sub
End Class