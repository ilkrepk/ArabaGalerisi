Public Class Form4
    Dim fiyat, vade, pesin, vadee, sonuc, xsonuc As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fiyat = Convert.ToInt32(TextBox8.Text)
        If RadioButton1.Checked Then
            pesin = (fiyat * 1.1) - fiyat
            sonuc = fiyat - pesin
            TextBox10.Text = sonuc
            If CheckBox2.Checked Then
                xsonuc = sonuc + 1000
                TextBox9.Text = "peşin alımda %10 iskonto uygulandı...fiyat : " & xsonuc & " TL olmustur..."

            End If
        End If

        TextBox9.Text = "peşin alımda %10 iskonto uygulandı...fiyat : " & sonuc & " TL olmustur..."

        If RadioButton2.Checked Then
            pesin = fiyat * 1.2
            vade = pesin / 12
            TextBox9.Text = "12 ay vadeli satışta %10 vade farkı uygulandı...fiyat : " & pesin & " TL olmustur...Ve aylık ödeme tutarınız :" & vade & " TL'dir..."
            TextBox10.Text = pesin
        End If
        If RadioButton3.Checked Then
            pesin = fiyat * 1.3
            vadee = fiyat / 24
            TextBox9.Text = "24 ay vadeli satışta %20 vade farkı uygulandı...fiyat : " & pesin & " TL olmustur...Ve aylık ödeme tutarınız :" & vadee & " TL'dir..."
            TextBox10.Text = pesin
        End If
    End Sub

    Private Sub MusteriBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BMWDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BMWDataSet.musteri' table. You can move, or remove it, as needed.
        Me.MusteriTableAdapter.Fill(Me.BMWDataSet.musteri)
        'TODO: This line of code loads data into the 'BMWDataSet.musteri' table. You can move, or remove it, as needed.
        Me.MusteriTableAdapter.Fill(Me.BMWDataSet.musteri)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MusteriBindingSource.AddNew()
        Me.MusteriBindingSource.Current("no") = TextBox1.Text
        Me.MusteriBindingSource.Current("ad") = TextBox2.Text
        Me.MusteriBindingSource.Current("soyad") = TextBox3.Text
        Me.MusteriBindingSource.Current("tc") = TextBox4.Text
        Me.MusteriBindingSource.Current("numara") = TextBox5.Text
        Me.MusteriBindingSource.Current("adres") = TextBox6.Text
        Me.MusteriBindingSource.Current("model") = TextBox7.Text
        Me.MusteriBindingSource.Current("fiyat") = TextBox8.Text
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(BMWDataSet)
        MsgBox("kayıt eklendi...")
    End Sub

    Private Sub MusteriBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BMWDataSet)

    End Sub
End Class