Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 底線表示換行
        Dim cust As IEnumerable(Of Customer) = New Customer() {
        New Customer() With {.FirstName = "A", .LastName = "A1", .Age = 22},
        New Customer() With {.FirstName = "C", .LastName = "C1", .Age = 25},
        New Customer() With {.FirstName = "B", .LastName = "B1", .Age = 20}
        }


        Dim list As New List(Of String)()
        For Each t As Customer In cust
            list.Add(t.LastName)
        Next
        For Each t As String In list
            Console.WriteLine(t)
        Next

        Dim rs = cust.Select(Function(c) c.LastName) 'lambda表達式;方法當作參數傳入 c=>c.LastName
        For Each t As String In rs
            Console.WriteLine(t)
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim words As String() = {"Apple", "aPPLE", "Banana", "bANANA", "Mamgo", "mAMGO", "x", "y", "z", "X", "Y", "Z"}
        'Dim rs = words.OrderByDescending(Function(w) w).Select(Function(w) w)
        '使用自訂排序條件
        Dim rs = words.OrderByDescending(Function(w) w, New MyComparer()).Select(Function(w) w)
        For Each t As String In rs
            Console.Write(t & vbTab)
        Next
        Console.WriteLine()
    End Sub

    Class MyComparer
        Implements IComparer(Of String)
        Public Function Compare(x As String, y As String) As Integer Implements IComparer(Of String).Compare
            Return String.Compare(x, y, StringComparison.Ordinal) 'StringComparison.Ordinal:英文字母小寫比英文字母大寫大
        End Function

    End Class

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim cust As IEnumerable(Of Customer) = New Customer() {
        New Customer() With {.FirstName = "A", .LastName = "A1", .Age = 22},
        New Customer() With {.FirstName = "C", .LastName = "C1", .Age = 25},
        New Customer() With {.FirstName = "B", .LastName = "B1", .Age = 20}
        }
        Dim rs = cust.Where(Function(c) c.Age > 20).OrderByDescending(Function(c) c.LastName).
            Select(Function(c) New With {.第一個字 = c.FirstName, .最後一個字 = c.LastName, .年齡 = c.Age})
        '匿名型別 所以不用 t AS ???
        For Each t In rs
            Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}", t.第一個字, t.最後一個字, t.年齡)
        Next

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim cust As IEnumerable(Of Customer) = New Customer() {
            New Customer() With {.FirstName = "A", .LastName = "A1", .Age = 20},
            New Customer() With {.FirstName = "D", .LastName = "D1", .Age = 22},
            New Customer() With {.FirstName = "B", .LastName = "B1", .Age = 22},
            New Customer() With {.FirstName = "E", .LastName = "E1", .Age = 24},
            New Customer() With {.FirstName = "C", .LastName = "C1", .Age = 25}
            }
        Console.WriteLine("資料筆數:{0}" & vbLf & "年齡平均:{1}" & vbLf & "最大年齡{2}" & vbLf &
                          "最小年齡{3}", cust.Count(), cust.Average(Function(c) c.Age), cust.Max(Function(c) c.Age), cust.Min(Function(c) c.Age))
        Console.WriteLine("移除年齡相同後剩餘筆數:{0}", cust.Select(Function(c) c.Age).Distinct().Count())
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim words As String() = {"cherry", "cococnut", "apple", "blueberry", "banana", "almond"}
        Dim rs = From w In words Group w By key = w(0) Into indexs = Group Select key, indexs
        'key,indexs:變數名稱
        For Each t In rs
            Console.WriteLine("篩選字首={0}", t.key)
            For Each i In t.indexs
                Console.WriteLine("{0}", i)
            Next
        Next
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim emp As IEnumerable(Of Employee) = New Employee() {
           New Employee() With {.FirstName = "A", .LastName = "A1", .Age = 20, .Company = "1stcomp"},
           New Employee() With {.FirstName = "D", .LastName = "D1", .Age = 22, .Company = "3rdcomp"},
           New Employee() With {.FirstName = "B", .LastName = "B1", .Age = 22, .Company = "2ndcomp"},
           New Employee() With {.FirstName = "E", .LastName = "E1", .Age = 24, .Company = "2ndcomp"},
           New Employee() With {.FirstName = "C", .LastName = "C1", .Age = 25, .Company = "1stcomp"}
           }
        Dim comp As IEnumerable(Of Company) = New Company() {
          New Company() With {.CompanyName = "1stcomp", .Country = "TW"},
          New Company() With {.CompanyName = "2ndcomp", .Country = "US"},
          New Company() With {.CompanyName = "3rdcomp", .Country = "HK"}
          }
        Dim rs = emp.Join(comp, Function(em) em.Company, Function(c) c.CompanyName _
            , Function(em, c) New With {em.FirstName, em.LastName, c.Country})
        For Each t In rs
            Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}", t.FirstName, t.LastName, t.Country)
        Next
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim emp As IEnumerable(Of Employee) = New Employee() {
         New Employee() With {.FirstName = "A", .LastName = "A1", .Age = 20, .Company = "1stcomp"},
         New Employee() With {.FirstName = "D", .LastName = "D1", .Age = 22, .Company = "3rdcomp"},
         New Employee() With {.FirstName = "B", .LastName = "B1", .Age = 22, .Company = "2ndcomp"},
         New Employee() With {.FirstName = "E", .LastName = "E1", .Age = 24, .Company = "2ndcomp"},
         New Employee() With {.FirstName = "C", .LastName = "C1", .Age = 25, .Company = "1stcomp"}
         }
        Dim r = From em In emp Select em
        Dim rs = r.ToList
        For Each t In rs
            Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}", t.FirstName, t.LastName, t.Company)
        Next
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button9.Click
        Dim emp As IEnumerable(Of Employee) = New Employee() {
        New Employee() With {.FirstName = "A", .LastName = "A1", .Age = 20, .Company = "1stcomp"},
        New Employee() With {.FirstName = "D", .LastName = "D1", .Age = 22, .Company = "3rdcomp"},
        New Employee() With {.FirstName = "B", .LastName = "B1", .Age = 22, .Company = "2ndcomp"},
        New Employee() With {.FirstName = "E", .LastName = "E1", .Age = 24, .Company = "2ndcomp"},
        New Employee() With {.FirstName = "C", .LastName = "C1", .Age = 25, .Company = "1stcomp"}
        }
        Dim r = From em In emp Select em
        Dim rs = r.ToArray
        For Each t In rs
            Console.WriteLine("{0}" & vbTab & "{1}" & vbTab & "{2}", t.FirstName, t.LastName, t.Company)
        Next
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Dim XmlFile As XElement = XElement.Load("Student.xml")
        Dim rs = From stu In XmlFile.Elements("student")
                 Select New _
                     With {
                         .學號 = stu.Element("no").Value,
                         .姓名 = stu.Element("name").Value,
                         .電話 = stu.Element("tel").Value
                     }
        For Each t In rs
            Console.WriteLine("{0} {1} {2}", t.學號, t.姓名, t.電話)
        Next
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Dim conString As String = "Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;"
        Dim db As New DataContext(conString)
        Dim custTable As Table(Of MyCustomer) = db.GetTable(Of MyCustomer)()
        Dim rs = From cust In custTable Select cust

        For Each t In rs
            Console.WriteLine("{0}" & vbTab & "{1}", t.Id, t.ContactName)
        Next
        Console.WriteLine("筆數有:" & rs.Count())
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        Dim ds As New DataSet()
        Dim table As DataTable = ds.Tables.Add("Product")
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Price", GetType(Decimal))

        Dim dr As DataRow = ds.Tables("Product").NewRow()

        '冒號表示分隔語句,一行中的幾個語句分隔開
        dr("Name") = "Memgo" : dr("Price") = "22.3"
        ds.Tables("Product").Rows.Add(dr)

        dr = ds.Tables("Product").NewRow()
        dr("Name") = "Apple" : dr("Price") = "12.5"
        ds.Tables("Product").Rows.Add(dr)

        dr = ds.Tables("Product").NewRow()
        dr("Name") = "Lemon" : dr("Price") = "25.0"
        ds.Tables("Product").Rows.Add(dr)

        Dim rs = From p In table.AsEnumerable() Where p.Field(Of Decimal)("Price") > 20
                 Order By p.Field(Of Decimal)("Price") Descending
                 Select New With
                     {.name = p.Field(Of String)("Name"),
                     .price = p.Field(Of Decimal)("Price")}
        For Each t In rs
            Console.WriteLine("{0} {1:C}", t.name, t.price)
        Next
    End Sub
End Class
