<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
<script runat="server">
 protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Form["user"];
            string p = Request.Form["pwd"];
            Response.Write(string.Format("Username:{0}\tPassword:{1}",s,p));
        }
</script>
</head>
<body>
    <!--<form action="WebForm1.aspx" method="post">
        Username:<input id="user" type="text" name="user" />
        </br>
        Password:<input id="pwd" type="text" name="pwd" />
        </br>
        <input id="Submit1" type="submit" value="submit" />
    </form>-->

    <!--HtmlPage1.html改為HtmlPage1.aspx-->
    <!--開頭宣告<\%@ page language="c#" \%>-->
    <!--傳資料給自己-->
    <!--將Response的顯示方法寫在script-->
    <form action="HtmlPage1.aspx" method="post" runat="server">
        Username:<input id="user" type="text" name="user" runat="server" />
        </br>
        Password:<input id="pwd" type="text" name="pwd" runat="server" />
        </br>
        <input id="Submit1" type="submit" value="submit" runat="server" />
    </form>
</body>
</html>