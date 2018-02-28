Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub GirisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GirisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BMWDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BMWDataSet.BMWCABRIO' table. You can move, or remove it, as needed.
        Me.BMWCABRIOTableAdapter.Fill(Me.BMWDataSet.BMWCABRIO)
        'TODO: This line of code loads data into the 'BMWDataSet.giris' table. You can move, or remove it, as needed.
        Me.GirisTableAdapter.Fill(Me.BMWDataSet.giris)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GirisBindingSource.Filter = "isim='" + TextBox1.Text + "' and sifre='" + TextBox2.Text + "'"
        If GirisBindingSource.Count = 1 Then
            Form5.Show()
        Else
            MsgBox("hatalı kullanıcıadı veya parola...")
        End If
    End Sub
End Class
