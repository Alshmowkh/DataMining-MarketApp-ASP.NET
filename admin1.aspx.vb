Imports System.Configuration
Imports System.Data.OleDb


Partial Class _Default
    Inherits System.Web.UI.Page


    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click


    '    'Dim i As Integer
    '        Dim con As New OleDbConnection
    '        con.ConnectionString = ConfigurationManager.AppSettings("con")
    '        con.Open()
    '        Dim ds As New Data.DataSet
    '        Dim dp As New OleDbDataAdapter("SELECT q FROM n ", con)
    '    dp.Fill(ds, "n")
    '    Dim s As New OleDbCommand
    '    s.Connection = con
    '    s.CommandType = Data.CommandType.Text
    '    s.CommandText = "insert into n (w,q) values (" & Me.TextBox2.Text & ",'" & Me.TextBox1.Text & "')"
    '    'con.Open()
    '    s.ExecuteNonQuery()
    '    con.Close()
    '    Response.Redirect("Default.aspx")
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
    '    Dim con As New OleDbConnection
    '    con.ConnectionString = ConfigurationManager.AppSettings("con")
    '    con.Open()
    '    Dim ds As New Data.DataSet
    '    Dim dp As New OleDbDataAdapter("SELECT * FROM n where w =" & Me.drpcartype.Text & " ", con)
    '    dp.Fill(ds, "n")

    '    'Me.GridView1.DataSource = ds
    '    'Me.GridView1.DataMember = "n"

    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub
    Public Sub clear()
        txtcmname.Text = ""
        TextBox3.Text = ""
        txttel.Text = ""
        txtmobile.Text = ""
        txtemail.Text = ""
        txtother.Text = ""
        drpcntry.Text = ""
        drpcity.Text = ""
        drpstreet.Text = ""

    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Label1.Visible = True
        If Me.txtcmname.Text = "" Or Me.TextBox3.Text = "" Or Me.drpcntry.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else
            ' Â–« «·ﬂÊœ ÌﬁÊ„ »Õ›Ÿ «·»Ì«‰«  
            ' Ì „ Ê’· «·« ’«· »«·ﬂ‰
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            'Ì „ Ã·» ·»Ì«‰«  „‰ «·ÃœÊ·
            Dim dp As New OleDbDataAdapter("SELECT * FROM company ", con)
            ' Ì „  ⁄»∆… «·œ« « ”Ì  »«·ÃœÊ·
            dp.Fill(ds, "company")
            Dim s As New OleDbCommand
            s.Connection = con
            '    s.CommandType = Data.CommandType.Text
            ' Â‰« Ì „ «÷«›… Ã„·Â «·«” ﬂÌÊ «· «·Œ«’… »«·«œŒ«·
            s.CommandText = "insert into company (cmp_no,cmp_name,cmp_cntry,cmp_city,cmp_strt,cmp_tel,cmp_mob,cmp_mail,cmp_other)values (" & Val(Me.TextBox3.Text) & ",'" & Me.txtcmname.Text & "','" & Me.drpcntry.Text & "','" & Me.drpcity.Text & "','" & Me.drpstreet.Text & "','" & Me.txttel.Text & "','" & Me.txtmobile.Text & "','" & Me.txtemail.Text & "','" & Me.txtother.Text & "')"
            'Ì „  ‰›Ì– Ã„·… «·«” ﬂÌÊ «·
            s.ExecuteNonQuery()
            con.Close()
            Me.Label1.Text = " „ «·Õ›Ÿ »‰Ã«Õ"
            clear()
        End If
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Label1.Visible = True
        If Me.txtcmname.Text = "" Or Me.TextBox3.Text = "" Or Me.drpcntry.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from company"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "company")
            Dim aa As New OleDbCommand
            aa.Connection = con
            ' Ì „ «” Œœ«„ Ã„·… «·«” ﬂÌÊ «· «·Œ«’… «·Õ–›
            aa.CommandText = "delete from company  where cmp_name='" & Me.txtcmname.Text & "'"
            'Ì „  ‰›Ì– «·Ã„·…
            aa.ExecuteNonQuery()
            Me.Label1.Text = " „ «·Õ–› »‰Ã«Õ"
            con.Close()

            clear()
        End If
    End Sub
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Label1.Visible = True
        If Me.txtcmname.Text = "" Or Me.TextBox3.Text = "" Or Me.drpcntry.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "SELECT company.cmp_no, company.cmp_name, company.cmp_cntry, company.cmp_city, company.cmp_strt, company.cmp_tel, company.cmp_mob, company.cmp_mail, company.cmp_other FROM company where  cmp_name='" & Me.txtcmname.Text & "'"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "company")
            Dim savrr As New OleDbCommand
            savrr.Connection = cona
            ' Ì „ «” Œœ«„ Ã„·… «·«” ﬂÌÊ «· «·Œ«’… »«· ⁄œÌ·
            savrr.CommandText = "UPDATE company SET cmp_cntry='" & Me.drpcntry.Text & "',cmp_city='" & Me.drpcity.Text & "',cmp_strt='" & Me.drpstreet.Text & "',cmp_tel='" & Me.txttel.Text & "',cmp_mob='" & Me.txtmobile.Text & "',cmp_mail='" & Me.txtemail.Text & "',cmp_other='" & Me.txtother.Text & "' where cmp_name='" & Me.txtcmname.Text & "'"
            'Â‰« Ì „  ‰›Ì– «·Ã„·…
            savrr.ExecuteNonQuery()
            Me.Label1.Text = " „ «· ⁄œÌ· »‰Ã«Õ"
            cona.Close()
            clear()
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Label1.Visible = True
        Me.Label1.Text = ""
        If Me.txtcmname.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «”„ «·„—ﬂ“"
        Else
            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from company where cmp_name='" & Me.txtcmname.Text & "'"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "company")
            Dim i As Integer
            For i = 0 To ds.Tables("company").Rows.Count - 1

            Next
            If i > 0 Then
                For i = 0 To ds.Tables("company").Rows.Count - 1
                    Me.TextBox3.Text = ds.Tables("company").Rows(i).Item(0)
                    Me.drpcntry.Text = ds.Tables("company").Rows(i).Item(2)
                    Me.drpcity.Text = ds.Tables("company").Rows(i).Item(3)
                    Me.drpstreet.Text = ds.Tables("company").Rows(i).Item(4)
                    Me.txttel.Text = ds.Tables("company").Rows(i).Item(5)
                    Me.txtmobile.Text = ds.Tables("company").Rows(i).Item(6)
                    Me.txtemail.Text = ds.Tables("company").Rows(i).Item(7)
                    Me.txtother.Text = ds.Tables("company").Rows(i).Item(8)

                Next
            Else
                Me.Label1.Text = "·« ÌÊÃœ »Ì«‰«  ›Ì ﬁ«⁄œ… «·»Ì«‰« "
                cona.Close()
            End If
        End If
    End Sub
   
    Protected Sub txtcmname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcmname.TextChanged

    End Sub


End Class
