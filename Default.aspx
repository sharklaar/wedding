﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Shark and Natalie are getting married!</h1>

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>So what's the beef?</h2>
            <p>
                Marc and Natalie will be wed at the registry office in Stamford on September 26th 2015. 
            </p>
            <p>
                <asp:TextBox id="usernameInput" runat="server" placeholder="Your username" />
                <asp:button runat="server" 
                    id="btnRsvp" 
                    class="btn btn-default" 
                    Text="RSVP NOW!"
                    OnClick="Rsvp_Onclick"/>
            </p>
        </div>

    </div>
    <script>
        $('#btnRsvp').click(function () {

        });
    </script>
</asp:Content>
