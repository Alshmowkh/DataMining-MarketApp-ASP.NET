Imports System.Configuration
Imports System.Data.OleDb


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

    End Sub
    Public Sub clrear()
        txtsupid.Text = ""
        txttele.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtsup.Text = ""
        txttele.Text = ""
        txtmailo.Text = ""
        txtothersup.Text = ""
    End Sub

    Protected Sub Menu3_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu3.MenuItemClick

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Label1.Visible = True
        If Me.txtsup.Text = "" Or Me.txtsupid.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «·»Ì«‰«  «·÷—Ê—Ì…"
        Else

            Dim con As New OleDbConnection
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim ds As New Data.DataSet
            Dim dp As New OleDbDataAdapter("SELECT * FROM Supervisors ", con)
            dp.Fill(ds, "Supervisors")
            Dim s As New OleDbCommand
            s.Connection = con
            s.CommandText = "insert into Supervisors ( super_name,super_id, super_cntry, super_city, super_tel, super_mob, super_email, super_other)values('" & Me.txtsup.Text & "'," & Me.txtsupid.Text & ",'" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.txttele.Text & "','" & Me.txtmobile.Text & "','" & Me.txtmailo.Text & "','" & Me.txtothersup.Text & "')"
            s.ExecuteNonQuery()
            con.Close()
            Me.Label1.Text = " „ «·Õ›Ÿ »‰Ã«Õ"
            clrear()

        End If
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Label1.Visible = True
        If Me.txtsup.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «”„ «·„‘—› «·„—«œ Õ–›  »Ì«‰« Â"
        Else

            Dim con As New OleDbConnection
            Dim ds As New Data.DataSet
            con.ConnectionString = ConfigurationManager.AppSettings("con")
            con.Open()
            Dim sql As String = "select * from Supervisors"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Supervisors")
            Dim aa As New OleDbCommand
            aa.Connection = con

            aa.CommandText = "delete from Supervisors  where super_name='" & Me.txtsup.Text & "'"
            'con.Open()
            aa.ExecuteNonQuery()
            Me.Label1.Text = " „ «·Õ–› »‰Ã«Õ"
            con.Close()
            clrear()
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Label1.Visible = True
        If Me.txtsup.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «”„ «·„‘—› «·„—«œ «· ⁄œÌ· ⁄·Ï »Ì«‰« Â"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from Supervisors"
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "Supervisors")
            Dim savrr As New OleDbCommand
            savrr.Connection = cona
            savrr.CommandText = "UPDATE Supervisors SET super_id= " & Me.txtsupid.Text & ", super_cntry= '" & Me.TextBox1.Text & "', super_city= '" & Me.TextBox2.Text & "', super_tel= '" & Me.txttele.Text & "', super_mob= '" & Me.txtmobile.Text & "', super_email= '" & Me.txtmailo.Text & "', super_other= '" & Me.txtothersup.Text & "' where super_name='" & Me.txtsup.Text & "'"
            savrr.ExecuteNonQuery()
            Me.Label1.Text = " „ «· ⁄œÌ· »‰Ã«Õ"
            cona.Close()
            clrear()
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Label1.Visible = True
        If Me.txtsup.Text = "" Then
            Me.Label1.Text = "ÌÃ» ⁄·Ìﬂ «œŒ«· «”„ «·„‘—› «·„—«œ «÷Â«—  »Ì«‰« Â"
        Else

            Dim cona As New OleDbConnection
            cona.ConnectionString = ConfigurationManager.AppSettings("con")
            cona.Open()
            Dim sql As String = "select * from Supervisors where super_name='" & Me.txtsup.Text & "' "
            Dim dp As New OleDbDataAdapter
            Dim ds As New Data.DataSet
            dp = New OleDbDataAdapter(sql, cona)
            dp.Fill(ds, "Supervisors")
            Dim i As Integer
            For i = 0 To ds.Tables("Supervisors").Rows.Count - 1
            Next
            If i > 0 Then

                For i = 0 To ds.Tables("Supervisors").Rows.Count - 1
                     Me.txtsupid.Text = ds.Tables("Supervisors").Rows(i).Item(1)
                    Me.TextBox1.Text = ds.Tables("Supervisors").Rows(i).Item(2)
                    Me.TextBox2.Text = ds.Tables("Supervisors").Rows(i).Item(3)
                    Me.txtmobile.Text = ds.Tables("Supervisors").Rows(i).Item(5)
                    Me.txttele.Text = ds.Tables("Supervisors").Rows(i).Item(4)
                    Me.txtmailo.Text = ds.Tables("Supervisors").Rows(i).Item(6)
                    Me.txtothersup.Text = ds.Tables("Supervisors").Rows(i).Item(7)


                Next
            Else
                Me.Label1.Text = "·« ÌÊÃœ „‘—› »Â–« «·«”„"
            End If

        End If
    End Sub
End Class
