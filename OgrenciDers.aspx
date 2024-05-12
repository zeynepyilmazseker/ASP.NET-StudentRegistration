<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciDers.aspx.cs" Inherits="YazOkuluDersKayit.OgrenciDers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <thead class="thead-light">
            <tr>
                <th style="height: 36px">Öğrenci ID</th>
                <th style="height: 36px">Öğrenci Ad</th>
                <th style="height: 36px">Öğrenci Soyad</th>
                <th style="height: 36px">Öğrenci Numara</th>
                <th style="height: 36px">Öğrencinin Dersleri</th>


            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrid") %></td>
                        <td><%#Eval("Ad") %></td>
                        <td><%#Eval("Soyad") %></td>
                        <td><%#Eval("Numara") %></td>
                        <td><%#Eval("DersAd") %></td>
                    </tr>


                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
