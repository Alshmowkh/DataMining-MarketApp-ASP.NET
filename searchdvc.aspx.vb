Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplication
Imports System.Web.HttpResponse
Imports System.Web.HttpRequest
'Imports ASP.searchdesk_aspx
Imports ASP.searchdvc_aspx


Partial Class _Default
    Inherits System.Web.UI.Page



    'Protected Sub drpcartype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcartype.SelectedIndexChanged
    '    'Me.drpcartype.Items.Clear()
    '    ' Dim i As Integer
    '    ' Dim con As New OleDbConnection
    '    'con.ConnectionString = ConfigurationManager.AppSettings("con")
    '    'con.Open()
    '    'Dim ds As New Data.DataSet
    '    'Dim dp As New OleDbDataAdapter("SELECT * FROM n where w =" & Me.drpcartype.Text & " ", con)
    '    'dp.Fill(ds, "n")

    '    'Me.GridView1.DataSource = ds
    '    'Me.GridView1.DataMember = "n"

    'End Sub



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.drpcntry.Items.Count < 2 Then

            Dim ds As New Data.DataSet
            Dim i As Integer
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim dp As New OleDbDataAdapter("SELECT Distinct company.cmp_cntry FROM(company)", con)
            dp.Fill(ds, "n")



            Dim clr As Integer = ds.Tables("n").Rows.Count

                For i = 0 To clr - 1





                Me.drpcntry.Items.Add(ds.Tables("n").Rows(i).Item(0))

            Next

        End If

    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub


    Protected Sub drpcmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcmp.SelectedIndexChanged

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT device.dvc_id, device.dvc_type, device.dv_model, device.dvc_size, device.dvc_capacity, device.dvc_speed, device.dvc_product, device.dvc_price, company.cmp_name FROM company INNER JOIN device ON company.cmp_no = device.cmp_no WHERE (((company.cmp_name)='" & Me.drpcmp.SelectedValue & "'))", con)
        dp.Fill(ds, "bbb")
        Me.drptypecm.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")


        For i = 0 To ds.Tables("bbb").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("bbb").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("bbb").Rows(i).Item("dvc_type")) Then Me.drptypecm.Items.Add(ds.Tables("bbb").Rows(i).Item("dvc_type"))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()

    End Sub
    Protected Sub srshdv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles srshdv.Click
        Me.drpmodel.Items.Clear()

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT device.dv_model, device.dvc_type, company.cmp_name FROM company INNER JOIN device ON company.cmp_no = device.cmp_no WHERE (((device.dvc_type)='" & Me.drptypecm.SelectedValue & "') AND ((company.cmp_name)='" & Me.drpcmp.SelectedValue & "'))", con)
        dp.Fill(ds, "deskt")

        For i = 0 To ds.Tables("deskt").Rows.Count - 1

            '    Me.lb3.Text = ds.Tables("deskt").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item(0)) Then Me.drpmodel.Items.Add(ds.Tables("deskt").Rows(i).Item(0))
        Next
        'Me.drptypecm.Enabled = True
        con.Close()

    End Sub


    Protected Sub drpcntry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcntry.SelectedIndexChanged
        Me.drptypecm.Items.Clear()
        Me.drpcity.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT company.* FROM company WHERE (((company.cmp_cntry)='" & Me.drpcntry.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")
        Me.drpcity.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")
        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(i).Item(3)) Then Me.drpcity.Items.Add(ds.Tables("deskto").Rows(i).Item(3))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub

    Protected Sub drpcity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcity.SelectedIndexChanged
        Me.drptypecm.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT Distinct company.cmp_name FROM company WHERE (((company.cmp_city)='" & Me.drpcity.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")
        Me.drpcmp.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")

        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(i).Item(0)) Then Me.drpcmp.Items.Add(ds.Tables("deskto").Rows(i).Item(0))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub

    Protected Sub sendcomp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sendcomp.Click
        ' Session("sub") = Me.Label1.Text + (":") + Me.txtdvnamesr.Text + ("    ") + Me.txtdvmodelsr.Text + (":") + Me.txtdvspeedsr.Text + Me.txtdvsizesr.Text + Me.txtdvopacitysr.Text + Me.txtdvcostsr.Text + Me.txtdvothersr.Text

        Me.drptypecm.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT company.cmp_mail, company.cmp_name, company.cmp_no FROM company INNER JOIN email ON company.cmp_no = email.cmp_no WHERE cmp_name='" & Me.drpcmp.SelectedValue & "'", con)
        dp.Fill(ds, "deskto")

        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            Session("no") = ds.Tables("deskto").Rows(i).Item(2)
            Response.Redirect("send.aspx")
        Next


        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub

    Protected Sub drptypecm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drptypecm.SelectedIndexChanged
        Me.drpmodel.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT distinct device.dvc_id, device.dvc_type, device.dv_model, device.dvc_size, device.dvc_capacity, device.dvc_speed, device.dvc_product, device.dvc_price, company.cmp_name FROM company INNER JOIN device ON company.cmp_no = device.cmp_no WHERE company.cmp_name='" & Me.drpcmp.SelectedValue & "'and dvc_type='" & Me.drptypecm.SelectedValue & "'", con)
        dp.Fill(ds, "bbb")
        Me.drptypecm.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")


        For i = 0 To ds.Tables("bbb").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("bbb").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("bbb").Rows(i).Item(0)) Then Me.drpmodel.Items.Add(ds.Tables("bbb").Rows(i).Item(0))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()

    End Sub

    Protected Sub drpmodel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpmodel.SelectedIndexChanged
        Me.lb10.Visible = True
        Me.lb3.Visible = True
        Me.lb4.Visible = True
        Me.lb5.Visible = True
        Me.lb6.Visible = True
        Me.lb7.Visible = True
        Me.lb8.Visible = True
        Me.lb12.Visible = True
        Me.lb14.Visible = True
        ' Me.Label1.Visible = True
        Me.Label11.Visible = True
        Me.Label9.Visible = True


        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim d As New OleDbDataAdapter("SELECT device.dvc_id, device.dvc_type, device.dv_model, device.dvc_size, device.dvc_capacity, device.dvc_speed, device.dvc_product, device.dvc_price, device.cmp_no FROM company INNER JOIN device ON company.cmp_no = device.cmp_no WHERE dvc_id='" & Me.drpmodel.SelectedValue & "'", con)
        d.Fill(ds, "deskt")

        For i = 0 To ds.Tables("deskt").Rows.Count - 1
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dvc_type")) Then Me.lb4.Text = ds.Tables("deskt").Rows(i).Item("dvc_type")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dv_model")) Then Me.lb6.Text = ds.Tables("deskt").Rows(i).Item("dv_model")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dvc_speed")) Then Me.lb8.Text = ds.Tables("deskt").Rows(i).Item("dvc_speed")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dvc_size")) Then Me.lb10.Text = ds.Tables("deskt").Rows(i).Item("dvc_size")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dvc_capacity")) Then Me.lb12.Text = ds.Tables("deskt").Rows(i).Item("dvc_capacity")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dvc_price")) Then Me.lb14.Text = ds.Tables("deskt").Rows(i).Item("dvc_price")
           
        Next

        con.Close()

        

    End Sub
End Class

