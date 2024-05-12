<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKayıt.aspx.cs" Inherits="YazOkuluDersKayit.AdminKayıt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <h2>Admin Kayıt Formu</h2>
            <div class="form-group">
                <strong>
                    <asp:Label for="TxtAd" runat="server" Text="Ad:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <strong>
                    <asp:Label for="TxtSoyad" runat="server" Text="Soyad:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <strong>
                    <asp:Label for="TxtMail" runat="server" Text="Mail:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            </div>

            <div class="form-group">
                <strong>
                    <asp:Label for="TxtSifre" runat="server" Text="Şifre:"></asp:Label>
                    </strong><asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="BtnAdminKayit" runat="server" Text="Kayıt ol" CssClass="btn btn-primary" OnClick="BtnAdminKayit_Click" />

        </div>
    </form>
</asp:Content>
