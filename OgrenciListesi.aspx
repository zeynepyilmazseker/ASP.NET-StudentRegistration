<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersKayit.OgrenciListesi" %>

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
                
                <th style="height: 36px">Öğrenci Mail</th>
               
                <th style="height: 36px">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrenciid") %></td>
                        <td><%#Eval("Ad") %></td>
                        <td><%#Eval("Soyad") %></td>
                        <td><%#Eval("Numara") %></td>
                      
                        <td><%#Eval("Mail") %></td>
                      
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID="+Eval("ogrenciid")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID="+Eval("ogrenciid")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                             <asp:HyperLink NavigateUrl='<%#"~/Dersler.aspx?OGRID="+Eval("ogrenciid")%>' ID="HyperLink3" CssClass="btn btn-warning" runat="server">Ders Kayıt</asp:HyperLink>
                        </td>
                    </tr>


                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
