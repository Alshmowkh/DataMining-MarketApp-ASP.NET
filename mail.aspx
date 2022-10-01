<%@ Page Language="VB" AutoEventWireup="false" CodeFile="mail.aspx.vb" Inherits="_Default" %>

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
</head>
<body style="background-color: buttonface">
    <form id="form1" runat="server">
   
   
        <table align="center" style="width: 600px" border="0" dir="rtl">
            <tr>
                <td colspan="7" style="height: 96px; width: 661px;" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/image/d.gif" Width="598px" /></td>
                        
            </tr>
            <tr>
                <td style="width: 661px; height: 77px" align="center" colspan="7" dir="rtl" valign="bottom">
                    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" Width="600px">
                        <DynamicItemTemplate>
                            <%# Eval("Text") %>
                        </DynamicItemTemplate>
                        <Items>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/mine.jpg" Text=" " Value="mine"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/shop.jpg" Text=" " Value="shop"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/desk.jpg" Text=" " Value="desk"></asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/labtop.jpg" Text=" " Value="labtop">
                            </asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/device.jpg" Text=" " Value="device">
                            </asp:MenuItem>
                            <asp:MenuItem Enabled="False" ImageUrl="~/image/about.jpg" Text=" " Value="about"></asp:MenuItem>
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
                            <asp:MenuItem Text="—«”‹‹·‹‹‰«" Value="contact"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                    &nbsp; &nbsp;
                    &nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td colspan="7" rowspan="4" dir="rtl" valign="top" style="width: 661px; height: 17px;">
                    <table style="width: 600px">
                        <tr>
                            <td rowspan="2" style="background-image: url(image/left.gif); width: 140px" valign="top">
                                <br />
                            </td>
                            <td colspan="2" rowspan="2" style="background-image: none; width: 460px; background-color: #ffffff;" valign="top">
                                <table dir="rtl" style="width: 432px">
                                    <tr>
                                        <td colspan="3" style="color: #000000; font-weight: bold;" align="center">
                                            <br />
                                            <br />
                                             ›«’Ì· «·—”«·…<br />
                                            <br />
                                <table style="width: 400px">
                                    <tr>
                                        <td style="font-size: 12pt; background-image: none; width: 100px; height: 22px; font-weight: bold; background-color: #33cc99;">
                                            «·«”„</td>
                                        <td colspan="2" align="right">
                                            <asp:TextBox ID="txtname" runat="server" Width="288px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 12pt; width: 100px; font-weight: bold; background-image: none; height: 22px; background-color: #33cc99;">
                                            &nbsp; «·≈Ì„Ì·</td>
                                        <td colspan="2" align="right">
                                            <asp:TextBox ID="txteml" runat="server" Width="288px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: bold; width: 100px; height: 22px; font-size: 12pt; background-image: none; background-color: #33cc99;" valign="top">
                                            «·„Õ ÊÏ</td>
                                        <td align="center" colspan="2" style="height: 29px" valign="middle">
                                            <asp:TextBox ID="txtdsc" runat="server" Height="136px" Width="288px" TextMode="MultiLine"></asp:TextBox></td>
                                    </tr>
                                </table>
                                            <br />
                                            <br />
                                            &nbsp;
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3" rowspan="2" style="color: #ffffff">
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td colspan="7" rowspan="1" style="background-image: url(image/footer.gif); height: 60px; width: 661px;" dir="rtl" valign="top">
                </td>
            </tr>
        </table>
    
   
    </form>
</body>
</html>
