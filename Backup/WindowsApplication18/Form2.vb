Imports System.Data.OleDb
Public Class Form2
    Dim da As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As DataSet
    Dim cm As OleDbCommand
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BMW.accdb")

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.MusteriTableAdapter.Fill(Me.BMWDataSet.musteri)
        Dim a As Integer
        TextBox7.DataBindings.Add("text", BMWDataSet, "musteri.no")
        TextBox7.Text = Convert.ToInt16(a)
        TextBox1.Text = a + 6
    End Sub

    Private Sub MusteriBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BMWDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        MusteriBindingSource.AddNew()
        Me.MusteriBindingSource.Current("no") = TextBox1.Text
        Me.MusteriBindingSource.Current("ad") = TextBox2.Text
        Me.MusteriBindingSource.Current("soyad") = TextBox3.Text
        Me.MusteriBindingSource.Current("tc") = TextBox4.Text
        Me.MusteriBindingSource.Current("numara") = TextBox5.Text
        Me.MusteriBindingSource.Current("adres") = TextBox6.Text
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(BMWDataSet)
        MsgBox("kayıt eklendi...")
    End Sub
End Class