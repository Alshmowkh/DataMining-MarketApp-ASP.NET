Imports System.Configuration
Imports System.Data.OleDb


Partial Class _Default
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
         ''Me.TextBox1.Text = Session("qw")
        'Dim con As New OleDbConnection
        'con.ConnectionString = ConfigurationManager.AppSettings("con")
        'con.Open()

        ''Application("visitors") = Application("visitors") + 1
        ''Response.Write(Application("visitors"))

        ' ''
        'Dim ds As New Data.DataSet
        'Dim dp As New OleDbDataAdapter("SELECT * FROM offers where offers_detil='" & Session("inf") & "'", con)
        'dp.Fill(ds, "offers")
        
    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click


        Me.Label1.Visible = True
        If Me.txtadvr.Text = "" Or Me.dropdept.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim b As Date
            b = Me.Calendar1.SelectedDate.Date
            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM company INNER JOIN offers ON company.cmp_no = offers.cmp_no ", con)
            dp.Fill(ds, "offers")
            Dim s As New OleDbCommand
            s.Connection = con

            s.CommandText = "insert into offers ( offers_dept, offers_detil, offers_date,offers_photo,cmp_no) values ( '" & Me.dropdept.Text & "','" & Me.txtadvr.Text & "','" & Me.Calendar1.SelectedDate.Date & "','" & Me.Label2.Text & "'," & Session("usr_name") & ")"

            s.ExecuteNonQuery()


            con.Close()
              Me.Label1.Text = " „ «·Õ›Ÿ »‰Ã«Õ"
            Response.Redirect("Default.aspx")


        End If



    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Label1.Visible = True
        If Me.txtadvr.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from offers"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "offers")
            Dim savrr As New OleDbCommand
            savrr.Connection = cona
            savrr.CommandText = "UPDATE offers SET offers_dept='" & Me.dropdept.Text & "', offers_date='" & Me.Calendar1.SelectedDate.Date & "',offers.offers_photo='" & Me.Label2.Text & "' where offers_detil='" & Me.txtadvr.Text & "'"
            savrr.ExecuteNonQuery()
            Me.Label1.Text = " „ «· ⁄œÌ· »‰Ã«Õ"
            cona.Close()
        End If
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Label1.Visible = True
        If Me.txtadvr.Text = "" Or Me.dropdept.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from offers"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "offers")
            Dim aa As New OleDbCommand
            aa.Connection = con
            aa.CommandText = "delete from offers  where offers_detil='" & Me.txtadvr.Text & "'"
            aa.ExecuteNonQuery()
            Me.Label1.Text = " „ «·Õ–› »‰Ã«Õ"
            con.Close()
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Label1.Visible = True
        If Me.txtadvr.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from offers  where offers_detil='" & Me.txtadvr.Text & "'"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "offers")
            Dim i As Integer

            For i = 0 To ds.Tables("offers").Rows.Count - 1
            Next
            If i > 0 Then

                For i = 0 To ds.Tables("offers").Rows.Count - 1
                    Me.dropdept.Text = ds.Tables("offers").Rows(i).Item(1)
                    Me.txtadvr.Text = ds.Tables("offers").Rows(i).Item(2)
                    Me.Calendar1.SelectedDate = ds.Tables("offers").Rows(i).Item(3)

                Next
            Else
                Me.Label1.Text = "·« ÌÊÃœ ⁄—÷ »«·»Ì«‰«  «· Ì «œŒ· Â«"
            End If
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Dim Path As String
        Path = Server.MapPath("~//Offers//")
        Path += FileUpload1.FileName

        FileUpload1.SaveAs(Path)


        ' FileUpload1.SaveAs("C:\Documents and Settings\Abu malik\Desktop\«·„‘—Ê⁄\Abdulwahab friend\senaan\offers\" + FileUpload1.FileName)
        Dim name As String = "~//Offers//" + FileUpload1.FileName
        Me.Image2.ImageUrl = name
        Me.Label2.Text = Me.FileUpload1.FileName.ToString


    End Sub
End Class
