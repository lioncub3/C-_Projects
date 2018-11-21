<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stud_Page.aspx.cs" Inherits="Stud_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server">
            <AlternatingItemTemplate>
                <div style="color: black">
                    <%# Eval("FirstName") %> <%# Eval("LastName") %>
                    <br></br>
                    <%# Eval("Number") %>
                    <br />
                    <%# Eval("Email") %>
                    <br />
                </div>
            </AlternatingItemTemplate>

            <ItemTemplate>
                <div style="color: silver">
                    <%# Eval("FirstName") %> <%# Eval("LastName") %>
                    <br></br>
                    <%# Eval("Number") %>
                    <br />
                    <%# Eval("Email") %>
                    <br />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:GridView ID="GridView1" runat="server"
            AutoGenerateColumns="false"
            CellPadding="4"
            ForeColor="Violet"
            GridLines="None" 
            OnRowDataBound="GridView1_RowDataBound" 
            OnSelectedIndexChanging="GridView1_SelectedIndexChanging"
            DataKeyNames="Id">
            <Columns>
                <asp:CommandField ButtonType="Image" SelectImageUrl="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAJNSURBVGhD7Zm/S1VhGMePJZIhZkuIRpIONVlYaoE5RIuDU0SSuVRD6ZRBppSgWNpQBA7R0uagSEFLBG3lloMNbQ0qRERI4D/g53vfe+Ii53blnvd9OxfeD3w4zznDufe57+/nRoFAIBAI/AeqsRk78Iwl2/EIeqEJX+Jv3MRV/GLJNfyF33ECa9EJF/AnPkYl5Aq1zCIqMbW6VU6gfq2LuTtDL07iQxxLqd61m3H8igdyd5Z4h6MmjA7hc+zH/XrgkLd4z4Tp0QDcwhrchy/wMPqgC7+ZMD19+N6E0XXUTOWLKtzGutxdSq7hggmjqfzVJ+t4zITpKExkOn/1iZNEZvNXn1R8IvGCWPGJaOEVmU3kPOqdpWjNXzObyF0cxlILXeZbRLuBp3gH7+tBEeLPyvQYUTJzeBu1p0rCe9fSDjXpfFHKs/gG1TLatu/Ga9fS/usD6tct127UDrgRC/HetXrwShlexU94E5NaxHsi5aAxondpjDzQgwQyn0g8a2kKruhZS+vHCMYHtWJkPpFzOGDCf5L5RPZKSKQYhYn4PFjFn1XRiRxELZLCWiIq+6gcJDTvt5nQKUN4yoS5Ck6DCdPRgqowqhSkYtk8amviiqM4Y8LoJKpFrPEZB00YHUclo+qjbS7hM1TXEq8w3jxaQRu7Hxh/ebXILdSYsVEyfYRqBdXQYi7jBlrpVoWoOKcudgP1t4Ir6vEJqtp/Wg9c0IkfUX8r6Lpk0WVcwT/4Gl1W/P+is4Mq80nb83JVV9KRwEp5NBAIBAKBvRNFO45mvDYaj64tAAAAAElFTkSuQmCC" ShowSelectButton="true" />
                <asp:CommandField ButtonType="Button" SelectText="Вибрати" ShowSelectButton="true" />
                <asp:BoundField HeaderText="Id" DataField="Id" ReadOnly="true" InsertVisible="false" />
                <asp:TemplateField HeaderText="Студент">
                    <ItemTemplate>
                        <img width="200" height="200" src="<%# Eval("Img_url") %>" />
                        <h4><%# Eval("FirstName") %> <%# Eval("LastName") %></h4>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Електронний адрес">
                    <ItemTemplate>
                        <a href="mailto:<%# Eval("Email") %>"><%# Eval("Email") %></a>
                        <a href="tel:><%# Eval("Number") %>">
                            <h4><%# Eval("Number") %></h4>
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D789D" Font-Bold="true" ForeColor="White" />
            <HeaderStyle BackColor="#5D789D" Font-Bold="true" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="true" ForeColor="Red" />
        </asp:GridView>
    </form>
</body>
</html>
