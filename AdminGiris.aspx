<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminGiris.aspx.cs" Inherits="YazOkuluDersKayit.Admin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h2>Admin Giriş Sayfası</h2>

        <form runat="server" id="Form1">
            <div class="form-group">
                <label for="email">Email:</label>
                <asp:TextBox ID="TxtMail" runat="server" class="form-control"   placeholder="Email giriniz" TextMode="Email"></asp:TextBox>
                
            </div>
            <div class="form-group">
                <label for="pwd">Şifre:</label>
                <asp:TextBox ID="TxtSifre" runat="server" placeholder="Şifrenizi giriniz." class="form-control"  TextMode="Password"></asp:TextBox>
                
            </div>
            <asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" class="btn btn-warning" OnClick="BtnGiris_Click"/>
          
        </form>
    </div>

</asp:Content>
