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


    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Label1.Visible = True
        If Me.txtdvname.Text = "" Or Me.txtdvtype.Text = "" Or Me.txtdvmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· «·»Ì«‰««  «·÷—Ê—Ì…"
            
        Else
            ' Â–« «·ﬂÊœ ÌﬁÊ„ »Õ›Ÿ «·»Ì«‰«  
            ' Ì „ Ê’· «·« ’«· »«·ﬂ‰
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            'Ì „ Ã·» ·»Ì«‰«  „‰ «·ÃœÊ·
            Dim dp As New OleDbDataAdapter("SELECT device.dvc_id, device.dvc_type, device.dv_model, device.dvc_size, device.dvc_capacity, device.dvc_speed, device.dvc_product, device.dvc_price, device.cmp_no FROM company INNER JOIN device ON company.cmp_no = device.cmp_no", con)
            ' Ì „  ⁄»∆… «·œ« « ”Ì  »«·ÃœÊ·
            dp.Fill(ds, "device")
            Dim s As New OleDbCommand
            s.Connection = con
            s.CommandText = "insert into device (  dvc_id, dvc_type, dv_model, dvc_size, dvc_capacity, dvc_speed, dvc_product, dvc_price, cmp_no) values (" & Me.txtdvname.Text & ",'" & Me.txtdvtype.Text & "','" & Me.txtdvmodel.Text & "','" & Me.txtdvsize.Text & "','" & Me.txtdvopacity.Text & "','" & Me.txtdvspeed.Text & "','" & Me.txtdvother.Text & "','" & Me.txtdvcost.Text & "'," & Session("usr_name") & ")"
            'Ì „  ‰›Ì– Ã„·… «·«” ﬂÌÊ «·
            s.ExecuteNonQuery()
            con.Close()
            Me.Label1.Text = " „ «·Õ›Ÿ"


        End If

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Label1.Visible = True
        If Me.txtdvname.Text = "" Or Me.txtdvtype.Text = "" Or Me.txtdvmodel.Text = "" Then
            Me.Label1.Text = "ÌÃ» «œŒ«· «·»Ì«‰««  «·÷—Ê—Ì…"

        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from device"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "device")
            Dim aa As New OleDbCommand
            aa.Connection = con

            aa.CommandText = "delete from device  where dvc_id=" & Me.txtdvname.Text & " and cmp_no=" & Session("usr_name") & ""
            aa.ExecuteNonQuery()
             con.Close()
            Me.Label1.Text = " „ «·Õ–› »‰Ã«Õ"
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
