<%@ Page Title="RSVP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="rsvp.aspx.cs" Inherits="Contact" %>

<asp:Content ContentPlaceHolderID="FooterScripts" runat="server">

</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Please RSVP</h3>
    <ul>
    <asp:Repeater ID="rptGuests" runat="server">
        <ItemTemplate>
            <li>
                Name: <%# DataBinder.Eval(Container.DataItem, "Name") %>
                
            </li>
        </ItemTemplate>
    </asp:Repeater>
    </ul>
</asp:Content>
