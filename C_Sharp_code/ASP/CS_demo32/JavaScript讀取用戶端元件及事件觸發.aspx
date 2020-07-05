<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavaScript讀取用戶端元件及事件觸發.aspx.cs" Inherits="CS_demo32.JavaScript讀取用戶端元件及事件觸發" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入ScriptManager擴充功能<br />
        2.script標籤需寫在form標籤內,因script裡面會宣告Sys.Application.add_init(Init)<br />
        3.加入Html標籤text、submit
            --------------------------------------------<br />
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <input id="Text1" type="text" /><br />
            <input id="Submit1" type="submit" value="show data" onclick="btnClick()" />
        </div>
        <script type="text/javascript">
            //$addHandler(網頁元素實體參照,事件名稱,執行函式)
            //JavaScript DOM Event>事件名稱
            //evt是傳入事件對象>傳入按了鍵盤上的哪一個鍵的事件
            function pageLoad() {
                var txt = $get('Text1');
                $addHandler(txt,'keypress',txt_keypress);//第二參數:註冊要發生事件的名稱,第三參數:事件名稱
            }
            function pageUnload() {
                var txt = $get('Text1');
                $removeHandler(txt, 'keypress', txt_keypress);
            }
            function txt_keypress(evt) {                
                var c = evt.charCode;//取得鍵盤碼
                if (c >= 48 && c <= 57)                    
                    evt.preventDefault();//0~9數字移除掉
            }
            function btnClick() {
                var txt = $get('Text1');
                alert(txt.value);
            }
        </script>
    </form>
</body>
</html>
