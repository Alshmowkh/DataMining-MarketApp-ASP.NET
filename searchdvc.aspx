<%@ Page Language="VB" AutoEventWireup="false" CodeFile="searchdvc.aspx.vb" Inherits="_Default" %>

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
    <form id="form1" runat="server" method="post">
        <table align="center" style="width: 600px" border="0" dir="rtl">
            <tr>
                <td colspan="7" style="height: 96px; width: 661px;" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/image/d.gif" Width="598px" /></td>
                        
            </tr>
            <tr>
                <td style="width: 661px; height: 77px" align="right" colspan="7" dir="rtl" valign="bottom">
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
                </td>
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
                                        <td colspan="3" style="color: #000000" align="center">
                                            <br />
                                            <table dir="rtl" style="width: 432px">
                                                <tr>
                                                    <td align="center" colspan="3" style="color: #000000">
                                                        <br />
                                                        &nbsp;„Ê«’›«  «·ﬁÿ⁄… &nbsp;«·–Ì  —€» ›Ì ‘—«∆Â«<br />
                                                        <br />
                                                        <table dir="rtl" style="width: 376px">
                                                            <tr>
                                                                <td style="width: 101px; height: 20px">
                                                                    «·œÊ·…</td>
                                                                <td style="width: 115px; height: 20px">
                                                                    <asp:DropDownList ID="drpcntry" runat="server" Width="110px" AutoPostBack="True">
                                                                        <asp:ListItem></asp:ListItem>
                                                                    </asp:DropDownList></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    «·„œÌ‰…</td>
                                                                <td style="width: 110px; height: 20px">
                                                                    <asp:DropDownList ID="drpcity" runat="server" Width="110px" AutoPostBack="True">
                                                                    </asp:DropDownList></td>
                                                            </tr>
                                                        </table>
                                                        <table dir="rtl" style="width: 376px">
                                                            <tr>
                                                                <td style="width: 101px; height: 20px">
                                                        „—ﬂ“ «·»Ì⁄</td>
                                                                <td style="width: 110px; height: 20px" valign="top">
                                                                    <asp:DropDownList ID="drpcmp" runat="server" AutoPostBack="True" Width="110px">
                                                                    </asp:DropDownList></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    «”„ «·ﬁÿ⁄…</td>
                                                                <td style="width: 110px; height: 20px">
                                                                    <asp:DropDownList ID="drptypecm" runat="server" AutoPostBack="True" ForeColor="Black"
                                                                        Width="110px">
                                                                        <asp:ListItem></asp:ListItem>
                                                                    </asp:DropDownList></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 101px; height: 20px">
                                                                    «·„ÊœÌ·</td>
                                                                <td style="width: 110px; height: 20px" valign="top">
                                                                    <asp:DropDownList ID="drpmodel" runat="server" AutoPostBack="True" Width="110px">
                                                                    </asp:DropDownList></td>
                                                                <td style="width: 100px; height: 20px">
                                                                </td>
                                                                <td style="width: 110px; height: 20px">
                                                                    <asp:Button ID="srshdv" runat="server" Font-Bold="True" Font-Size="12pt" Height="24px"
                                                                        Text="»ÕÀ" Width="72px" /></td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                        <br />
                                                        &nbsp;<asp:Button ID="Button4" runat="server" Height="24px" Text="√ŸÂ— «·„Ê«’›« " Width="96px" /><br />
                                                        <table dir="rtl" style="width: 368px">
                                                            <tr>
                                                                <td align="center" colspan="4" style="height: 20px">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 85px; height: 20px">
                                                                    <asp:Label ID="lb3" runat="server" Font-Size="Smaller" Text="«·„ÊœÌ·" Visible="False"
                                                                        Width="85px"></asp:Label></td>
                                                                <td align="center" style="width: 100px; height: 20px">
                                                                    <asp:Label ID="lb4" runat="server" ForeColor="#C04000" Text=" " Visible="False" Width="100px"></asp:Label></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    <asp:Label ID="lb7" runat="server" Text="«·”—⁄…" Visible="False" Width="100px"></asp:Label></td>
                                                                <td style="width: 105px; height: 20px">
                                                                    <asp:Label ID="lb8" runat="server" ForeColor="#C04000" Text=" " Visible="False" Width="105px"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 85px; height: 20px">
                                                                    <asp:Label ID="lb5" runat="server" Text="«·ÕÃ„" Visible="False" Width="85px"></asp:Label></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    <asp:Label ID="lb6" runat="server" ForeColor="#C04000" Text=" " Visible="False" Width="100px"></asp:Label></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    <asp:Label ID="Label9" runat="server" Text="«·”⁄…" Visible="False" Width="100px"></asp:Label></td>
                                                                <td style="width: 105px; height: 20px">
                                                                    <asp:Label ID="lb10" runat="server" ForeColor="#C04000" Text=" " Visible="False"
                                                                        Width="105px"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 85px; height: 20px">
                                                                    <asp:Label ID="Label11" runat="server" Text="«·”⁄—" Visible="False" Width="85px"></asp:Label></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    <asp:Label ID="lb12" runat="server" ForeColor="#C04000" Text=" " Visible="False"
                                                                        Width="100px"></asp:Label></td>
                                                                <td style="width: 100px; height: 20px">
                                                                    <asp:Label ID="Label2" runat="server" Text="«Œ—Ï" Visible="False" Width="100px"></asp:Label></td>
                                                                <td style="width: 105px; height: 20px">
                                                                    <asp:Label ID="lb14" runat="server" ForeColor="#C04000" Text=" " Visible="False"
                                                                        Width="105px"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td align="center" colspan="4" rowspan="3" valign="middle">
                                                                    <br />
                                                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                                                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="Button2" runat="server"
                                                                        Font-Bold="True" Font-Size="12pt" Text=" —«”· «·„Õ·" Width="104px" />
                                                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                                    &nbsp; &nbsp; &nbsp; &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                            </tr>
                                                            <tr>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                        &nbsp;
                                                        &nbsp; &nbsp;&nbsp;
                                                        <p class="MsoNormal" dir="rtl" style="margin: 0cm 0cm 0pt">
                                                            <span lang="AR-SA">&nbsp; &nbsp; &nbsp;&nbsp; </span>
                                                            <br />
                                                            <br />
                                                        </p>
                                                        <br />
                                                        <asp:Button ID="sendcomp" runat="server" Font-Bold="True" Font-Size="12pt" Text=" —«”· «·„Õ·"
                                                            Width="104px" /></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3" rowspan="2" style="color: #ffffff">
                                            «·⁄—Ê÷<br />
                                            <br />
                                            &nbsp; &nbsp;
                                            &nbsp; &nbsp;
                                            <br />
                                            <br />
                                            <br />
                                            <br />
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
