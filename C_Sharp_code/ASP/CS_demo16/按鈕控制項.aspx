<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="按鈕控制項.aspx.cs" Inherits="CS_demo16.按鈕控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    ------------------------
    </br>
    "Button"</br>
    OnClientClick執行瀏覽器端程式</br>
    PostBackUrl導覽至某網址</br>
    CommandName,CommandArgument按鈕命令及參數</br>
    </br>
    "LinkButton"</br>
    Text超連結文字</br>
    OnClick程式名稱</br>
    </br>
    "ImageaButton"</br>
    ImageUrl圖片檔案的網址</br>
    AlternateText滑鼠停留時顯示的文字</br>
    OnClick程式名稱</br>
    ------------------------
    <br />
    在2個按鈕屬性上面的閃電圖案中Command點兩下,名稱都設定為Button1_Command<br />
    修改2個按鈕的CommandName,CommandArgument<br />
    在Second按鈕的OnClientClick輸入alert(&#39;第二個按鈕&#39;);<br />
    在First按鈕的PostBackUrl設定WebForm2.aspx網址<br />
    ------------------------
    <br />
    設定LinkButton屬性ToolTip,PostBackUrl設定WebForm2.aspx網址<br />
    ------------------------
    <br />
    將圖片檔放到跟(專案)底下,方案總管上面工具列顯示所有檔案將圖片檔加入專案<br />
    設定ImageButtom屬性ImageUrl,width,ToolTip,PostBackUrl<br />
    -----------------------<br />
    <br />
    </br>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" CommandArgument="First" CommandName="sayHi" OnCommand="Button1_Command" Text="First" PostBackUrl="~/重新導向頁面.aspx" />
            <asp:Button ID="Button2" runat="server" CommandArgument="Second" CommandName="sayHi" OnClientClick="alert('Second Hello');" OnCommand="Button1_Command" Text="Second" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/重新導向頁面.aspx" ToolTip="GoTo重新導向頁面">GoTo重新導向頁面</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl="~/duke.png" PostBackUrl="~/重新導向頁面.aspx" ToolTip="duck" Width="300px" />
        </div>
    </form>
</body>
</html>
