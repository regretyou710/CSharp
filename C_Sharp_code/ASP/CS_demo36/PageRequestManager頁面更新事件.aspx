<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageRequestManager頁面更新事件.aspx.cs" Inherits="CS_demo36.PageRequestManager頁面更新事件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入ScriptManager、UpdatePanel擴充功能<br />
        2.UpdatePanel加入Panel、DropDownList、Label控制項<br />
        3.DropDownList快顯視窗&gt;編輯項目<br />
        4.DropDownList屬性設定AutoPostBack<br />
        5.DropDownList設定SelectedIndexChanged事件<br />        
        -------------------------------------<br/>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Apple</asp:ListItem>
                            <asp:ListItem>HTC</asp:ListItem>
                            <asp:ListItem>LG</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
        <script type="text/javascript">
            var obj;
            function pageLoad() {
                var reqObj = Sys.WebForms.PageRequestManager.getInstance();//取得PageRequestManager物件
                //進行註冊javascript回呼方法
                reqObj.add_beginRequest(beginRequest);
                reqObj.add_endRequest(endRequest);
            }

            //前端Request發現還沒endRequest,畫面會在disabled = true
            //如果前端接收到Request回傳回來的資料,畫面會在disabled = false
            function beginRequest(sneder,arg) {
                obj = arg.get_postBackElement();//後端所傳回來的物件
                if (obj.id = 'DropDownList1') {
                    $get('Panel1').disabled = true;
                }
            }
            function endRequest(sneder, arg) {
                if (obj.id = 'DropDownList1') {
                    $get('Panel1').disabled = false;
                }
            }
        </script>
    </form>
</body>
</html>
