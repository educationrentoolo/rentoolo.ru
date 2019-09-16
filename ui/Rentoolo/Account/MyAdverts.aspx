﻿<%@ Page Title="Мои объявления" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAdverts.aspx.cs" Inherits="Rentoolo.Account.MyAdverts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script>
        $(document).ready(function () {
            $(".photoContainer").each(function (index) {
                var htmlString = '';

                JSON.parse(imgUrls,
                    function (k, v) {
                        if (k != "") {
                            htmlString += "<img src='" + v + "' style='height: 275px; width: 275px;' alt='' />";
                        }
                    });

                $(this).html(htmlString);
            });

            $(".photoContainer").brazzersCarousel();

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <ul class="list-group media-list media-list-stream mb-4">

        <li class="media list-group-item p-4">

            <div class="media-body">
                <div class="media-heading">
                    <small class="float-right text-muted">14 объявлений</small>
                    <h6>Мои объявления:</h6>
                </div>

                <div class="media-body-inline-grid">
                    <%foreach (var item in ListItems)
                        { %>
                    <div class="list-item-wrap" style="display: none">
                        <div class="photoContainer" data='<%=item.ImgUrls%>'></div>
                        <div class="item-wrap-content">
                            <div class="item-wrap-name"><a href="#"><%=item.Name%></a></div>
                            <div class="item-wrap-cost"><%=item.Price%> ₽<%--<%=item.CurrencyAcronim%>--%></div>
                            <div class="item-wrap__description">
                                <p><%=item.Category%></p>
                                <p><%=item.Address%></p>
                                <div class="item-wrap__data"><%=item.Created.ToString("dd.MM.yyyy HH:mm")%></div>
                            </div>
                        </div>
                    </div>
                    <%} %>
                </div>
            </div>
        </li>


    </ul>

</asp:Content>
