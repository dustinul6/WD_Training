# 後端簡介

## 目標: 建立簡單的Api  
第一階段: 無資料庫連結，著重在理解 Model 與 Controller 怎麼運作。資料直接寫在 Controller裡面。
我們將作出一個能接收Http Request, 並回傳 Model資料的 Api 。

第二階段: 用Entity Framework 來管理 Model與資料庫的連結。
 
1. 用DbContext來註冊哪個Model要對應到資料庫的Table
2. 用CodeFirst Migration 來追蹤Model 的修訂，並且自動產生 SQL code來更新資料庫定義。

## 新增專案

![NewAspNetProject](img/newproj.png)

選擇新增ASP.NET Web Application

![alt](img/EmptyApi.png)

選擇Empty Template, 但在加入WebApi Folders and references的地方打勾

## ​定義Model
在.NET 中，所有資料都要對應到一個Type, 例如string, decimal, string[] 等等。
我們可以定義自己的Type: Class。一個class可以有很多fields, 每一個field 都可以是別的Type
在.NET中，每個class都有獨立的檔案，檔案名稱盡量跟class名稱相同，方便管理、避免混淆。
在 Solution Manager 中 Model 點右鍵，新增Class。命名為"Product"，並貼上以下Code

```csharp
namespace Demo02.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
```
這個動作相當於定義了所有物件的結構，以後每創建一個Product物件，都會有上面三個屬性。
未來當我們需要創立一個新的物件(instance)，並assign給一個local variable 時，可用以下語法:


```csharp
var product = new Product(){
    Id = 1,
    Name = "Computer",
    Price = 100
}
```

## Controller and Routing
### Routing 
參考: http://www.asp.net/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api

HttpRequest 基本格式 
~~~
GET [路徑(Uri)] HTTP/1.1
Host: http://www.wdmis.com/
~~~

我們希望透過指定不同的路徑，可以跟伺服器要到不同的資料
~~~
GET api/Products => 回傳所有Products
GET api/Products/2 => 回傳 Id是2的Product
POST api/Products => 新增一個Product
~~~

1. Controller 的功能就在於接收Http Request 並撈取、運算要回傳資料。
2. 一個controller 是由好幾個Action 所構成，每個Action 處理一種Request Method + Uri組合。  ​
3. Routing 就是在決定一個Request Method + Uri，要對應到哪一個Controller以及哪一個Action。
4. 路徑可以使用預設規則，或是自訂規則。
舉例:

打開 AppStart/WebApiConfig.cs 看看routing的設定
```csharp
public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Web API configuration and services

        // Web API routes
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}
```

在Controller資料夾新增Controller, 選擇Empty Controller, 命名為 "ProductsController"
```csharp
public class ProductsController : ApiController
{
    public IHttpActionResult GetAllProducts() { }
    public IHttpActionResult GetProductById(int id) { }
    public HttpResponseMessage DeleteProduct(int id){ }
}
```
以上有三個Actions, 每個Action都是一個function (method)
依照預設路徑，路徑包含 api/Products都會導引到 ProducstController
GetAllProducts 要對應到 Get api/Products
GetProductById 會對應到 Get api/Products/2
DeleteProduct 會對應到 Post api/Products/2

### Actions in Controller

1. GetAllProducts
編輯第一個Action，新增兩個Product 實體，存到一個list中，回傳整個list。WebApi會自動幫我們把資料用JSON 格式回傳出去。
```csharp
public IHttpActionResult GetAllProducts()
{
    var product1 = new Product()
    {
        Id = 1,
        Name = "Desktop Computer",
        Price = 100
    };
    var product2 = new Product()
    {
        Id = 1,
        Name = "Laptop Computer",
        Price = 150
    };

    var products = new List<Product>()
    {
        product1,
        product2
    };
    return Ok(products);
}
```
2. GetProductById
```csharp
public IHttpActionResult GetProductById(int id)
{
    if (id == 1)
    {
        return Ok(new Product()
        {
            Id = 1,
            Name = "Desk",
            Price = 0
        });
    }
    return NotFound();
}
``` 
### Build 
1. F5 : 啟動Debug Mode, 可設定 break points, 但debug狀態下不能編輯。在游標所在的位置按下F9可設定斷點。
2. Ctrl + F5 : 啟動伺服器，伺服器啟動的狀態下，可編輯，並且可用 Crtl + B重新 Build並馬上測試結果。但無法設break points

不管用哪個方法，Visual Studio 都會幫我們打開瀏覽器，並指向伺服器的位址。基本上都會在 localhost, 不過每個App使用的 port會不一樣。網址通常長這樣: "http://localhost:56490/"
把該網址複製下來。

## 用 Postman 測試 Api 

進入 Postman, 在URI列貼上剛剛複製下來的網址，接上 api/Products
確認我們的 HttpRequest Method 選擇了 GET ，按下 Send, 
![Postman](img/postman.png)

應該就能看到資料了，資料應該是JSON 格式
~~~
[
  {
    "Id": 1,
    "Name": "Computer",
    "Price": 200,
    "Description": "Good product"
  },
  {
    "Id": 2,
    "Name": "Laptop",
    "Price": 150,
    "Description": "Wonderful!!"
  }
]
~~~
(截圖是後來才截的，所以多了兩筆資料，請忽略)


## 與資料庫連結 Entity Framework

## Model 與 SQL database 的對應
1. 一個Class對應到一個SQL Table
2. 一個實體(Instance) 對應到一筆資料(row)
3. 一個 property 對應到一個 SQL 欄位

用 DbContext 來建立對應關係，並且在Runtime中去query database

### 建立資料庫，並把Connection string放在Web.config中

1. 新增資料庫:在SQL management studio 新增資料庫，命名 "Demo3"
2. 取得資料庫 connection string: 
    1. 在 Visual Studio中，Tools/Connect to Database 指定要連線的資料庫。
    2. 在左側的 Server Explorer 中，選取該資料庫，按右鍵選Properties, 即可檢視 connection string
3. 把connection string 存在 Web.config 中，命名為 "demo3connection"
```xml 
...
<configuration>
  <configSections>
    ...
  </configSections>
  //以下新增:
  <connectionStrings>
    <add name="deomo3connection" connectionString="Data Source=TzuYaoPC;Initial Catalog=Demo3;Persist Security Info=True;User ID=username;Password=xxxx"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
  ...
</configuration>
```
### 用 Entity Framework 建立 Model 與資料庫的連結

4. 安裝 Entity Framework 套件:

    1. 打開 Tools/Nuget Package Manager/Package Manager Console 
    2. 執行以下指令 
    ~~~
    >Install-Package EntityFramework
    ~~~
    

5. 建立 AppDbContext, 繼承 DbContext
在 Model 資料夾新增一個Class, 命名為AppDbContext (資料夾上按右鍵->Add->Class)
貼上以下Code
~~~csharp
using System.Data.Entity;

namespace Demo03.Models
{
    public class ProductsContext : DbContext
    {
        // 指定Connection string
        public ProductsContext()
            :base("name=demo3connection")
        {    
        }

        public DbSet<Product> Products { get; set; }
    }
}
~~~
* 在 `:base()` 中指定 `"name=demo3connection"` 會讓 EF 去讀取Web.config 中 <connectionStrings> 裡面 `name="deomo3connection"`的 connection string. 
* 在AppDbContext 中新增 `DbSet<Type>` 的field, 就是在告訴Entity Framework 我要把我指定的 `Type` 跟Database中的一個table做連結。

## CodeFirst Migration 

因為我們要維護 Model 與 database table 的對應關係，理論上來說，Model 一但有修訂，database也要跟著修訂。EF CodeFirst的意思就是，要我們專心維護Model中的Code, 資料庫的更新他們幫我們處理。
當我們做出一點點Model的變動，就可以新增一個Migration, 讓EF 自動幫我產生Sql code, 調整 Database schema。
EF 也會追蹤資料庫的更新進度，並且能容許我們取消某幾次的資料庫更新，把資料庫回復到前幾次Migration前的狀態。

要開啟這項功能，在 Package Manager Console 中輸入
~~~
>Enable-Migrations
~~~
這個指令每個app只需要做一次。此時注意 Solution Manager, EF 幫我們新增了一個資料夾叫做 Migrations。
這個資料夾會去紀錄每一次Migration 時，我們的Model 長什麼樣子，資料庫長什麼樣子，並且對資料庫做出甚麼變更。

接著，我們建立我們第一個Migration, 命名為'InitialMigration'
~~~
>Add-Migration 'InitialMigration'
~~~
這時，EF已經幫我們建立了第一個Migration file, 我們可以檢視它產生的 C# code, 
~~~csharp
namespace Demo03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
~~~
`Up()` 與 `Down()` 都是EF 調整資料庫的計畫，先把計畫呈報給我們看。

`Up()` Method 做的事情是，EF 先去比較現在的Model 跟上次更新時的Model 有哪些變更，經過計算以後寫出C# code 告訴我們她計畫怎麼去更新資料庫。
因為我們現在資料庫是空的，但我們有一個Model 已經跟 DbContext 註冊需要建立與資料庫的連結，所以他幫我們建立一個能對應到 Product 的Table。

`Down()` Method 做的是，當我們哪天後悔這次的變更，想要把資料庫回復到更新前的狀態，就會執行 `Down()` Method 。以我們現在的例子，就是直接把這個Table 拿掉。

## 更新資料庫

當我們看一看覺得沒問題，跟預想中的一樣，就可以請EF幫我們按照計畫( 'Up()`) 更新資料庫。在 Package Manager Console 中執行
~~~
>Update-Database
~~~
如果我們好奇他到底用了哪些SQL code, 或是希望手動執行SQL code, 我們可以增加 `-Script` 選項:
~~~
>Updata-Database -Script
~~~
這時他會產生一個SQL code, 但不會幫我們執行，我們可以檢視以後手動選取connection去執行。


## 修改Model, 新增Migration

我們來測試一下，當Model 有異動時，能不能被EF 偵測到。
打開 Product.cs, 新增一個 string field, 命名Description
~~~ csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    // 以下是新增
    public string Description { get; set; }
}
~~~

在 Package management console 中輸入

~~~
>Add-Migration 'AddDescription'
~~~
此時EF 幫我們產生的migraiton file 會長這樣，

~~~csharp
namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Description");
        }
    }
}
~~~
可見EF有抓到 Model 的變更，並且計畫幫我們在 Products 這個Table 新增 Description 這個欄位。

我們可以稍微做個對照，在Model 資料夾新增一個 Class, 命名為 "Customers.cs", 新增以下code
~~~csharp
namespace Demo03.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
~~~
請注意，這時我們並**沒有**將 Customer 這個 Model 向 AppDbContext 註冊，所以 EF 不應該偵測到這個Model 的新增與異動，當我們 Add-Migraion, 不應該幫我們在資料庫中建立 Customer Table。讓我們試試看:
~~~
>Add-Migration 'AddCustomer'
~~~
此時應該產生一個空的 Migration file:
~~~csharp
namespace Demo03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
~~~

但是如果我們把這個Model 新增到 AppDbContext.cs 中，
~~~csharp
public class AppDbContext : DbContext
{
    ...前略
    public DbSet<Product> Products { get; set; }
    // 以下是新增
    public DbSet<Customer> Customers { get; set; }

}
~~~
再執行一次 Add-Migration，但由於原本的Migration 已經存在，且還沒有套用到資料庫上，此時EF會不讓我們新增Midgration。 所以我們可以加上 '-force' 選項在指令中，複寫原本產生的migration file 
~~~
>Add-Migration 'AddCustomer' -force
~~~
現在，產生的 Migration file 應該要長這樣:
~~~csharp
namespace Demo03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}

~~~
沒問題的話，請執行Update-Database
~~~
>Update-Database
~~~


## 在資料庫中新增資料
EF 提供我們幾種新增資料進資料庫的方法
1. Seed Method

打開 Migrations/Configurations.cs, 在 `Seed(...){}` method 中可以新增以下代碼:
~~~csharp
protected override void Seed(Demo03.Models.AppDbContext context)
{
    var product1 = new Product()
    {
        Id = 1,
        Name = "Computer",
        Price = 200,
        Description = "Good product"
    };
    var product2 = new Product()
    {
        Id = 2,
        Name = "Laptop",
        Price = 150,
        Description = "Wonderful!!"
    };

    context.Products.AddOrUpdate(product1, product2);

}
~~~
* EF 幫我們Updata Database時，套用完 Migrations 之後，會幫我們建立一個 AppDbContext 實體，並且丟進 Seed method 中，叫做 `context`，所以我們可以透過context 來存取資料庫裡的內容。
* `context.Products` 指向 Products這個 field, 類別(Type)是 `DbSet<Product>`, 這個Type 有一個內建的 Method, `AddOrUpdate()` 把要新增的物件放進去，就可以幫我們在資料庫新增 record. 

2. 在Migration 中手動增加SQL 指令

在 Updata-Database 之後，還沒有變更Model的情況下，新增一個空白 Migration，  
```
>Add-Migration 'AddProductData'
```
這時我們看到的Migraiotn file 中，`Up()` 跟 `Down()` 應該都是空白的。我們可以手動新增SQL 指令:

~~~csharp
namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddProductData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Price) VALUES ('Monitor', '250')");
            Sql("INSERT INTO Products (Name, Price) VALUES ('Cell Phone', '300')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Products WHERE Name='Monitor'");
            Sql("DELETE FROM Products WHERE Name='Cell Phone'");
        }
    }
}
~~~
並執行
~~~
>Update-Database
~~~
這時，Id 因為是 Primary Key, SQL 會自動幫我們產生。

## 在 Controller 中存取資料庫
打開ProductsController, 做以下修改
~~~csharp
public class ProductsController : ODataController
{
    // 主要需要以下這行:
    // 因為要讓Controller 中各個Actions都能存取資料庫，我們必須在ProductsController中加入一個 field 儲存 AppDbContext 。
    private AppDbContext _context = new AppDbContext();
    
    // 以下兩個Method 先複製過去，先不用搞懂他們在幹嘛。
    private bool ProductExists(int key)
    {
        return _context.Products.Any(p => p.Id == key);
    } 
    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
        base.Dispose(disposing);
    }

    // Action:  
    // 接收 GET api/Products => 回傳所有 Products
    public IHttpActionResult GetAllProducts()
    {
        //把 product1, product2 刪掉，productlist直接透過 AppDbContext 從資料庫裡叫。
        var productlist = _context.Products;
        return Ok(productlist);
    }
}
~~~

此時可以按 Ctrl + F5 執行程式(Visual Studio 會幫我們 Build + 打開瀏覽器)，複製瀏覽器的網址，如 "http://localhost:56490/"



