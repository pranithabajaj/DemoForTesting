<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dob.aspx.cs" Inherits="DemoForTesting.Dob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Date Of Birth
                    </td>
                    <td>
                        <asp:TextBox ID="txtDob" TextMode="Date" runat="server"></asp:TextBox>
                       </td>
                   </tr>
                <tr>
                    <td>
                        Age
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                       </td>
                   </tr>
                <tr>
                    
                    <td>
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
                       </td>
                   </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
