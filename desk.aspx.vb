Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplication
Imports System.Web.HttpResponse
Imports System.Web.HttpRequest
Imports ASP.desk_aspx


Partial Class _Default
    Inherits System.Web.UI.Page




    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click


    '    'Dim i As Integer
    '    '  Dim con As New OleDbConnection
    '    ' ' con.ConnectionString = ConfigurationManager.AppSettings("con")
    '    ' con.Open()
    '    ' Dim ds As New Data.DataSet
    '    '  Dim dp As New OleDbDataAdapter("SELECT q FROM n ", con)
    '    ' dp.Fill(ds, "n")
    '    ' Dim s As New OleDbCommand
    '    ' s.Connection = con
    '    's.CommandType = Data.CommandType.Text
    '    ' s.CommandText = "insert into n (w,q) values (" & Me.TextBox2.Text & ",'" & Me.TextBox1.Text & "')"
    '    'con.Open()
    '    ' s.ExecuteNonQuery()
    '    ' con.Close()
    '    ' Response.Redirect("Default.aspx")
    '    '    For i = 0 To ds.Tables("n").Rows.Count = 0
    '    '        'Response.Write(Me.TextBox1.Text = ds.Tables("n").Rows(i).Item(0))
    '    '        'Response.Write(Me.TextBox2.Text = ds.Tables("n").Rows(i).Item(1))

    '    '        drpcartype.Items.Add(ds.Tables("n").Rows(i).Item(0))
    '    '    Next
    '    'End If
    'End Sub

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
        If Session("usr_name") = Nothing Then
            Response.Redirect("default.aspx")
        Else
        End If
        
    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «·ÃÂ«“«·„—«œ  ⁄œÌ·Â"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from desktob"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "desktob")
            Dim savrr As New OleDbCommand
            savrr.Connection = cona

            savrr.CommandText = "UPDATE desktob SET  dsk_type='" & Me.TextBox2.Text & "', dsk_hdd='" & Me.TextBox1.Text & "', dsk_ram='" & Me.TextBox3.Text & "', dsk_cpu='" & Me.txtprss.Text & "', dsk_lcd='" & Me.txtscrn.Text & "', dsk_cost='" & Me.txtcost.Text & "', dsk_other='" & Me.txtdother.Text & "'  where dsk_modul='" & Me.txtmodel.Text & "' and cmp_no=" & Session("usr_name") & ""
            savrr.ExecuteNonQuery()
            Me.Label1.Text = " „ «· ⁄œÌ· »‰Ã«Õ"
            cona.Close()


        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «·ÃÂ«“«·„—«œ Õ–›Â"
        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from desktob"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "desktob")
            Dim aa As New OleDbCommand
            aa.Connection = con

            aa.CommandText = "delete from desktob  where dsk_modul='" & Me.txtmodel.Text & "' and cmp_no=" & Session("usr_name") & ""        
            aa.ExecuteNonQuery()
            MsgBox(" „ «·Õ–› »‰Ã«Õ", MsgBoxStyle.Information)
            con.Close()
        End If
    End Sub

    Protected Sub Buttonadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonadd.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «·ÃÂ«“"
        Else
            ' Â–« «·ﬂÊœ ÌﬁÊ„ »Õ›Ÿ «·»Ì«‰«  
            ' Ì „ Ê’· «·« ’«· »«·ﬂ‰
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            'Ì „ Ã·» ·»Ì«‰«  „‰ «·ÃœÊ·
            Dim dp As New OleDbDataAdapter("SELECT desktob.dsk_type, desktob.dsk_modul, desktob.dsk_hdd, desktob.dsk_ram, desktob.dsk_cpu, desktob.dsk_lcd, desktob.dsk_cost, desktob.dsk_other, desktob.cmp_no FROM company INNER JOIN desktob ON company.cmp_no = desktob.cmp_no", con)
            ' Ì „  ⁄»∆… «·œ« « ”Ì  »«·ÃœÊ·
            dp.Fill(ds, "desktob")
            Dim s As New OleDbCommand
            s.Connection = con

            s.CommandText = "insert into desktob (  dsk_modul,dsk_type, dsk_hdd, dsk_ram, dsk_cpu, dsk_lcd, dsk_cost, dsk_other, cmp_no) values ('" & Me.txtmodel.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox1.Text & "','" & Me.TextBox3.Text & "','" & Me.txtprss.Text & "','" & Me.txtscrn.Text & "','" & Me.txtcost.Text & "','" & Me.txtdother.Text & "'," & Session("usr_name") & ")"
            'Ì „  ‰›Ì– Ã„·… «·«” ﬂÌÊ «·
            s.ExecuteNonQuery()
            Me.Label1.Text = " „ «·Õ›Ÿ »‰Ã«Õ"

            con.Close()
        End If
    End Sub
End Class
