
Imports System.Data.OleDb
Public Class Form3
    Dim da As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As DataSet
    Dim cm As OleDbCommand
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BMW.accdb")

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BMWDataSet.BMWTOURING' table. You can move, or remove it, as needed.
        Me.BMWTOURINGTableAdapter.Fill(Me.BMWDataSet.BMWTOURING)
        'TODO: This line of code loads data into the 'BMWDataSet.BMWSEDAN' table. You can move, or remove it, as needed.
        Me.BMWSEDANTableAdapter.Fill(Me.BMWDataSet.BMWSEDAN)
        'TODO: This line of code loads data into the 'BMWDataSet.BMWCOUPE' table. You can move, or remove it, as needed.
        Me.BMWCOUPETableAdapter.Fill(Me.BMWDataSet.BMWCOUPE)
        'TODO: This line of code loads data into the 'BMWDataSet.BMWCABRIO' table. You can move, or remove it, as needed.
        Me.BMWCABRIOTableAdapter.Fill(Me.BMWDataSet.BMWCABRIO)
        'TODO: This line of code loads data into the 'BMWDataSet.musteri' table. You can move, or remove it, as needed.
        Me.MusteriTableAdapter.Fill(Me.BMWDataSet.musteri)
        TextBox1.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.model")
        TextBox2.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.silindir")
        TextBox3.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.guc")
        TextBox4.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.agirlik")
        TextBox5.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.depo")
        TextBox6.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.kapi")
        TextBox7.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.koltuk")
        TextBox8.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.0-100")
        TextBox9.DataBindings.Add("text", BMWDataSet, "BMWSEDAN.fiyat")


        Me.BMWCABRIOTableAdapter.Fill(Me.BMWDataSet.BMWCABRIO)



        TextBox18.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.model")
        TextBox17.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.silindir")
        TextBox16.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.guc")
        TextBox15.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.agırlık")
        TextBox14.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.depo")
        TextBox13.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.kapi")
        TextBox12.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.koltuk")
        TextBox11.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.0-100")
        TextBox10.DataBindings.Add("text", BMWDataSet, "BMWCOUPE.fiyat")




        TextBox27.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.model")
        TextBox26.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.silindir")
        TextBox25.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.guc")
        TextBox24.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.agirlik")
        TextBox23.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.depo")
        TextBox22.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.kapi")
        TextBox21.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.koltuk")
        TextBox20.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.0-100")
        TextBox19.DataBindings.Add("text", BMWDataSet, "BMWCABRIO.fiyat")



        TextBox36.DataBindings.Add("text", BMWDataSet, "BMWTOURING.model")
        TextBox35.DataBindings.Add("text", BMWDataSet, "BMWTOURING.silindir")
        TextBox34.DataBindings.Add("text", BMWDataSet, "BMWTOURING.guc")
        TextBox33.DataBindings.Add("text", BMWDataSet, "BMWTOURING.agirlik")
        TextBox32.DataBindings.Add("text", BMWDataSet, "BMWTOURING.depo")
        TextBox31.DataBindings.Add("text", BMWDataSet, "BMWTOURING.kapi")
        TextBox30.DataBindings.Add("text", BMWDataSet, "BMWTOURING.koltuk")
        TextBox29.DataBindings.Add("text", BMWDataSet, "BMWTOURING.0-100")
        TextBox28.DataBindings.Add("text", BMWDataSet, "BMWTOURING.fiyat")


    End Sub

    Private Sub MusteriBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BMWDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ileri As BindingManagerBase = BindingContext(BMWDataSet, "BMWSEDAN")
        ileri.Position += 1

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim geri As BindingManagerBase = BindingContext(BMWDataSet, "BMWSEDAN")
        geri.Position -= 1
    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ileri As BindingManagerBase = BindingContext(BMWDataSet, "BMWCOUPE")
        ileri.Position += 1

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim geri As BindingManagerBase = BindingContext(BMWDataSet, "BMWCOUPE")
        geri.Position -= 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim geri As BindingManagerBase = BindingContext(BMWDataSet, "BMWCABRIO")
        geri.Position -= 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ileri As BindingManagerBase = BindingContext(BMWDataSet, "BMWCABRIO")
        ileri.Position += 1

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim ileri As BindingManagerBase = BindingContext(BMWDataSet, "BMWTOURING")
        ileri.Position += 1

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim geri As BindingManagerBase = BindingContext(BMWDataSet, "BMWTOURING")
        geri.Position -= 1
    End Sub
End Class