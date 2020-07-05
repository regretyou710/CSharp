using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo23
{
    public partial class TreeNode類別產生樹狀圖 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode();
            root.Text = "販賣產品";
            root.ToolTip = "販賣產品";

            TreeNode 父節點 = new TreeNode();
            父節點.Text = "電子產品";
            父節點.ToolTip = "電子產品";
            root.ChildNodes.Add(父節點);//父節點加入根目錄            

            TreeNode 子節點 = new TreeNode();
            子節點.Text = "手機";
            子節點.ToolTip = "手機";
            子節點.NavigateUrl = "mobile.aspx";
            父節點.ChildNodes.Add(子節點);//子節點加入父節點

            子節點 = new TreeNode();
            子節點.Text = "電腦";
            子節點.ToolTip = "電腦";
            子節點.NavigateUrl = "computer.aspx";
            父節點.ChildNodes.Add(子節點);//子節點加入父節點

            子節點 = new TreeNode();
            子節點.Text = "平板電腦";
            子節點.ToolTip = "平板電腦";
            子節點.NavigateUrl = "tablet.aspx";
            父節點.ChildNodes.Add(子節點);//子節點加入父節點

            父節點 = new TreeNode();
            父節點.Text = "日常生活用品";
            父節點.ToolTip = "日常生活用品";
            root.ChildNodes.Add(父節點);//父節點加入根目錄

            子節點 = new TreeNode();
            子節點.Text = "紙巾";
            子節點.ToolTip = "紙巾";
            父節點.ChildNodes.Add(子節點);//子節點加入父節點

            子節點 = new TreeNode();
            子節點.Text = "飲料";
            子節點.ToolTip = "飲料";
            父節點.ChildNodes.Add(子節點);//子節點加入父節點

            TreeView1.Nodes.Add(root);//TreeView加入根目錄   

            /*
            *EnableViewState
            在 ASP.NET 4.0 之前，網頁和控制項雖然有 EnableViewState 屬性可以控制要不要啟用 view state，但是卻不夠彈性，
            因為一旦將頁面（或父層控制項）的 EnableViewState 設為 False，那麼無論其子控制項是否啟用 view state 都沒有用，一律為關閉。
            因此，以往如果要針對特定幾個控制項啟用 view state，就只能讓整個頁面的 EnableViewState 維持預設的啟用狀態，然後再去個別設定控制項的 EnableViewState 為 False。

            *ViewStateMode
            ASP.NET 4.0 為網頁和控制項增加了 ViewStateMode 屬性，讓你可能夠更方便地控制網頁的 view state。
            原本的 EnableViewState 還是有作用，而且是扮演「總開關」的角色。
            也就是說，當 EnableViewState 為 True 時，ViewStateMode 屬性的設定才有意義。

            */

            //TreeView1.EnableViewState = false;
            TreeView1.ViewStateMode = ViewStateMode.Disabled;
            TreeView1.ExpandDepth = 1; //顯示層數
        }
    }
}