<%@ Page Language=C# %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>

<script runat="server">
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = Request.Form["user"];
            string p = Request.Form["pwd"];
            Response.Write("username:" + u + " , password:" + p);
        }
</script>

</head>
<body>
<p>------------------------------</p>
<label>一般的HTML轉換成HTML伺服器控制項Web表單</label>
<label>id、runat、附檔名、網頁開頭宣告</label>
<form action="HtmlPage1.aspx" methos="post" runat="server">
        username:<input id="user" name="user" type="text" runat="server" />
        <br/>
        password:<input id="pwd" name="pwd" type="text" runat="server" />
        <input type="submit" value="submit" runat="server" />
</form>   
</body>
</html>