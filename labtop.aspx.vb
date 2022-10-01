Imports System.Configuration
Imports System.Data.OleDb


Partial Class _Default
    Inherits System.Web.UI.Page


  

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usr_name") = Nothing Then
            Response.Redirect("default.aspx")
        Else
        End If
        
    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub
    Public Sub clear()
        Texttype.Text = ""
        txtmodel.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtprss.Text = ""
        txtscrn.Text = ""
        txtcost.Text = ""
        txtdother.Text = ""
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Or Me.Texttype.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «··«»  Ê»"
        Else

            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            'Ì „ Ã·» ·»Ì«‰«  „‰ «·ÃœÊ·
            Dim dp As New OleDbDataAdapter("SELECT laptob.lap_no, laptob.lap_type, laptob.lap_modul, laptob.lap_hdd, laptob.lap_ram, laptob.lap_cpu, laptob.lap_lcd, laptob.lap_cost, laptob.lap_other, laptob.cmp_no FROM company INNER JOIN laptob ON company.cmp_no = laptob.cmp_no", con)
            ' Ì „  ⁄»∆… «·œ« « ”Ì  »«·ÃœÊ·
            dp.Fill(ds, "laptob")
            Dim s As New OleDbCommand
            s.Connection = con

            s.CommandText = "insert into laptob (  lap_modul, lap_type, lap_hdd, lap_ram, lap_cpu, lap_lcd, lap_cost, lap_other, cmp_no ) values ('" & Me.txtmodel.Text & "','" & Me.Texttype.Text & "','" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.txtprss.Text & "','" & Me.txtscrn.Text & "','" & Me.txtcost.Text & "','" & Me.txtdother.Text & "'," & Session("usr_name") & ")"
            'Ì „  ‰›Ì– Ã„·… «·«” ﬂÌÊ «·
            s.ExecuteNonQuery()
            con.Close()
            Me.Label1.Text = " „ «·Õ›Ÿ »‰Ã«Õ"
            clear()
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Or Me.Texttype.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «··«»  Ê»"
        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from laptob"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "laptob")
            Dim aa As New OleDbCommand
            aa.Connection = con

            aa.CommandText = "delete from laptob  where lap_modul='" & Me.txtmodel.Text & "' and cmp_no=" & Session("usr_name") & ""
            'con.Open()
            aa.ExecuteNonQuery()
            MsgBox(" „ «·Õ–› »‰Ã«Õ", MsgBoxStyle.Information)
            con.Close()
            Me.Label1.Text = " „ «·Õ–› »‰Ã«Õ"
            clear()
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Label1.Visible = True
        If Me.txtmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· „ÊœÌ· «·ÃÂ«“«·„—«œ  ⁄œÌ·Â"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from laptob"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "laptob")
            Dim savrr As New OleDbCommand
            savrr.Connection = cona
            savrr.CommandText = "UPDATE laptob SET  lap_type='" & Me.Texttype.Text & "',lap_modul='" & Me.txtmodel.Text & "',lap_hdd='" & Me.TextBox1.Text & "',lap_ram='" & Me.TextBox2.Text & "',lap_cpu='" & Me.txtprss.Text & "',lap_lcd='" & Me.txtscrn.Text & "',lap_cost='" & Me.txtcost.Text & "',lap_other='" & Me.txtdother.Text & "' where lap_modul ='" & Me.txtmodel.Text & "' and cmp_no=" & Session("usr_name") & ""
            savrr.ExecuteNonQuery()
            Me.Label1.Text = " „ «· ⁄œÌ· »‰Ã«Õ"
            cona.Close()

            clear()
        End If
    End Sub
End Class
