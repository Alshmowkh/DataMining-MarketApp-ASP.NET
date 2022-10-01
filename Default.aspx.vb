Imports System.Configuration
Imports System.Data.OleDb
Imports System.Web.HttpApplicationState
Imports System.Web.UI.HtmlControls.HtmlTextArea
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Session("usr_name") = Me.Password1.Value
        Session("hello") = Me.TextBox1.Text
        Session.Timeout = 1
      

        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim sql1 As String
        Dim ds As New Data.DataSet

        sql1 = "select * from company where cmp_name='" & Me.TextBox1.Text & "' and cmp_no=" & Me.Password1.Value & ""
        If Me.TextBox1.Text = "" or Me.TextArea1.Value = "" Then
            Me.Label3.Text = "Ì—ÃÏ «œŒ«· «”„ «·„”‰Œœ„ Êﬂ·„… «·„—Ê—"
            Me.Label3.Visible = True
        Else
            Dim DBCommand As New OleDbCommand()
            DBCommand.CommandText = sql1
            DBCommand.Connection = con
            Dim Myreader As System.Data.OleDb.OleDbDataReader
            ' Dim reader As New System.Data.OleDb.OleDbDataReader()
            Myreader = DBCommand.ExecuteReader()
            Myreader.Read()
            If (Myreader.HasRows = True) Then
                Myreader.Close()
                Response.Write(Session("usr_name"))
                Dim dp As New OleDbDataAdapter("SELECT email.eml_no, email.eml_dsc, email.eml_r, email.eml_ur, email.eml_pers, email.eml_date, email.cmp_no FROM company INNER JOIN email ON company.cmp_no = email.cmp_no where  email.cmp_no=" & Me.Password1.Value & " ORDER BY email.eml_ur", con)

                'Dim ds1 As New Data.DataSet
                dp.Fill(ds, "mail")
              
                If ds.Tables("mail").Rows(0).Item("eml_ur") = True Then
                    ' Response.Write("<script>" + "alert('·œÌﬂ —”«·… ÃœÌœ…');" + "</script>")
                    'MsgBox("you have new massege")

                End If

                Response.Redirect("acount.aspx")

            ElseIf (Myreader.HasRows = False) Then
                Myreader.Close()
                Me.Label3.Text = "«”„ «·„” Œœ„ «Ê ﬂ·„… «·„—Ê— Œÿ√"
                Me.Label3.Visible = True

            End If
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim i As Integer

     
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM(offers)ORDER BY offers.offers_id DESC , offers.offers_date", con)
        dp.Fill(ds, "offers")
        For i = 0 To ds.Tables("offers").Rows.Count - 1
          
            Me.TextArea1.Value = ds.Tables("offers").Rows(0).Item(2)
            Me.Textarea2.Value = ds.Tables("offers").Rows(1).Item(2)
            Me.Textarea3.Value = ds.Tables("offers").Rows(2).Item(2)
            Me.Textarea4.Value = ds.Tables("offers").Rows(3).Item(2)
            Me.Textarea5.Value = ds.Tables("offers").Rows(4).Item(2)
            Me.Textarea6.Value = ds.Tables("offers").Rows(5).Item(2)
            Me.Textarea7.Value = ds.Tables("offers").Rows(6).Item(2)
            Me.Textarea8.Value = ds.Tables("offers").Rows(7).Item(2)
            Me.Textarea9.Value = ds.Tables("offers").Rows(8).Item(2)
            Me.Textarea10.Value = ds.Tables("offers").Rows(9).Item(2)

            Dim Path As String
            Path = Server.MapPath("~//Offers//")
           

            ' FileUpload1.SaveAs("C:\Documents and Settings\Abu malik\Desktop\«·„‘—Ê⁄\Abdulwahab friend\senaan\offers\" + FileUpload1.FileName)
           

            Me.Image2.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(0).Item(4)
            Me.Image3.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(1).Item(4)
            Me.Image4.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(2).Item(4)
            Me.Image5.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(3).Item(4)
            Me.Image6.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(4).Item(4)
            Me.Image7.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(5).Item(4)
            Me.Image8.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(6).Item(4)
            Me.Image9.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(7).Item(4)
            Me.Image10.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(8).Item(4)
            Me.Image11.ImageUrl = "~//Offers//" + ds.Tables("offers").Rows(9).Item(4)
            If (i > 10) Then
                Exit For
            End If

        Next
        con.Close()
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Session("sub") = Me.TextArea1.Value
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.TextArea1.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea2.Value

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea2.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea3.Value
         Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea3.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea4.Value


        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea4.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea5.Value
       
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea5.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea6.Value
        
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea6.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea7.Value


        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea7.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea8.Value

        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea8.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea9.Value
        
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea9.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub

    Protected Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("sub") = Me.Textarea10.Value
      
        Dim i As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = ConfigurationManager.AppSettings("con")
        con.Open()
        Dim ds As New Data.DataSet
        Dim dp As New OleDbDataAdapter("SELECT offers.offers_id, offers.offers_dept, offers.offers_detil, offers.offers_date, offers.offers_photo, offers.cmp_no FROM offers WHERE offers_detil='" & Me.Textarea10.Value & "'", con)
        dp.Fill(ds, "offer")
        For i = 0 To ds.Tables("offer").Rows.Count - 1
            Session("sub") = ds.Tables("offer").Rows(i).Item(2)
            Session("no") = ds.Tables("offer").Rows(i).Item("cmp_no")
        Next
        Response.Redirect("send.aspx")
        con.Close()
    End Sub
End Class
