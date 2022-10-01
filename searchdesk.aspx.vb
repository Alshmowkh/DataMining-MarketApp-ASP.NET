Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplication
Imports System.Web.HttpResponse
Imports System.Web.HttpRequest
Imports ASP.searchdesk_aspx

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click


        'Dim i As Integer
        '  Dim con As New OleDbConnection
        ' ' con.ConnectionString = ConfigurationManager.AppSettings("con")
        ' con.Open()
        ' Dim ds As New Data.DataSet
        '  Dim dp As New OleDbDataAdapter("SELECT q FROM n ", con)
        ' dp.Fill(ds, "n")
        ' Dim s As New OleDbCommand
        ' s.Connection = con
        's.CommandType = Data.CommandType.Text
        ' s.CommandText = "insert into n (w,q) values (" & Me.TextBox2.Text & ",'" & Me.TextBox1.Text & "')"
        'con.Open()
        ' s.ExecuteNonQuery()
        ' con.Close()
        ' Response.Redirect("Default.aspx")
        '    For i = 0 To ds.Tables("n").Rows.Count = 0
        '        'Response.Write(Me.TextBox1.Text = ds.Tables("n").Rows(i).Item(0))
        '        'Response.Write(Me.TextBox2.Text = ds.Tables("n").Rows(i).Item(1))

        '        drpcartype.Items.Add(ds.Tables("n").Rows(i).Item(0))
        '    Next
        'End If
    End Sub

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

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '1.0.1
        Session("qw") = Me.drpcntry.SelectedValue
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
        '1.1.3
        Me.drptypecm.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT desktob.dsk_type, desktob.cmp_no, company.cmp_name FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no WHERE (((company.cmp_name)='" & Me.drpcmp.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")

        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(0).Item(0)) Then Me.drptypecm.Items.Add(ds.Tables("deskto").Rows(i).Item(0))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()
        Me.Button6.Enabled = True
    End Sub

    Protected Sub droptype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drptypecm.SelectedIndexChanged
        'SELECT desktob.dsk_modul, desktob.cmp_no, company.cmp_name FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no WHERE (((desktob.dsk_modul)="toshiba") AND ((company.cmp_name)="ØáÇá"));
        Me.dropmodel.Items.Clear()

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.dropmodel.Items.Add("ÇÎÊÑ ãä ÇáÞÇÆãÉ")
        Dim dp As New OleDbDataAdapter("SELECT desktob.dsk_modul, desktob.dsk_type, desktob.cmp_no, company.cmp_name FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no WHERE ((desktob.dsk_type)='" & Me.drptypecm.SelectedValue & "') AND ((company.cmp_name)='" & Me.drpcmp.SelectedValue & "')", con)
        dp.Fill(ds, "deskt")

        For i = 0 To ds.Tables("deskt").Rows.Count - 1

            '    Me.lb3.Text = ds.Tables("deskt").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item(0)) Then Me.dropmodel.Items.Add(ds.Tables("deskt").Rows(i).Item(0))
        Next
     
    End Sub
    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.dropmodel.Items.Clear()

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet

        Dim dp As New OleDbDataAdapter("SELECT desktob.dsk_modul, desktob.dsk_type, desktob.cmp_no, company.cmp_name FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no WHERE ((desktob.dsk_type)='" & Me.drptypecm.SelectedValue & "') AND ((company.cmp_name)='" & Me.drpcmp.SelectedValue & "')", con)
        dp.Fill(ds, "deskt")

        For i = 0 To ds.Tables("deskt").Rows.Count - 1

            '    Me.lb3.Text = ds.Tables("deskt").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item(0)) Then Me.dropmodel.Items.Add(ds.Tables("deskt").Rows(i).Item(0))
        Next
        'Me.drptypecm.Enabled = True
        con.Close()
        Me.Button4.Visible = True
        Me.Button6.Enabled = False
    End Sub

   
    
    Protected Sub drpcntry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcntry.SelectedIndexChanged
        '1.1.1
        Me.drptypecm.Items.Clear()
        Me.drpcity.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.drpcity.Items.Add("")
        Dim dp As New OleDbDataAdapter("SELECT company.* FROM company WHERE (((company.cmp_cntry)='" & Me.drpcntry.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")

        For i = 0 To ds.Tables("deskto").Rows.Count - 1
            'Me.lb2.Text = ds.Tables("deskto").Rows(i).Item(0)
            If Not IsDBNull(ds.Tables("deskto").Rows(i).Item(0)) Then Me.drpcity.Items.Add(ds.Tables("deskto").Rows(i).Item(3))
        Next

        'Me.drptypecm.Enabled = True
        con.Close()
    End Sub

    Protected Sub drpcity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drpcity.SelectedIndexChanged
        '1.1.2
        Me.drptypecm.Items.Clear()
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Me.drptypecm.Items.Add("")
        Dim dp As New OleDbDataAdapter("SELECT company.cmp_name FROM company WHERE (((company.cmp_city)='" & Me.drpcity.SelectedValue & "')) ", con)
        dp.Fill(ds, "deskto")

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

    Protected Sub dropmodel_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropmodel.SelectedIndexChanged
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

        Dim d As New OleDbDataAdapter("SELECT desktob.dsk_modul, desktob.dsk_type, desktob.dsk_hdd, desktob.dsk_ram, desktob.dsk_cpu, desktob.dsk_lcd, desktob.dsk_cost, desktob.dsk_other, desktob.cmp_no, company.cmp_name FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no WHERE ((desktob.dsk_modul)='" & Me.dropmodel.SelectedValue & "') AND ((desktob.dsk_type)='" & Me.drptypecm.SelectedValue & "') AND ((company.cmp_name)='" & Me.drpcmp.SelectedValue & "')", con)
        d.Fill(ds, "deskt")

        For i = 0 To ds.Tables("deskt").Rows.Count - 1
            ' Me.lb2.Text = ds.Tables("deskt").Rows(i).Item("dsk_modul")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_hdd")) Then Me.lb4.Text = ds.Tables("deskt").Rows(i).Item("dsk_hdd")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_ram")) Then Me.lb6.Text = ds.Tables("deskt").Rows(i).Item("dsk_ram")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_cpu")) Then Me.lb8.Text = ds.Tables("deskt").Rows(i).Item("dsk_cpu")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_lcd")) Then Me.lb10.Text = ds.Tables("deskt").Rows(i).Item("dsk_lcd")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_other")) Then Me.lb12.Text = ds.Tables("deskt").Rows(i).Item("dsk_other")
            If Not IsDBNull(ds.Tables("deskt").Rows(i).Item("dsk_cost")) Then Me.lb14.Text = ds.Tables("deskt").Rows(i).Item("dsk_cost")

        Next

        con.Close()

    End Sub
End Class
