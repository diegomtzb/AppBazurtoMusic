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
        <p>Aqui va ve vaina</p>
        <div><p id="cart_number" runat="server"></p></div>
        <asp:Button ID="Btn_add" class="btn btn-default" runat="server" OnClick="Btn_add_Click" Text="Agregar al carrito" />
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/ZionyLennox.jpg" />
        </figure>
        <h3>Zion y Lenox</h3>
        <p>Como curar</p>
        <p><a class="btn btn-default" href="#" role="button">Agregar al carrito</a></p>
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/silvestre.jpg" />
        </figure>
        <h3>Silvestre Dangond</h3>
        <p>La difunta</p>
        <p><a class="btn btn-default" href="#" role="button">Agregar al carrito</a></p>
    </div>

    <div class="col-sm-3">
        <figure class="cover">
            <img src="image/GilbertoSantaRosa.jpg" />
        </figure>
        <h3>Gilberto Santa Rosa</h3>
        <p>Contraste</p>
        <p><a class="btn btn-default" href="#" role="button">Agregar al carrito</a></p>
    </div>
    </form>
</asp:Content>
