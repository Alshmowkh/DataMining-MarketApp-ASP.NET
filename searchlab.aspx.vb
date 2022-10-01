Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplication
Imports System.Web.HttpResponse
Imports System.Web.HttpRequest
Imports ASP.searchlab_aspx

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
            Dim i As Integer
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet

            ds.Clear()
            Dim dp As New OleDbDataAdapter("SELECT distinct cmp_cntry FROM company ", con)
            dp.Fill(ds, "company")
            Dim clr As Integer = ds.Tables("company").Rows.Count
            '
            For i = 0 To clr - 1

                Me.drpcntry.Items.Add(ds.Tables("company").Rows(i).Item(0))
            Next


        End If
        
       
    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub


    Protected Sub drpcmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcmp.SelectedIndexChanged
        Me.lb10.Visible = False
        Me.lb3.Visible = False
        Me.lb4.Visible = False
        Me.lb5.Visible = False
        Me.lb6.Visible = False
        Me.lb7.Visible = False
        Me.lb8.Visible = False
        Me.lb12.Visible = False
        Me.lb14.Visible = False
        Me.Label1.Visible = False
        Me.Label11.Visible = False
        Me.Label9.Visible = False

        Me.drptypecm.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.drptypecm.Items.Add("")

        Dim dp As New OleDbDataAdapter("SELECT distinct laptob.lap_type, company.cmp_name FROM company INNER JOIN laptob ON company.cmp_no = laptob.cmp_no WHERE (((company.cmp_name)='" & Me.drpcmp.SelectedValue & "'))", con)
        dp.Fill(ds, "des")

        For i = 0 To ds.Tables("des").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("des").Rows(i).Item(0)) Then Me.drptypecm.Items.Add(ds.Tables("des").Rows(i).Item(0))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()

    End Sub

    Protected Sub droptype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drptypecm.SelectedIndexChanged
        Me.dropmodel.Items.Clear()

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.dropmodel.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")

        Dim d As New OleDbDataAdapter("SELECT laptob.lap_modul, laptob.lap_type, company.cmp_name FROM company INNER JOIN laptob ON company.cmp_no = laptob.cmp_no WHERE (((laptob.lap_type)='" & Me.drptypecm.SelectedValue & "') AND ((company.cmp_name)='" & Me.drpcmp.SelectedValue & "'))", con)
        d.Fill(ds, "tt")

        For i = 0 To ds.Tables("tt").Rows.Count - 1

            '    Me.lb3.Text = ds.Tables("deskt").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("tt").Rows(i).Item(0)) Then Me.dropmodel.Items.Add(ds.Tables("tt").Rows(i).Item(0))
        Next
        'Me.drptypecm.Enabled = True
        con.Close()
        Me.Button4.Visible = True
         End Sub
    Protected Sub drpcntry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcntry.SelectedIndexChanged
        Me.drptypecm.Items.Clear()
        Me.drpcity.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Me.drpcity.Items.Add("")
        Dim dp As New OleDbDataAdapter("SELECT DISTINCT  company.cmp_cntry, company.cmp_city FROM company WHERE (((company.cmp_cntry)='" & Me.drpcntry.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")

        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(i).Item(0)) Then Me.drpcity.Items.Add(ds.Tables("deskto").Rows(i).Item(1))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub

    Protected Sub drpcity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcity.SelectedIndexChanged
        Me.drptypecm.Items.Clear()
        Me.drpcmp.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.drpcmp.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")
        Dim dp As New OleDbDataAdapter("SELECT distinct company.cmp_name FROM company WHERE (((company.cmp_city)='" & Me.drpcity.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")
        ' MsgBox("fuck you")
        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(i).Item(0)) Then Me.drpcmp.Items.Add(ds.Tables("deskto").Rows(i).Item(0))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()

    End Sub

   
    Protected Sub sendcomp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sendcomp.Click
        Session("sub") = (Me.lb3.Text + (":") + Me.lb4.Text + ("    ") + Me.lb7.Text + (":") + Me.lb8.Text + Me.lb5.Text + Me.lb6.Text + Me.Label9.Text + Me.lb10.Text + Me.Label11.Text + Me.lb12.Text + Me.Label1.Text + Me.lb14.Text)
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
            'Session("b") = ds.Tables("deskto").Rows(i).Item("cmp_mail")
            Session("no") = ds.Tables("deskto").Rows(i).Item(2)
        Next

        Response.Redirect("send.aspx")

        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub

    Protected Sub dropmodel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lb10.Visible = True
        Me.lb3.Visible = True
        Me.lb4.Visible = True
        Me.lb5.Visible = True
        Me.lb6.Visible = True
        Me.lb7.Visible = True
        Me.lb8.Visible = True
        Me.lb12.Visible = True
        Me.lb14.Visible = True
        Me.Label1.Visible = True
        Me.Label11.Visible = True
        Me.Label9.Visible = True


        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim d As New OleDbDataAdapter("SELECT laptob.lap_hdd, laptob.lap_ram, laptob.lap_cpu, laptob.lap_lcd, laptob.lap_cost, laptob.lap_other, company.cmp_name, laptob.lap_type, laptob.lap_modul FROM company INNER JOIN laptob ON company.cmp_no = laptob.cmp_no WHERE (((company.cmp_name)='" & Me.drpcmp.SelectedValue & "') AND ((laptob.lap_type)='" & Me.drptypecm.SelectedValue & "') AND ((laptob.lap_modul)='" & Me.dropmodel.SelectedValue & "'))", con)
        d.Fill(ds, "dest")

        For i = 0 To ds.Tables("dest").Rows.Count - 1
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_hdd")) Then Me.lb4.Text = ds.Tables("dest").Rows(i).Item("lap_hdd")
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_cpu")) Then Me.lb8.Text = ds.Tables("dest").Rows(i).Item("lap_cpu")
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_ram")) Then Me.lb6.Text = ds.Tables("dest").Rows(i).Item("lap_ram")
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_lcd")) Then Me.lb10.Text = ds.Tables("dest").Rows(i).Item("lap_lcd")
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_other")) Then Me.lb12.Text = ds.Tables("dest").Rows(i).Item("lap_other")
            If Not IsDBNull(ds.Tables("dest").Rows(i).Item("lap_cost")) Then Me.lb14.Text = ds.Tables("dest").Rows(i).Item("lap_cost")
            'Me.lb14.Text = ds.Tables("deskt").Rows(i).Item("lap_cost")

        Next

        con.Close()


    End Sub
End Class
