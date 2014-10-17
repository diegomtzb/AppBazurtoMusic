<%@ MasterType virtualpath="~/StartingTemplate.Master" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/StartingTemplate.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppBazurtoMusic.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <br />
    <br />
    <br />
    <p class="lead">Ultimas canciones</p>
    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/kvrass.jpg" />
        </figure>
        <h3>Kvrass</h3>
        <p id="songName">Aqui va ve vaina</p>
        <asp:Button ID="Btn_add" class="btn btn-default" runat="server" OnClick="Btn_add_Click" Text="Agregar al carrito" />
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/ZionyLennox.jpg" />
        </figure>
        <h3>Zion y Lenox</h3>
        <p>Como curar</p>
        <asp:Button ID="Button1" class="btn btn-default" runat="server" OnClick="Btn_add_Click" Text="Agregar al carrito" />
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/silvestre.jpg" />
        </figure>
        <h3>Silvestre Dangond</h3>
        <p>La difunta</p>
        <asp:Button ID="Button2" class="btn btn-default" runat="server" OnClick="Btn_add_Click" Text="Agregar al carrito" />
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/GilbertoSantaRosa.jpg" />
        </figure>
        <h3>Gilberto Santa Rosa</h3>
        <p>Contraste</p>
        <asp:Button ID="Button3" class="btn btn-default" runat="server" OnClick="Btn_add_Click" Text="Agregar al carrito" />
    </div>
    </form>
</asp:Content>
