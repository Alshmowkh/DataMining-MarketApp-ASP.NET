<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

function TABLE1_onclick() {

}


// ]]>
</script>
    <style type="text/css">
        #Select1
        {
            width: 150px;
        }
        #TextArea1
        {
            height: 75px;
            width: 175px;
        }
    </style>
</head>
<body style="background-color: buttonface">
    <form id="form1" runat="server">
   
   
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table align="center" style="width: 600px" border="0" dir="rtl">
                    <tr>
                        <td style="height: 77px; width: 600px;" valign="top">
                            <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/image/d.gif" 
                        Width="598px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 600px; height: 77px" align="center" dir="rtl" valign="bottom">
                            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" Width="600px">
                                <DynamicItemTemplate>
                                    <%# Eval("Text") %>
                                </DynamicItemTemplate>
                                <Items>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/mine.jpg" Text=" " Value="mine">
                                    </asp:MenuItem>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/shop.jpg" Text=" " Value="shop">
                                    </asp:MenuItem>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/desk.jpg" Text=" " Value="desk">
                                    </asp:MenuItem>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/labtop.jpg" Text=" " 
                                Value="labtop"></asp:MenuItem>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/device.jpg" Text=" " 
                                Value="device"></asp:MenuItem>
                                    <asp:MenuItem Enabled="False" ImageUrl="~/image/about.jpg" Text=" " Value="about">
                                    </asp:MenuItem>
                                </Items>
                            </asp:Menu>
                            <asp:Menu ID="Menu3" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2"
                                Font-Names="Verdana" Font-Size="0.8em" ForeColor="White" Height="30px" Orientation="Horizontal"
                                StaticSubMenuIndent="10px" Style="font-weight: normal; font-size: 20pt; background-image: url(image/panel3.jpg)"
                                Width="600px">
                                <StaticSelectedStyle BackColor="#5D7B9D" />
                                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                <DynamicHoverStyle BackColor="#7C6F57" BorderColor="#0000C0" BorderWidth="12px" ForeColor="White" />
                                <DynamicMenuStyle BackColor="#F7F6F3" BorderWidth="12px" />
                                <DynamicSelectedStyle BackColor="#5D7B9D" />
                                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                <StaticHoverStyle BackColor="Maroon" ForeColor="White" />
                                <Items>
                                    <asp:MenuItem NavigateUrl="~/Default.aspx" Text="«·—∆Ì”Ì…" Value="Home"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/searchdesk.aspx" Text="ﬂ„»ÌÊ — „ﬂ »Ì" Value="dec"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/searchlab.aspx" Text="·«»  Ê»" Value="lap"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/searchdvc.aspx" Text="«·ﬁÿ⁄" Value="dvc"></asp:MenuItem>
                                    <asp:MenuItem Text="—«”‹‹·‹‹‰«" Value="contact" NavigateUrl="~/sendus.aspx"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                            &nbsp; &nbsp;&nbsp;</td>
                    </tr>
                    <tr>
                        <td dir="rtl" valign="top" style="width: 600px; height: 77px;">
                            <table style="width: 600px">
                                <tr>
                                    <td style="background-image: none; width: 147px; background-color: silver;" valign="top">
                                        <br />
                                        <table style="width: 140px">
                                            <tr>
                                                <td style="font-size: 12pt; background-image: none; width: 56px; height: 22px">
                                                    «·„‹”‹ Œ‹œ„</td>
                                                <td style="width: 113px">
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="84px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="font-size: 12pt; width: 56px">
                                                    &nbsp;ﬂ·„… «·”—</td>
                                                <td style="width: 113px">
                                                    <input id="Password1" type="password"   runat ="server" style="width: 84px" /></td>
                                            </tr>
                                            <tr>
                                                <td style="height: 75px; background-color: transparent;" align="right" colspan="2" valign="middle">
                                                    &nbsp; &nbsp;
                                                    <asp:Button ID="Button1" runat="server" Font-Bold="False" Font-Size="Medium"
                                                Width="117px" Height="26px" style="background-image: url(image/Regs.png)" /><br />
                                                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" Width="144px" Font-Size="Small" ForeColor="Red"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td align="right" colspan="2" style="background-image: url(image/SaharaNet.gif);
                                                    height: 596px; background-color: transparent" valign="middle">
                                                </td>
                                            </tr>
                                        </table>
                                                    </td>
                                    <td style="background-image: none; width: 460px; background-color: #ffffff;" 
                                valign="top">
                                        <table dir="rtl" style="width: 432px">
                                            <tr>
                                                <td align="center" style="color: #ffffff">
                                                    <br />
                                                    <br />
                                                    <table style="width: 384px; height: 360px">
                                                        <tr>
                                                            <td align="center" style="height: 100px; width: 284px;" valign="top">
                                                                &nbsp;<textarea id="TextArea1" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px; height: 100px" valign="top" align="center">
                                                                <asp:Image ID="Image2" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text=" —«”· «·„⁄·‰" Font-Bold="True" Font-Size="10pt" ForeColor="Blue" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px; height: 100px" align="center" valign="top">
                                                                &nbsp;<textarea id="Textarea2" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px" align="right" valign="top"><asp:Image ID="Image3" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button3_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px; height: 100px">
                                                                &nbsp;<textarea id="Textarea3" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px; height: 100px;"><asp:Image ID="Image4" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button4_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea4" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image5" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button5_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea5" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image6" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button6_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea6" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image7" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button7_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px; height: 21px">
                                                                &nbsp;<textarea id="Textarea7" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px; height: 21px"><asp:Image ID="Image8" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button8_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea8" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image9" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button9" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button9_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea9" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image10" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button10" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button10_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 284px">
                                                                &nbsp;<textarea id="Textarea10" runat="server" dir="rtl" enableviewstate="true" name="S1"
                                                                    readonly="readonly" style="font-size: 16pt; background-image: none; overflow: hidden;
                                                                    width: 272px; clip: rect(0px 0px 0px 0px); color: black; border-top-style: none;
                                                                    font-family: 'Akhbar MT'; border-right-style: none; border-left-style: none;
                                                                    height: 88px; background-color: transparent; text-decoration: none; border-bottom-style: none"></textarea>
                                                                </td>
                                                            <td style="width: 84px"><asp:Image ID="Image11" runat="server" Height="96px" Width="80px" /><br />
                                                                <asp:Button ID="Button11" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="Blue"
                                                                    OnClick="Button11_Click" Text=" —«”· «·„⁄·‰" /></td>
                                                        </tr>
                                                    </table>
                                                    &nbsp;<br />
                                                    &nbsp;
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 77px; width: 600px;" 
                    dir="rtl" valign="top">
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
   
    </form>
</body>
</html>
