<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataTable.aspx.cs" Inherits="tablo.dataTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: Arial, Helvetica, sans-serif;
        }
        html,body{
            width:100%;
            height:100vh;
        }
        .container{
            display:flex;
            flex-direction:column;
            align-items:center;
            justify-content:flex-start;
            padding:1rem;
            width:100%;
            height:100vh;
            background-color:bisque;
            gap:1rem;
        }
        .nav{
            width:90%;
            height:5rem;
            background-color:chocolate;
            border-radius:1rem;
            display:flex;
            flex-direction:row;
            align-items:center;
            justify-content:center;
            gap:2rem;
        }
        .navCell{
            display:block;
            width:auto;
            height:3rem;
            padding:1rem;
            border:1px solid white;
            background-color:rgba(255,255,255,.5);
            display:flex;
            flex-direction:row;
            align-items:center;
            justify-content:center;
            gap:.5rem;
            border-radius:.5rem;
        }
        .area{
            width:auto;
            min-width:90%;
            max-width:90%;
            height:auto;
            min-height:10rem;
            background-color:cornflowerblue;
            overflow-x:scroll;
           
        }
        .dropdown{
           
            width:auto;
            min-width:3rem;
            border:none;
            height:2rem;
            border-radius:.4rem;
        }
        .btn{
            width:auto;
            height:3rem;
            padding:0 1rem;
            border:none;
            border-radius:1rem;
            background-color:deepskyblue;
            color:white;
            font-size:16px;
            cursor:pointer;
            border:3px solid white;
            transition:150ms all;
        }
        .btn:hover{
            transform:scale(1.1);
        }
       
        .FCell{
            padding:.5rem .8rem;
            background-color:#01987a !important;
            color:white !important;
            word-wrap:normal;
            min-width:8rem;
        }
        .table{
            border-collapse:collapse;
            border-top-left-radius:3rem;
            border-bottom-left-radius:3rem;
            width:100%;
        }
        .table tbody tr {
            background-color:#ddd;
            border-bottom:1px solid #fff;
           
        }
        .table tbody tr td{
                padding:.3rem .5rem;
                margin:0 .3rem;
        }
        .table tbody tr td:nth-child(2n+1){
            background-color:white;
            color:black;
        }
        
    </style>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
            <div class="nav">
                 

              
                    <asp:Button ID="btn" runat="server" CssClass="btn" Text="Tablo Oluştur" OnClick="btn_Click1" />
              
            </div>
           <div class="area">
               <asp:GridView ID="GridView1" runat="server"></asp:GridView>
           </div>
       </div>
    </form>
   
</body>
</html>
