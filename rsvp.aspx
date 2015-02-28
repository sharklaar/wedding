<%@ Page Title="RSVP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="rsvp.aspx.cs" Inherits="Contact" %>

<asp:Content ContentPlaceHolderID="FooterScripts" runat="server">
    <script type="text/javascript">
        $('#numberOfGuests').change(function () {
            var numberOfGuests = $('#numberOfGuests').val();
            for (var i = 1; i <= numberOfGuests; i++) {
                var currentItemCount = $('.guestDetail').length;

                if (numberOfGuests < currentItemCount) {
                    var diff = currentItemCount - numberOfGuests;
                    for (var i = 1; i <= diff; i++) {
                        $('.guestDetails input').last().remove();
                    }
                }
                if (i <= currentItemCount) {
                    continue;
                } else {
                    $('.guestDetails')
                        .append('<input class="guestDetail" type="text" placeholder="Guest ' + i + ' name"/>');
                }

            }
        })

    </script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Please RSVP</h3>
    <input type="number" id="numberOfGuests" title="Number of guests" min="1" value="1" />
    <div class="guestDetails">
        <input class="guestDetail" type="text" placeholder="Guest 1 name"/>
    </div>
    <p></p>

</asp:Content>
